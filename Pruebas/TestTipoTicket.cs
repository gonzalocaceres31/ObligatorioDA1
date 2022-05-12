using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using System.Collections.Generic;

namespace Pruebas
{
    [TestClass]
    public class TestTipoTicket
    {
        [TestMethod]
        public void TestChequearQuedanEntradasTrue()
        {
            TipoTicket ticket = new TipoTicket();
            ticket.CantidadRestante = 1000;
            Boolean quedanEntradas = ticket.ChequearQuedanEntradas(5);
            Assert.IsTrue(quedanEntradas);
        }
        [TestMethod]
        public void TestChequearQuedanEntradasFalse()
        {
            TipoTicket ticket = new TipoTicket();
            ticket.CantidadRestante = 5;
            Boolean quedanEntradas = ticket.ChequearQuedanEntradas(8);
            Assert.IsFalse(quedanEntradas);
        }
        [TestMethod]
        public void TestRestarTicketsComprados()
        {
            TipoTicket ticket = new TipoTicket();
            int cantidadRestanteAux = 10;
            int cantidadCompradosAux = 5;
            ticket.CantidadRestante = cantidadRestanteAux;
            ticket.RestarTicketsComprados(cantidadCompradosAux);
            Assert.AreEqual(cantidadRestanteAux, ticket.CantidadRestante + cantidadCompradosAux);
        }
        [TestMethod]
        public void TestDatosValidosOk()
        {
            TipoTicket ticket = new TipoTicket() { Nombre = "Campo Vip", Precio = 100, CantidadRestante = 1000 };
            Boolean valido = TipoTicket.DatosValidos(ticket);
            Assert.IsTrue(valido);
        }
        [TestMethod]
        public void TestDatosValidosErrorSinNombre()
        {
            TipoTicket ticket = new TipoTicket() { Nombre = "", Precio = 100, CantidadRestante = 1000 };
            Boolean valido = TipoTicket.DatosValidos(ticket);
            Assert.IsFalse(valido);
        }
        [TestMethod]
        public void TestDatosValidosErrorSinPrecio()
        {
            TipoTicket ticket = new TipoTicket() { Nombre = "Campo Vip", CantidadRestante = 1000 };
            Boolean valido = TipoTicket.DatosValidos(ticket);
            Assert.IsFalse(valido);
        }
        [TestMethod]
        public void TestDatosValidosErrorSinCantidad()
        {
            TipoTicket ticket = new TipoTicket() { Nombre = "Campo Vip", Precio = 1000 };
            Boolean valido = TipoTicket.DatosValidos(ticket);
            Assert.IsFalse(valido);
        }
    }
}
