using System;
using MenuesConsola;
using CineJoits1958;

namespace ProgramaAdministrador.Menu
{
    class AgregarProyeccion:MenuComponente
    {
        public Proyeccion proyeccion { get; set; }
        public ListaSalas listaSalas { get; set; }
        public ListaPeliculas listaPeliculas { get; set; }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            var fecha = Convert.ToDateTime(prompt("Ingrese fecha y hora DD/MM/AAAA HH:MM"));
            Console.WriteLine("Seleccione Sala");
            var sala = listaSalas.seleccionarElemento();
            Console.WriteLine("Seleccione Pelicula");
            var pelicula = listaPeliculas.seleccionarElemento();
            var precio = float.Parse(prompt("Ingrese precio"));
            proyeccion=new Proyeccion()
            {
                FechaHora=fecha,
                Sala=sala,
                Pelicula=pelicula,
                Precio=precio


            };

            try
            {
                AdoAdministrador.ADO.agregarProyeccion(proyeccion);
                Console.WriteLine("Proyeccion agregada con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No pudo ser agregada por: {e.Message} - {e.InnerException.Message}");
            }
            Console.ReadKey();
        }
    }
}
