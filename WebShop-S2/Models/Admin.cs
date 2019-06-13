
namespace Model
{
    public class Admin : Account
    {
        public Admin(int id, string email ,bool isAdmin)
        {
            Id = id;
            Email = email;
            IsAdmin = isAdmin;
        }
    }
}
