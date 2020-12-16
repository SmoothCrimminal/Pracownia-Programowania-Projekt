using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PracowniaProgramowaniaClient.Api.Models;
using PracowniaProgramowaniaClient.ServerRemote;
using Google.Protobuf.Collections;
using PracowniaProgramowaniaServer;
using P.P.Database.Models;

namespace PracowniaProgramowaniaClient.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {

        string _serverServiceAddress;

        public ContactsController(IConfiguration configuration)
        {
            _serverServiceAddress = configuration.GetValue<string>("ServerServiceAddress");
        }

        [HttpPost]
        [Route("create")]
        public Contact CreateContact(ContactField contact)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.CreateContact(contact);
            return new Contact()
            {
               Id = reply.NewContact.Id,
               Imie = reply.NewContact.Name,
               Nazwisko = reply.NewContact.Surname,
               FirmaPowiazana = reply.NewContact.ConnectedCompanyId,
               IdUżytkownika = reply.NewContact.UserAddingContactId,
               Telefon = reply.NewContact.PhoneNumber,
               Mail = reply.NewContact.EmailAddress,
               Stanowisko = reply.NewContact.Position
            };
        }

        [HttpGet]
        [Route("delete/{contactId}")]
        public string DeleteContact(int contactId)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.DeleteContact(contactId);

            return reply.Message;

        }

        [HttpGet]
        [Route("read")]

        public RepeatedField<ContactField> ReadAllContacts()
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.ReadAllContacts();
            return reply.AllContacts;
        }

        [HttpGet]
        [Route("read/{contactId}")]
        public string ReadContact(int contactId)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.ReadContact(contactId);
            return reply.ContactDetails;
        }

        [HttpPost]
        [Route("update")]
        public string UpdateContact(ContactField contact)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.UpdateContact(contact);
            return reply.UpdatedContact;
        }
    }
}
