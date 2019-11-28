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
       => Console.WriteLine($"{elemento.Id} - {elemento.FechaHora} - ($){elemento.Valor}");
        public override List<Entrada> obtenerLista()
            => AdoCajero.ADO.obtenerEntradas(proyeccion);
        public override void mostrar()
        {
            Console.Clear();
            Console.WriteLine("Menu entradas");
            proyeccion = listaProyecciones.seleccionarElemento();

            obtenerLista().ForEach(e => imprimirElemento(e));
            Console.ReadKey();
        }
    }
}
