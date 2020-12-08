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
            string phoneNumber = "", string emailAddress = "", string stanowisko = "")
        {
            var dbCreateContact = new CreateContact();
            return dbCreateContact.CreateContacts(new Contact()
            {
                Imie = name,
                Nazwisko = surname,
                FirmaPowiazana = connectedCompanyId,
                IdUżytkownika = userId,
                Telefon = phoneNumber,
                Mail = emailAddress,
                Stanowisko = stanowisko,
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

        public string UpdateContact(int contactId, string name = "", string surname = "", string phoneNumber = "", string position = "", string emailAddress = "")
        {
            var dbUpdateContact = new UpdateContact();
            return dbUpdateContact.UpdateContacts(contactId, name, surname, phoneNumber, position, emailAddress);
        }
    }
}
