using CineJoits1958;
using MenuesConsola;       
using NETCore.Encrypt;
using System;
using static System.ReadLine;

namespace ProgramaAdministrador.Menu
{
    class AgregarCajero:MenuComponente
    {
        public Cajero cajero { get; set; }
        public override void mostrar()
        {
            base.mostrar();
            string email = null;
            var  dni = Convert.ToInt32(prompt("Ingrese DNI"));
            var nombre = prompt("Ingrese nombre del cajero");
            var apellido = prompt("Ingrese apellido");
            if (preguntaCerrada("Tiene email"))
            {
                email = prompt("Ingrese email");
            }
            var pass = ReadPassword("Ingrese contraseña: ");
            pass = EncryptProvider.Sha256(pass);

            cajero = new Cajero()
            {
                Apellido = apellido,
                Nombre = nombre,
                dni = dni,
                Contraseña = pass,
                Email = email
            };

            try
            {
                AdoAdministrador.ADO.agregarCajero(cajero);
                Console.WriteLine("Cajero dada de alta con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo dar de alta: {e.Message} - {e.InnerException.Message}");
            }
            Console.ReadKey();
        }
    }
}
