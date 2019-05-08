using DAL.Interface;
using Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.SQLContext
{
    public class AccountSQLContext : IAccountContext
    {
        private SqlCommand command;

        public bool CheckLogin(string email, string password)
        {
            int ExcistingAccount;
            using (SqlConnection Conn = ConnectDB.GetConnection())
            {
                Conn.Open();

                command = new SqlCommand("CheckLogin", Conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

                ExcistingAccount = (int)command.ExecuteScalar();


                Conn.Close();
            }
            if (ExcistingAccount == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckAccountTaken(string email)
        {
            int ExcistingAccount;
            using (SqlConnection Conn = ConnectDB.GetConnection())
            {
                Conn.Open();

                command = new SqlCommand("CheckAccountTaken", Conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

                ExcistingAccount = (int)command.ExecuteScalar();


                Conn.Close();
            }
            if (ExcistingAccount == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RegisterAccount(User newacc)
        {
            using (SqlConnection Conn = ConnectDB.GetConnection())
            {
                try
                {
                    Conn.Open();


                    command = new SqlCommand("RegisterAccount", Conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = newacc.Username;
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = newacc.Password;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = newacc.Email;
                    command.Parameters.Add("@birthdate", SqlDbType.Date).Value = newacc.Birthday;
                    command.ExecuteNonQuery();

                    Conn.Close();
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
        }

        public User GetUser(string email)
        {
            User CurrUser = new User();
            try
            {
                using (SqlConnection Conn = ConnectDB.GetConnection())
                {
                    Conn.Open();


                    command = new SqlCommand("GetAccountEmail", Conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int ID = Convert.ToInt32(reader["ID"]);
                                string Name = Convert.ToString(reader["UserName"]);
                                string Email = Convert.ToString(reader["Email"]);
                                DateTime date = Convert.ToDateTime(reader["Birthdate"]);
                                CurrUser = new User(ID, Email, Name, date);
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

            return CurrUser;
        }

        public User GetUser(int id)
        {
            User CurrUser = new User();
            try
            {
                using (SqlConnection Conn = ConnectDB.GetConnection())
                {
                    Conn.Open();


                    command = new SqlCommand("GetAccountID", Conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    command.ExecuteNonQuery();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int ID = Convert.ToInt32(reader["ID"]);
                                string Name = Convert.ToString(reader["UserName"]);
                                string Email = Convert.ToString(reader["Email"]);
                                DateTime date = Convert.ToDateTime(reader["Birthdate"]);
                                CurrUser = new User(ID, Email, Name, date);
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

            return CurrUser;
        }

        public void UpdateUser(User user)
        {
            using (SqlConnection Conn = ConnectDB.GetConnection())
            {
                try
                {
                    Conn.Open();


                    command = new SqlCommand("UpdateAccount", Conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@id", SqlDbType.Int).Value = user.ID;
                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = user.Username;
                    command.Parameters.Add("@birthdate", SqlDbType.Date).Value = user.Birthday;
                    command.ExecuteNonQuery();

                    Conn.Close();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }
}
