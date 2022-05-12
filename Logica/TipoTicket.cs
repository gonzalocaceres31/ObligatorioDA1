using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class TipoTicket
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int CantidadRestante { get; set; }

        public Boolean ChequearQuedanEntradas(int cantidad) 
        {
            if(cantidad <= CantidadRestante){
                return true;
            }else{
                return false;
            }
        }

        public void RestarTicketsComprados(int cantidad)
        {
            CantidadRestante = CantidadRestante - cantidad;
        }

        public static Boolean DatosValidos(TipoTicket ticket)
        {
            if(ticket.Nombre.Length > 4 && ticket.Precio > 0 && ticket.CantidadRestante > 0){
                return true;
            }else{
                return false;
            }
        }
        public override string ToString()
        {
            return this.Nombre + " - " + this.Precio;
        }
    }
}
