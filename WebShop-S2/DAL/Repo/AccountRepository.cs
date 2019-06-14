using DAL.Interface;
using DAL.SQLContext;
using Model;

namespace DAL.Repo
{
    public class AccountRepository
    {
        public readonly IAccountContext AccountContext;

        public AccountRepository()
        {
            AccountContext = new AccountSqlContext();
        }

        public AccountRepository(IAccountContext context)
        {
            AccountContext = context;
        }

        public bool CheckLogin(string email, string password)
        {
            return AccountContext.CheckLogin(email, password);
        }


        public bool CheckAccountTaken(string email)
        {
            return AccountContext.CheckAccountTaken(email);
        }

        public void RegisterAccount(User newAccount)
        {
            AccountContext.RegisterAccount(newAccount);
        }
        public dynamic GetUser(int id)
        {
            return AccountContext.GetUser(id);
        }
        public dynamic GetUser(string email)
        {
            return AccountContext.GetUser(email);
        }
        public void UpdateUser(User user)
        {
            AccountContext.UpdateUser(user);
        }
    }
}
