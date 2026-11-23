using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CineGest.BLL
{
    public static class Seguridad
    {
        //SHA-256 en hexadecimal y minúsculas: el mismo formato que el INSERT del script.
        public static string Sha256(string texto)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(texto));
                return string.Concat(bytes.Select(b => b.ToString("x2")));
            }
        }
    }
}
