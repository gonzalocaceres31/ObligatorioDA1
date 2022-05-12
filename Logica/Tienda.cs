using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Tienda
    {
        public List<Evento> Eventos{ get; set; }
        public List<Productor> Productores { get; set; }
        public Productor ProductorLogueado { get; set; }

        public void AgregarEvento(Evento e)
        {
            Eventos.Add(e);
        }
        public void AgregarProductor(Productor p)
        {
            if(Productor.DatosValidos(this, p)) {
                Productores.Add(p);
            }
        }

    }
}
