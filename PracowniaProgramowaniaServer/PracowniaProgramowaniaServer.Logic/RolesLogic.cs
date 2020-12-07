using System;
using System.Collections.Generic;
using System.Text;
using CRUD.Roles;
using P.P.Database.Models;

namespace PracowniaProgramowaniaServer.Logic
{
    public class RolesLogic
    {
        public Role CreateRole(string roleName) // metoda przyjmuje string name
        {
            var dbCreateRole = new CreateRoles(); // tworzy obiekt CreateBrands
            return dbCreateRole.CreateRole(new Role() { NazwaRoli = roleName }); // zwraca instancję obiektu z nazwą podaną w stringu brandName
        }

        public bool DeleteRole(int roleId)
        {
            var dbDeleteRole = new DeleteRoles();
            return dbDeleteRole.DeleteRole(roleId);
        }

        /* public IEnumerable<Brand> ReadAllBrands()
        {
            var dbReadAllBrands = new ReadBrands();
            return dbReadAllBrands.ReadAllBrands();
        } */

        public string ReadRole(int roleId)
        {
            var dbReadRole = new ReadRoles();
            return dbReadRole.ReadRole(roleId);
        }

        public string UpdateRole(int roleId, string roleName)
        {
            var dbUpdateRole = new UpdateRoles();
            return dbUpdateRole.UpdateRole(roleId, roleName);
        }
    }
}
