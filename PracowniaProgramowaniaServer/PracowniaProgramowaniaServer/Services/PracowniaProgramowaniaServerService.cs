using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using PracowniaProgramowaniaServer.Logic;

namespace PracowniaProgramowaniaServer
{
    public class PracowniaProgramowaniaServerService : PracowniaProgramowaniaServer.PracowniaProgramowaniaServerBase
    {
        private readonly ILogger<PracowniaProgramowaniaServerService> _logger;
        public PracowniaProgramowaniaServerService(ILogger<PracowniaProgramowaniaServerService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
        public override Task<CreateBrandReply> CreateBrand(CreateBrandRequest request, ServerCallContext context)
        {
            var brandsLogic = new BrandsLogic();
            var newBrand = brandsLogic.CreateBrand(request.BrandName);
            return Task.FromResult(new CreateBrandReply() 
            {
                BrandId = newBrand.Id,
                BrandName = newBrand.NazwaBranzy 
            }); 

        }

    }
}
