using Model;

namespace DAL.Interface
{
    public interface IAccountContext
    {
        bool CheckLogin(string email, string password);
        bool CheckAccountTaken(string email);

        void RegisterAccount(User account);
        User GetUser(int id);
        User GetUser(string email);
        void UpdateUser(User user);
    }
}
