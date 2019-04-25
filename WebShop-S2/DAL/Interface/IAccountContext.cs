using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interface
{
    public interface IAccountContext
    {
        bool CheckLogin(string email, string password);
        bool CheckAccountTaken(string email);

        void RegisterAccount(User newacc);

        User GetUser(string email);
        
    }
}
