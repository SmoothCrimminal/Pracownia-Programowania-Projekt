using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Contact
{
    public class ReadContact
    {
        public List<P.P.Database.Models.Contact> ReadAllContacts()
        {
            using (var context = new ProjektPPContext())
            {
                var allContacts = context.Contacts.ToList();
                return allContacts;

            }
        }

        public string ReadContacts(int contactId)
        {
            using (var context = new ProjektPPContext())
            {
                var contact = context.Contacts.Find(contactId);
                if (contact != null)
                {
                    return $"{contact.Id} {contact.Imie} {contact.Nazwisko} {contact.FirmaPowiazana} {contact.IdUżytkownika} " +
                        $"{contact.Telefon} {contact.Mail} {contact.Stanowisko} {contact.IsDeleted}";
                }

                return "Contact not found";
            }
        }
    }
}
