using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CineGest.BE;
using CineGest.MAPPER;

namespace CineGest.DAL
{
    public class FuncionDAL
    {
        private const string SqlSelect = @"
SELECT f.ID_FUNCION, f.ID_PELICULA, f.ID_SALA, f.FECHA_HORA, f.PRECIO, f.ESTADO,
       p.TITULO, p.DURACION, s.NOMBRE AS NOMBRE_SALA
FROM FUNCION f
INNER JOIN PELICULA p ON p.ID_PELICULA = f.ID_PELICULA
INNER JOIN SALA s     ON s.ID_SALA = f.ID_SALA";

        public List<Funcion> Listar(bool soloActivas)
        {
            string sql = SqlSelect + (soloActivas ? " WHERE f.ESTADO = 1" : "") + " ORDER BY f.FECHA_HORA";
            using (var cn = Conexion.Crear())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                var tabla = new DataTable();
                da.Fill(tabla);
                return FuncionMapper.ALista(tabla);
            }
        }

        // ✅ NUEVO MÉTODO: Trae solo las funciones activas de una película específica
        public List<Funcion> ListarPorPelicula(int idPelicula)
        {
            string sql = SqlSelect + " WHERE f.ID_PELICULA = @idPelicula AND f.ESTADO = 1 ORDER BY f.FECHA_HORA";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@idPelicula", SqlDbType.Int).Value = idPelicula;
                using (var da = new SqlDataAdapter(cmd))
                {
                    var tabla = new DataTable();
                    da.Fill(tabla);
                    return FuncionMapper.ALista(tabla);
                }
            }
        }

        public Funcion ObtenerPorId(int id)
        {
            string sql = SqlSelect + " WHERE f.ID_FUNCION = @id";
            using (var cn = Conexion.Crear())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
                var tabla = new DataTable();
                da.Fill(tabla);
                return tabla.Rows.Count == 0 ? null : FuncionMapper.ADominio(tabla.Rows[0]);
            }
        }

        public bool ObtenerDatosPelicula(int idPelicula, out bool activa, out int duracion)
        {
            const string sql = "SELECT ESTADO, DURACION FROM PELICULA WHERE ID_PELICULA = @id";
            activa = false;
            duracion = 0;
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idPelicula;
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    if (!dr.Read()) return false;
                    activa = Convert.ToBoolean(dr["ESTADO"]);
                    duracion = Convert.ToInt32(dr["DURACION"]);
                    return true;
                }
            }
        }

        public bool ExisteSala(int idSala)
        {
            return Contar("SELECT COUNT(*) FROM SALA WHERE ID_SALA = @id",
                new SqlParameter("@id", SqlDbType.Int) { Value = idSala }) > 0;
        }

        public bool HaySuperposicion(int idSala, DateTime inicio, DateTime fin, int idExcluir)
        {
            const string sql = @"
SELECT COUNT(*)
FROM FUNCION f
INNER JOIN PELICULA p ON p.ID_PELICULA = f.ID_PELICULA
WHERE f.ID_SALA = @idSala
  AND f.ESTADO = 1
  AND f.ID_FUNCION <> @idExcluir
  AND f.FECHA_HORA < @fin
  AND DATEADD(MINUTE, p.DURACION, f.FECHA_HORA) > @inicio";
            return Contar(sql,
                new SqlParameter("@idSala", SqlDbType.Int) { Value = idSala },
                new SqlParameter("@idExcluir", SqlDbType.Int) { Value = idExcluir },
                new SqlParameter("@inicio", SqlDbType.DateTime2) { Value = inicio },
                new SqlParameter("@fin", SqlDbType.DateTime2) { Value = fin }) > 0;
        }

        public bool TieneEntradasVendidas(int idFuncion)
        {
            return Contar("SELECT COUNT(*) FROM ENTRADA WHERE ID_FUNCION = @id",
                new SqlParameter("@id", SqlDbType.Int) { Value = idFuncion }) > 0;
        }

        public int Insertar(Funcion f)
        {
            const string sql = @"INSERT INTO FUNCION (ID_PELICULA, ID_SALA, FECHA_HORA, PRECIO, ESTADO)
                                 VALUES (@idPelicula, @idSala, @fechaHora, @precio, 1);
                                 SELECT CAST(SCOPE_IDENTITY() AS int);";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                CargarParametros(cmd, f);
                cn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public void Modificar(Funcion f)
        {
            const string sql = @"UPDATE FUNCION
                                 SET ID_PELICULA = @idPelicula, ID_SALA = @idSala,
                                     FECHA_HORA = @fechaHora, PRECIO = @precio
                                 WHERE ID_FUNCION = @id";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                CargarParametros(cmd, f);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = f.Id;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void CambiarEstado(int id, bool activa)
        {
            const string sql = "UPDATE FUNCION SET ESTADO = @estado WHERE ID_FUNCION = @id";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@estado", SqlDbType.Bit).Value = activa;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private static int Contar(string sql, params SqlParameter[] parametros)
        {
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddRange(parametros);
                cn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        private static void CargarParametros(SqlCommand cmd, Funcion f)
        {
            cmd.Parameters.Add("@idPelicula", SqlDbType.Int).Value = f.IdPelicula;
            cmd.Parameters.Add("@idSala", SqlDbType.Int).Value = f.IdSala;
            cmd.Parameters.Add("@fechaHora", SqlDbType.DateTime2).Value = f.FechaHora;
            var precio = cmd.Parameters.Add("@precio", SqlDbType.Decimal);
            precio.Precision = 10;
            precio.Scale = 2;
            precio.Value = f.Precio;
        }
    }
}