using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CineGest.BE;
using CineGest.MAPPER;

namespace CineGest.DAL
{
    public class UsuarioDAL
    {
        // ==========================================================
        // OBTENER POR NOMBRE (para Login)
        // ==========================================================
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

        // ==========================================================
        // OBTENER POR ID
        // ==========================================================
        public Usuario ObtenerPorId(int id)
        {
            const string sql = @"SELECT ID_USUARIO, NOMBRE_USUARIO, PASSWORD_HASH, ROL
                                 FROM USUARIO WHERE ID_USUARIO = @id";
            using (var cn = Conexion.Crear())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                var tabla = new DataTable();
                da.Fill(tabla);
                return tabla.Rows.Count == 0 ? null : UsuarioMapper.ADominio(tabla.Rows[0]);
            }
        }

        // ==========================================================
        // EXISTE NOMBRE
        // ==========================================================
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

        // ==========================================================
        // INSERTAR
        // ==========================================================
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

        // ==========================================================
        // LISTAR (oculta el ADMIN maestro)
        // ==========================================================
        public List<Usuario> Listar()
        {
            var lista = new List<Usuario>();
            const string sql = "SELECT ID_USUARIO, NOMBRE_USUARIO, ROL FROM USUARIO WHERE NOMBRE_USUARIO <> 'ADMIN'";
            using (var cn = Conexion.Crear())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                var tabla = new DataTable();
                da.Fill(tabla);
                foreach (DataRow fila in tabla.Rows)
                {
                    lista.Add(new Usuario
                    {
                        Id = Convert.ToInt32(fila["ID_USUARIO"]),
                        NombreUsuario = fila["NOMBRE_USUARIO"].ToString(),
                        Rol = fila["ROL"].ToString()
                    });
                }
            }
            return lista;
        }

        // ==========================================================
        // ELIMINAR
        // ==========================================================
        public void Eliminar(int id)
        {
            const string sql = "DELETE FROM USUARIO WHERE ID_USUARIO = @id";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        // ==========================================================
        // ACTUALIZAR CONTRASEÑA
        // ==========================================================
        public void ActualizarPassword(int idUsuario, string nuevoPasswordHash)
        {
            const string sql = "UPDATE USUARIO SET PASSWORD_HASH = @hash WHERE ID_USUARIO = @id";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idUsuario;
                cmd.Parameters.Add("@hash", SqlDbType.VarChar, 256).Value = nuevoPasswordHash;

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}