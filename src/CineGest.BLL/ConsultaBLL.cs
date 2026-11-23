using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineGest.BE;
using CineGest.DAL;

namespace CineGest.BLL
{
    public class ConsultaBLL
    {
        private readonly ConsultaDAL _dal = new ConsultaDAL();

        public List<VentaPorCliente> VentasPorCliente(int idCliente)
        {
            if (idCliente <= 0)
                throw new InvalidOperationException("Seleccioná un cliente.");
            return _dal.VentasPorCliente(idCliente);
        }

        public List<OcupacionFuncion> OcupacionPorFuncion(DateTime? desde, DateTime? hasta)
        {
            NormalizarRango(desde, hasta, out DateTime? inicio, out DateTime? fin);
            return _dal.OcupacionPorFuncion(inicio, fin);
        }

        public List<RecaudacionPelicula> RecaudacionPorPelicula(DateTime? desde, DateTime? hasta)
        {
            NormalizarRango(desde, hasta, out DateTime? inicio, out DateTime? fin);
            return _dal.RecaudacionPorPelicula(inicio, fin);
        }

        private static void NormalizarRango(DateTime? desde, DateTime? hasta,
                                            out DateTime? inicio, out DateTime? fin)
        {
            if (desde.HasValue && hasta.HasValue && desde.Value.Date > hasta.Value.Date)
                throw new InvalidOperationException("La fecha desde no puede ser posterior a la fecha hasta.");
            inicio = desde?.Date;
            fin = hasta?.Date.AddDays(1);
        }
    }
}
