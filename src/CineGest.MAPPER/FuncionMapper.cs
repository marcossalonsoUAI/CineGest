using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineGest.BE;

namespace CineGest.MAPPER
{
    public static class FuncionMapper
    {
        public static Funcion ADominio(DataRow fila)
        {
            return new Funcion
            {
                Id = Convert.ToInt32(fila["ID_FUNCION"]),
                IdPelicula = Convert.ToInt32(fila["ID_PELICULA"]),
                IdSala = Convert.ToInt32(fila["ID_SALA"]),
                FechaHora = Convert.ToDateTime(fila["FECHA_HORA"]),
                Precio = Convert.ToDecimal(fila["PRECIO"]),
                Activa = Convert.ToBoolean(fila["ESTADO"]),
                TituloPelicula = Convert.ToString(fila["TITULO"]),
                DuracionPelicula = Convert.ToInt32(fila["DURACION"]),
                NombreSala = Convert.ToString(fila["NOMBRE_SALA"])
            };
        }

        public static List<Funcion> ALista(DataTable tabla)
        {
            var lista = new List<Funcion>();
            foreach (DataRow fila in tabla.Rows)
                lista.Add(ADominio(fila));
            return lista;
        }
    }
}
