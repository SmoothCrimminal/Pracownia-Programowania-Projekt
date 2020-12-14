using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Brands
{
    public class UpdateBrands
    {
        public string UpdateBrand(int brandId, string brandName)
        {
            using (var context = new ProjektPPContext())
            {
                var brandToUpdate = context.Brands.Find(brandId);
                if (brandToUpdate != null)
                {
                    brandToUpdate.BrandName = brandName;
                    context.SaveChanges();
                    return $"{brandToUpdate.Id} {brandToUpdate.BrandName}";
                }

                return "Brand with such id not found in database.";
            }
        }
    }
}
