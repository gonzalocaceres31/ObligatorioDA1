using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Compra
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public List<Ticket> Tickets { get; set; }
        public static Boolean DatosValidos(Compra compra)
        {
            if(compra.Nombre.Length > 0 && compra.Apellido.Length > 0 && compra.Cedula.ToString().Length == 8 && compra.Tickets.Count > 0) {
                return true;
            }else{
                return false;
            }
        }
        public void AgregarTicket(Ticket ticket)
        {
            if(Ticket.DatosValidos(ticket)){
                Tickets.Add(ticket);
            }
        }
    }
}
