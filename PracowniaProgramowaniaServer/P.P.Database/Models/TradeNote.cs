using System;
using System.Collections.Generic;

#nullable disable

namespace P.P.Database.Models
{
    public partial class Tradenote
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsDeleted { get; set; }
        public int CompanyId { get; set; }
        public int UserId { get; set; }
    }
}
