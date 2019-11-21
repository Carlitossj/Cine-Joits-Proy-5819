using CineJoits1958.ADO;

namespace ProgramaAdministrador.Menu
{
    public class AdoCajero
    {
        public static AdoMySQLEntityCore ADO { get; set; } =
            FactoryAdoMySQL.GetAdoDesdeJson("appsettings.json", "cajeros");
    }
}
