using System;
using MenuesConsola;
using CineJoits1958;
using System.Collections.Generic;

namespace ProgramaAdministrador.Menu
{
    class ListaCajeros : MenuListador<Cajero>
    {
        public override void imprimirElemento(Cajero elemento)
       => Console.WriteLine($"{elemento.dni} - {elemento.Nombre}");
        public override List<Cajero> obtenerLista()
            => AdoAdministrador.ADO.obtenerCajeros();
    
    }
}
