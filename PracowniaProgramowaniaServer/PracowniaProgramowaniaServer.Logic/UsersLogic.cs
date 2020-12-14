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

        public static string CreateMD5Hash(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        public User CreateUser(string login, string password, int roleId, string name="", string surname="", string dateOfBirth="")
        {
            var dbCreateUser = new CreateUsers();
            DateTime dateTime;
            bool isParsed = DateTime.TryParse(dateOfBirth, out dateTime);
            if (isParsed == false)
            {
                dateTime = DateTime.Parse("1.1.2000");
            }
            return dbCreateUser.CreateUser(new User()
            {
                Login = login,
                PasswordMd5 = CreateMD5Hash(password),
                RoleId = roleId,
                Name = name,
                Surname = surname,
                DateOfBirth = dateTime,
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
            password = CreateMD5Hash(password);
            return dbUpdateUser.UpdateUser(userId, login, password, name, surname, dateOfBirth);
        }
    }
}