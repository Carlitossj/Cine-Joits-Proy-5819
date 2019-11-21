using System;
using MenuesConsola;
using CineJoits1958;
using System.Collections.Generic;

namespace ProgramaAdministrador.Menu
{
    class ListaProyecciones:MenuListador<Proyeccion>
    {
        public override void imprimirElemento(Proyeccion elemento)
       => Console.WriteLine($"{elemento.id} - {elemento.FechaHora} - {elemento.Pelicula.Nombre}");
        public override List<Proyeccion> obtenerLista()
            => AdoAdministrador.ADO.obtenerProyecciones();
    
    }
}
