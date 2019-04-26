using DAL.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

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
        }

        public User GetUser(string email)
        {
            return null;
        }
    }
    }
