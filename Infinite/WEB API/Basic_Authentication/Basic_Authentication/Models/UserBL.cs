using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Basic_Authentication.Models
{
    public class UserBL
    {
        public List<User> GetUsers()
        {
            List<User> userlist = new List<User>()
            {
                new User{ID=100,UserName="Maleuser",Password="Mpass123"},
                new User{ID=101,UserName="Femaleuser",Password="Fpass123"},
            };
            return userlist;
        }
    }
}