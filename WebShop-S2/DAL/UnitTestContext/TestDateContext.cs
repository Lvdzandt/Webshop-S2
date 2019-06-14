using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interface;
using Model;

namespace DAL.UnitTestContext
{
    public class TestDateContext : IAccountContext
    {
        public bool CheckLogin(string email, string password)
        {
            return email == "test@test.nl" && password == "Test123";
        }

        public bool CheckAccountTaken(string email)
        {
            return email == "test@test.nl";
        }

        public void RegisterAccount(User account)
        {
            throw new NotImplementedException();
        }

        public dynamic GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public dynamic GetUser(string email)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
