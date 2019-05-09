﻿using DAL.Interface;
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
                                int _id = Convert.ToInt32(reader["ID"]);
                                string Name = Convert.ToString(reader["Name"]);
                                int Price = Convert.ToInt32(reader["Price"]);
                                string Description = Convert.ToString(reader["Description"]);
                                DateTime Release = Convert.ToDateTime(reader["ReleaseDate"]);

                                output.ID = _id;
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

        public List<Game> GetAllGames()
        {
            List<Game> output = new List<Game>();
            try
            {
                using (SqlConnection Conn = ConnectDB.GetConnection())
                {
                    Conn.Open();

                    command = new SqlCommand("GetAllGames", Conn);
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int _id = Convert.ToInt32(reader["ID"]);
                                string _Name = Convert.ToString(reader["Name"]);
                                int _Price = Convert.ToInt32(reader["Price"]);
                                string _Description = Convert.ToString(reader["Description"]);
                                DateTime _Release = Convert.ToDateTime(reader["ReleaseDate"]);

                                output.Add(new Game() { ID = _id, Name = _Name, Price = _Price, Description = _Description, ReleaseDate = _Release });
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
