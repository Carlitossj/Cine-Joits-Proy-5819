using System;
using MenuesConsola;
using CineJoits1958;


namespace ProgramaAdministrador.Menu
{
    class AgregarGenero: MenuComponente
    {
        public Genero genero { get; set; }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            var nombre = prompt("Ingrese nombre del genero: ");
           genero = new Genero (nombre);
            try
            {
               AdoAdministrador.ADO.agregarGenero(genero);
                Console.WriteLine("Genero agregado con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo agregar el genero por: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}
