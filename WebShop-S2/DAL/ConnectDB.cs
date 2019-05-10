using System.Data.SqlClient;

namespace DAL
{
    public static class ConnectDb
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString.CreateConString());
        }
    }
}
