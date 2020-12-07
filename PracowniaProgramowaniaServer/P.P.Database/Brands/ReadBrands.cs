using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using P.P.Database.Models;

namespace CRUD.Brands
{
    public class ReadBrands
    {
      /*  public IEnumerable<Brand> ReadAllBrands()
        {
            using (var context = new ProjektPPContext())
            {
                var allBrands = context.Brands.ToList();
                return allBrands;
                
            }
        } */

        public string ReadBrand(int brandId)
        {
            using (var context = new ProjektPPContext())
            {
                var brand = context.Brands.Find(brandId);
                if (brand != null)
                {
                    return $"{brand.Id} {brand.NazwaBranzy}";
                }

                return "Brand not found";
            }

        }

    }
}
