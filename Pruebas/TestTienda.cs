using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logica;
using System.Collections.Generic;

namespace Pruebas
{
    [TestClass]
    public class TestTienda
    {
        [TestMethod]
        public void TestAgregarEventoOk()
        {
            Tienda tienda = new Tienda();
            tienda.Eventos = new List<Evento>();
            Evento evento = new Evento() { Nombre = "Guns'n Roses en Uruguay", Descripcion = "Guns'n Roses en Uruguay", Direccion = "Estadio centenario" };
            tienda.AgregarEvento(evento);
            Evento eventoAux = tienda.Eventos.Find(item => item.Nombre.Equals(evento.Nombre));
            Assert.AreEqual(eventoAux, evento);
        }

        [TestMethod]
        public void TestAgregarProductorOk()
        {
            Tienda tienda = new Tienda();
            tienda.Productores = new List<Productor>();
            Productor productor = new Productor() { Nombre = "Gonzalo", Apellido = "Caceres", Mail = "gonzalo@gmail.com", Contraseña = "Gonzalo123" };
            tienda.AgregarProductor(productor);
            Productor productorAux = tienda.Productores.Find(item => item.Mail.Equals(productor.Mail));
            Assert.AreEqual(productorAux, productor);
        }
        [TestMethod]
        public void TestAgregarProductorError()
        {
            Tienda tienda = new Tienda();
            tienda.Productores = new List<Productor>();
            Productor productor = new Productor() { Nombre = "Gonzalo", Apellido = "Caceres", Mail = "", Contraseña = "" };
            tienda.AgregarProductor(productor);
            Productor productorAux = tienda.Productores.Find(item => item.Mail.Equals(productor.Mail));
            Assert.IsNull(productorAux);
        }
    }
}
