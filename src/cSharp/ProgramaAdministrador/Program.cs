using System;
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

            var menuCajero = new MenuCompuesto() { Nombre = "Cajero" };
            menuCajero.agregarMenu(menuListaCajero);
            menuCajero.agregarMenu(menuAgregarCajero);

            var menu = new MenuCompuesto() { Nombre = "Menu Gerente" };
            menu.agregarMenu(menuCajero);

            menu.mostrar();
        }
    }
}
