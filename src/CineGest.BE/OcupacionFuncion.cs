using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest.BE
{
    public class OcupacionFuncion
    {
        public int IdFuncion { get; set; }
        public string Pelicula { get; set; }
        public string Sala { get; set; }
        public DateTime FechaHora { get; set; }
        public int Capacidad { get; set; }
        public int EntradasVendidas { get; set; }
        public decimal Recaudacion { get; set; }

        public decimal PorcentajeOcupacion =>
            Capacidad > 0 ? Math.Round(EntradasVendidas * 100m / Capacidad, 1) : 0m;
    }
}
