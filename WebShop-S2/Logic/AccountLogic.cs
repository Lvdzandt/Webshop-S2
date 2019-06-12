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

        public string PasswordHash(string password)
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
            string passwordHash = PasswordHash(password);
            return _repo.CheckLogin(email, passwordHash);
        }

        public bool CheckAccountTaken(string email)
        {
            return _repo.CheckAccountTaken(email);
        }

        public void RegisterAccount(User newUser)
        {
            newUser.Password = PasswordHash(newUser.Password);
            _repo.RegisterAccount(newUser);
        }
        public dynamic GetUser(int id)
        {
            return _repo.GetUser(id);
        }
        public dynamic GetUser(string email)
        {
            return _repo.GetUser(email);
        }

        public void UpdateUser(User user)
        {
            _repo.UpdateUser(user);
        }
    }
}
