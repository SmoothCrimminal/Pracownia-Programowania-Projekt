using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Companies
{
    public class ReadCompanies
    {
        public List<Company> ReadAllCompanies()
        {
            using (var context = new ProjektPPContext())
            {
                var allCompanies = context.Companies.ToList();
                return allCompanies;

            }
        }

        public string ReadCompany(int companyId)
        {
            using (var context = new ProjektPPContext())
            {
                var company = context.Companies.Find(companyId);
                if (company != null)
                {
                    return $"{company.Id} {company.NazwaFirmy} {company.IdBranży} {company.IdUżytkownika} {company.Nip} " +
                        $"{company.Adres} {company.Miasto} {company.IsDeleted}";
                }

                return "Company not found";
            }
        }
    }
}
