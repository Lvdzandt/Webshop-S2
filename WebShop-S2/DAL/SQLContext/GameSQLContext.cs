using DAL.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL.SQLContext
{
    internal class GameSqlContext : IGameContext
    {
        public SqlCommand Command;
        public Game GetGame(int id)
        {
            var output = new Game();
            
                using (var conn = ConnectDb.GetConnection())
                {
                    conn.Open();

                    Command = new SqlCommand("GetGame", conn) {CommandType = CommandType.StoredProcedure};
                    Command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                    using (var reader = Command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id = Convert.ToInt32(reader["ID"]);
                                var name = Convert.ToString(reader["Name"]);
                                var price = Convert.ToDouble(reader["Price"]);
                                var description = Convert.ToString(reader["Description"]);
                                var release = Convert.ToDateTime(reader["ReleaseDate"]);

                                output.Id = id;
                                output.Name = name;
                                output.Price = price;
                                output.Description = description;
                                output.ReleaseDate = release;
                            }
                        }
                        conn.Close();
                    }
                }
            return output;
        }

        public List<Game> GetAllGames()
        {
            var output = new List<Game>();
            
                using (var conn = ConnectDb.GetConnection())
                {
                    conn.Open();

                    Command = new SqlCommand("GetAllGames", conn) {CommandType = CommandType.StoredProcedure};

                    using (var reader = Command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var id = Convert.ToInt32(reader["ID"]);
                                var name = Convert.ToString(reader["Name"]);
                                var price = Convert.ToDouble(reader["Price"]);
                                var description = Convert.ToString(reader["Description"]);
                                var release = Convert.ToDateTime(reader["ReleaseDate"]);

                                output.Add(new Game() { Id = id, Name = name, Price = price, Description = description, ReleaseDate = release });
                            }
                        }
                        conn.Close();
                    }
                }
                return output;
        }
    }
}
