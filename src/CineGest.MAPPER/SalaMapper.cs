using CineGest.BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest.MAPPER
{
    public static class SalaMapper
    {
        public static Sala ADominio(DataRow fila)
        {
            return new Sala
            {
                IdSala = (int)fila["ID_SALA"],
                Nombre = (string)fila["NOMBRE"],
                Capacidad = (int)fila["CAPACIDAD"],
                Tipo = (string)fila["TIPO"]
            };
        }

        public static List<Sala> ALista(DataTable tabla)
        {
            var lista = new List<Sala>();
            foreach (DataRow fila in tabla.Rows)
                lista.Add(ADominio(fila));
            return lista;
        }
    }
}
