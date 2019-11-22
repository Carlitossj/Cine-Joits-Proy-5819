using MenuesConsola;
using NETCore.Encrypt;
using System;
using CineJoits1958;
using CineJoits1958.ADO;
using static System.ReadLine;
using ProgramaAdministrador.Menu;

namespace ProgramaAdministrador
{
    class LogeoCajero : MenuComponente
    {
        private Cajero cajero { get; set; }
        private MenuCompuesto MenuCajero { get; set; }
        
        
        public override void mostrar()
        {
            base.mostrar();
            base.mostrar();

            var dni = Convert.ToInt32(prompt("Ingrese dni"));
            var pass = ReadPassword("Ingrese contraseña: ");
            pass = EncryptProvider.Sha256(pass);

            try
            {
                Console.WriteLine("entre al try");
                cajero = AdoCajero.ADO.cajeroPorDniPass(dni, pass);
                if (cajero is null)
                {
                    Console.WriteLine("DNI o contraseña incorrecta");
                    Console.ReadKey();
                }
                else
                {
                    instanciarMenuesPara(cajero);
                    MenuCajero.mostrar();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo iniciar sesion debido a un error: {e.Message}");
                Console.ReadKey();
            }
           
        }
        private void instanciarMenuesPara(Cajero cajero)
        {
            var menuListaCajeros = new ListaCajeros() { Nombre = "Listado Cajeros" };
            var menuListaGeneros = new ListaGeneros() { Nombre = "Listado Generos" };
            var menuListaPeliculas = new ListaPeliculas() { Nombre = "Listado Peliculas" };
            var menuListaSalas = new ListaSalas() { Nombre = "Listado Salas" };
            var menuListaProyecciones = new ListaProyecciones() { Nombre = "Listado Proyecciones" };
            var menuEntrada = new MenuCompuesto() { Nombre = "Entrada" };
            var menuAgregarEntrada = new AgregarEntrada { Nombre = "Agregar Entrada",listaProyecciones = menuListaProyecciones, Cajero = cajero };
            var menuListaEntradas = new ListaEntradas() { Nombre = "Listado Entradas", listaProyecciones = menuListaProyecciones };
            menuEntrada.agregarMenu(menuListaEntradas);
            menuEntrada.agregarMenu(menuAgregarEntrada);

            MenuCajero = new MenuCompuesto() { Nombre = "Menu Cajero" };
            MenuCajero.agregarMenu(menuEntrada);
            MenuCajero.agregarMenu(menuListaPeliculas);
            MenuCajero.agregarMenu(menuListaProyecciones);
            MenuCajero.agregarMenu(menuListaGeneros);
            MenuCajero.agregarMenu(menuListaPeliculas);
        }
    }
}
