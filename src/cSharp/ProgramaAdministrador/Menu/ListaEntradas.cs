using System;
using MenuesConsola;
using CineJoits1958;
using System.Collections.Generic;

namespace ProgramaAdministrador.Menu
{
    class ListaEntradas : MenuListador<Entrada>
    {
        public override void imprimirElemento(Entrada elemento)
       => Console.WriteLine($"{elemento.Id} - {elemento.FechaHora} - {elemento.Proyeccion}");
        public override List<Entrada> obtenerLista()
            => AdoAdministrador.ADO.obtenerEntradas();


    }
}
