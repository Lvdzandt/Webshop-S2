using DAL.Interface;
using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.SQLContext
{
    public class AccountSqlContext : IAccountContext
    {
        public SqlCommand Command;

        public bool CheckLogin(string email, string password)
        {
            int account;
            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();

                Command = new SqlCommand("CheckLogin", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                Command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

                account = (int)Command.ExecuteScalar();


                conn.Close();
            }
            return account == 1;
        }

        public bool CheckAccountTaken(string email)
        {
            int account;
            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();

                Command = new SqlCommand("CheckAccountTaken", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

                account = (int)Command.ExecuteScalar();


                conn.Close();
            }
            return account == 1;
        }

        public void RegisterAccount(User account)
        {
            using (var conn = ConnectDb.GetConnection())
            {

                conn.Open();


                Command = new SqlCommand("RegisterAccount", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@username", SqlDbType.NVarChar).Value = account.Username;
                Command.Parameters.Add("@password", SqlDbType.NVarChar).Value = account.Password;
                Command.Parameters.Add("@email", SqlDbType.NVarChar).Value = account.Email;
                Command.Parameters.Add("@birthdate", SqlDbType.Date).Value = account.Birthday;
                Command.ExecuteNonQuery();

                conn.Close();


            }
        }

        public User GetUser(string email)
        {
            var user = new User();
            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();


                Command = new SqlCommand("GetAccountEmail", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                Command.ExecuteNonQuery();
                using (var reader = Command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var id = Convert.ToInt32(reader["ID"]);
                            var name = Convert.ToString(reader["UserName"]);
                            email = Convert.ToString(reader["Email"]);
                            var date = Convert.ToDateTime(reader["Birthdate"]);
                            user = new User(id, email, name, date);
                        }
                    }
                    conn.Close();
                }

            }

            return user;
        }

        public User GetUser(int id)
        {
            var user = new User();

            using (var conn = ConnectDb.GetConnection())
            {
                conn.Open();


                Command = new SqlCommand("GetAccountID", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                Command.ExecuteNonQuery();
                using (var reader = Command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            id = Convert.ToInt32(reader["ID"]);
                            var name = Convert.ToString(reader["UserName"]);
                            var email = Convert.ToString(reader["Email"]);
                            var date = Convert.ToDateTime(reader["Birthdate"]);
                            user = new User(id, email, name, date);
                        }
                    }
                    conn.Close();
                }

            }


            return user;
        }

        public void UpdateUser(User user)
        {
            using (var conn = ConnectDb.GetConnection())
            {

                conn.Open();


                Command = new SqlCommand("UpdateAccount", conn) { CommandType = CommandType.StoredProcedure };
                Command.Parameters.Add("@id", SqlDbType.Int).Value = user.Id;
                Command.Parameters.Add("@username", SqlDbType.NVarChar).Value = user.Username;
                Command.Parameters.Add("@birthdate", SqlDbType.Date).Value = user.Birthday;
                Command.ExecuteNonQuery();

                conn.Close();

            }
        }
    }
}
