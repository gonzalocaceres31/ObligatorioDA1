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
        public Compra compraEnSesion;

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
            TipoTicket ticket2 = new TipoTicket { Nombre = "Campo Vip", CantidadRestante = 100, Precio = 800 };
            Funcion funcion  = new Funcion {CantidadRestante = 200, Compras = new List<Compra>(), FechaFin = "2022-01-01 02:00:00", FechaInicio = "2022-01-01 02:00:00", TiposTicket = new List<TipoTicket> { ticket, ticket2 } };
            Evento evento = new Evento { Nombre = "La Vela Puerca", Categoria = "Musica", Descripcion = "La Vela en Sala del Museo", Direccion = "Rambla", Funciones = new List<Funcion> { funcion }, Imagen = "", Link = "", Tipo = "Presencial" };
            t.Eventos.Add(evento);
            ListaEventos.DataSource = t.Eventos;
            int milliseconds = 2000;
            System.Threading.Thread.Sleep(milliseconds);
            ListaEventos.SelectedIndex = -1;
            CantidadEntradas.Maximum = 10;
            CantidadEntradas.Minimum = 1;
            ComprarEntrada.Visible = false;
            compraEnSesion = new Compra();
            compraEnSesion.Tickets = new List<Ticket>();
        }

        private void CrearProductor_Click(object sender, EventArgs e)
        {
            RegistrarProductor.Visible = true;
            IngresarProductor.Visible = false;
            PanelCompra.Visible = false;
            PanelEventos.Visible = false;
        }

        private void BtnCrearProductor_Click(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            string nombreAux = Nombre.Text;
            string apellidoAux = Apellido.Text;
            string mailAux = Mail.Text;
            string contraseñaAux = Contraseña.Text;
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
                    t.Productores.Add(p);
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
            }else
            {
                ErrorLabel.Visible = true;
            }
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
            RegistrarProductor.Visible = false;
            IngresarProductor.Visible = true;
            PanelCompra.Visible = false;
            PanelEventos.Visible = false;
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            Productor.Logout(t);
            CrearProductor.Visible = true;
            EntrarProductor.Visible = true;
            HolaProductor.Visible = false;
            CerrarSesion.Visible = false;
            PanelEventos.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ListaEventos_DoubleClick(object sender, EventArgs e)
        {
            if(ListaEventos.SelectedIndex > -1)
            {
                //PanelEventos.Visible = false;
                PanelCompra.Visible = true;
                Evento eventoSeleccionado = t.Eventos[ListaEventos.SelectedIndex];
                ListaFunciones.DataSource = eventoSeleccionado.Funciones;
                ListaTiposTicket.DataSource = eventoSeleccionado.Funciones[0].TiposTicket;
            }
        }

        private void VolverAEventos_Click(object sender, EventArgs e)
        {
            PanelCompra.Visible = false;
            PanelEventos.Visible = true;
        }
        private void ComprarEntrada_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAgregarACompra_Click(object sender, EventArgs e)
        {
            Evento eventoSeleccionado = t.Eventos[ListaEventos.SelectedIndex];
            for (int i = 1; i <= CantidadEntradas.Value; i++)
            {
                Ticket t = new Ticket { Codigo = Ticket.GenerarCodigoUnico(), NombreTipoTicket = eventoSeleccionado.Funciones[0].TiposTicket[ListaTiposTicket.SelectedIndex].Nombre };
                compraEnSesion.Tickets.Add(t);
            }
            CantidadEntradas.Maximum = CantidadEntradas.Maximum - CantidadEntradas.Value;
        }

        private void BtnTerminarCompra_Click(object sender, EventArgs e)
        {
            DatosCompra.Visible = true;
        }

        private void TerminarCompraFinal_Click(object sender, EventArgs e)
        {
            Evento eventoSeleccionado = t.Eventos[ListaEventos.SelectedIndex];
            Boolean hasErrors = false;
            string nombreAux = NombreCompra.Text;
            string apellidoAux = ApellidoCompra.Text;
            string cedulaAux = CedulaCompra.Text;
            if (nombreAux.Length < 2)
            {
                hasErrors = true;
                LabelErrorCompra.Text = "Debe ingresar su nombre";
            }
            if (apellidoAux.Length < 2)
            {
                hasErrors = true;
                LoginLabel.Text = "Debe ingresar su apellido";
            }
            if (cedulaAux.Length < 2)
            {
                hasErrors = true;
                LoginLabel.Text = "Debe ingresar su cedula";
            }
            if (!hasErrors)
            {
                compraEnSesion.Nombre = nombreAux;
                compraEnSesion.Apellido = apellidoAux;
                compraEnSesion.Cedula = Int32.Parse(cedulaAux);
                Boolean datosValidos = Compra.DatosValidos(compraEnSesion);
                if(datosValidos)
                {
                    eventoSeleccionado.Funciones[ListaFunciones.SelectedIndex].AgregarCompra(compraEnSesion);
                    ListaTickets.Text = String.Join(Environment.NewLine, compraEnSesion.Tickets);
                    LabelGracias.Text = "Gracias por tu compra, " + compraEnSesion.Nombre + "!";
                    LabelTickets.Text = "Tus tickets asociados a la cedula: " + compraEnSesion.Cedula;
                    ListaTickets.Visible = true;
                    compraEnSesion = new Compra();
                    PanelTickets.Visible = true;
                }
            }
        }

        private void VolverEventos_Click(object sender, EventArgs e)
        {
            PanelCompra.Visible = false;
            DatosCompra.Visible = false;
            PanelTickets.Visible = false;
        }
    }
}
