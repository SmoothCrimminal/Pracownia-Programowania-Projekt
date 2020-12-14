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

       public PracowniaProgramowaniaServer.ReadAllBrandsReply ReadAllBrands()
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadAllBrands(new PracowniaProgramowaniaServer.ReadAllBrandsRequest());
        } 
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

        public PracowniaProgramowaniaServer.ReadAllRolesReply ReadAllRoles()       
        {
             var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
             return pPServer.ReadAllRoles(new PracowniaProgramowaniaServer.ReadAllRolesRequest());
        } 
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


        public PracowniaProgramowaniaServer.CreateTradeNoteReply CreateTrade(string content, int companyId, int userId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.CreateTradeNote(new PracowniaProgramowaniaServer.CreateTradeNoteRequest() { Content = content, CompanyId = companyId, UserId = userId });
        }

        public PracowniaProgramowaniaServer.DeleteTradeNoteReply DeleteTradeNote(int tradeNoteId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.DeleteTradeNote(new PracowniaProgramowaniaServer.DeleteTradeNoteRequest() { TradeNoteId = tradeNoteId });
        }

        public PracowniaProgramowaniaServer.ReadAllTradeNotesReply ReadAllTradeNotes()
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadAllTradeNotes(new PracowniaProgramowaniaServer.ReadAllTradeNotesRequest());
        }

        public PracowniaProgramowaniaServer.ReadTradeNoteReply ReadTradeNote(int tradeNoteId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadTradeNote(new PracowniaProgramowaniaServer.ReadTradeNoteRequest() { TradeNoteId = tradeNoteId });
        }

        public PracowniaProgramowaniaServer.UpdateTradeNoteReply UpdateTrade(int tradeNoteId, string content)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.UpdateTradeNote(new PracowniaProgramowaniaServer.UpdateTradeNoteRequest() { TradeNoteId = tradeNoteId, NewContent = content });
        }

        public PracowniaProgramowaniaServer.CreateContactReply CreateContact(string name, string surname, int connectedCompanyId, int userId,
            int phoneNumber = 0, string emailAddress = "", string stanowisko = "")
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.CreateContact(new PracowniaProgramowaniaServer.CreateContactRequest()
            {
                Name = name,
                Surname = surname,
                ConnectedCompanyId = connectedCompanyId,
                UserAddingContactId = userId,
                PhoneNumber = phoneNumber,
                EmailAddress = emailAddress,
                Position = stanowisko
            });
        }

        public PracowniaProgramowaniaServer.DeleteContactReply DeleteContact(int contactId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.DeleteContact(new PracowniaProgramowaniaServer.DeleteContactRequest() { ContactId = contactId });
        }

        public PracowniaProgramowaniaServer.ReadAllContactsReply ReadAllContacts()
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadAllContacts(new PracowniaProgramowaniaServer.ReadAllContactsRequest());
        }

        public PracowniaProgramowaniaServer.ReadContactReply ReadContact(int contactId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadContact(new PracowniaProgramowaniaServer.ReadContactRequest() { Id = contactId });
        }

        public PracowniaProgramowaniaServer.UpdateContactReply UpdateContact(int contactId, string name = "", string surname = "", int phoneNumber = 0, string position = "", string emailAddress = "")
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.UpdateContact(new PracowniaProgramowaniaServer.UpdateContactRequest()
            {
                ContactId = contactId,
                Name = name,
                Surname = surname,
                PhoneNumber = phoneNumber,
                Position = position,
                EmailAddress = emailAddress
            });
        }

        public PracowniaProgramowaniaServer.CreateCompanyReply CreateCompany(string companyName, int brandId, int userId, string nip = "", string address = "")
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.CreateCompany(new PracowniaProgramowaniaServer.CreateCompanyRequest()
            {
                CompanyName = companyName,
                BrandId = brandId,
                UserAddingCompanyId = userId,
                Nip = nip,
                Address = address
            });
        }

        public PracowniaProgramowaniaServer.DeleteCompanyReply DeleteCompany(int companyId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.DeleteCompany(new PracowniaProgramowaniaServer.DeleteCompanyRequest() { CompanyId = companyId });
        }

        public PracowniaProgramowaniaServer.ReadAllCompaniesReply ReadAllCompanies()
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadAllCompanies(new PracowniaProgramowaniaServer.ReadAllCompaniesRequest());
        }

        public PracowniaProgramowaniaServer.ReadCompanyReply ReadCompany(int companyId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadCompany(new PracowniaProgramowaniaServer.ReadCompanyRequest() { CompanyId = companyId });
        }

        public PracowniaProgramowaniaServer.UpdateCompanyReply UpdateCompany(int companyId, string companyName = "", string nip = "", string address = "")
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.UpdateCompany(new PracowniaProgramowaniaServer.UpdateCompanyRequest()
            {
                Id = companyId,
                CompanyName = companyName,
                Nip = nip,
                Address = address
            });
        }

        public PracowniaProgramowaniaServer.CreateUserReply CreateUser(string login, string password, int roleId, string name = "", string surname = "", string dateOfBirth = "")
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.CreateUser(new PracowniaProgramowaniaServer.CreateUserRequest() { Login = login, Password = password, RoleID = roleId, Name = name, Surname = surname, DateOfBirth = dateOfBirth });
        }

        public PracowniaProgramowaniaServer.DeleteUserReply DeleteUser(int userId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.DeleteUser(new PracowniaProgramowaniaServer.DeleteUserRequest() { Id = userId });
        }

        public PracowniaProgramowaniaServer.ReadAllUsersReply ReadAllUsers()
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadAllUsers(new PracowniaProgramowaniaServer.ReadAllUsersRequest());
        }

        public PracowniaProgramowaniaServer.ReadUserReply ReadUser(int userId)
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.ReadUser(new PracowniaProgramowaniaServer.ReadUserRequest() { Id = userId });
        }

        public PracowniaProgramowaniaServer.UpdateUserReply UpdateUser(int userId, string login = "", string password = "", string name = "", string surname = "", string dateOfBirth = "")
        {
            var pPServer = new PracowniaProgramowaniaServer.PracowniaProgramowaniaServer.PracowniaProgramowaniaServerClient(Grpc.Net.Client.GrpcChannel.ForAddress(_serverServiceAddress));
            return pPServer.UpdateUser(new PracowniaProgramowaniaServer.UpdateUserRequest()
            {
                Id = userId,
                Login = login,
                Password = password,
                Name = name,
                Surname = surname,
                DateOfBirth = dateOfBirth
            });
        }
    }
}
