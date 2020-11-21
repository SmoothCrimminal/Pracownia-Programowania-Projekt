using P.P.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Brands
{
    public class CreateBrands
    {
        public Brand CreateBrand(Brand brand)
        {
            using (var context = new masterContext())
            {
               var test = context.Brands.Add(brand);
                context.SaveChanges();
                return test.Entity;
            };
            
        }
    }
}
