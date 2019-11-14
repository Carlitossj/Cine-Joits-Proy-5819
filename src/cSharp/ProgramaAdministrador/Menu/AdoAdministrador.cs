using CineJoits1958.ADO;
namespace ProgramaAdministrador.Menu
{
    public static class AdoAdministrador
    {
        public static AdoMySQLEntityCore ADO { get; set; } =
            FactoryAdoMySQL.GetAdoDesdeJson("appsettings.json", "administradores");
    }
}
