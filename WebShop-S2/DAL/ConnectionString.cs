using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    static class ConnectionString
    {
        private static readonly string DataBase = "dbi361369";
        static private readonly string Password = "Wachtwoord1";
        static private readonly string Server = "mssql.fhict.local";
        static private readonly string UID = "dbi361369";

        public static string CreateConString()
        {
            return $"SERVER= {Server}; DATABASE= {DataBase}; UID= {UID}; PASSWORD= {Password};";
        }

    }
}
