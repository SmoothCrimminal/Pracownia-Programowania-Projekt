using CRUD.Brands;
using P.P.Database.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace PracowniaProgramowaniaServer.Logic
{
    public class BrandsLogic
    { 
        public Brand CreateBrand(string brandName) // metoda przyjmuje string name
        {
            var dbCreateBrand = new CreateBrands(); // tworzy obiekt CreateBrands
            return dbCreateBrand.CreateBrand(new Brand() { NazwaBranzy = brandName }); // zwraca instancję obiektu z nazwą podaną w stringu brandName
        }

        public bool DeleteBrand(int brandId)
        {
            var dbDeleteBrand = new DeleteBrands();
            return dbDeleteBrand.DeleteBrand(brandId);
        }

         public List<Brand> ReadAllBrands()
        {
            var dbReadAllBrands = new ReadBrands();
            return dbReadAllBrands.ReadAllBrands();
        } 

        public string ReadBrand(int brandId)
        {
            var dbReadBrand = new ReadBrands();
            return dbReadBrand.ReadBrand(brandId);
        }

        public string UpdateBrand(int brandId, string brandName)
        {
            var dbUpdateBrand = new UpdateBrands();
            return dbUpdateBrand.UpdateBrand(brandId, brandName);
        }
    }
}
