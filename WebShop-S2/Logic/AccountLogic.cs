using DAL.Repo;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class AccountLogic
    {
        private AccountRepository _repo = new AccountRepository();

        public bool CheckLogin(string email, string password)
        {
            return _repo.CheckLogin(email, password);
        }

        public bool CheckAccountTaken(string email)
        {
            return _repo.CheckAccountTaken(email);
        }

        public void RegisterAccount(User newacc)
        {
            _repo.RegisterAccount(newacc);
        }

        public User GetUser(string email)
        {
            return _repo.GetUser(email);
        }
    }
}
