using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapOuPasCap.UsesCase.Tools;

namespace CapOuPasCap.UsesCase.Entities
{
    public class User
    {
        public User(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public string _username { get; set; }

        public string _password { get; set; } 

        public bool IsValid()
        {
            return _username.IsNullOrEmpty() is false 
                && _password.IsNullOrEmpty() is false;
        }
    }
}
