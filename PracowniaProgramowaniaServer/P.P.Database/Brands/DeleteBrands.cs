using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Brands
{
    public class DeleteBrands
    {
        public bool DeleteBrand(int brandId) 
        {
            using (var context = new ProjektPPContext()) 
            {
                var brand = context.Brands.Find(brandId);
                if (brand != null)
                {
                    context.Remove(brand);
                    context.SaveChanges();
                    return true;
                }

                return false;

            };

        }

    }
}
