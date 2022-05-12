using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using System.Collections.Generic;

namespace Pruebas
{
    [TestClass]
    public class TestCompra
    {
        [TestMethod]
        public void TestDatosValidosOk()
        {
            List<Ticket> tickets = new List<Ticket>();
            Ticket ticket1 = new Ticket() { Codigo = Ticket.GenerarCodigoUnico(), NombreTipoTicket = "Prueba" };
            Ticket ticket2 = new Ticket() { Codigo = Ticket.GenerarCodigoUnico(), NombreTipoTicket = "Prueba" };
            tickets.Add(ticket1);
            tickets.Add(ticket2);
            Compra compra = new Compra() { Nombre = "Gonzalo", Apellido = "Caceres", Cedula = 49105893, Tickets = tickets };
            Boolean validos = Compra.DatosValidos(compra);
            Assert.IsTrue(validos);
        }

        [TestMethod]
        public void TestDatosValidosErrorSinTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            Compra compra = new Compra() { Nombre = "Gonzalo", Apellido = "Caceres", Cedula = 49105893, Tickets = tickets };
            Boolean validos = Compra.DatosValidos(compra);
            Assert.IsFalse(validos);
        }
        [TestMethod]
        public void TestAgregarTicketOk()
        {
            Compra compra = new Compra();
            compra.Tickets = new List<Ticket>();
            Ticket ticket = new Ticket() { Codigo = Ticket.GenerarCodigoUnico(), NombreTipoTicket = "Prueba" };
            compra.AgregarTicket(ticket);
            Ticket ticketAux = compra.Tickets.Find(item => item.Codigo.Equals(ticket.Codigo));
            Assert.AreEqual(ticket, ticketAux);
        }
        [TestMethod]
        public void TestAgregarTicketError()
        {
            Compra compra = new Compra();
            compra.Tickets = new List<Ticket>();
            Ticket ticket = new Ticket() { Codigo = Ticket.GenerarCodigoUnico(), NombreTipoTicket = "" };
            compra.AgregarTicket(ticket);
            Ticket ticketAux = compra.Tickets.Find(item => item.Codigo.Equals(ticket.Codigo));
            Assert.IsNull(ticketAux);
        }
    }
}
