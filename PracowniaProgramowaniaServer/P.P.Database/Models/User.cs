using System;
using System.Collections.Generic;

#nullable disable

namespace P.P.Database.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Login { get; set; }
        public string PasswordMd5 { get; set; }
        public int RoleId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
