using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Users
{
    public class CreateUsers
    {
        public User CreateUser(User user)
        {
            using (var context = new ProjektPPContext())
            {
                var newUser = context.Users.Add(user);
                context.SaveChanges();
                return newUser.Entity;
            }
        }
    }
}
