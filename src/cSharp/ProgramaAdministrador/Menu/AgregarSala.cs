using System;
using MenuesConsola;
using CineJoits1958;


namespace ProgramaAdministrador.Menu
{
    class AgregarSala : MenuComponente
    {
        public Sala sala { get; set; }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            var capacidad = Convert.ToInt16(prompt("Ingrese capacidad de la sala"));
            var piso = Convert.ToByte(prompt("Ingrese el numero de piso de la sala"));
            sala = new Sala()
            {
                Capacidad = capacidad,
                Piso = piso

            };
            try
            {
                AdoAdministrador.ADO.agregarSala(sala);
                Console.WriteLine("Sala agregada con exito");
            }
            catch (Exception e)
            {
                Console.WriteLine($"No se pudo agregar la sala: {e.Message}");
            }
            Console.ReadKey();

        }
    }
}
