using CineGest.BE;
using System;
using System.Collections.Generic;
using System.Data;

namespace CineGest.MAPPER
{
    public static class PeliculaMapper
    {
        public static Pelicula ADominio(DataRow fila)
        {
            return new Pelicula
            {
                IdPelicula = (int)fila["ID_PELICULA"],
                Titulo = (string)fila["TITULO"],
                Genero = (string)fila["GENERO"],
                Duracion = (int)fila["DURACION"],
                Director = fila["DIRECTOR"] == DBNull.Value ? "" : (string)fila["DIRECTOR"],
                Estado = (bool)fila["ESTADO"]
            };
        }

        public static List<Pelicula> ALista(DataTable tabla)
        {
            var lista = new List<Pelicula>();
            foreach (DataRow fila in tabla.Rows)
                lista.Add(ADominio(fila));
            return lista;
        }
    }
}