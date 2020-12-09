using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Companies
{
    public class UpdateCompanies
    {
        public string UpdateCompany(int companyId, string companyName="", string nip = "", string address = "", string city = "")
        {
            using (var context = new ProjektPPContext())
            {
                var companyToUpdate = context.Companies.Find(companyId);
                if ((companyToUpdate != null) && ((bool)companyToUpdate.IsDeleted == false))
                {
                    if (companyName != "")
                        companyToUpdate.NazwaFirmy = companyName;
                    if (nip != "")
                        companyToUpdate.Nip = nip;
                    if (address != "")
                        companyToUpdate.Adres = address;
                    if (city != "")
                        companyToUpdate.Miasto = city;

                    context.SaveChanges();
                    return $"{companyToUpdate.Id} {companyToUpdate.NazwaFirmy} {companyToUpdate.IdBranży} {companyToUpdate.IdUżytkownika} " +
                        $"{companyToUpdate.Nip} {companyToUpdate.Adres} {companyToUpdate.Miasto}";
                }

                return "Company with such id not found in database or has been deleted";
            }
        }
    }
}
