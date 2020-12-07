using System;
namespace PracowniaProgramowaniaClient.ServerRemote
{
    public class ServerServiceRemote
    {
        private string _serverServiceAddress;
        public ServerServiceRemote(string serverServiceAddress)
        {
            _serverServiceAddress = serverServiceAddress;
        }

        public PracowniaProgramowaniaServer.CreateBrandReply CreateBrand(string brandName)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.CreateBrand(new PracowniaProgramowaniaServer.CreateBrandRequest() { BrandName = brandName });
            
        }
        public PracowniaProgramowaniaServer.DeleteBrandReply DeleteBrand(int brandId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.DeleteBrand(new PracowniaProgramowaniaServer.DeleteBrandRequest(){ BrandId = brandId });

        }

       /* public PracowniaProgramowaniaServer.ReadAllBrandsReply ReadAllBrands()
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadAllBrands(new PracowniaProgramowaniaServer.ReadAllBrandsRequest());
        } */
        public PracowniaProgramowaniaServer.ReadBrandReply ReadBrand(int brandId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadBrand(new PracowniaProgramowaniaServer.ReadBrandRequest() { BrandId = brandId });

        }

        public PracowniaProgramowaniaServer.UpdateBrandReply UpdateBrand(int brandId, string brandName)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.UpdateBrand(new PracowniaProgramowaniaServer.UpdateBrandRequest() { BrandId = brandId, BrandName = brandName });

        }

        public PracowniaProgramowaniaServer.CreateRoleReply CreateRole(string roleName)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.CreateRole(new PracowniaProgramowaniaServer.CreateRoleRequest() { RoleName = roleName });

        }
        public PracowniaProgramowaniaServer.DeleteRoleReply DeleteRole(int roleId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.DeleteRole(new PracowniaProgramowaniaServer.DeleteRoleRequest() { RoleId = roleId });

        }

        /* public PracowniaProgramowaniaServer.ReadAllBrandsReply ReadAllBrands()
         {
             var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
             return pPServer.ReadAllBrands(new PracowniaProgramowaniaServer.ReadAllBrandsRequest());
         } */
        public PracowniaProgramowaniaServer.ReadRoleReply ReadRole(int roleId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadRole(new PracowniaProgramowaniaServer.ReadRoleRequest() { RoleId = roleId });

        }

        public PracowniaProgramowaniaServer.UpdateRoleReply UpdateRole(int roleId, string roleName)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.UpdateRole (new PracowniaProgramowaniaServer.UpdateRoleRequest() { RoleId = roleId, RoleName = roleName });

        }
    }
}
