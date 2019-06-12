using Model;

namespace DAL.Interface
{
    public interface IAccountContext
    {
        bool CheckLogin(string email, string password);
        bool CheckAccountTaken(string email);

        void RegisterAccount(User account);
        dynamic GetUser(int id);
        dynamic GetUser(string email);
        void UpdateUser(User user);
    }
}
