using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest.BE
{
    public class VentaPorCliente
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadEntradas { get; set; }
        public decimal Total { get; set; }
    }
}
