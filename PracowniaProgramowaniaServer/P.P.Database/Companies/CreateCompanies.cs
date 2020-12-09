using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Companies
{
    public class CreateCompanies
    {
        public Company CreateCompany(Company company)
        {
            
            using (var context = new ProjektPPContext())
            {
                var newCompany = context.Companies.Add(company);
                context.SaveChanges();
                return newCompany.Entity;
            }
        }
    }
}
