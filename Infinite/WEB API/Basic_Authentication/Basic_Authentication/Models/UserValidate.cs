using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Basic_Authentication.Models
{
    public class UserValidate
    {
        public static bool Login(string uname,string upassword)
        {
            UserBL userbl = new UserBL();
            var ulist = userbl.GetUsers();
            return ulist.Any(user => user.UserName.Equals(uname, StringComparison.OrdinalIgnoreCase)
            && user.Password == upassword);
        }
    }
}