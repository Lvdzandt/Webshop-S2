using DAL.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DAL.SQLContext
{
    class GameSQLContext : IGameContext
    {
        public SqlCommand command;
        public Game GetGame(int id)
        {
            Game output = new Game();
            try
            {
                using (SqlConnection Conn = ConnectDB.GetConnection())
                {
                    Conn.Open();

                    command = new SqlCommand("GetGame", Conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string Name = Convert.ToString(reader["Name"]);
                                int Price = Convert.ToInt32(reader["Price"]);
                                string Description = Convert.ToString(reader["Description"]);
                                DateTime Release = Convert.ToDateTime(reader["ReleaseDate"]);

                                output.Name = Name;
                                output.Price = Price;
                                output.Description = Description;
                                output.ReleaseDate = Release;
                            }
                        }
                        Conn.Close();
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            return output;
        }
    }
}
