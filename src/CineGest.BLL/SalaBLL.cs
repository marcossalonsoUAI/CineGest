using CineGest.BE;
using CineGest.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest.BLL
{
    public class SalaBLL
    {
        private readonly SalaDAL _dal = new SalaDAL();

        public List<Sala> Listar() => _dal.Listar();

        public void Alta(Sala s)
        {
            Normalizar(s);
            Validar(s);
            _dal.Insertar(s);
        }

        public void Modificar(Sala s)
        {
            if (s.IdSala <= 0)
                throw new InvalidOperationException("Seleccioná una Sala para modificar.");
            Normalizar(s);
            Validar(s);
            _dal.Modificar(s);
        }

        public void Baja(int id)
        {
            if (id <= 0)
                throw new InvalidOperationException("Seleccioná un Sala para eliminar.");
            try
            {
                _dal.Eliminar(id);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new InvalidOperationException("No se puede eliminar: la Sala tiene funciones registradas.");
            }
        }

        private static void Normalizar(Sala s)
        {
            s.Nombre = (s.Nombre ?? "").Trim();
            s.Tipo = (s.Tipo ?? "").Trim();
        }

        private static void Validar(Sala s)
        {
            if (s.Nombre.Length == 0) throw new InvalidOperationException("El nombre es obligatorio.");
            if (s.Capacidad <= 0) throw new InvalidOperationException("La capacidad debe ser mayor a cero.");
            if (s.Tipo.Length == 0) throw new InvalidOperationException("Eltipo de sala es obligatorio.");
        }
    }
}
