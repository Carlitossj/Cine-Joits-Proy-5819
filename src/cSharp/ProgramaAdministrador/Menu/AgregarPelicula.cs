using System;
using MenuesConsola;
using CineJoits1958;


namespace ProgramaAdministrador.Menu
{
    class AgregarPelicula : MenuComponente
    {
        public Pelicula pelicula { get; set; }
        public ListaGeneros listaGeneros{ get; set; }
        public override void mostrar()
        {
            base.mostrar();
            var nombre = prompt("Ingrese nombre de la pelicula");
            var fecha = Convert.ToDateTime(prompt("Ingrese fecha de lanzamiento DD/MM/AAAA"));
            var genero = listaGeneros.seleccionarElemento();
            pelicula = new Pelicula()
            {
              Nombre=nombre,
              Lanzamiento=fecha,
              Genero=genero
            };

            try
            {
                AdoAdministrador.ADO.agregarPelicula(pelicula);
                Console.WriteLine("Pelicula agregada con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No pudo ser agregada por : {e.Message} - {e.InnerException.Message}");
            }
            Console.ReadKey();
        }
    }
}
