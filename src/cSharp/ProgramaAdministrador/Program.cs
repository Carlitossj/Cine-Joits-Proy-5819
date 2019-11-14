using System;
using MenuesConsola;
using ProgramaAdministrador.Menu;
namespace ProgramaAdministrador
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuAgregarCajero = new AgregarCajero() { Nombre = "Alta Cajero" };

            menuAgregarCajero.mostrar();
        }
    }
}
