using System;
using System.Collections.Generic;

#nullable disable

namespace P.P.Database.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string Position { get; set; }
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
