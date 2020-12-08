using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.TradeNote
{
    public class UpdateTradeNote
    {
        public string UpdateNote(int tradeNoteId, string content)
        {
            using (var context = new ProjektPPContext())
            {
                var tradeNoteToUpdate = context.TradeNotes.Find(tradeNoteId);
                if ((tradeNoteToUpdate != null) && ( (bool) tradeNoteToUpdate.IsDeleted == false))
                {                   
                   tradeNoteToUpdate.Tresc = content;
         
                   context.SaveChanges();
                   return $"{tradeNoteToUpdate.Id} {tradeNoteToUpdate.Tresc} {tradeNoteToUpdate.FirmaPowiazana}";
                }

                return "Trade Note with such id not found in database or has been deleted";
            }
        }
    }
}
