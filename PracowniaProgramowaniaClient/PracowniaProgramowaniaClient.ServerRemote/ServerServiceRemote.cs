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
    }
}
