using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using P.P.Database.Models;

namespace CRUD.Roles
{
    public class ReadRoles
    {

        public List<Role> ReadAllRoles()
        {
            using (var context = new ProjektPPContext())
            {
                var allRoles = context.Roles.ToList();
                return allRoles;
            }
        }
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
