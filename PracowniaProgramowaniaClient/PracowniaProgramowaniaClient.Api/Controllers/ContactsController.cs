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

        [HttpGet]
        [Route("create/{name} {surname} {connectedCompanyId} {userAddingContactID} {phoneNumber} {email} {position}")]
        public Contact CreateContact(string name, string surname, int connectedCompanyId, int userId,
            string phoneNumber, string email, string position)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.CreateContact(name, surname, connectedCompanyId, userId, phoneNumber, email, position);
            return new Contact()
            {
               Id = reply.ContactId,
               Imie = reply.Name,
               Nazwisko = reply.Surname,
               FirmaPowiazana = reply.ConnectedCompanyId,
               IdUżytkownika = reply.UserAddingContactId,
               Telefon = reply.PhoneNumber,
               Mail = reply.EmailAddress,
               Stanowisko = reply.Position
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

        [HttpGet]
        [Route("update/{contactId} {name} {surname} {phoneNumber} {position} {mail}")]
        public string UpdateContact(int contactId, string name, string surname, string phoneNumber, string position, string mail)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.UpdateContact(contactId, name, surname, phoneNumber, position, mail);
            return reply.UpdatedContact;
        }
    }
}
