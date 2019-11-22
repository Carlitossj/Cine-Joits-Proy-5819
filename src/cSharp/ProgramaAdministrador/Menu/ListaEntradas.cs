using System;
using MenuesConsola;
using CineJoits1958;
using System.Collections.Generic;

namespace ProgramaAdministrador.Menu
{
    class ListaEntradas : MenuListador<Entrada>
    {
        public Proyeccion proyeccion { get; set; }
        public ListaProyecciones listaProyecciones { get; set; }
        public override void imprimirElemento(Entrada elemento)
       => Console.WriteLine($"{elemento.Id} - {elemento.FechaHora} - {elemento.Proyeccion}");
        public override List<Entrada> obtenerLista()
            => AdoCajero.ADO.obtenerEntradas(proyeccion);
        public override void mostrar()
        {
            Console.WriteLine("Seleccione una proyeccion");
            var Proyeccion = listaProyecciones.seleccionarElemento();
            base.mostrar();
            try
            {
                proyeccion = Proyeccion;
                Console.WriteLine("Lista de Entradas");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudieron mostrar por : {e.Message} - {e.InnerException.Message}");
            }
            Console.ReadKey();
        }


    }
}
