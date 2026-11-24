using CineGest.BE;
using System;
using System.Collections.Generic;
using System.Data;

namespace CineGest.MAPPER
{
    public static class UsuarioMapper
    {
        public static Usuario ADominio(DataRow fila)
        {
            return new Usuario
            {
                Id = Convert.ToInt32(fila["ID_USUARIO"]),
                NombreUsuario = fila["NOMBRE_USUARIO"].ToString(),
                PasswordHash = fila["PASSWORD_HASH"] == DBNull.Value ? null : fila["PASSWORD_HASH"].ToString(),
                Rol = fila["ROL"].ToString()
            };
        }

        public static List<Usuario> ALista(DataTable tabla)
        {
            var lista = new List<Usuario>();
            foreach (DataRow fila in tabla.Rows)
                lista.Add(ADominio(fila));
            return lista;
        }
    }
}