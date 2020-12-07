using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Roles
{
    public class DeleteRoles
    {
        public bool DeleteRole(int roleId) // metoda modelu Brand tworząca obiekt typu Brand
        {
            using (var context = new ProjektPPContext()) // używamy using ponieważ okres istnienia obiektu jest ograniczony do pojedynczej metody
            {
                var role = context.Roles.Find(roleId);
                if (role != null)
                {
                    context.Remove(role);
                    context.SaveChanges();
                    return true;
                }

                return false;

            };
        }
    }
}
