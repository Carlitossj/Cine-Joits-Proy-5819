using CineJoits1958;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestCineJoits
{
    [TestClass]
    public class TestSala
    {
        Sala tres { get; set; }
        public void setup()
        {
            tres = new Sala();
            tres.Capacidad = 250;
            tres.Piso = 2;
          
        }
        

    }
}
