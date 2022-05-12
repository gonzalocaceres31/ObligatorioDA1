using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using System.Collections.Generic;

namespace Pruebas
{
    [TestClass]
    public class TestProductor
    {
        [TestMethod]
        public void TestLoginProductorOk()
        {
            Tienda tienda = new Tienda();
            tienda.ProductorLogueado = new Productor();
            Productor productor = new Productor() { Nombre = "Gonzalo", Apellido = "Caceres", Mail = "gonzalo@gmail.com", Contraseña = "Gonzalo123" };
            tienda.Productores = new List<Productor> { productor };
            Productor.Login(tienda, productor.Mail, productor.Contraseña);
            Productor productorAux = tienda.ProductorLogueado;
            Assert.AreEqual(productorAux, productor);
        }

        [TestMethod]
        public void TestLoginProductorError()
        {
            Tienda tienda = new Tienda();
            tienda.ProductorLogueado = new Productor();
            Productor productor = new Productor() { Nombre = "Gonzalo", Apellido = "Caceres", Mail = "gonzalo@gmail.com", Contraseña = "Gonzalo123" };
            tienda.Productores = new List<Productor> { productor };
            Productor.Login(tienda, "-", "-");
            Productor productorAux = tienda.ProductorLogueado;
            Assert.AreNotEqual(productorAux, productor);
        }

        [TestMethod]
        public void TestLogoutOk()
        {
            Tienda tienda = new Tienda();
            Productor productorLogueado = new Productor() { Nombre = "Gonzalo", Apellido = "Caceres", Mail = "gonzalo@gmail.com", Contraseña = "Gonzalo123" };
            tienda.ProductorLogueado = productorLogueado;
            Productor.Logout(tienda);
            Productor productorAux = tienda.ProductorLogueado;
            Assert.AreNotEqual(productorLogueado, productorAux);
        }

        [TestMethod]
        public void TestDatosValidosOk()
        {
            Tienda tienda = new Tienda();
            tienda.Productores = new List<Productor> {};
            Productor productor = new Productor() { Nombre = "Gonzalo", Apellido = "Caceres", Mail = "gonzalo@gmail.com", Contraseña = "Gonzalo123" };
            Boolean valido = Productor.DatosValidos(tienda, productor);
            Assert.IsTrue(valido);
        }

        [TestMethod]
        public void TestDatosValidosErrorSinNombre()
        {
            Tienda tienda = new Tienda();
            tienda.Productores = new List<Productor> { };
            Productor productor = new Productor() { Nombre = "", Apellido = "Caceres", Mail = "gonzalo@gmail.com", Contraseña = "Gonzalo123" };
            Boolean valido = Productor.DatosValidos(tienda, productor);
            Assert.IsFalse(valido);
        }
        [TestMethod]
        public void TestDatosValidosErrorMail()
        {
            Tienda tienda = new Tienda();
            tienda.Productores = new List<Productor> { };
            Productor productor = new Productor() { Nombre = "Gonzalo", Apellido = "Caceres", Mail = "gonzalo", Contraseña = "Gonzalo123" };
            Boolean valido = Productor.DatosValidos(tienda, productor);
            Assert.IsFalse(valido);
        }
        [TestMethod]
        public void TestExisteProductorConMailTrue()
        {
            Tienda tienda = new Tienda();
            Productor productor = new Productor() { Nombre = "Gonzalo", Apellido = "Caceres", Mail = "gonzalo@gmail.com", Contraseña = "Gonzalo123" };
            tienda.Productores = new List<Productor> { productor  };
            Boolean existe = Productor.ExisteProductorConMail(tienda, productor.Mail);
            Assert.IsTrue(existe);
        }
        [TestMethod]
        public void TestExisteProductorConMailFalse()
        {
            Tienda tienda = new Tienda();
            Productor productor = new Productor() { Nombre = "Gonzalo", Apellido = "Caceres", Mail = "gonzalo@gmail.com", Contraseña = "Gonzalo123" };
            tienda.Productores = new List<Productor> { productor };
            Boolean existe = Productor.ExisteProductorConMail(tienda, "a@a.com");
            Assert.IsFalse(existe);
        }
    }
}
