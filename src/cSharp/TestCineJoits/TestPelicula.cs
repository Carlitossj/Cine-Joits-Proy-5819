using CineJoits1958;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestCineJoits
{
    [TestClass]
    public class TestCineJoits
    {
        Pelicula It { get; set; }
        Genero Terror { get; set; }
        public void setup()
        {
            Proyeccion p1 = new Proyeccion()
            {
                FechaHora = new DateTime(2019, 09, 05)
                
            };
            Terror = new Genero() { Nombre = "Terror" };
            It = new Pelicula();
            It.Nombre = "IT(ESO) 2";
            It.Genero = Terror;
            It.Lanzamiento = new DateTime(2019, 09, 05);
            It.Proyecciones = new List<Proyeccion>() {p1};

        }
    }
}
