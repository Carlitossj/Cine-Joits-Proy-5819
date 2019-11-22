using System;
using MenuesConsola;
using CineJoits1958;
namespace ProgramaAdministrador.Menu
{
    class EntradasVenididasEntre:MenuComponente
    {
        public ListaPeliculas listaPeliculas = new ListaPeliculas();
        public override void mostrar()
        {
           
            base.mostrar(); 
            var fecha1 = Convert.ToDateTime(prompt("Ingrese fecha de inicio DD/MM/AAAA"));
            var fecha2 = Convert.ToDateTime(prompt("Ingrese fecha de fin DD/MM/AAAA"));
            
            try
            {
                Console.WriteLine("Lista de Entradas Vendidas");
                pelicula.EntradasVendidasEntre(fecha1, fecha2);

            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudieron mostrar las entradas por: {e.Message} - {e.InnerException.Message}");
            }
            Console.ReadKey();
        }
    }
}
