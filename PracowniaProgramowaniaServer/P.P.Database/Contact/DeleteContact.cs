using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Contact
{
    public class DeleteContact
    {
        public string DeleteContacts(int contactId)
        {
            using (var context = new ProjektPPContext())
            {
                var contact = context.Contacts.Find(contactId);
                if ((contact != null) && ((bool)contact.IsDeleted == false))
                {
                    contact.IsDeleted = true;
                    return "Contact Successfully deleted";
                }

                else if ((contact != null) && ((bool)contact.IsDeleted == true))
                {
                    return "Contact with this id already has been deleted";
                }

                context.SaveChanges();

                return "Contact Not Found";

            }
        }
    }
}
