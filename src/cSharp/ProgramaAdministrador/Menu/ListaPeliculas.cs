using System;
using MenuesConsola;
using CineJoits1958;
using System.Collections.Generic;

namespace ProgramaAdministrador.Menu
{
    class ListaPeliculas : MenuListador<Pelicula>
    {
        public override void imprimirElemento(Pelicula elemento)
       => Console.WriteLine($"{elemento.Id} - {elemento.Nombre}");
        public override List<Pelicula> obtenerLista()
            => AdoAdministrador.ADO.obtenerPeliculas();
    
    }
}
