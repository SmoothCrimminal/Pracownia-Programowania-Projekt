using P.P.Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Brands
{
    public class CreateBrands
    {
        public Brand CreateBrand(Brand brand) // metoda modelu Brand tworząca obiekt typu Brand
        {
            using (var context = new ProjektPPContext()) // używamy using ponieważ okres istnienia obiektu jest ograniczony do pojedynczej metody
            {
                var test = context.Brands.Add(brand);
                context.SaveChanges() ; // dzięki metodzie using po zapisaniu i zakończeniu metody na zmiennej context wykona się Dispose
                return test.Entity;
                
            };
            
        }
    }
}
