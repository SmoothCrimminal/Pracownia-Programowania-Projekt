using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Users
{
    public class DeleteUsers
    {
        public string DeleteUser(int userId)
        {
            using (var context = new ProjektPPContext())
            {
                var user = context.Users.Find(userId);
                if ((user != null) && ((bool)user.IsDeleted == false))
                {
                    user.IsDeleted = true;
                    return "User Successfully deleted";
                }

                else if ((user != null) && ((bool)user.IsDeleted == true))
                {
                    return "User with this id already has been deleted";
                }

                context.SaveChanges();

                return "User Not Found";

            }
        }
    }
}
