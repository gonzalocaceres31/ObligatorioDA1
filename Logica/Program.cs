using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            Tienda tienda = new Tienda();
            Evento evento = new Evento() { Nombre = "Prueba" };
            tienda.Eventos = new List<Evento>();
            tienda.AgregarEvento(evento);
            Console.WriteLine(tienda.Eventos[0].Nombre);
            Console.ReadLine();
        }
    }
}
