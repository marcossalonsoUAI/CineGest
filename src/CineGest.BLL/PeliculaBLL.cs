using CineGest.BE;
using CineGest.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CineGest.BLL
{
    public class PeliculaBLL
    {
        private readonly PeliculaDAL _dal = new PeliculaDAL();

        public List<Pelicula> Listar() => _dal.Listar();

        public void Alta(Pelicula p)
        {
            Normalizar(p);
            Validar(p);
            _dal.Insertar(p);
        }

        public void Modificar(Pelicula p)
        {
            if (p.IdPelicula <= 0)
                throw new InvalidOperationException("Seleccioná una Pelicula para modificar.");
            Normalizar(p);
            Validar(p);
            _dal.Modificar(p);
        }

        public void Baja(int id)
        {
            if (id <= 0)
                throw new InvalidOperationException("Seleccioná un Pelicula para eliminar.");
            try
            {
                _dal.Eliminar(id);
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new InvalidOperationException("No se puede eliminar: la Pelicula tiene funciones registradas.");
            }
        }

        private static void Normalizar(Pelicula p)
        {
            p.Titulo = (p.Titulo ?? "").Trim();
            p.Genero = (p.Genero ?? "").Trim();
            p.Director = (p.Director ?? "").Trim();
        }

        private static void Validar(Pelicula p)
        {
            if (p.Titulo.Length == 0) throw new InvalidOperationException("El título es obligatorio.");
            if (p.Duracion <= 0) throw new InvalidOperationException("La duración debe ser mayor a cero.");
            if (p.Genero.Length == 0) throw new InvalidOperationException("El o los generos son obligatorios.");
            if (p.Director.Length == 0) throw new InvalidOperationException("El director es obligatorio.");
        }
    }
}
