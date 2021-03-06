﻿using System;
using MenuesConsola;
using CineJoits1958;


namespace ProgramaAdministrador.Menu
{
    class AgregarEntrada:MenuComponente
    {
        public ListaProyecciones listaProyecciones { get; set; }
        public Cajero Cajero { get; set; }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            Console.WriteLine("Seleccione Proyeccion");
            var proyeccion = listaProyecciones.seleccionarElemento();

            proyeccion.VenderEntrada(Cajero);

            try
            {
                AdoCajero.ADO.actualizarProyeccion(proyeccion);
                Console.WriteLine("Entrada agregada con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No pudo ser agregada por : {e.Message} - {e.InnerException.Message}");
            }
            Console.ReadKey();
        }
    }
}
