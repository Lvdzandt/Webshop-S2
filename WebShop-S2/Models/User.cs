using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class User : Account
    {
        public string Username { get; set; }
        public DateTime Birthday { get; set; }

        public User(string _email,string _username,DateTime _birthday,string _password)
        {
            Email = _email;
            Username = _username;
            Birthday = _birthday;
            Password = _password;
        }
    }
}
