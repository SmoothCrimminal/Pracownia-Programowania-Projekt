using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using P.P.Database.Models;

namespace CRUD.TradeNote
{
    public class ReadTradeNote
    {
        public List<P.P.Database.Models.TradeNote> readAllTradeNotes()
        {
            using (var context = new ProjektPPContext())
            {
                var allTradeNotes = context.TradeNotes.ToList();
                return allTradeNotes;

            }
        }

        public string readTradeNote(int tradeNoteId)
        {
            using (var context = new ProjektPPContext())
            {
                var tradeNote = context.TradeNotes.Find(tradeNoteId);
                if (tradeNote != null)
                {
                    return $"{tradeNote.Id} {tradeNote.Tresc} {tradeNote.FirmaPowiazana} {tradeNote.IdUżytkownika} {tradeNote.IsDeleted}";
                }

                return "Trade Note not found";
            }
        }
    }
}
