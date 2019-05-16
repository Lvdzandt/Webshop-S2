using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Model;

namespace DAL.SQLContext
{
    class OrderSqlContext : IOrderContext
    {
        public SqlCommand Command;
        public void AddOrder(Order order)
        {
            using (var conn = ConnectDb.GetConnection())
            {

                conn.Open();


                Command = new SqlCommand("AddOrder", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@orderdate", SqlDbType.Date).Value = order.OrderDate;
                Command.Parameters.Add("@address", SqlDbType.NVarChar).Value = order.Address;
                Command.Parameters.Add("@orderstatus", SqlDbType.NVarChar).Value = order.OrderStatus;
                Command.Parameters.Add("@userId", SqlDbType.Int).Value = order.UserId;

                Command.ExecuteNonQuery();

                conn.Close();


            }
            AddGamesOrder(order.GameList);
        }

        private void AddGamesOrder(List<Game> games)
        {
            int userId = GetOrderId();

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

        private int GetOrderId()
        {
            int orderId = 0;

            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();

                Command = new SqlCommand("GetOrderId", conn) { CommandType = CommandType.StoredProcedure };
                orderId = Convert.ToInt32(Command.ExecuteScalar());


            }
            return orderId;
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
