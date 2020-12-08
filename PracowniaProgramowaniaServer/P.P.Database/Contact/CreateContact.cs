using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Contact
{
    public class CreateContact
    {
        public P.P.Database.Models.Contact CreateContacts(P.P.Database.Models.Contact contact)
        {
            using (var context = new ProjektPPContext())
            {
                var newContact = context.Contacts.Add(contact);
                context.SaveChanges();
                return newContact.Entity;
            }
        }
    }
}
