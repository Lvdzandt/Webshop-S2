using DAL.Interface;
using DAL.SQLContext;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repo
{
    public class AccountRepository
    {
        IAccountContext accountContext = new AccountSQLContext();

        public bool CheckLogin(string email, string password)
        {
            return accountContext.CheckLogin(email, password);
        }

        public bool CheckAccountTaken(string email)
        {
            return accountContext.CheckAccountTaken(email);
        }

        public void RegisterAccount(User newacc)
        {
            accountContext.RegisterAccount(newacc);
        }

        public User GetUser(string email)
        {
            return accountContext.GetUser(email);
        }
    }
}
