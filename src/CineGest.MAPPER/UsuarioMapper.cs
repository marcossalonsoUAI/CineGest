using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineGest.BE;

namespace CineGest.MAPPER
{
    public static class UsuarioMapper
    {
        public static Usuario ADominio(DataRow fila)
        {
            return new Usuario
            {
                Id = Convert.ToInt32(fila["ID_USUARIO"]),
                NombreUsuario = Convert.ToString(fila["NOMBRE_USUARIO"]),
                PasswordHash = Convert.ToString(fila["PASSWORD_HASH"]),
                Rol = Convert.ToString(fila["ROL"])
            };
        }
    }
}
