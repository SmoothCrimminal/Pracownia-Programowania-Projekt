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

namespace PracowniaProgramowaniaClient.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {

        string _serverServiceAddress;

        public RolesController(IConfiguration configuration)
        {
            _serverServiceAddress = configuration.GetValue<string>("ServerServiceAddress");
        }

        [HttpGet]
        [Route("create/{roleName}")]
        public Role CreateRole(string roleName)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.CreateRole(roleName);
            return new Role() { RoleId = reply.RoleId, RoleName = reply.RoleName };
        }

        [HttpGet]
        [Route("delete/{roleId}")]
        public bool DeleteRole(int roleId)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.DeleteRole(roleId);
            if (reply != null)
            {
                return reply.Result;
            }

            return false;
        }

        [HttpGet]
        [Route("read")]

        public RepeatedField<RoleField> ReadAllRoles()
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.ReadAllRoles();
            return reply.AllRoles;
        } 

        [HttpGet]
        [Route("read/{roleId}")]
        public string ReadRole(int roleId)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.ReadRole(roleId);
            return reply.RoleDetails;
        }

        [HttpGet]
        [Route("update/{roleId} {roleName}")]
        public string UpdateRole(int roleId, string roleName)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.UpdateRole(roleId, roleName);
            return reply.UpdatedRole;

        }
    }
}
