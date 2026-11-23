using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest.BE
{
    public class RecaudacionPelicula
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public int CantidadFunciones { get; set; }
        public int EntradasVendidas { get; set; }
        public decimal Recaudacion { get; set; }
    }
}
