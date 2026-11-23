using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest.BE
{
    public class Venta
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public string MedioPago { get; set; }
        public List<Entrada> Entradas { get; set; } = new List<Entrada>();
    }
}
