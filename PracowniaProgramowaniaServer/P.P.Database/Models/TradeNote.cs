using System;
using System.Collections.Generic;

#nullable disable

namespace P.P.Database.Models
{
    public partial class TradeNote
    {
        public int Id { get; set; }
        public string Tresc { get; set; }
        public bool? IsDeleted { get; set; }
        public int FirmaPowiazana { get; set; }
        public int IdUżytkownika { get; set; }

        public virtual Company FirmaPowiazanaNavigation { get; set; }
        public virtual User IdUżytkownikaNavigation { get; set; }
    }
}
