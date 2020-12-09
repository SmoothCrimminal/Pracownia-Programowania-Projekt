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
                if ((userToUpdate != null) && ((bool)userToUpdate.IsDeleted == false))
                {
                    if (login != "")
                    {
                        var allUsers = context.Users.ToList();
                        bool isTaken = false;

                        foreach (User user in allUsers)
                        {
                            if (login == user.Login)
                            {
                                isTaken = true;
                                break;
                            }
                            
                        }

                        if (isTaken == true)
                        {
                            return "User with this login already exists!";
                        }

                        else
                        {
                            userToUpdate.Login = login;
                            return "Login successfully changed!";
                        }

                    }
                    if ((password != "") && (userToUpdate.PasswordMd5 != password))
                        userToUpdate.PasswordMd5 = password;
                    if (name != "")
                        userToUpdate.Imie = name;
                    if (surname != "")
                        userToUpdate.Nazwisko = surname;
                    if (dateOfBirth != "")
                    {
                        DateTime parsedDate;
                        bool isParsed = DateTime.TryParse(dateOfBirth, out parsedDate);
                        if (isParsed == true)
                        {
                            userToUpdate.DateOfBirth = parsedDate;
                            return "Date of birth successfully changed";
                        }

                        else
                        {
                            return "Changing date of birth failed!";
                        }
                    }
                        

                    context.SaveChanges();
                    return $"{userToUpdate.Id} {userToUpdate.Login} {userToUpdate.IdRoli}";
                }

                return "User with such id not found in database or has been deleted";
            }
        }
    }
}
