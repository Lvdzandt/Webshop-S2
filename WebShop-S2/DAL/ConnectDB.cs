using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    static class ConnectDB
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString.CreateConString());
        }
    }
}
