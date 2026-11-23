using System;
using System.Collections.Generic;
using System.Data;
using CineGest.BE;

namespace CineGest.MAPPER
{
    public static class EntradaMapper
    {
        public static Entrada ADominio(DataRow fila)
        {
            return new Entrada
            {
                Id = Convert.ToInt32(fila["ID_ENTRADA"]),
                IdVenta = Convert.ToInt32(fila["ID_VENTA"]),
                IdFuncion = Convert.ToInt32(fila["ID_FUNCION"]),
                Asiento = Convert.ToString(fila["ASIENTO"]),
                Precio = Convert.ToDecimal(fila["PRECIO"])
            };
        }

        public static List<Entrada> ALista(DataTable tabla)
        {
            var lista = new List<Entrada>();
            foreach (DataRow fila in tabla.Rows)
                lista.Add(ADominio(fila));
            return lista;
        }
    }
}
