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
        [Route("create/{brandName}")] // mapowanie metody createBrand na create/"brandName"
        public Brand CreateBrand(string brandName)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.CreateBrand(brandName);
            return new Brand() { BrandId = reply.BrandId, BrandName = reply.BrandName };
        }

        [HttpGet]
        [Route("delete/{brandId}")]
        public bool DeleteBrand(int brandId)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.DeleteBrand(brandId);
            if (reply != null)
            {
                return reply.Result;
            }

            return false;
        } 

        [HttpGet]
        [Route("read")]

        public RepeatedField<BrandField> ReadAllBrands()
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.ReadAllBrands();
            return reply.AllBrands;
        } 

        [HttpGet]
        [Route("read/{brandId}")]
        public string ReadBrand(int brandId)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.ReadBrand(brandId);
            return reply.BrandDetails;
        }

        [HttpGet]
        [Route("update/{brandId} {brandName}")]
        public string UpdateBrand(int brandId, string brandName)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.UpdateBrand(brandId, brandName);
            return reply.UpdatedBrand;
            
        }
    }
}
