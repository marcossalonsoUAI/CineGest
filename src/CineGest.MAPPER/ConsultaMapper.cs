using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineGest.BE;

namespace CineGest.MAPPER
{
    public static class ConsultaMapper
    {
        public static List<VentaPorCliente> AVentasPorCliente(DataTable tabla)
        {
            var lista = new List<VentaPorCliente>();
            foreach (DataRow f in tabla.Rows)
            {
                lista.Add(new VentaPorCliente
                {
                    IdVenta = Convert.ToInt32(f["ID_VENTA"]),
                    Fecha = Convert.ToDateTime(f["FECHA"]),
                    CantidadEntradas = Convert.ToInt32(f["CANTIDAD_ENTRADAS"]),
                    Total = Convert.ToDecimal(f["TOTAL"])
                });
            }
            return lista;
        }

        public static List<OcupacionFuncion> AOcupacionFunciones(DataTable tabla)
        {
            var lista = new List<OcupacionFuncion>();
            foreach (DataRow f in tabla.Rows)
            {
                lista.Add(new OcupacionFuncion
                {
                    IdFuncion = Convert.ToInt32(f["ID_FUNCION"]),
                    Pelicula = Convert.ToString(f["PELICULA"]),
                    Sala = Convert.ToString(f["SALA"]),
                    FechaHora = Convert.ToDateTime(f["FECHA_HORA"]),
                    Capacidad = Convert.ToInt32(f["CAPACIDAD"]),
                    EntradasVendidas = Convert.ToInt32(f["ENTRADAS_VENDIDAS"]),
                    Recaudacion = Convert.ToDecimal(f["RECAUDACION"])
                });
            }
            return lista;
        }

        public static List<RecaudacionPelicula> ARecaudacionPeliculas(DataTable tabla)
        {
            var lista = new List<RecaudacionPelicula>();
            foreach (DataRow f in tabla.Rows)
            {
                lista.Add(new RecaudacionPelicula
                {
                    IdPelicula = Convert.ToInt32(f["ID_PELICULA"]),
                    Titulo = Convert.ToString(f["TITULO"]),
                    CantidadFunciones = Convert.ToInt32(f["CANTIDAD_FUNCIONES"]),
                    EntradasVendidas = Convert.ToInt32(f["ENTRADAS_VENDIDAS"]),
                    Recaudacion = Convert.ToDecimal(f["RECAUDACION"])
                });
            }
            return lista;
        }
    }
}
