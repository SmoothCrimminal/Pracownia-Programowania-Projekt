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

        [HttpPost]
        [Route("create")]
        public Company CreateCompany(CompanyField company)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.CreateCompany(company);
            return new Company()
            {
                Id = reply.NewCompany.Id,
                NazwaFirmy = reply.NewCompany.CompanyName,
                IdBranży = reply.NewCompany.BrandId,
                Nip = reply.NewCompany.Nip,
                Adres = reply.NewCompany.Address
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

        [HttpPost]
        [Route("update")]
        public string UpdateCompany(CompanyField company)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.UpdateCompany(company);
            return reply.UpdatedCompany;
        }
    }
}
