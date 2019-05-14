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
                            orders.Add(new Order(){Id = id,OrderStatus = orderStatus,OrderDate = date});
                        }
                    }
                    conn.Close();
                }


            }

            return orders;
        }


    }
}
