using CRUD.Contact;
using P.P.Database.Models;
using System.Collections.Generic;
using System.Linq;
using System;
namespace PracowniaProgramowaniaServer.Logic
{
    public class ContactsLogic
    {
        public Contact CreateContact(string name, string surname, int connectedCompanyId, int userId,
            int phoneNumber = 0, string emailAddress = "", string position = "")
        {
            var dbCreateContact = new CreateContact();
            return dbCreateContact.CreateContacts(new Contact()
            {
                Name = name,
                Surname = surname,
                CompanyId = connectedCompanyId,
                UserId = userId,
                PhoneNumber = phoneNumber,
                Mail = emailAddress,
                Position = position,
                IsDeleted = false
            });
        }

        public string DeleteContact(int contactId)
        {
            var dbDeleteContact = new DeleteContact();
            return dbDeleteContact.DeleteContacts(contactId);
        }

        public List<Contact> ReadAllContacts()
        {
            var dbReadAllContacts = new ReadContact();
            return dbReadAllContacts.ReadAllContacts();
        }

        public string ReadContact(int contactId)
        {
            var dbReadContact = new ReadContact();
            return dbReadContact.ReadContacts(contactId);
        }

        public string UpdateContact(int contactId, string name = "", string surname = "", int phoneNumber = 0, string position = "", string emailAddress = "")
        {
            var dbUpdateContact = new UpdateContact();
            return dbUpdateContact.UpdateContacts(contactId, name, surname, phoneNumber, position, emailAddress);
        }
    }
}
