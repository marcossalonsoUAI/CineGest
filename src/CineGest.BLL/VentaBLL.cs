using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using CineGest.BE;
using CineGest.DAL;

namespace CineGest.BLL
{
    public class VentaBLL
    {
        private readonly VentaDAL _dal = new VentaDAL();

        public static readonly string[] MediosDePago = { "Efectivo", "Débito", "Crédito", "Transferencia" };

        public List<string> AsientosOcupados(int idFuncion) => _dal.AsientosOcupados(idFuncion);

        public List<Entrada> ObtenerEntradas(int idVenta) => _dal.ObtenerEntradas(idVenta);

        public int Registrar(Venta v)
        {
            if (v == null) throw new ArgumentNullException(nameof(v));

            if (v.IdCliente <= 0)
                throw new InvalidOperationException("Seleccioná un cliente.");
            if (!_dal.ExisteCliente(v.IdCliente))
                throw new InvalidOperationException("El cliente seleccionado no existe.");

            v.MedioPago = (v.MedioPago ?? "").Trim();
            if (v.MedioPago.Length == 0)
                throw new InvalidOperationException("Elegí un medio de pago.");
            if (v.MedioPago.Length > 30)
                throw new InvalidOperationException("El medio de pago no puede superar los 30 caracteres.");

            //RN06: una venta debe contener al menos una entrada.
            if (v.Entradas == null || v.Entradas.Count == 0)
                throw new InvalidOperationException("La venta tiene que tener al menos una entrada.");

            foreach (var grupo in v.Entradas.GroupBy(e => e.IdFuncion))
                ValidarEntradasDeFuncion(grupo.Key, grupo.ToList());

            //RN07: el total no se recibe de la pantalla; se calcula a partir de las entradas,
            //así siempre coincide con la suma de sus precios.
            v.Total = v.Entradas.Sum(e => e.Precio);

            try
            {
                return _dal.Registrar(v);
            }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627)
            {
                //RN05 desde la base (UX_ENTRADA_FUNCION_ASIENTO): otra venta tomó el asiento
                //entre la validación y el INSERT. La transacción ya hizo Rollback.
                throw new InvalidOperationException(
                    "Uno de los asientos se acaba de vender en otra venta. Actualizá los asientos y elegí otro.");
            }
        }

        private void ValidarEntradasDeFuncion(int idFuncion, List<Entrada> entradas)
        {
            if (!_dal.ObtenerDatosFuncion(idFuncion, out bool activa, out decimal precio,
                                          out int capacidad, out DateTime fechaHora))
                throw new InvalidOperationException("Una de las funciones seleccionadas no existe.");

            //RN04: no se pueden realizar ventas para funciones inactivas.
            if (!activa)
                throw new InvalidOperationException("No se pueden vender entradas para una función inactiva.");

            if (fechaHora <= DateTime.Now)
                throw new InvalidOperationException("La función ya comenzó: no se pueden vender entradas.");

            var ocupados = new HashSet<string>(_dal.AsientosOcupados(idFuncion), StringComparer.OrdinalIgnoreCase);
            int disponibles = capacidad - ocupados.Count;
            if (entradas.Count > disponibles)
                throw new InvalidOperationException($"No hay lugar suficiente: quedan {disponibles} asientos para esa función.");

            var asientosDeEstaVenta = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var e in entradas)
            {
                e.Asiento = (e.Asiento ?? "").Trim().ToUpperInvariant();
                if (e.Asiento.Length == 0)
                    throw new InvalidOperationException("Hay una entrada sin asiento.");
                if (e.Asiento.Length > 10)
                    throw new InvalidOperationException($"El asiento {e.Asiento} supera los 10 caracteres.");
                if (!asientosDeEstaVenta.Add(e.Asiento))
                    throw new InvalidOperationException($"El asiento {e.Asiento} está repetido en la venta.");

                //RN05: no se puede vender un asiento ya vendido para esa función.
                if (ocupados.Contains(e.Asiento))
                    throw new InvalidOperationException($"El asiento {e.Asiento} ya está vendido para esa función.");

                e.Precio = precio;

                //RN08: el precio de una entrada debe ser mayor a cero.
                if (e.Precio <= 0)
                    throw new InvalidOperationException("El precio de la entrada debe ser mayor a cero.");
            }
        }
    }
}
