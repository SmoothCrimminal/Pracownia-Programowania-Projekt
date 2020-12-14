using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Contact
{
    public class UpdateContact
    {
        public string UpdateContacts(int contactId, string name="", string surname="", int phoneNumber = 0, string position="", string emailAddress="")
        {
            using (var context = new ProjektPPContext())
            {
                var contactToUpdate = context.Contacts.Find(contactId);
                if ((contactToUpdate != null) && ((bool)contactToUpdate.IsDeleted == false))
                {
                    if (name != "")
                        contactToUpdate.Name = name;
                    if (surname != "")
                        contactToUpdate.Surname = surname;
                    if (phoneNumber != 0)
                        contactToUpdate.PhoneNumber = phoneNumber;
                    if (position != "")
                        contactToUpdate.Position = position;
                    if (emailAddress != "")
                        contactToUpdate.Mail = emailAddress;

                    context.SaveChanges();
                    return $"{contactToUpdate.Id} {contactToUpdate.Name} {contactToUpdate.Surname} {contactToUpdate.CompanyId} " +
                        $"{contactToUpdate.UserId} {contactToUpdate.PhoneNumber} {contactToUpdate.Mail} {contactToUpdate.Position}";
                }

                return "Contact with such id not found in database or has been deleted";
            }
        }
    }
}
