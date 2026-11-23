using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CineGest.BE;
using CineGest.MAPPER;

namespace CineGest.DAL
{
    public class VentaDAL
    {
        //Transacción principal: VENTA + todas sus ENTRADA, o nada.
        //Si falla cualquier INSERT se hace Rollback y la excepción sube a la BLL.
        public int Registrar(Venta v)
        {
            const string sqlVenta = @"INSERT INTO VENTA (ID_CLIENTE, TOTAL, MEDIO_PAGO)
                                      VALUES (@idCliente, @total, @medioPago);
                                      SELECT CAST(SCOPE_IDENTITY() AS int);";
            const string sqlEntrada = @"INSERT INTO ENTRADA (ID_VENTA, ID_FUNCION, ASIENTO, PRECIO)
                                        VALUES (@idVenta, @idFuncion, @asiento, @precio);
                                        SELECT CAST(SCOPE_IDENTITY() AS int);";

            using (var cn = Conexion.Crear())
            {
                cn.Open();
                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        int idVenta;
                        using (var cmd = new SqlCommand(sqlVenta, cn, tx))
                        {
                            cmd.Parameters.Add("@idCliente", SqlDbType.Int).Value = v.IdCliente;
                            AgregarDecimal(cmd, "@total", v.Total);
                            cmd.Parameters.Add("@medioPago", SqlDbType.NVarChar, 30).Value = v.MedioPago;
                            idVenta = (int)cmd.ExecuteScalar();
                        }

                        foreach (var e in v.Entradas)
                        {
                            using (var cmd = new SqlCommand(sqlEntrada, cn, tx))
                            {
                                cmd.Parameters.Add("@idVenta", SqlDbType.Int).Value = idVenta;
                                cmd.Parameters.Add("@idFuncion", SqlDbType.Int).Value = e.IdFuncion;
                                cmd.Parameters.Add("@asiento", SqlDbType.NVarChar, 10).Value = e.Asiento;
                                AgregarDecimal(cmd, "@precio", e.Precio);
                                e.Id = (int)cmd.ExecuteScalar();
                                e.IdVenta = idVenta;
                            }
                        }

                        tx.Commit();
                        v.Id = idVenta;
                        return idVenta;
                    }
                    catch
                    {
                        try { tx.Rollback(); } catch { /* se conserva la excepción original */ }
                        throw;
                    }
                }
            }
        }

        public bool ObtenerDatosFuncion(int idFuncion, out bool activa, out decimal precio,
                                        out int capacidad, out DateTime fechaHora)
        {
            const string sql = @"SELECT f.ESTADO, f.PRECIO, f.FECHA_HORA, s.CAPACIDAD
                                 FROM FUNCION f
                                 INNER JOIN SALA s ON s.ID_SALA = f.ID_SALA
                                 WHERE f.ID_FUNCION = @id";
            activa = false;
            precio = 0;
            capacidad = 0;
            fechaHora = DateTime.MinValue;
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idFuncion;
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    if (!dr.Read()) return false;
                    activa = Convert.ToBoolean(dr["ESTADO"]);
                    precio = Convert.ToDecimal(dr["PRECIO"]);
                    fechaHora = Convert.ToDateTime(dr["FECHA_HORA"]);
                    capacidad = Convert.ToInt32(dr["CAPACIDAD"]);
                    return true;
                }
            }
        }

        //Para RN05 y para mostrar en pantalla qué asientos ya no se pueden elegir.
        public List<string> AsientosOcupados(int idFuncion)
        {
            const string sql = "SELECT ASIENTO FROM ENTRADA WHERE ID_FUNCION = @id";
            var lista = new List<string>();
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idFuncion;
                cn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                        lista.Add(Convert.ToString(dr["ASIENTO"]));
                }
            }
            return lista;
        }

        public bool ExisteCliente(int idCliente)
        {
            const string sql = "SELECT COUNT(*) FROM CLIENTE WHERE ID_CLIENTE = @id";
            using (var cn = Conexion.Crear())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idCliente;
                cn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        //Para armar un comprobante de la venta.
        public List<Entrada> ObtenerEntradas(int idVenta)
        {
            const string sql = @"SELECT ID_ENTRADA, ID_VENTA, ID_FUNCION, ASIENTO, PRECIO
                                 FROM ENTRADA WHERE ID_VENTA = @id ORDER BY ASIENTO";
            using (var cn = Conexion.Crear())
            using (var da = new SqlDataAdapter(sql, cn))
            {
                da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = idVenta;
                var tabla = new DataTable();
                da.Fill(tabla);
                return EntradaMapper.ALista(tabla);
            }
        }

        private static void AgregarDecimal(SqlCommand cmd, string nombre, decimal valor)
        {
            var p = cmd.Parameters.Add(nombre, SqlDbType.Decimal);
            p.Precision = 10;
            p.Scale = 2;
            p.Value = valor;
        }
    }
}
