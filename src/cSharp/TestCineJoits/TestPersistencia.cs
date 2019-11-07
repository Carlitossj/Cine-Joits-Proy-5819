using CineJoits1958;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CineJoits1958.ADO;
using NETCore.Encrypt;

namespace TestCineJoits
{
    [TestClass]
    public class TestPersistencia
    {
        public static AdoMySQLEntityCore AdoMySQL { get; set; }

        [ClassInitialize]
        public static void CrearBD(TestContext context)
        {
            AdoMySQL = FactoryAdoMySQL.GetAdoDesdeJson("appsettings.json", "root");
            AdoMySQL.Database.EnsureDeleted();
        }
        [TestMethod]
        public void SeCreaDB()
        {
            AdoMySQL.Database.EnsureCreated();
        }
        [TestMethod]
        public void persistenciaCajero()
        {
            string passEncriptada = EncryptProvider.Sha256("buenardo");
            string otherpass= EncryptProvider.Sha256("faerte");
            int DNI = 43568787;
            int otherdni = 98655483;
            Cajero cajero = new Cajero()
            {
               dni = DNI,
               Nombre="Alvaro",
               Apellido="Diaz",
               Contraseña=passEncriptada
                
            };
            AdoMySQLEntityCore ado = new AdoMySQLEntityCore();
            ado.agregarCajero(cajero);
            Cajero cajero2 = ado.cajeroPorDniPass(DNI, otherpass);
            Assert.IsNull(cajero2);

            Cajero cajero3 = ado.cajeroPorDniPass(otherdni, passEncriptada);
            Assert.IsNull(cajero3);

            Cajero cajero4 = ado.cajeroPorDniPass(otherdni, otherpass);
            Assert.IsNull(cajero4);

            Cajero cajero5 = ado.cajeroPorDniPass(DNI, passEncriptada);
            Assert.IsNotNull(cajero5);
            Assert.AreEqual("Gomez, Juan", cajero5.NombreCompleto);
        }
       



    }
}
