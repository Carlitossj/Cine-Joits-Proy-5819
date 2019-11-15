using System;
using MenuesConsola;
using CineJoits1958;


namespace ProgramaAdministrador.Menu
{
    class AgregarEntrada:MenuComponente
    {
        public Entrada entrada{ get; set; }
        public ListaProyecciones listaProyecciones { get; set; }
        public ListaCajeros  listaCajeros { get; set; }
        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine();
            var proyeccion = listaProyecciones.seleccionarElemento();
            var fecha = Convert.ToDateTime(prompt("Ingrese fecha y hora DD / MM / AAAA HH: MMA"));
            var cajero = listaCajeros.seleccionarElemento();
            entrada = new Entrada()
            {
                Proyeccion = proyeccion,
                FechaHora = fecha,
                Cajero = cajero
            };
            try
            {
                AdoAdministrador.ADO.agregarEntrada(entrada);
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
