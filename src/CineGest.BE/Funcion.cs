using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineGest.BE
{
    public class Funcion
    {
        public int Id { get; set; }
        public int IdPelicula { get; set; }
        public int IdSala { get; set; }
        public DateTime FechaHora { get; set; }
        public decimal Precio { get; set; }
        public bool Activa { get; set; }   // columna ESTADO

        //Datos de solo lectura que llegan del JOIN con PELICULA y SALA (para grillas y combos).
        public string TituloPelicula { get; set; }
        public int DuracionPelicula { get; set; }
        public string NombreSala { get; set; }

        public DateTime HoraFin => FechaHora.AddMinutes(DuracionPelicula);
        public string Descripcion => $"{TituloPelicula} - {NombreSala} - {FechaHora:dd/MM HH:mm}";
    }
}
