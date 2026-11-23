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
    public class UsuarioDAL
    {
        public Usuario ObtenerPorNombre(string nombreUsuario)
        {
            const string sql = @"SELECT ID_USUARIO, NOMBRE_USUARIO, PASSWORD_HASH, ROL
                                 FROM USUARIO WHERE NOMBRE_USUARIO = @nombre";
            using (var cn = Conexion.Crear())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                da.SelectCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombreUsuario;
                var tabla = new DataTable();
                da.Fill(tabla);
                return tabla.Rows.Count == 0 ? null : UsuarioMapper.ADominio(tabla.Rows[0]);
            }
        }

        public bool ExisteNombre(string nombreUsuario)
        {
            const string sql = "SELECT COUNT(*) FROM USUARIO WHERE NOMBRE_USUARIO = @nombre";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = nombreUsuario;
                cn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        public int Insertar(Usuario u)
        {
            const string sql = @"INSERT INTO USUARIO (NOMBRE_USUARIO, PASSWORD_HASH, ROL)
                                 VALUES (@nombre, @hash, @rol);
                                 SELECT CAST(SCOPE_IDENTITY() AS int);";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = u.NombreUsuario;
                cmd.Parameters.Add("@hash", SqlDbType.VarChar, 256).Value = u.PasswordHash;
                cmd.Parameters.Add("@rol", SqlDbType.VarChar, 20).Value = u.Rol;
                cn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
