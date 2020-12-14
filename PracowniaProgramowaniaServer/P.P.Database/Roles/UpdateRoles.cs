using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Roles
{
    public class UpdateRoles
    {
        public string UpdateRole (int roleId, string roleName)
        {
            using (var context = new ProjektPPContext())
            {
                var roleToUpdate = context.Roles.Find(roleId);
                if (roleToUpdate != null)
                {
                    roleToUpdate.RoleName = roleName;
                    context.SaveChanges();
                    return $"{roleToUpdate.Id} {roleToUpdate.RoleName}";
                }

                return "Role with such id not found in database.";
            }
        }
    }
}
