
namespace DAL
{
    public static class ConnectionString
    {
        private const string DataBase = "dbi361369";
        private const string Password = "Wachtwoord1";
        private const string Server = "mssql.fhict.local";
        private const string Uid = "dbi361369";

        public static string CreateConString()
        {
            return $"SERVER= {Server}; DATABASE= {DataBase}; UID= {Uid}; PASSWORD= {Password};";
        }

    }
}
