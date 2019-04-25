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
                    command.Parameters.Add("@param2", SqlDbType.VarChar).Value = email;
                    command.Parameters.Add("@param1", SqlDbType.NVarChar).Value = password;

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
            return false;
        }

        public void RegisterAccount(User newacc)
        {

        }

        public User GetUser(string email)
        {
            return null;
        }
    }
    }
