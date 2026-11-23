using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest.BE
{
    public class Pelicula
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Duracion { get; set; } // Duración en minutos
        public string Director { get; set; }
        public bool Estado { get; set; }
    }
}
