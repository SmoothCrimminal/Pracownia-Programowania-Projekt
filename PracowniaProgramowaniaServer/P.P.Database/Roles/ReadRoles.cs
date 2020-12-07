using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Roles
{
    public class ReadRoles
    {
        public string ReadRole(int roleId)
        {
            using (var context = new ProjektPPContext())
            {
                var role = context.Roles.Find(roleId);
                if (role != null)
                {
                    return $"{role.Id} {role.NazwaRoli}";
                }

                return "Role not found";
            }

        }
    }
}
