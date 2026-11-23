using System;
using System.Collections.Generic;
using CineGest.BE;
using CineGest.DAL;

namespace CineGest.BLL
{
    public class FuncionBLL
    {
        private readonly FuncionDAL _dal = new FuncionDAL();

        public List<Funcion> Listar() => _dal.Listar(false);

        // Para la venta (RN04): solo se puede vender para funciones activas.
        public List<Funcion> ListarActivas() => _dal.Listar(true);

        // ✅ NUEVO MÉTODO: Exposto desde la capa de negocios
        public List<Funcion> ListarPorPelicula(int idPelicula) => _dal.ListarPorPelicula(idPelicula);

        public Funcion ObtenerPorId(int id) => _dal.ObtenerPorId(id);

        public int Alta(Funcion f)
        {
            ValidarProgramacion(f, 0);
            f.Activa = true;
            return _dal.Insertar(f);
        }

        public void Modificar(Funcion f)
        {
            if (f.Id <= 0)
                throw new InvalidOperationException("Seleccioná una función para modificar.");
            if (_dal.TieneEntradasVendidas(f.Id))
                throw new InvalidOperationException(
                    "No se puede modificar una función con entradas vendidas. Si hace falta, desactivala y creá una nueva.");
            ValidarProgramacion(f, f.Id);
            _dal.Modificar(f);
        }

        public void Desactivar(int id)
        {
            if (id <= 0)
                throw new InvalidOperationException("Seleccioná una función.");
            _dal.CambiarEstado(id, false);
        }

        public void Activar(int id)
        {
            var f = _dal.ObtenerPorId(id);
            if (f == null)
                throw new InvalidOperationException("La función no existe.");
            ValidarProgramacion(f, f.Id);
            _dal.CambiarEstado(id, true);
        }

        private void ValidarProgramacion(Funcion f, int idExcluir)
        {
            if (f.IdPelicula <= 0) throw new InvalidOperationException("Seleccioná una película.");
            if (f.IdSala <= 0) throw new InvalidOperationException("Seleccioná una sala.");
            if (f.Precio <= 0) throw new InvalidOperationException("El precio debe ser mayor a cero.");
            if (f.FechaHora <= DateTime.Now)
                throw new InvalidOperationException("La función tiene que programarse en una fecha y hora futura.");
            if (!_dal.ExisteSala(f.IdSala))
                throw new InvalidOperationException("La sala seleccionada no existe.");

            if (!_dal.ObtenerDatosPelicula(f.IdPelicula, out bool peliculaActiva, out int duracion))
                throw new InvalidOperationException("La película seleccionada no existe.");

            // RN02: no se pueden programar funciones de películas inactivas.
            if (!peliculaActiva)
                throw new InvalidOperationException("No se pueden programar funciones de películas inactivas.");

            // RN03: no puede haber dos funciones superpuestas en la misma sala.
            DateTime fin = f.FechaHora.AddMinutes(duracion);
            if (_dal.HaySuperposicion(f.IdSala, f.FechaHora, fin, idExcluir))
                throw new InvalidOperationException("La sala ya tiene una función programada en ese horario.");
        }
    }
}