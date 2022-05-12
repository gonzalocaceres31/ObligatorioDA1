using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using System.Collections.Generic;

namespace Pruebas
{
    [TestClass]
    public class TestFuncion
    {
        [TestMethod]
        public void TestDatosValidosOk()
        {
            List<Compra> compras = new List<Compra>();
            List<TipoTicket> tiposTicket = new List<TipoTicket>();
            TipoTicket tipoTicket = new TipoTicket() { Nombre = "Prueba", CantidadRestante = 1000, Precio = 100 };
            tiposTicket.Add(tipoTicket);
            Funcion funcion = new Funcion() { FechaInicio = "01/01/2020 00:00:00", FechaFin = "01/01/2020 02:00:00", CantidadRestante = 1000, TiposTicket = tiposTicket, Compras = compras };
            Boolean validos = Funcion.DatosValidos(funcion);
            Assert.IsTrue(validos);
        }
        [TestMethod]
        public void TestDatosValidosErrorFechas()
        {
            List<Compra> compras = new List<Compra>();
            List<TipoTicket> tiposTicket = new List<TipoTicket>();
            TipoTicket tipoTicket = new TipoTicket() { Nombre = "Prueba", CantidadRestante = 1000, Precio = 100 };
            tiposTicket.Add(tipoTicket);
            Funcion funcion = new Funcion() { FechaInicio = "Gonzalo", FechaFin = "Caceres", CantidadRestante = 1000, TiposTicket = tiposTicket, Compras = compras };
            Boolean validos = Funcion.DatosValidos(funcion);
            Assert.IsFalse(validos);
        }
        [TestMethod]
        public void TestDatosValidosErrorSinTiposTicket()
        {
            List<Compra> compras = new List<Compra>();
            List<TipoTicket> tiposTicket = new List<TipoTicket>();
            Funcion funcion = new Funcion() { FechaInicio = "01/01/2020 00:00:00", FechaFin = "01/01/2020 02:00:00", CantidadRestante = 1000, TiposTicket = tiposTicket, Compras = compras };
            Boolean validos = Funcion.DatosValidos(funcion);
            Assert.IsFalse(validos);
        }
        [TestMethod]
        public void TestAgregarCompraOk()
        {
            List<Ticket> tickets = new List<Ticket>();
            Ticket ticket = new Ticket() { Codigo = Ticket.GenerarCodigoUnico(), NombreTipoTicket = "Prueba" };
            tickets.Add(ticket);
            Compra compra = new Compra() { Nombre = "Gonzalo", Apellido = "Caceres", Cedula = 49105893, Tickets = tickets };
            Funcion funcion = new Funcion();
            funcion.Compras = new List<Compra>();
            funcion.AgregarCompra(compra);
            Compra compraAux = funcion.Compras.Find(item => item.Cedula.Equals(compra.Cedula));
            Assert.AreEqual(compra, compraAux);
        }
        [TestMethod]
        public void TestAgregarCompraErrorSinTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            Compra compra = new Compra() { Nombre = "Gonzalo", Apellido = "Caceres", Cedula = 49105893, Tickets = tickets };
            Funcion funcion = new Funcion();
            funcion.Compras = new List<Compra>();
            funcion.AgregarCompra(compra);
            Compra compraAux = funcion.Compras.Find(item => item.Cedula.Equals(compra.Cedula));
            Assert.IsNull(compraAux);
        }
        [TestMethod]
        public void TestAgregarTipoTicketOk()
        {
            Funcion funcion = new Funcion();
            funcion.TiposTicket = new List<TipoTicket>();
            TipoTicket tipoTicket = new TipoTicket() { Nombre = "Prueba", CantidadRestante = 100, Precio = 100 };
            funcion.AgregarTipoTicket(tipoTicket);
            TipoTicket tipoTicketAux = funcion.TiposTicket.Find(item => item.Nombre.Equals(tipoTicket.Nombre));
            Assert.AreEqual(tipoTicket, tipoTicketAux);
        }
        [TestMethod]
        public void TestAgregarTipoTicketError()
        {
            Funcion funcion = new Funcion();
            funcion.TiposTicket = new List<TipoTicket>();
            TipoTicket tipoTicket = new TipoTicket() { Nombre = "Prueba", CantidadRestante = 0, Precio = 0 };
            funcion.AgregarTipoTicket(tipoTicket);
            TipoTicket tipoTicketAux = funcion.TiposTicket.Find(item => item.Nombre.Equals(tipoTicket.Nombre));
            Assert.IsNull(tipoTicketAux);
        }

    }
}
