using DAL.Interface;
using DAL.SQLContext;
using Model;

namespace DAL.Repo
{
    public class AccountRepository
    {
        public readonly IAccountContext AccountContext = new AccountSqlContext();

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
        public User GetUser(int id)
        {
            return AccountContext.GetUser(id);
        }
        public User GetUser(string email)
        {
            return AccountContext.GetUser(email);
        }
        public void UpdateUser(User user)
        {
            AccountContext.UpdateUser(user);
        }
    }
}
