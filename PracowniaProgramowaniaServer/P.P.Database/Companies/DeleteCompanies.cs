using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Companies
{
    public class DeleteCompanies
    {
        public string DeleteCompany(int companyId)
        {
            using (var context = new ProjektPPContext())
            {
                var company = context.Companies.Find(companyId);
                if ((company != null) && ((bool)company.IsDeleted == false))
                {
                    company.IsDeleted = true;
                    return "Company Successfully deleted";
                }

                else if ((company != null) && ((bool)company.IsDeleted == true))
                {
                    return "Company with this id already has been deleted";
                }

                context.SaveChanges();

                return "Company Not Found";

            }
        }
    }
}
