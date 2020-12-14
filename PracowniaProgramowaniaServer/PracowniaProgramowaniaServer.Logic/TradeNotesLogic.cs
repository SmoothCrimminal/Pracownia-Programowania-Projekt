using CRUD.TradeNote;
using P.P.Database.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace PracowniaProgramowaniaServer.Logic
{
    public class TradeNotesLogic
    {
        public Tradenote CreateTradeNote(string content, int companyId, int userId)
        {
            var dbCreateTradeNote = new CreateTradeNote();
            return dbCreateTradeNote.CreateNote(new Tradenote() { Content = content, CompanyId = companyId, UserId = userId, IsDeleted = false });
        }

        public string DeleteTradeNote(int tradeNoteid)
        {
            var dbDeleteTradeNote = new DeleteTradeNote();
            return dbDeleteTradeNote.DeleteNote(tradeNoteid);
        }

        public List<Tradenote> ReadAllTradeNotes()
        {
            var dbReadAllTradeNotes = new ReadTradeNote();
            return dbReadAllTradeNotes.readAllTradeNotes();
        }

        public string ReadTradeNote(int tradeNoteId)
        {
            var dbReadTradeNote = new ReadTradeNote();
            return dbReadTradeNote.readTradeNote(tradeNoteId);
        }

        public string UpdateTradeNote(int tradeNoteId, string content)
        {
            var dbUpdateTradeNote = new UpdateTradeNote();
            return dbUpdateTradeNote.UpdateNote(tradeNoteId, content);
        }

    }
}
