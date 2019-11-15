using System;
using MenuesConsola;
using CineJoits1958;
using System.Collections.Generic;

namespace ProgramaAdministrador.Menu
{
    class ListaGeneros : MenuListador<Genero>
    {
        public override void imprimirElemento(Genero elemento)
       => Console.WriteLine($"{elemento.Id} - {elemento.Nombre}");
        public override List<Genero> obtenerLista()
            => AdoAdministrador.ADO.obtenerGeneros();
    }
}
