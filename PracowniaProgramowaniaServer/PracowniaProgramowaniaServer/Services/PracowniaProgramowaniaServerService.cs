using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using PracowniaProgramowaniaServer.Logic;
using Google.Protobuf.Collections;

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
            var brandsLogic = new BrandsLogic(); // obiekt klasy brandsLogic
            var newBrand = brandsLogic.CreateBrand(request.BrandName); // tworzymy zmienn¹ newBrand typu BrandsLogic której przypisujemy z requesta BrandName

            return Task.FromResult(new CreateBrandReply()
            {
                BrandId = newBrand.Id,
                BrandName = newBrand.NazwaBranzy   // zwracamy w odpowiedzi ID i NazwêBran¿y
            });

        }

        public override Task<DeleteBrandReply> DeleteBrand(DeleteBrandRequest request, ServerCallContext context)
        {
            var brandsLogic = new BrandsLogic();
            var deleteBrand = brandsLogic.DeleteBrand(request.BrandId);
            return Task.FromResult(new DeleteBrandReply()
            {
                Result = deleteBrand
            });
        }

        /* public override Task<ReadAllBrandsReply> ReadAllBrands(ReadAllBrandsRequest request, ServerCallContext context)
         {
             var brandsLogic = new BrandsLogic();
             var readAllBrands = brandsLogic.ReadAllBrands();
             RepeatedField<Brand> brands = readAllBrands; */

        public override Task<ReadBrandReply> ReadBrand(ReadBrandRequest request, ServerCallContext context)
        {
            var brandsLogic = new BrandsLogic();
            var readBrand = brandsLogic.ReadBrand(request.BrandId);
            return Task.FromResult(new ReadBrandReply()
            {
                BrandDetails = readBrand
            });
        }

        public override Task<UpdateBrandReply> UpdateBrand(UpdateBrandRequest request, ServerCallContext context)
        {
            var brandsLogic = new BrandsLogic();
            var updateBrand = brandsLogic.UpdateBrand(request.BrandId, request.BrandName);
            return Task.FromResult(new UpdateBrandReply()
            {
                UpdatedBrand = updateBrand
            });
        }

        public override Task<CreateRoleReply> CreateRole(CreateRoleRequest request, ServerCallContext context)
        {
            var rolesLogic = new RolesLogic(); // obiekt klasy brandsLogic
            var newRole = rolesLogic.CreateRole(request.RoleName); // tworzymy zmienn¹ newBrand typu BrandsLogic której przypisujemy z requesta BrandName
            return Task.FromResult(new CreateRoleReply()
            {
                RoleId = newRole.Id,
                RoleName = newRole.NazwaRoli   // zwracamy w odpowiedzi ID i NazwêBran¿y
            });

        }

        public override Task<DeleteRoleReply> DeleteRole(DeleteRoleRequest request, ServerCallContext context)
        {
            var rolesLogic = new RolesLogic();
            var deleteRole = rolesLogic.DeleteRole(request.RoleId);
            return Task.FromResult(new DeleteRoleReply()
            {
                Result = deleteRole
            });
        }

        /* public override Task<ReadAllBrandsReply> ReadAllBrands(ReadAllBrandsRequest request, ServerCallContext context)
         {
             var brandsLogic = new BrandsLogic();
             var readAllBrands = brandsLogic.ReadAllBrands();
             RepeatedField<Brand> brands = readAllBrands; */

        public override Task<ReadRoleReply> ReadRole (ReadRoleRequest request, ServerCallContext context)
        {
            var rolesLogic = new RolesLogic();
            var readRole = rolesLogic.ReadRole(request.RoleId);
            return Task.FromResult(new ReadRoleReply()
            {
                RoleDetails = readRole
            });
        }

        public override Task<UpdateRoleReply> UpdateRole(UpdateRoleRequest request, ServerCallContext context)
        {
            var rolesLogic = new RolesLogic();
            var updateRole = rolesLogic.UpdateRole(request.RoleId, request.RoleName);
            return Task.FromResult(new UpdateRoleReply()
            {
                UpdatedRole = updateRole
            });
        }
    }
}
