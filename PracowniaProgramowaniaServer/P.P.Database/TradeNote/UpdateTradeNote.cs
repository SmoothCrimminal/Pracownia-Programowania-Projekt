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
                var tradeNoteToUpdate = context.Tradenotes.Find(tradeNoteId);
                if ((tradeNoteToUpdate != null) && ( (bool) tradeNoteToUpdate.IsDeleted == false))
                {                   
                   tradeNoteToUpdate.Content = content;
         
                   context.SaveChanges();
                   return $"{tradeNoteToUpdate.Id} {tradeNoteToUpdate.Content} {tradeNoteToUpdate.CompanyId}";
                }

                return "Trade Note with such id not found in database or has been deleted";
            }
        }
    }
}
