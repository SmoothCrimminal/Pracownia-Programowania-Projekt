using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Contact
{
    public class UpdateContact
    {
        public string UpdateContacts(int contactId, string name="", string surname="", string phoneNumber="", string position="", string emailAddress="")
        {
            using (var context = new ProjektPPContext())
            {
                var contactToUpdate = context.Contacts.Find(contactId);
                if ((contactToUpdate != null) && ((bool)contactToUpdate.IsDeleted == false))
                {
                    if (name != "")
                        contactToUpdate.Imie = name;
                    if (surname != "")
                        contactToUpdate.Nazwisko = surname;
                    if (phoneNumber != "")
                        contactToUpdate.Telefon = phoneNumber;
                    if (position != "")
                        contactToUpdate.Stanowisko = position;
                    if (emailAddress != "")
                        contactToUpdate.Mail = emailAddress;

                    context.SaveChanges();
                    return $"{contactToUpdate.Id} {contactToUpdate.Imie} {contactToUpdate.Nazwisko} {contactToUpdate.FirmaPowiazana} " +
                        $"{contactToUpdate.IdUżytkownika} {contactToUpdate.Telefon} {contactToUpdate.Mail} {contactToUpdate.Stanowisko}";
                }

                return "Contact with such id not found in database or has been deleted";
            }
        }
    }
}
