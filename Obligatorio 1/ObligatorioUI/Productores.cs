using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace ObligatorioUI
{
    public partial class Form1 : Form
    {
        public Tienda t;
       
        public Form1()
        {
            InitializeComponent();
            t = new Tienda();
            t.Eventos = new List<Evento>();
            t.Productores = new List<Productor>();
            Productor productorRoot = new Productor() { Nombre = "root", Apellido = "root", Contraseña = "root", Mail = "root@root" };
            t.Productores.Add(productorRoot);
            t.ProductorLogueado = new Productor();
            TipoTicket ticket = new TipoTicket { Nombre = "Campo", CantidadRestante = 200, Precio = 500 };
            Funcion funcion  = new Funcion {CantidadRestante = 200, Compras = new List<Compra>(), FechaFin = "2022-01-01 02:00:00", FechaInicio = "2022-01-01 02:00:00", TiposTicket = new List<TipoTicket> { ticket } };
            Evento evento = new Evento { Nombre = "La Vela Puerca", Categoria = "Musica", Descripcion = "La Vela en Sala del Museo", Direccion = "Rambla", Funciones = new List<Funcion> { funcion }, Imagen = "", Link = "", Tipo = "Presencial" };
            t.Eventos.Add(evento);
        }

        private void CrearProductor_Click(object sender, EventArgs e)
        {
            RegistrarProductor.Visible = true;
        }

        private void BtnCrearProductor_Click(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            string nombreAux = Nombre.Text;
            string apellidoAux = Apellido.ToString();
            string mailAux = Mail.ToString();
            string contraseñaAux = Contraseña.ToString();
            Boolean hasErrors = false;
            if(nombreAux.Length < 1)
            {
                hasErrors = true;
                ErrorLabel.Text = "Debe ingresar su nombre";
            }
            if (apellidoAux.Length < 1)
            {
                hasErrors = true;
                ErrorLabel.Text = "Debe ingresar su apellido";
            }
            if (mailAux.Length < 1)
            {
                hasErrors = true;
                ErrorLabel.Text = "Debe ingresar su mail";
            }
            if (contraseñaAux.Length < 6)
            {
                hasErrors = true;
                ErrorLabel.Text = "Debe ingresar una contraseña de al menos 6 letras";
            }
            if(!hasErrors)
            {
                Productor p = new Productor { Nombre = nombreAux, Apellido = apellidoAux, Mail = mailAux, Contraseña = contraseñaAux };
                Boolean datosValidos = Productor.DatosValidos(t, p);
                if(datosValidos)
                {
                    t.AgregarProductor(p);
                    t.ProductorLogueado = p;
                    ErrorLabel.Text = "Productor creado correctamente";
                    RegistrarProductor.Visible = false;
                    EntrarProductor.Visible = false;
                    CrearProductor.Visible = false;
                    string[] textAux = { "Hola, ", nombreAux, "!" };
                    HolaProductor.Text = string.Concat(textAux);
                    HolaProductor.Visible = true;
                    CerrarSesion.Visible = true;
                }
            }
            ErrorLabel.Visible = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Boolean hasErrors = false;
            string mailAux = LoginMail.Text;
            string contraseñaAux = LoginContraseña.Text;
            if (mailAux.Length < 2)
            {
                hasErrors = true;
                LoginLabel.Text = "Debe ingresar su mail";
            }
            if (contraseñaAux.Length < 2)
            {
                hasErrors = true;
                LoginLabel.Text = "Debe ingresar su contraseña";
            }
            if(!hasErrors)
            {
                Productor.Login(t, mailAux, contraseñaAux);
                if(t.ProductorLogueado.Mail == mailAux)
                {
                    RegistrarProductor.Visible = false;
                    EntrarProductor.Visible = false;
                    CrearProductor.Visible = false;
                    HolaProductor.Text = "Hola, " + t.ProductorLogueado.Nombre + "!";
                    HolaProductor.Visible = true;
                    IngresarProductor.Visible = false;
                    CerrarSesion.Visible = true;
                }
                else
                {
                    LoginLabel.Text = "El usuario y contraseña no son correctos";
                }
            }
            LoginLabel.Visible = true;
        }

        private void EntrarProductor_Click(object sender, EventArgs e)
        {
            IngresarProductor.Visible = true;
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            Productor.Logout(t);
            CrearProductor.Visible = true;
            EntrarProductor.Visible = true;
            HolaProductor.Visible = false;
            CerrarSesion.Visible = false;
        }
    }
}
