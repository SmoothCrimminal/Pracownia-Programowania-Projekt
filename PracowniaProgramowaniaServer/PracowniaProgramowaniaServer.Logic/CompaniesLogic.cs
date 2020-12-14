using CRUD.Companies;
using P.P.Database.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace PracowniaProgramowaniaServer.Logic
{
    public class CompaniesLogic
    {
        public Company CreateCompany(string companyName, int brandId, int userId, string nip = "", string address = "")
        {
            var dbCreateCompany = new CreateCompanies();
            return dbCreateCompany.CreateCompany(new Company()
            {
                CompanyName = companyName,
                Nip = nip,
                BrandId = brandId,
                UserId = userId,
                Address = address,
                IsDeleted = false
            });
        }

        public string DeleteCompany(int companyId)
        {
            var dbDeleteCompany = new DeleteCompanies();
            return dbDeleteCompany.DeleteCompany(companyId);
        }

        public List<Company> ReadAllCompanies()
        {
            var dbReadAllCompanies = new ReadCompanies();
            return dbReadAllCompanies.ReadAllCompanies();
        }

        public string ReadCompany(int companyId)
        {
            var dbReadCompany = new ReadCompanies();
            return dbReadCompany.ReadCompany(companyId);
        }

        public string UpdateCompany(int companyId, string companyName = "", string nip = "", string address = "")
        {
            var dbUpdateCompany = new UpdateCompanies();
            return dbUpdateCompany.UpdateCompany(companyId, companyName, nip, address);
        }
    }

}
