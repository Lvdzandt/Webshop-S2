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



                Command.ExecuteNonQuery();

                conn.Close();


            }
        }
    }
}
