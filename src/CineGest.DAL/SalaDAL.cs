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
    public class SalaDAL
    {
        public List<Sala> Listar()
        {
            const string sql = "SELECT ID_SALA, NOMBRE ,CAPACIDAD ,TIPO FROM SALA";
            using (var cn = Conexion.Crear())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                var tabla = new DataTable();
                da.Fill(tabla);
                return SalaMapper.ALista(tabla);
            }
        }

        public void Insertar(Sala s)
        {
            const string sql = "INSERT INTO SALA (NOMBRE, CAPACIDAD, TIPO) " +
                               "VALUES(@nombre, @capacidad, @tipo)";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                CargarParametros(cmd, s);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Modificar(Sala s)
        {
            const string sql = "UPDATE SALA " +
                                "SET NOMBRE = @nombre, CAPACIDAD = @capacidad, TIPO = @tipo " +
                                "WHERE ID_SALA = @id";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                CargarParametros(cmd, s);
                cmd.Parameters.AddWithValue("@id", s.IdSala);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            const string sql = "DELETE FROM SALA WHERE ID_SALA = @id";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private static void CargarParametros(SqlCommand cmd, Sala s)
        {
            cmd.Parameters.AddWithValue("@nombre", s.Nombre);
            cmd.Parameters.AddWithValue("@capacidad", s.Capacidad);
            cmd.Parameters.AddWithValue("@tipo", s.Tipo);
        }
    }
}
