using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineGest.BE;
using CineGest.MAPPER;

namespace CineGest.DAL
{
    public class ClienteDAL
    {
        public List<Cliente> Listar()
        {
            const string sql = "SELECT ID_CLIENTE, NOMBRE, APELLIDO, DNI, EMAIL FROM CLIENTE ORDER BY APELLIDO, NOMBRE";
            using (var cn = Conexion.Crear())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                var tabla = new DataTable();
                da.Fill(tabla);
                return ClienteMapper.ALista(tabla);
            }
        }

        public List<Cliente> Buscar(string texto)
        {
            const string sql = @"SELECT ID_CLIENTE, NOMBRE, APELLIDO, DNI, EMAIL FROM CLIENTE
                                 WHERE NOMBRE LIKE @t OR APELLIDO LIKE @t OR DNI LIKE @t
                                 ORDER BY APELLIDO, NOMBRE";
            using (var cn = Conexion.Crear())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                da.SelectCommand.Parameters.AddWithValue("@t", "%" + texto + "%");
                var tabla = new DataTable();
                da.Fill(tabla);
                return ClienteMapper.ALista(tabla);
            }
        }

        public bool ExisteDni(string dni, int idExcluir = 0)
        {
            const string sql = "SELECT COUNT(*) FROM CLIENTE WHERE DNI = @dni AND ID_CLIENTE <> @id";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@id", idExcluir);
                cn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
        public Cliente ObtenerPorDni(string dni)
        {
            const string sql = "SELECT ID_CLIENTE, NOMBRE, APELLIDO, DNI, EMAIL FROM CLIENTE WHERE DNI = @dni";
            using (var cn = Conexion.Crear())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                da.SelectCommand.Parameters.AddWithValue("@dni", dni);
                var tabla = new DataTable();
                da.Fill(tabla);
                return tabla.Rows.Count == 0 ? null : ClienteMapper.ADominio(tabla.Rows[0]);
            }
        }

        public int Insertar(Cliente c)
        {
            const string sql = @"INSERT INTO CLIENTE (NOMBRE, APELLIDO, DNI, EMAIL)
                                 VALUES (@nombre, @apellido, @dni, @email);
                                 SELECT CAST(SCOPE_IDENTITY() AS int);";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                CargarParametros(cmd, c);
                cn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public void Modificar(Cliente c)
        {
            const string sql = @"UPDATE CLIENTE
                                 SET NOMBRE = @nombre, APELLIDO = @apellido, DNI = @dni, EMAIL = @email
                                 WHERE ID_CLIENTE = @id";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                CargarParametros(cmd, c);
                cmd.Parameters.AddWithValue("@id", c.Id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            const string sql = "DELETE FROM CLIENTE WHERE ID_CLIENTE = @id";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private static void CargarParametros(SqlCommand cmd, Cliente c)
        {
            cmd.Parameters.AddWithValue("@nombre", c.Nombre);
            cmd.Parameters.AddWithValue("@apellido", c.Apellido);
            cmd.Parameters.AddWithValue("@dni", c.Dni);
            cmd.Parameters.AddWithValue("@email", string.IsNullOrWhiteSpace(c.Email) ? (object)DBNull.Value : c.Email);
        }
    }
}
