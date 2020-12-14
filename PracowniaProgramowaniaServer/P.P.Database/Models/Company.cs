using System;
using System.Collections.Generic;

#nullable disable

namespace P.P.Database.Models
{
    public partial class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Nip { get; set; }
        public int BrandId { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
