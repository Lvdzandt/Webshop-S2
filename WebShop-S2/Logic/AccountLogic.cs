using DAL.Repo;
using Microsoft.AspNetCore.Http;
using Model;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Logic
{
    public class AccountLogic
    {
        private AccountRepository _repo = new AccountRepository();

        private string PasswordHash(string password)
        {
            using (var sha256 = SHA256.Create())
            { 
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                return hash;
            }
        }


        public bool CheckLogin(string email, string password)
        {
            string hashpass = PasswordHash(password);
            return _repo.CheckLogin(email, hashpass);
        }

        public bool CheckAccountTaken(string email)
        {
            return _repo.CheckAccountTaken(email);
        }

        public void RegisterAccount(User newacc)
        {
            newacc.Password = PasswordHash(newacc.Password);
            _repo.RegisterAccount(newacc);
        }

        public User GetUser(string email)
        {
            return _repo.GetUser(email);
        }
    }
}
