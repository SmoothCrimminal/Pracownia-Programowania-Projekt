using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.TradeNote
{
    public class CreateTradeNote
    {
        public P.P.Database.Models.TradeNote CreateNote(P.P.Database.Models.TradeNote tradeNote)
        {
            using (var context = new ProjektPPContext())
            {
                var newNote = context.TradeNotes.Add(tradeNote);
                context.SaveChanges();
                return newNote.Entity;
            }
        }
        
    }
}
