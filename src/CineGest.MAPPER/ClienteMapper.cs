using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineGest.BE;

namespace CineGest.MAPPER
{
    public static class ClienteMapper
    {
        public static Cliente ADominio(DataRow fila)
        {
            return new Cliente
            {
                Id = (int)fila["ID_CLIENTE"],
                Nombre = (string)fila["NOMBRE"],
                Apellido = (string)fila["APELLIDO"],
                Dni = (string)fila["DNI"],
                Email = fila["EMAIL"] == System.DBNull.Value ? null : (string)fila["EMAIL"]
            };
        }

        public static List<Cliente> ALista(DataTable tabla)
        {
            var lista = new List<Cliente>();
            foreach (DataRow fila in tabla.Rows)
                lista.Add(ADominio(fila));
            return lista;
        }
    }
}
