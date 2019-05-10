using DAL.Repo;
using Model;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Logic
{
    public class AccountLogic
    {
        private readonly AccountRepository _repo = new AccountRepository();

        private static string PasswordHash(string password)
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
        public User GetUser(int id)
        {
            return _repo.GetUser(id);
        }
        public User GetUser(string email)
        {
            return _repo.GetUser(email);
        }

        public void UpdateUser(User user)
        {
            _repo.UpdateUser(user);
        }
    }
}
