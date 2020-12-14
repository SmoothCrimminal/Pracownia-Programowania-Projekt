using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Users
{
    public class ReadUsers
    {
        public List<User> ReadAllUsers()
        {
            using (var context = new ProjektPPContext())
            {
                var allUsers = context.Users.ToList();
                return allUsers;

            }
        }

        public string ReadUser(int userId)
        {
            using (var context = new ProjektPPContext())
            {
                var user = context.Users.Find(userId);
                if (user != null)
                {
                    return $"{user.Id} {user.Login} {user.RoleId} {user.IsDeleted}";
                }

                return "User not found";
            }
        }
    }
}
