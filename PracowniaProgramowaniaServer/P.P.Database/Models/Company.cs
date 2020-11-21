using System;
using System.Collections.Generic;

#nullable disable

namespace P.P.Database.Models
{
    public partial class Company
    {
        public Company()
        {
            Contacts = new HashSet<Contact>();
            TradeNotes = new HashSet<TradeNote>();
        }

        public int Id { get; set; }
        public string NazwaFirmy { get; set; }
        public string Nip { get; set; }
        public int? IdBranży { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }
        public int IdUżytkownika { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual User IdUżytkownikaNavigation { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<TradeNote> TradeNotes { get; set; }
    }
}
