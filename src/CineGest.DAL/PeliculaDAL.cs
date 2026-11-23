using CineGest.BE;
using CineGest.MAPPER;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest.DAL
{
    public class PeliculaDAL
    {
        public List<Pelicula> Listar()
        {
            const string sql = "SELECT ID_PELICULA, TITULO ,DURACION ,GENERO ,DIRECTOR ,ESTADO FROM PELICULA";
            using (var cn = Conexion.Crear())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                var tabla = new DataTable();
                da.Fill(tabla);
                return PeliculaMapper.ALista(tabla);
            }
        }

        public void Insertar(Pelicula p)
        {
            const string sql = "INSERT INTO PELICULA (TITULO, DURACION, GENERO, DIRECTOR, ESTADO)" +
                                "VALUES (@titulo, @duracion, @genero, @director, @estado)";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                CargarParametros(cmd, p);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Modificar(Pelicula p)
        {
            const string sql = "UPDATE PELICULA " +
                       "SET TITULO = @titulo, DURACION = @duracion, GENERO = @genero, DIRECTOR = @director, ESTADO = @estado " +
                       "WHERE ID_PELICULA = @id";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                CargarParametros(cmd, p);
                cmd.Parameters.AddWithValue("@id", p.IdPelicula);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            const string sql = "DELETE FROM PELICULA WHERE ID_PELICULA = @id";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private static void CargarParametros(SqlCommand cmd, Pelicula p)
        {
            cmd.Parameters.AddWithValue("@titulo", p.Titulo);
            cmd.Parameters.AddWithValue("@duracion", p.Duracion);
            cmd.Parameters.AddWithValue("@genero", p.Genero);
            cmd.Parameters.AddWithValue("@director", p.Director);
            cmd.Parameters.AddWithValue("@estado", p.Estado);
        }
    }
}
