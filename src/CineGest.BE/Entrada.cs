using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest.BE
{
    public class Entrada
    {
        public int Id { get; set; }
        public int IdVenta { get; set; }
        public int IdFuncion { get; set; }
        public string Asiento { get; set; }
        public decimal Precio { get; set; }
    }
}
