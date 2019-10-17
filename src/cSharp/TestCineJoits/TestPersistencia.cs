using CineJoits1958;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CineJoits1958.ADO;

namespace TestCineJoits
{
    [TestClass]
    public class TestPersistencia
    {
        public static void CrearBD(TestContext context)
        {
            var ado = new AdoMySQLEntityCore();
            ado.Database.EnsureDeleted();
            ado.Database.EnsureCreated();
        }
    }
}
