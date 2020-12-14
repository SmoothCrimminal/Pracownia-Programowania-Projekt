using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.TradeNote
{
    public class CreateTradeNote
    {
        public Tradenote CreateNote(P.P.Database.Models.Tradenote tradeNote)
        {
            using (var context = new ProjektPPContext())
            {
                var newNote = context.Tradenotes.Add(tradeNote);
                context.SaveChanges();
                return newNote.Entity;
            }
        }
        
    }
}
