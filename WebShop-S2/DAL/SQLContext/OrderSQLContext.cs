using DAL.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL.SQLContext
{
    public class OrderSqlContext : IOrderContext
    {
        public SqlCommand Command;

        public void RemoveWishListItem(int gameId, int userId)
        {
            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();

                Command = new SqlCommand("RemoveWishListItem", conn) {CommandType = CommandType.StoredProcedure};
                Command.Parameters.Add("@gameId", SqlDbType.Int).Value = gameId;
                Command.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                Command.ExecuteNonQuery();

                conn.Close();

            }
        }
        public List<WishList> GetWishList(int userId)
        {
            List<WishList> list = new List<WishList>();
            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();

                Command = new SqlCommand("GetWishList", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                using (var reader = Command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int gameId = Convert.ToInt32(reader["GameId"]);
                            string name = Convert.ToString(reader["Name"]);
                            DateTime dateAdded = Convert.ToDateTime(reader["dateAdded"]);
                            list.Add(new WishList() { Id = gameId, Game = new Game() { Id = gameId, Name = name }, DateAdded = dateAdded });
                        }
                    }

                    conn.Close();
                }
            }
            return list;
        }

        public void AddWishListItem(int gameId, int userId)
        {
            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();

                Command = new SqlCommand("AddWishList", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@gameId", SqlDbType.Int).Value = gameId;
                Command.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                Command.Parameters.Add("@dateAdded", SqlDbType.Date).Value = DateTime.Now.ToShortDateString();
                Command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public Order GetOrder(int id)
        {
            Order order = new Order();
            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();

                Command = new SqlCommand("GetOrder", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                using (var reader = Command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            order.Id = id;
                            order.Address = Convert.ToString(reader["OrderAdress"]);
                            order.OrderDate = Convert.ToDateTime(reader["OrderDate"]);
                            Enum.TryParse(Convert.ToString(reader["OrderStatus"]), out OrderStatus orderStatus);
                            order.OrderStatus = orderStatus;
                        }
                    }

                    conn.Close();
                }
            }


            return order;
        }

        public void AddOrder(Order order)
        {
            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();

                Command = new SqlCommand("AddOrder", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@orderDate", SqlDbType.Date).Value = order.OrderDate;
                Command.Parameters.Add("@address", SqlDbType.NVarChar).Value = order.Address;
                Command.Parameters.Add("@orderStatus", SqlDbType.NVarChar).Value = order.OrderStatus;
                Command.Parameters.Add("@userId", SqlDbType.Int).Value = order.UserId;

                Command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void AddGamesOrder(List<Game> games, int id)
        {
            int userId = id;

            foreach (var item in games)
            {
                using (var conn = ConnectDb.GetConnection())
                {

                    conn.Open();

                    Command = new SqlCommand("AddGamesOrder", conn) { CommandType = CommandType.StoredProcedure };
                    Command.Parameters.Add("@gameId", SqlDbType.Int).Value = item.Id;
                    Command.Parameters.Add("@orderId", SqlDbType.Int).Value = userId;
                    Command.ExecuteNonQuery();

                    conn.Close();


                }
            }
        }

        public int GetOrderId()
        {
            int orderId;

            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();

                Command = new SqlCommand("GetOrderId", conn) { CommandType = CommandType.StoredProcedure };
                orderId = Convert.ToInt32(Command.ExecuteScalar());
            }
            return orderId;
        }

        public List<Tuple<int, int>> GetAllGames()
        {
            List<Tuple<int, int>> list = new List<Tuple<int, int>>();
            using (var conn = ConnectDb.GetConnection())
            {

                conn.Open();


                Command = new SqlCommand("GetOrderGames", conn) { CommandType = CommandType.StoredProcedure };

                Command.ExecuteNonQuery();
                using (var reader = Command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var gameId = Convert.ToInt32(reader["GameID"]);
                            var orderId = Convert.ToInt32(reader["OrderID"]);
                            list.Add(new Tuple<int, int>(gameId, orderId));
                        }
                    }

                    conn.Close();
                }
            }

            return list;
        }

        public List<Order> GetAllOrdersById(int userId)
        {
            List<Order> orders = new List<Order>();
            using (var conn = ConnectDb.GetConnection())
            {

                conn.Open();


                Command = new SqlCommand("GetOrdersById", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@userId", SqlDbType.Int).Value = userId;
                Command.ExecuteNonQuery();
                using (var reader = Command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var id = Convert.ToInt32(reader["ID"]);
                            Enum.TryParse(Convert.ToString(reader["OrderStatus"]), out OrderStatus orderStatus);
                            var date = Convert.ToDateTime(reader["OrderDate"]);
                            orders.Add(new Order() { Id = id, OrderStatus = orderStatus, OrderDate = date });
                        }
                    }
                    conn.Close();
                }
            }

            return orders;
        }


    }
}
