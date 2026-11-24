using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using CineGest.BE;
using CineGest.DAL;

namespace CineGest.BLL
{
    public class ClienteBLL
    {
        private readonly ClienteDAL _dal = new ClienteDAL();

        public List<Cliente> Listar() => _dal.Listar();

        public List<Cliente> Buscar(string texto)
        {
            return string.IsNullOrWhiteSpace(texto) ? _dal.Listar() : _dal.Buscar(texto.Trim());
        }

        public int Alta(Cliente c)
        {
            Normalizar(c);
            Validar(c);
            if (_dal.ExisteDni(c.Dni))
                throw new InvalidOperationException("Ya existe un cliente con ese DNI.");
            return _dal.Insertar(c);
        }

        public void Modificar(Cliente c)
        {
            if (c.Id <= 0)
                throw new InvalidOperationException("Seleccioná un cliente para modificar.");
            Normalizar(c);
            Validar(c);
            if (_dal.ExisteDni(c.Dni, c.Id))
                throw new InvalidOperationException("Ya existe otro cliente con ese DNI.");
            _dal.Modificar(c);
        }

        public void Baja(int id)
        {
            if (id <= 0)
                throw new InvalidOperationException("Seleccioná un cliente para eliminar.");
            try
            {
                _dal.Eliminar(id);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new InvalidOperationException("No se puede eliminar: el cliente tiene ventas registradas.");
            }
        }

        private static void Normalizar(Cliente c)
        {
            c.Nombre = (c.Nombre ?? "").Trim();
            c.Apellido = (c.Apellido ?? "").Trim();
            c.Dni = (c.Dni ?? "").Trim();
            c.Email = string.IsNullOrWhiteSpace(c.Email) ? null : c.Email.Trim();
        }

        private static void Validar(Cliente c)
        {
            if (c.Nombre.Length == 0) throw new InvalidOperationException("El nombre es obligatorio.");
            if (c.Apellido.Length == 0) throw new InvalidOperationException("El apellido es obligatorio.");
            if (c.Dni.Length == 0) throw new InvalidOperationException("El DNI es obligatorio.");
            if (!c.Dni.All(char.IsDigit) || c.Dni.Length < 7 || c.Dni.Length > 8)
                throw new InvalidOperationException("El DNI debe tener 7 u 8 dígitos numéricos.");
            if (c.Email != null)
            {
                try { new MailAddress(c.Email); }
                catch (FormatException) { throw new InvalidOperationException("El email no tiene un formato válido."); }
            }
        }
        public Cliente ObtenerPorDni(string dni)
        {
            return _dal.ObtenerPorDni(dni.Trim());
        }
    }
}
