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
    public class ConsultaDAL
    {
        private const string SqlVentasPorCliente = @"
SELECT v.ID_VENTA          AS ID_VENTA,
       v.FECHA_VENTA       AS FECHA,
       COUNT(e.ID_ENTRADA) AS CANTIDAD_ENTRADAS,
       v.TOTAL             AS TOTAL
FROM VENTA v
LEFT JOIN ENTRADA e ON e.ID_VENTA = v.ID_VENTA
WHERE v.ID_CLIENTE = @idCliente
GROUP BY v.ID_VENTA, v.FECHA_VENTA, v.TOTAL
ORDER BY v.FECHA_VENTA DESC";

        private const string SqlOcupacionPorFuncion = @"
SELECT f.ID_FUNCION             AS ID_FUNCION,
       p.TITULO                 AS PELICULA,
       s.NOMBRE                 AS SALA,
       f.FECHA_HORA             AS FECHA_HORA,
       s.CAPACIDAD              AS CAPACIDAD,
       COUNT(e.ID_ENTRADA)      AS ENTRADAS_VENDIDAS,
       ISNULL(SUM(e.PRECIO), 0) AS RECAUDACION
FROM FUNCION f
INNER JOIN PELICULA p ON p.ID_PELICULA = f.ID_PELICULA
INNER JOIN SALA s     ON s.ID_SALA = f.ID_SALA
LEFT JOIN ENTRADA e   ON e.ID_FUNCION = f.ID_FUNCION
WHERE (@desde IS NULL OR f.FECHA_HORA >= @desde)
  AND (@hasta IS NULL OR f.FECHA_HORA <  @hasta)
GROUP BY f.ID_FUNCION, p.TITULO, s.NOMBRE, f.FECHA_HORA, s.CAPACIDAD
ORDER BY f.FECHA_HORA";

        private const string SqlRecaudacionPorPelicula = @"
SELECT p.ID_PELICULA                AS ID_PELICULA,
       p.TITULO                     AS TITULO,
       COUNT(DISTINCT f.ID_FUNCION) AS CANTIDAD_FUNCIONES,
       COUNT(e.ID_ENTRADA)          AS ENTRADAS_VENDIDAS,
       ISNULL(SUM(e.PRECIO), 0)     AS RECAUDACION
FROM PELICULA p
LEFT JOIN FUNCION f ON f.ID_PELICULA = p.ID_PELICULA
                   AND (@desde IS NULL OR f.FECHA_HORA >= @desde)
                   AND (@hasta IS NULL OR f.FECHA_HORA <  @hasta)
LEFT JOIN ENTRADA e ON e.ID_FUNCION = f.ID_FUNCION
GROUP BY p.ID_PELICULA, p.TITULO
ORDER BY RECAUDACION DESC, p.TITULO";

        public List<VentaPorCliente> VentasPorCliente(int idCliente)
        {
            var tabla = Ejecutar(SqlVentasPorCliente,
                new SqlParameter("@idCliente", SqlDbType.Int) { Value = idCliente });
            return ConsultaMapper.AVentasPorCliente(tabla);
        }

        public List<OcupacionFuncion> OcupacionPorFuncion(DateTime? desde, DateTime? hasta)
        {
            var tabla = Ejecutar(SqlOcupacionPorFuncion, Fecha("@desde", desde), Fecha("@hasta", hasta));
            return ConsultaMapper.AOcupacionFunciones(tabla);
        }

        public List<RecaudacionPelicula> RecaudacionPorPelicula(DateTime? desde, DateTime? hasta)
        {
            var tabla = Ejecutar(SqlRecaudacionPorPelicula, Fecha("@desde", desde), Fecha("@hasta", hasta));
            return ConsultaMapper.ARecaudacionPeliculas(tabla);
        }

        private static DataTable Ejecutar(string sql, params SqlParameter[] parametros)
        {
            using (var cn = Conexion.Crear())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                da.SelectCommand.Parameters.AddRange(parametros);
                var tabla = new DataTable();
                da.Fill(tabla);
                return tabla;
            }
        }

        private static SqlParameter Fecha(string nombre, DateTime? valor)
        {
            return new SqlParameter(nombre, SqlDbType.DateTime2) { Value = (object)valor ?? DBNull.Value };
        }
    }
}
