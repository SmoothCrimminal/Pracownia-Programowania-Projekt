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

        [HttpPost]
        [Route("create")]
        public User CreateUser(UserField user)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.CreateUser(user);
            return new User()
            {
                Id = reply.NewUser.Id,
                Login = reply.NewUser.Login,
                IdRoli = reply.NewUser.RoleID,
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

        [HttpPost]
        [Route("update")]
        public string UpdateUser(UserField user)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.UpdateUser(user);
            return reply.UpdatedUser;
        }
    }
}
