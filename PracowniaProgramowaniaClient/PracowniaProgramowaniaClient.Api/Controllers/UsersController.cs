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
    public class UsersController : ControllerBase
    {

        string _serverServiceAddress;

        public UsersController(IConfiguration configuration)
        {
            _serverServiceAddress = configuration.GetValue<string>("ServerServiceAddress");
        }

        [HttpGet]
        [Route("create/{login} {password} {roleId} {name} {surname} {dateOfBirth}")]
        public User CreateUser(string login, string password, int roleId, string name, string surname, string dateOfBirth)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.CreateUser(login, password, roleId, name, surname, dateOfBirth);
            return new User()
            {
                Id = reply.Id,
                Login = reply.Login,
                IdRoli = reply.RoleID
            };
        }

        [HttpGet]
        [Route("delete/{userId}")]
        public string DeleteUser(int userId)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.DeleteUser(userId);

            return reply.Message;

        }

        [HttpGet]
        [Route("read")]

        public RepeatedField<UserField> ReadAllUsers()
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.ReadAllUsers();
            return reply.ReadAllUsers;
        }

        [HttpGet]
        [Route("read/{userId}")]
        public string ReadUser(int userId)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.ReadUser(userId);
            return reply.UserDetails;
        }

        [HttpGet]
        [Route("update/{userId} {login} {password} {name} {surname} {dateOfBirth}")]
        public string UpdateUser(int userId, string login, string password, string name, string surname, string dateOfBirth)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.UpdateUser(userId, login, password, name, surname, dateOfBirth);
            return reply.UpdatedUser;
        }
    }
}
