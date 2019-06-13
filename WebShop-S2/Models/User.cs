using System;

namespace Model
{
    public class User : Account
    {
        public string Username { get; set; }
        public DateTime Birthday { get; set; }

        public User(string email,string username,DateTime birthday,string password, bool isAdmin)
        {
            Email = email;
            Username = username;
            Birthday = birthday;
            Password = password;
            IsAdmin = isAdmin;
        }

        public User(int id, string email, string username, DateTime birthday, bool isAdmin)
        {
            Id = id;
            Email = email;
            Username = username;
            Birthday = birthday;
            IsAdmin = isAdmin;
        }

        public User()
        {

        }
    }
}
