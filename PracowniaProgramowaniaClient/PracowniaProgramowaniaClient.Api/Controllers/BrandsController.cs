using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PracowniaProgramowaniaClient.Api.Models;
using PracowniaProgramowaniaClient.ServerRemote;

namespace PracowniaProgramowaniaClient.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        string _serverServiceAddress;
        public BrandsController(IConfiguration configuration)
        {
            _serverServiceAddress = configuration.GetValue<string>("ServerServiceAddress");
        }

        [HttpGet]
        [Route("create/{brandName}")]
        public Brand CreateBrand(string brandName)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.CreateBrand(brandName);
            return new Brand() { BrandId = reply.BrandId, BrandName = reply.BrandName };
        }
    }
}
