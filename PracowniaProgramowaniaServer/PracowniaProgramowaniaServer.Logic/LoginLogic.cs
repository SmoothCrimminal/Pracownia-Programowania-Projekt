using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;
using System.Security.Cryptography;
using System.Linq;
using Login;

namespace PracowniaProgramowaniaServer.Logic
{
    public class LoginLogic
    {
        public void GetUser(string login, string password)
        {
            var data = System.Text.Encoding.ASCII.GetBytes(password);
            var saveDetails = new LoginDetails();
            data = MD5.Create().ComputeHash(data);
            using (var context = new ProjektPPContext())
            {
                var allUsers = context.Users.ToList();
                foreach (User user in allUsers)
                {
                    if ((user.Login == login) && (user.PasswordMd5 == data.ToString()))
                    {
                        saveDetails.GetDetails(user);
                        break;
                    }
                }

            }
        }
    }
}
