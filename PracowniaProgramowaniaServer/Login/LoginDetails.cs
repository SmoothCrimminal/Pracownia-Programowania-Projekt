using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel.Security;
using System.ServiceModel.Description;
using P.P.Database.Models;

namespace Login
{
    public class LoginDetails : ClientCredentials
    {
        private int RoleId;
       public void GetDetails(User user)
        {
            UserName.UserName = user.Login;
            UserName.Password = user.PasswordMd5;
            RoleId = user.RoleId;
        }


    }

}
