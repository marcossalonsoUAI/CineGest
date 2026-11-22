using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CineGest.DAL
{
    public static class Conexion
    {
        public static SqlConnection Crear()
        {
            string cadena = ConfigurationManager.ConnectionStrings["CineGest"].ConnectionString;
            return new SqlConnection(cadena);
        }
    }
}
