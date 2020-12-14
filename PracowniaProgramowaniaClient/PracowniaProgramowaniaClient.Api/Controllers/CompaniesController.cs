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
    [ApiController]
    [Route("[controller]")]

    public class CompaniesController : ControllerBase
    {

        string _serverServiceAddress;

        public CompaniesController(IConfiguration configuration)
        {
            _serverServiceAddress = configuration.GetValue<string>("ServerServiceAddress");
        }

        [HttpGet]
        [Route("create/{companyName} {brandId} {userId} {nip} {address} {city}")]
        public Company CreateCompany(string companyName, int brandId, int userId, string nip, string address, string city)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.CreateCompany(companyName, brandId, userId, nip, address);
            return new Company()
            {
                Id = reply.CompanyId,
                NazwaFirmy = reply.CompanyName,
                IdBranży = reply.BrandId,
                Nip = reply.Nip,
                Adres = reply.Address
            };
        }

        [HttpGet]
        [Route("delete/{companyId}")]
        public string DeleteCompany(int companyId)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.DeleteCompany(companyId);

            return reply.Message;

        }

        [HttpGet]
        [Route("read")]

        public RepeatedField<CompanyField> ReadAllCompanies()
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.ReadAllCompanies();
            return reply.ReadAllCompanies;
        }

        [HttpGet]
        [Route("read/{companyId}")]
        public string ReadCompany(int companyId)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.ReadCompany(companyId);
            return reply.CompanyDetails;
        }

        [HttpGet]
        [Route("update/{companyId} {companyName} {nip} {address} {city}")]
        public string UpdateCompany(int companyId, string companyName, string nip, string address, string city)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.UpdateCompany(companyId, companyName, nip, address);
            return reply.UpdatedCompany;
        }
    }
}
