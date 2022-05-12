using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Funcion
    {
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public int CantidadRestante { get; set; }
        public List<TipoTicket> TiposTicket { get; set; }
        public List<Compra> Compras { get; set; }

        public static Boolean DatosValidos(Funcion funcion)
        {
            DateTime fechaFin;
            DateTime fechaInicio;
            if (DateTime.TryParse(funcion.FechaFin, out fechaFin) && DateTime.TryParse(funcion.FechaInicio, out fechaInicio) && funcion.CantidadRestante > 0 && funcion.TiposTicket.Count > 0 && funcion.Compras.Count == 0) {
                return true;
            }else{
                return false;
            }
        }
        public void AgregarTipoTicket(TipoTicket tipoTicket)
        {
            if(TipoTicket.DatosValidos(tipoTicket)){
                TiposTicket.Add(tipoTicket);
            }
        }
        public void AgregarCompra(Compra compra)
        {
            if (Compra.DatosValidos(compra))
            {
                Compras.Add(compra);
            }
        }
    }
}
