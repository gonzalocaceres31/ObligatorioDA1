using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Productor
    {
        public string Mail { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public static void Login(Tienda tienda, string mail, string contraseña)
        {
            Productor productor = tienda.Productores.Find(item => item.Mail.Equals(mail) && item.Contraseña.Equals(contraseña));
            if(productor != null){
                tienda.ProductorLogueado = productor;
            }
        }
        public static void Logout(Tienda tienda)
        {
            tienda.ProductorLogueado = new Productor();
        }
        public static Boolean DatosValidos(Tienda tienda, Productor p)
        {
            if(!ExisteProductorConMail(tienda, p.Mail) && p.Mail.Contains("@") && p.Mail.Length > 5 && p.Contraseña.Length > 6 && p.Nombre.Length > 0 && p.Apellido.Length > 0){
                return true;
            }else{
                return false;
            }
        }

        public static Boolean ExisteProductorConMail(Tienda tienda, string mail)
        {
            Productor productor = tienda.Productores.Find(item => item.Mail.Equals(mail));
            if (productor != null){
                return true;
            }else{
                return false;
            }
        }
    }
}
