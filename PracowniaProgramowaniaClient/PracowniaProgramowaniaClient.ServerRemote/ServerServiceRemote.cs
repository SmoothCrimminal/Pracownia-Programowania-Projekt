using PracowniaProgramowaniaServer;
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

        public CreateBrandReply CreateBrand(string brandName)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.CreateBrand(new CreateBrandRequest() { BrandName = brandName });
            
        }
        public DeleteBrandReply DeleteBrand(int brandId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.DeleteBrand(new DeleteBrandRequest(){ BrandId = brandId });

        }

       public ReadAllBrandsReply ReadAllBrands()
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadAllBrands(new ReadAllBrandsRequest());
        } 
        public ReadBrandReply ReadBrand(int brandId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadBrand(new ReadBrandRequest() { BrandId = brandId });

        }

        public UpdateBrandReply UpdateBrand(BrandField brand)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.UpdateBrand(new UpdateBrandRequest() { UpdateBrand = brand});

        }

        public CreateRoleReply CreateRole(string roleName)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.CreateRole(new CreateRoleRequest() { RoleName = roleName });

        }
        public DeleteRoleReply DeleteRole(int roleId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.DeleteRole(new DeleteRoleRequest() { RoleId = roleId });

        }

        public ReadAllRolesReply ReadAllRoles()       
        {
             var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
             return pPServer.ReadAllRoles(new ReadAllRolesRequest());
        } 
        public ReadRoleReply ReadRole(int roleId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadRole(new ReadRoleRequest() { RoleId = roleId });

        }

        public UpdateRoleReply UpdateRole(RoleField role)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.UpdateRole (new UpdateRoleRequest() { Role = role });

        }


        public CreateTradeNoteReply CreateTrade(TradeNoteField tradeNote)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.CreateTradeNote(new CreateTradeNoteRequest() { TradeNote = tradeNote });
        }

        public DeleteTradeNoteReply DeleteTradeNote(int tradeNoteId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.DeleteTradeNote(new DeleteTradeNoteRequest() { TradeNoteId = tradeNoteId });
        }

        public ReadAllTradeNotesReply ReadAllTradeNotes()
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadAllTradeNotes(new ReadAllTradeNotesRequest());
        }

        public ReadTradeNoteReply ReadTradeNote(int tradeNoteId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadTradeNote(new ReadTradeNoteRequest() { TradeNoteId = tradeNoteId });
        }

        public UpdateTradeNoteReply UpdateTrade(TradeNoteField tradeNote)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.UpdateTradeNote(new UpdateTradeNoteRequest() { TradeNote = tradeNote });
        }

        public CreateContactReply CreateContact(ContactField contact)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.CreateContact(new CreateContactRequest()
            {
              Contact = contact
            });
        }

        public DeleteContactReply DeleteContact(int contactId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.DeleteContact(new DeleteContactRequest() { ContactId = contactId });
        }

        public ReadAllContactsReply ReadAllContacts()
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadAllContacts(new ReadAllContactsRequest());
        }

        public ReadContactReply ReadContact(int contactId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadContact(new ReadContactRequest() { Id = contactId });
        }

        public UpdateContactReply UpdateContact(ContactField contact)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.UpdateContact(new UpdateContactRequest()
            {
                Contact = contact
            });
        }

        public CreateCompanyReply CreateCompany(CompanyField company)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.CreateCompany(new CreateCompanyRequest()
            {
                Company = company
            });
        }

        public DeleteCompanyReply DeleteCompany(int companyId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.DeleteCompany(new DeleteCompanyRequest() { CompanyId = companyId });
        }

        public ReadAllCompaniesReply ReadAllCompanies()
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadAllCompanies(new ReadAllCompaniesRequest());
        }

        public ReadCompanyReply ReadCompany(int companyId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadCompany(new ReadCompanyRequest() { CompanyId = companyId });
        }

        public UpdateCompanyReply UpdateCompany(CompanyField company)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.UpdateCompany(new UpdateCompanyRequest()
            {
               Company = company
            });
        }

        public CreateUserReply CreateUser(UserField user)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.CreateUser(new CreateUserRequest() { User = user});
        }

        public DeleteUserReply DeleteUser(int userId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.DeleteUser(new DeleteUserRequest() { Id = userId });
        }

        public ReadAllUsersReply ReadAllUsers()
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadAllUsers(new ReadAllUsersRequest());
        }

        public ReadUserReply ReadUser(int userId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadUser(new ReadUserRequest() { Id = userId });
        }

        public UpdateUserReply UpdateUser(UserField user)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.UpdateUser(new UpdateUserRequest()
            {
               User = user
            });
        }
    }
}
