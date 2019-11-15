﻿using System;
using MenuesConsola;
using ProgramaAdministrador.Menu;
namespace ProgramaAdministrador
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuAgregarCajero = new AgregarCajero() { Nombre = "Agregar  Cajero" };
            var menuListaCajero = new ListaCajeros() { Nombre = "Listado Cajeros" };
            var menuAgregarGenero =new AgregarGenero() { Nombre = "Agregar Genero" };
            var menuListaGenero = new ListaGeneros() { Nombre = "Listado Generos" };
            var menuAgregarPelicula = new AgregarPelicula() { Nombre = "Agregar Pelicula" };
            var menuListaPeliculas = new ListaPeliculas() { Nombre = "Listado Peliculas" };
            var menuAgregarSala = new AgregarSala() { Nombre = "Agregar Sala" };
            var menuListaSalas = new ListaSalas() { Nombre = "Listado Salas" };
            var menuAgregarProyeccion = new AgregarProyeccion() { Nombre = "Agregar Proyeccion" };
            var menuListaProyecciones = new ListaProyecciones() { Nombre = "Listado Proyecciones" };


            var menuCajero = new MenuCompuesto() { Nombre = "Cajero" };
            menuCajero.agregarMenu(menuListaCajero);
            menuCajero.agregarMenu(menuAgregarCajero);

            var menuGenero = new MenuCompuesto() { Nombre = "Genero" };
            menuGenero.agregarMenu(menuListaGenero);
            menuGenero.agregarMenu(menuAgregarGenero);
            
            var menuPelicula = new MenuCompuesto() { Nombre = "Pelicula" };
            menuPelicula.agregarMenu(menuListaPeliculas);
            menuPelicula.agregarMenu(menuAgregarPelicula);

            var menuSala = new MenuCompuesto() { Nombre = "Sala" };
            menuSala.agregarMenu(menuListaSalas);
            menuSala.agregarMenu(menuAgregarSala);

            var menuProyeccion = new MenuCompuesto() { Nombre = "Proyeccion" };
            menuProyeccion.agregarMenu(menuListaProyecciones);
            menuProyeccion.agregarMenu(menuAgregarProyeccion);


            var menuAdministrador = new MenuCompuesto() { Nombre = "Menu Administrador" };
            menuAdministrador.agregarMenu(menuCajero);
            menuAdministrador.agregarMenu(menuGenero);
            menuAdministrador.agregarMenu(menuPelicula);
            menuAdministrador.agregarMenu(menuSala);
            menuAdministrador.agregarMenu(menuProyeccion);

            menuAdministrador.mostrar();
            var menuAgregarEntrada= new AgregarEntrada{ Nombre = "Agregar Entrada" };
            var menuListaEntradas = new ListaEntradas () { Nombre = "Listado Entradas" };

            var menuEntrada = new MenuCompuesto() { Nombre = "Entrada" };
            menuEntrada.agregarMenu(menuListaEntradas);
            menuEntrada.agregarMenu(menuAgregarEntrada);


            var MenuCajero = new MenuCompuesto() { Nombre = "Menu Cajero" };
            MenuCajero.agregarMenu(menuEntrada);

            menuCajero.mostrar();

        }
    }
}
