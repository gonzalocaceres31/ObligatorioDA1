using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Ticket
    {
        public string Codigo { get; set; }
        public string NombreTipoTicket { get; set; }
        public static string GenerarCodigoUnico()
        {
            return Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Substring(0, 10);
        }
        public static Boolean DatosValidos(Ticket ticket)
        {
            if(ticket.Codigo.Length == 10 && ticket.NombreTipoTicket.Length > 4){
                return true;
            }else{
                return false;
            }
        }
        public override string ToString()
        {
            return this.NombreTipoTicket + " - " + this.Codigo;
        }
    }
}
