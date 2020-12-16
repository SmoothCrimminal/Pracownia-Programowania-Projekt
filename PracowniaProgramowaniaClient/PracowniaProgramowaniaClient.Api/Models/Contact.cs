using System;
using System.Collections.Generic;

#nullable disable

namespace P.P.Database.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Telefon { get; set; }
        public string Mail { get; set; }
        public string Stanowisko { get; set; }
        public int FirmaPowiazana { get; set; }
        public int IdUżytkownika { get; set; }
        public bool? IsDeleted { get; set; }

    }
}
