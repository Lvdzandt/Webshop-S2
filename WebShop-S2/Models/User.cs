using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class User : Account
    {
        public string Username { get; set; }
        public DateTime Birthday { get; set; }
    }
}
