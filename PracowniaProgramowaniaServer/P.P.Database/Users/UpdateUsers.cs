using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;
using System.Linq;

namespace CRUD.Users
{
    public class UpdateUsers
    {
        public string UpdateUser(int userId, string login="", string password="", string name="", string surname="", string dateOfBirth="")
        {
            using (var context = new ProjektPPContext())
            {
                var userToUpdate = context.Users.Find(userId);
                bool isTaken = false, isParsed, isChanged = false;
                if ((userToUpdate != null) && ((bool)userToUpdate.IsDeleted == false))
                {
                    if (login != "")
                    {
                        var allUsers = context.Users.ToList();

                        foreach (User user in allUsers)
                        {
                            if (login == user.Login)
                            {
                                isTaken = true;
                                break;
                            }

                        }

                        if (isTaken == false)
                        {
                            userToUpdate.Login = login;
                        }

                    }
                    if ((password != "") && (userToUpdate.PasswordMd5 != password))
                    {
                        userToUpdate.PasswordMd5 = password;
                        isChanged = true;
                    }
                    if (name != "")
                        userToUpdate.Name = name;
                    if (surname != "")
                        userToUpdate.Surname = surname;
                    if (dateOfBirth != "")
                    {
                        DateTime parsedDate;
                        isParsed = DateTime.TryParse(dateOfBirth, out parsedDate);
                        if (isParsed == true)
                        {
                            userToUpdate.DateOfBirth = parsedDate;
                        }

                    }
                        
                    context.SaveChanges();
                    if ((password != "") && (isChanged == true))                   
                        return $"{userToUpdate.Id} {userToUpdate.Login} {userToUpdate.RoleId} {userToUpdate.DateOfBirth} {userToUpdate.Surname}" +
                            $"Password Successfully changed!";
                    else if ((password != "") && (isChanged == false))
                        return $"{userToUpdate.Id} {userToUpdate.Login} {userToUpdate.RoleId} {userToUpdate.DateOfBirth} {userToUpdate.Surname}" +
                            $"Changing Password Failed!";
                    else
                        return $"{userToUpdate.Id} {userToUpdate.Login} {userToUpdate.RoleId} {userToUpdate.DateOfBirth} {userToUpdate.Surname}";
                }

                return "User with such id not found in database or has been deleted";
            }
        }
    }
}
