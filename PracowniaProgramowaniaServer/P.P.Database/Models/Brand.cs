using System;
using System.Collections.Generic;

#nullable disable

namespace P.P.Database.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Companies = new HashSet<Company>();
        }

        public int Id { get; set; }
        public string NazwaBranzy { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
    }
}
