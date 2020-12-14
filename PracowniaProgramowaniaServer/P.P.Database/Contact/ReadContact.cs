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
                    return $"{contact.Id} {contact.Name} {contact.Surname} {contact.CompanyId} {contact.UserId} " +
                        $"{contact.PhoneNumber} {contact.Mail} {contact.Position} {contact.IsDeleted}";
                }

                return "Contact not found";
            }
        }
    }
}
