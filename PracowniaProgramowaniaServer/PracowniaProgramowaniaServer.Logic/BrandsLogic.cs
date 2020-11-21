using CRUD.Brands;
using P.P.Database.Models;
using System;

namespace PracowniaProgramowaniaServer.Logic
{
    public class BrandsLogic
    { 
        public Brand CreateBrand(string brandName)
        {
            var dbCreateBrand = new CreateBrands();
            return dbCreateBrand.CreateBrand(new Brand() { NazwaBranzy = brandName });
        }
    }
}
