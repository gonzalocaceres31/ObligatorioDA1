using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Evento
    {
        public string Nombre{get; set;}
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Imagen { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public string Link { get; set; }
        public List<Funcion> Funciones { get; set; }

        public static Boolean DatosValidos (Evento e)
        {
            if(e.Nombre.Length > 1 && e.Descripcion.Length > 1 && (e.Direccion.Length > 0 || e.Link.Length > 0) && e.Categoria.Length > 0 && e.Imagen.Length > 0 && e.Funciones.Count > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
