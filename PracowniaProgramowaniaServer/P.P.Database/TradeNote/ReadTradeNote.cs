using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using P.P.Database.Models;

namespace CRUD.TradeNote
{
    public class ReadTradeNote
    {
        public List<P.P.Database.Models.Tradenote> readAllTradeNotes()
        {
            using (var context = new ProjektPPContext())
            {
                var allTradeNotes = context.Tradenotes.ToList();
                return allTradeNotes;

            }
        }

        public string readTradeNote(int tradeNoteId)
        {
            using (var context = new ProjektPPContext())
            {
                var tradeNote = context.Tradenotes.Find(tradeNoteId);
                if (tradeNote != null)
                {
                    return $"{tradeNote.Id} {tradeNote.Content} {tradeNote.CompanyId} {tradeNote.UserId} {tradeNote.IsDeleted}";
                }

                return "Trade Note not found";
            }
        }
    }
}
