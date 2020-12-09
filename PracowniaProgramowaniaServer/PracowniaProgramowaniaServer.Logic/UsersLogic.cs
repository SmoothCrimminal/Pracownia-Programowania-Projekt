using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using P.P.Database.Models;
using CRUD.Users;

namespace PracowniaProgramowaniaServer.Logic
{
    public class UsersLogic
    {
        public User CreateUser(string login, string password, int roleId, string imie="", string nazwisko="", string dateOfBirth="1/1/2000")
        {
            var dbCreateUser = new CreateUsers();
            var data = System.Text.Encoding.ASCII.GetBytes(password);
            var parsedDate = DateTime.Parse(dateOfBirth);
            data = MD5.Create().ComputeHash(data);
            return dbCreateUser.CreateUser(new User()
            {
                Login = login,
                PasswordMd5 = data.ToString(),
                IdRoli = roleId,
                Imie = imie,
                Nazwisko = nazwisko,
                DateOfBirth = parsedDate,
                IsDeleted = false
            });
        }

        public string DeleteUser(int userId)
        {
            var dbDeleteUser = new DeleteUsers();
            return dbDeleteUser.DeleteUser(userId);
        }

        public List<User> ReadAllUsers()
        {
            var dbReadAllUsers = new ReadUsers();
            return dbReadAllUsers.ReadAllUsers();
        }

        public string ReadUser(int userId)
        {
            var dbReadUser = new ReadUsers();
            return dbReadUser.ReadUser(userId);
        }

        public string UpdateUser(int userId, string login = "", string password = "", string name = "", string surname = "", string dateOfBirth = "")
        {
            var dbUpdateUser = new UpdateUsers();
            var data = System.Text.Encoding.ASCII.GetBytes(password);
            data = MD5.Create().ComputeHash(data);
            password = data.ToString();
            return dbUpdateUser.UpdateUser(userId, login, password, name, surname, dateOfBirth);
        }
    }
}