using System;
using System.Collections.Generic;
using System.Text;
using P.P.Database.Models;

namespace CRUD.TradeNote
{
    public class DeleteTradeNote
    {
        public string DeleteNote(int noteId)
        {
            using (var context = new ProjektPPContext())
            {
                var note = context.Tradenotes.Find(noteId);
                if ((note != null) && ( (bool) note.IsDeleted == false)) 
                {
                    note.IsDeleted = true;
                    return "Trade Note Successfully deleted";
                }

                else if ((note != null) && ( (bool) note.IsDeleted == true))
                {
                    return "Note with this id already has been deleted";
                }

                context.SaveChanges();

                return "Trade Note Not Found";
            }
        } 
    }
}
