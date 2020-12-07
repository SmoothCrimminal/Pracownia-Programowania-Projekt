using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Roles
{
    public class CreateRoles
    {
        public Role CreateRole(Role role)
        {
            using (var context = new ProjektPPContext())
            {
                var newRole = context.Roles.Add(role);
                context.SaveChanges();
                return newRole.Entity;
            }
        }
    }
}
