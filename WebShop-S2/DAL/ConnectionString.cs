using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    static class ConnectionString
    {
        private static readonly string DataBase = "dbi361369";
        private static readonly string Password = "Wachtwoord1";
        private static readonly string Server = "mssql.fhict.local";
        private static readonly string UID = "dbi361369";

        public static string CreateConString()
        {
            return $"SERVER= {Server}; DATABASE= {DataBase}; UID= {UID}; PASSWORD= {Password};";
        }

    }
}
