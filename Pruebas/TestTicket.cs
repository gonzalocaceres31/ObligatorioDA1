using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;

namespace Pruebas
{
    [TestClass]
    public class TestTicket
    {
        [TestMethod]
        public void TestGenerarCodigoUnico()
        {
            string codigo1 = Ticket.GenerarCodigoUnico();
            string codigo2 = Ticket.GenerarCodigoUnico();
            Assert.AreEqual(codigo1.Length, codigo2.Length);
            Assert.AreNotEqual(codigo1, codigo2);
        }
        [TestMethod]
        public void TestDatosValidosOk()
        {
            Ticket ticket = new Ticket() { Codigo = Ticket.GenerarCodigoUnico(), NombreTipoTicket = "Prueba" };
            Boolean validos = Ticket.DatosValidos(ticket);
            Assert.IsTrue(validos);
        }
        [TestMethod]
        public void TestDatosValidosErrorSinNombreTipoTicket()
        {
            Ticket ticket = new Ticket() { Codigo = Ticket.GenerarCodigoUnico(), NombreTipoTicket = "" };
            Boolean validos = Ticket.DatosValidos(ticket);
            Assert.IsFalse(validos);
        }
        [TestMethod]
        public void TestDatosValidosErrorSinCodigo()
        {
            Ticket ticket = new Ticket() { Codigo = "", NombreTipoTicket = "Prueba" };
            Boolean validos = Ticket.DatosValidos(ticket);
            Assert.IsFalse(validos);
        }
    }
}
