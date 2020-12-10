using PracowniaProgramowaniaClient.Api.Models;
using System;
using System.Collections.Generic;

#nullable disable

namespace P.P.Database.Models
{
    public partial class User
    {
        public User()
        {
            Companies = new HashSet<Company>();
            Contacts = new HashSet<Contact>();
            TradeNotes = new HashSet<TradeNote>();
        }

        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Login { get; set; }
        public string PasswordMd5 { get; set; }
        public int IdRoli { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Role IdRoliNavigation { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<TradeNote> TradeNotes { get; set; }
    }
}
