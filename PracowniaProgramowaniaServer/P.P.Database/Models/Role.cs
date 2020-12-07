using System;
using System.Collections.Generic;

#nullable disable

namespace P.P.Database.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string NazwaRoli { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
