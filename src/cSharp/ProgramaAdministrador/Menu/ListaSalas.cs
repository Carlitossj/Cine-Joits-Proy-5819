using System;
using MenuesConsola;
using CineJoits1958;
using System.Collections.Generic;


namespace ProgramaAdministrador.Menu
{
    class ListaSalas : MenuListador<Sala>
    {
        public override void imprimirElemento(Sala elemento)
       => Console.WriteLine($"{elemento.id} - {elemento.Capacidad} - {elemento.Piso}");
        public override List<Sala> obtenerLista()
            => AdoAdministrador.ADO.obtenerSalas();
    }
}
