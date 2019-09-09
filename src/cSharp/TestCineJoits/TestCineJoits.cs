using CineJoits1958;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestCineJoits
{
    [TestClass]
    public class TestCineJoits
    {
        Pelicula It { get; set; }
        Genero Terror { get; set; }
        Sala tres { get; set; }
        Proyeccion proyeccion1 { get; set; }
        Entrada entradaIt { get; set; }
        Entrada entradaIt2 { get; set; }
        
        List<Entrada> EntradasVendidas =new List<Entrada> ();

        [TestInitialize]
        public void setupPelicula()
        {
            Terror = new Genero() { Nombre = "Terror" };
           
            It = new Pelicula();
            It.Nombre = "IT(ESO) 2";
            It.Genero = Terror;
            It.Lanzamiento = new DateTime(2019, 09, 05);
            
            setupSala();
            setupProyeccion();
            setupEntradait();
            setupEntradait2();            
            proyeccion1.EntradasVendidas = new List<Entrada>() { entradaIt, entradaIt2 };
        }
        
        public void setupProyeccion()
        {
            proyeccion1 = new Proyeccion();
            proyeccion1.FechaHora = new DateTime(2019, 09, 06);
            proyeccion1.Precio = 170;
            It.AgregarProyeccion(proyeccion1);
           
        }
        
        public void setupSala()
        {
            tres = new Sala();
            tres.Capacidad = 250;
            tres.Piso = 2;

        }
       
        public void setupEntradait2()
        {

            entradaIt2 = new Entrada();
            entradaIt2.FechaHora = new DateTime(2019,09,06,12,45,00);
            entradaIt2.Valor = proyeccion1.Precio;
            entradaIt2.Proyeccion = proyeccion1;
            
        }
        
        public void setupEntradait()
        {
            entradaIt = new Entrada();
            entradaIt.FechaHora = new DateTime(2019, 09, 06, 12, 15, 00);
            entradaIt.Valor = proyeccion1.Precio;
            entradaIt.Proyeccion = proyeccion1;
        }
       
        [TestMethod]
        public void AgregarProyeccion()
        {
            Assert.AreEqual(0, It.Proyecciones.Count);
            It.AgregarProyeccion(proyeccion1);
            Assert.AreEqual( 1,It.Proyecciones.Count);
        }
        [TestMethod]
        public bool Entre()
        {
            DateTime inicio = new DateTime (2019, 09, 05);
            DateTime fin = new DateTime(2019, 09, 07);
            return inicio <= entradaIt.FechaHora && entradaIt.FechaHora <= fin;
        }
        [TestMethod]
        public  void VenderEntrada()
        {
            Assert.AreEqual(2, proyeccion1.CantidadVendidas);
            proyeccion1.VenderEntrada();
            Assert.AreEqual(3, proyeccion1.CantidadVendidas);
        }
        [TestMethod]
        public void EntradasVenidasentre()
        {
            DateTime inicio = new DateTime(2019, 09, 04);
            DateTime fin = new DateTime(2019, 09, 08);
            Assert.AreEqual(2, proyeccion1.CantidadVendidas);
            Assert.AreEqual(2,proyeccion1.EntradasVendidasentre(inicio, fin));
        }
        [TestMethod]
        public void EntradasVendidasEntre()
        {
            DateTime inicio = new DateTime(2019, 09, 04);
            DateTime fin = new DateTime(2019, 09, 08);
            Assert.AreEqual(2,It.EntradasVendidasEntre(inicio,fin));
            
        }





    }
}
