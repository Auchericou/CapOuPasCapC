using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapOuPasCap.UsesCase.Entities;

namespace CapOuPasCap.UsesCase.Builder
{
    public class UserBuilder
    {
        private readonly UserForBuilder _User;

      

        public UserBuilder(string username)
        {
            _User = new UserForBuilder()
            {
                username = username
            };
        }

        public UserBuilder Password(string password)
        {
            _User.password = password;
            return this;
        }

        public User Build()
        {
            var result = new User(_User.username, _User.password);
            if(result.IsValid() is false)
            {
                throw new UserBuildException("User not set correctly");
            }
            return result;
        }

        private class UserForBuilder
        {
            public string username { get; set; }

            public string password { get; set; }
        }
    }
}
