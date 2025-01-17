﻿using DAL.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL.SQLContext
{
    public class GameSqlContext : IGameContext
    {
        public SqlCommand Command;

        public void AddGame(Game game)
        {
            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();

                Command = new SqlCommand("AddGame", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = game.Name;
                Command.Parameters.Add("@Price", SqlDbType.Decimal).Value = game.Price;
                Command.Parameters.Add("@Description", SqlDbType.Text).Value = game.Description;
                Command.Parameters.Add("@ReleaseDate", SqlDbType.Date).Value = game.ReleaseDate;
                Command.Parameters.Add("@TagName", SqlDbType.NVarChar).Value = game.GameTag;
                Command.ExecuteNonQuery();
            }
        }

        public Game GetGame(int id)
        {
            var output = new Game();

            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();

                Command = new SqlCommand("GetGame", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                using (var reader = Command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader["ID"]);
                            var name = Convert.ToString(reader["Name"]);
                            var price = Convert.ToDecimal(reader["Price"]);
                            var description = Convert.ToString(reader["Description"]);
                            var release = Convert.ToDateTime(reader["ReleaseDate"]);
                            var gameTag = Convert.ToString(reader["TagName"]);
                            output.Id = id;
                            output.Name = name;
                            output.Price = price;
                            output.Description = description;
                            output.ReleaseDate = release;
                            output.GameTag = gameTag;
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

                Command = new SqlCommand("GetAllGames", conn) { CommandType = CommandType.StoredProcedure };

                using (var reader = Command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var id = Convert.ToInt32(reader["ID"]);
                            var name = Convert.ToString(reader["Name"]);
                            var price = Convert.ToDecimal(reader["Price"]);
                            var description = Convert.ToString(reader["Description"]);
                            var release = Convert.ToDateTime(reader["ReleaseDate"]);
                            var gameTag = Convert.ToString(reader["TagName"]);
                            output.Add(new Game() { Id = id, Name = name, Price = price, Description = description, ReleaseDate = release, GameTag = gameTag});
                        }
                    }
                    conn.Close();
                }
            }
            return output;
        }

        public List<Tuple<string, int>> GetGameCount()
        {
            List<Tuple<string,int>> list = new List<Tuple<string, int>>();
            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();

                Command = new SqlCommand("GameTagCount", conn) { CommandType = CommandType.StoredProcedure };

                using (var reader = Command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int count = Convert.ToInt32(reader["GAMECOUNT"]);
                            string name = Convert.ToString(reader["TagName"]);
                           list.Add(new Tuple<string, int>(name,count));
                        }
                    }
                    conn.Close();
                }
            }
            return list;
        }
    }
}
