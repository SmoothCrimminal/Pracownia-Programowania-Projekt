using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using PracowniaProgramowaniaServer.Logic;
using Google.Protobuf.Collections;
using P.P.Database.Models;

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
            var newBrand = brandsLogic.CreateBrand(request.BrandName); // tworzymy zmienn� newBrand typu BrandsLogic kt�rej przypisujemy z requesta BrandName

            return Task.FromResult(new CreateBrandReply()
            {
                BrandId = newBrand.Id,
                BrandName = newBrand.BrandName   // zwracamy w odpowiedzi ID i Nazw�Bran�y
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

        public override Task<ReadAllBrandsReply> ReadAllBrands(ReadAllBrandsRequest request, ServerCallContext context)
        {
            var brandsLogic = new BrandsLogic();
            var readAllBrands = brandsLogic.ReadAllBrands();
            var allBrandsReply = new ReadAllBrandsReply();
            foreach(Brand brand in readAllBrands)
            {
                allBrandsReply.AllBrands.Add(new BrandField { Id = brand.Id, BrandName = brand.BrandName });
            }

            return Task.FromResult(allBrandsReply);
        }

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
            var updateBrand = brandsLogic.UpdateBrand(request.UpdateBrand.Id, request.UpdateBrand.BrandName);
            return Task.FromResult(new UpdateBrandReply()
            {
                UpdatedBrand = updateBrand
            });
        }



        public override Task<CreateRoleReply> CreateRole(CreateRoleRequest request, ServerCallContext context)
        {
            var rolesLogic = new RolesLogic(); 
            var newRole = rolesLogic.CreateRole(request.RoleName);
            return Task.FromResult(new CreateRoleReply()
            {
                RoleId = newRole.Id,
                RoleName = newRole.RoleName 
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

        public override Task<ReadAllRolesReply> ReadAllRoles(ReadAllRolesRequest request, ServerCallContext context)
        {
            var rolesLogic = new RolesLogic();
            var readAllRoles = rolesLogic.ReadAllRoles();
            var allRolesReply = new ReadAllRolesReply();

            foreach (Role role in readAllRoles)
            {
                allRolesReply.AllRoles.Add(new RoleField { Id = role.Id, RoleName = role.RoleName });
            }

            return Task.FromResult(allRolesReply);

        }

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
            var updateRole = rolesLogic.UpdateRole(request.Role.Id, request.Role.RoleName);
            return Task.FromResult(new UpdateRoleReply()
            {
                UpdatedRole = updateRole
            });
        }


        public override Task<CreateTradeNoteReply> CreateTradeNote(CreateTradeNoteRequest request, ServerCallContext context)
        {
            var tradeNotesLogic = new TradeNotesLogic();
            var newTradeNote = tradeNotesLogic.CreateTradeNote(request.TradeNote.Content, request.TradeNote.ConnectedCompanyId, request.TradeNote.UserAddingNoteId);
            TradeNoteField tradeNote = new TradeNoteField();
            tradeNote.Id = newTradeNote.Id;
            tradeNote.Content = newTradeNote.Content;
            tradeNote.ConnectedCompanyId = newTradeNote.CompanyId;
            tradeNote.UserAddingNoteId = newTradeNote.UserId;
            return Task.FromResult(new CreateTradeNoteReply()
            {
                NewNote = tradeNote
            });
        }

        public override Task<DeleteTradeNoteReply> DeleteTradeNote(DeleteTradeNoteRequest request, ServerCallContext context)
        {
            var tradeNotesLogic = new TradeNotesLogic();
            var deleteTradeNote = tradeNotesLogic.DeleteTradeNote(request.TradeNoteId);
            return Task.FromResult(new DeleteTradeNoteReply()
            {
                Message = deleteTradeNote
            });
        }

        public override Task<ReadAllTradeNotesReply> ReadAllTradeNotes(ReadAllTradeNotesRequest request, ServerCallContext context)
        {
            var tradeNotesLogic = new TradeNotesLogic();
            var readAllTradeNotes = tradeNotesLogic.ReadAllTradeNotes();
            var allTradNotesReply = new ReadAllTradeNotesReply();
            foreach (Tradenote tradeNote in readAllTradeNotes)
            {
                allTradNotesReply.ReadAllTradeNotes.Add(new TradeNoteField { Id = tradeNote.Id, Content = tradeNote.Content, ConnectedCompanyId
                = tradeNote.CompanyId, UserAddingNoteId = tradeNote.UserId, IsDeleted = (bool)tradeNote.IsDeleted});
            }

            return Task.FromResult(allTradNotesReply);
        }

        public override Task<ReadTradeNoteReply> ReadTradeNote(ReadTradeNoteRequest request, ServerCallContext context)
        {
            var tradeNotesLogic = new TradeNotesLogic();
            var readTradeNote = tradeNotesLogic.ReadTradeNote(request.TradeNoteId);
            return Task.FromResult(new ReadTradeNoteReply()
            {
                TradeNoteDetails = readTradeNote
            });
        }

        public override Task<UpdateTradeNoteReply> UpdateTradeNote(UpdateTradeNoteRequest request, ServerCallContext context)
        {
            var tradeNotesLogic = new TradeNotesLogic();
            var updateTradeNote = tradeNotesLogic.UpdateTradeNote(request.TradeNote.Id, request.TradeNote.Content);
            return Task.FromResult(new UpdateTradeNoteReply()
            {
                UpdatedTradeNote = updateTradeNote
            });
        }



        public override Task<CreateContactReply> CreateContact(CreateContactRequest request, ServerCallContext context) 
        {
            var contactsLogic = new ContactsLogic();
            var newContact = contactsLogic.CreateContact(request.Contact.Name, request.Contact.Surname,
                request.Contact.ConnectedCompanyId, request.Contact.UserAddingContactId, request.Contact.PhoneNumber,
                request.Contact.EmailAddress, request.Contact.Position);
            ContactField contact = new ContactField();
            contact.Name = newContact.Name;
            contact.Surname = newContact.Surname;
            contact.ConnectedCompanyId = newContact.CompanyId;
            contact.UserAddingContactId = newContact.UserId;
            contact.PhoneNumber = newContact.PhoneNumber;
            contact.EmailAddress = newContact.Mail;
            contact.Position = newContact.Position;

            return Task.FromResult(new CreateContactReply()
            {
                NewContact = contact
            });
        
        }

        public override Task<DeleteContactReply> DeleteContact(DeleteContactRequest request, ServerCallContext context)
        {
            var contactsLogic = new ContactsLogic();
            var deleteContat = contactsLogic.DeleteContact(request.ContactId);
            return Task.FromResult(new DeleteContactReply()
            {
                Message = deleteContat
            });
        }

        public override Task<ReadAllContactsReply> ReadAllContacts(ReadAllContactsRequest request, ServerCallContext context)
        {
            var contactsLogic = new ContactsLogic();
            var readAllContacts = contactsLogic.ReadAllContacts();
            var readAllContactsReply = new ReadAllContactsReply();
            
            foreach(Contact contact in readAllContacts)
            {
                readAllContactsReply.AllContacts.Add(new ContactField
                {
                    Id = contact.Id,
                    Name = contact.Name,
                    Surname = contact.Surname,
                    ConnectedCompanyId = contact.CompanyId,
                    UserAddingContactId = contact.UserId,
                    Position = contact.Position,
                    PhoneNumber = contact.PhoneNumber,
                    EmailAddress = contact.Mail,
                    IsDeleted = (bool)contact.IsDeleted
                });
            }

            return Task.FromResult(readAllContactsReply);
        }

        public override Task<ReadContactReply> ReadContact(ReadContactRequest request, ServerCallContext context)
        {
            var contactsLogic = new ContactsLogic();
            var readAllContacts = contactsLogic.ReadContact(request.Id);
            return Task.FromResult(new ReadContactReply()
            {
                ContactDetails = readAllContacts
            });
        }

        public override Task<UpdateContactReply> UpdateContact(UpdateContactRequest request, ServerCallContext context)
        {
            var contactsLogic = new ContactsLogic();
            var updateContact = contactsLogic.UpdateContact(request.Contact.Id, request.Contact.Name, request.Contact.Surname,
                request.Contact.PhoneNumber, request.Contact.Position, request.Contact.EmailAddress);

            return Task.FromResult(new UpdateContactReply()
            {
                UpdatedContact = updateContact
            });
        }



        public override Task<CreateCompanyReply> CreateCompany(CreateCompanyRequest request, ServerCallContext context)
        {
            var companiesLogic = new CompaniesLogic();
            var newCompany = companiesLogic.CreateCompany(request.Company.CompanyName, request.Company.BrandId,
                request.Company.UserAddingCompanyId, request.Company.Nip, request.Company.Address);
            CompanyField company = new CompanyField();
            company.CompanyName = newCompany.CompanyName;
            company.BrandId = newCompany.BrandId;
            company.UserAddingCompanyId = newCompany.UserId;
            company.Nip = newCompany.Nip;
            company.Address = newCompany.Address;
            return Task.FromResult(new CreateCompanyReply()
            {
                NewCompany = company
            });
        }

        public override Task<DeleteCompanyReply> DeleteCompany(DeleteCompanyRequest request, ServerCallContext context)
        {
            var companiesLogic = new CompaniesLogic();
            var deleteCompany = companiesLogic.DeleteCompany(request.CompanyId);
            return Task.FromResult(new DeleteCompanyReply() { Message = deleteCompany });
        }

        public override Task<ReadAllCompaniesReply> ReadAllCompanies(ReadAllCompaniesRequest request, ServerCallContext context)
        {
            var companiesLogic = new CompaniesLogic();
            var readAllCompanies = companiesLogic.ReadAllCompanies();
            var readAllCompaniesReply = new ReadAllCompaniesReply();
            
            foreach (Company company in readAllCompanies)
            {
                readAllCompaniesReply.ReadAllCompanies.Add(new CompanyField
                {
                    Id = company.Id,
                    CompanyName = company.CompanyName,
                    BrandId = (int)company.BrandId,
                    UserAddingCompanyId = company.UserId,
                    Nip = company.Nip,
                    Address = company.Address,
                    IsDeleted = (bool) company.IsDeleted
                });
            }
            return Task.FromResult(readAllCompaniesReply);
        }

        public override Task<ReadCompanyReply> ReadCompany(ReadCompanyRequest request, ServerCallContext context)
        {
            var companiesLogic = new CompaniesLogic();
            var readCompany = companiesLogic.ReadCompany(request.CompanyId);
            return Task.FromResult(new ReadCompanyReply { CompanyDetails = readCompany });
        }

        public override Task<UpdateCompanyReply> UpdateCompany(UpdateCompanyRequest request, ServerCallContext context)
        {
            var companiesLogic = new CompaniesLogic();
            var updateCompany = companiesLogic.UpdateCompany(request.Company.Id, request.Company.CompanyName, 
                request.Company.Nip, request.Company.Address);
            return Task.FromResult(new UpdateCompanyReply { UpdatedCompany = updateCompany });
        }


        public override Task<CreateUserReply> CreateUser(CreateUserRequest request, ServerCallContext context)
        {
            var usersLogic = new UsersLogic();
            var newUser = usersLogic.CreateUser(request.User.Login, request.User.Password, request.User.RoleID, request.User.Name, request.User.Surname,
                request.User.DateOfBirth);
            UserField grpcUser = new UserField();
            grpcUser.Id = newUser.Id;
            grpcUser.Login = newUser.Login;
            grpcUser.Password = newUser.PasswordMd5;
            grpcUser.Name = newUser.Name;
            grpcUser.RoleID = newUser.RoleId;
            grpcUser.Surname = newUser.Surname;
            grpcUser.DateOfBirth = newUser.DateOfBirth.ToString();
            grpcUser.IsDeleted = newUser.IsDeleted;
            return Task.FromResult(new CreateUserReply()
            {
                NewUser = grpcUser
            });
        }

        public override Task<DeleteUserReply> DeleteUser(DeleteUserRequest request, ServerCallContext context)
        {
            var usersLogic = new UsersLogic();
            var deleteUser = usersLogic.DeleteUser(request.Id);
            return Task.FromResult(new DeleteUserReply { Message = deleteUser });
        }

        public override Task<ReadAllUsersReply> ReadAllUsers(ReadAllUsersRequest request, ServerCallContext context)
        {
            var usersLogic = new UsersLogic();
            var readAllUsers = usersLogic.ReadAllUsers();
            var readAllUsersReply = new ReadAllUsersReply();

            foreach (User user in readAllUsers)
            {
                readAllUsersReply.ReadAllUsers.Add(new UserField
                {
                    Id = user.Id,
                    Login = user.Login,
                    RoleID = user.RoleId,
                    IsDeleted = (bool)user.IsDeleted
                });
            }

            return Task.FromResult(readAllUsersReply);
        }

        public override Task<ReadUserReply> ReadUser(ReadUserRequest request, ServerCallContext context)
        {
            var usersLogic = new UsersLogic();
            var readUser = usersLogic.ReadUser(request.Id);
            return Task.FromResult(new ReadUserReply { UserDetails = readUser });
        }

        public override Task<UpdateUserReply> UpdateUser(UpdateUserRequest request, ServerCallContext context)
        {
            var usersLogic = new UsersLogic();
            var updateUser = usersLogic.UpdateUser(request.User.Id, request.User.Login, request.User.Password,
                request.User.Name, request.User.Surname, request.User.DateOfBirth);
            return Task.FromResult(new UpdateUserReply()
            {
                UpdatedUser = updateUser
            });
        }
    }
}
