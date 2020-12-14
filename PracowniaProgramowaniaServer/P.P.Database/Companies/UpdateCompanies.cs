using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Companies
{
    public class UpdateCompanies
    {
        public string UpdateCompany(int companyId, string companyName="", string nip = "", string address = "")
        {
            using (var context = new ProjektPPContext())
            {
                var companyToUpdate = context.Companies.Find(companyId);
                if ((companyToUpdate != null) && ((bool)companyToUpdate.IsDeleted == false))
                {
                    if (companyName != "")
                        companyToUpdate.CompanyName = companyName;
                    if (nip != "")
                        companyToUpdate.Nip = nip;
                    if (address != "")
                        companyToUpdate.Address = address;

                    context.SaveChanges();
                    return $"{companyToUpdate.Id} {companyToUpdate.CompanyName} {companyToUpdate.BrandId} {companyToUpdate.UserId} " +
                        $"{companyToUpdate.Nip} {companyToUpdate.Address}";
                }

                return "Company with such id not found in database or has been deleted";
            }
        }
    }
}
