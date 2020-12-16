using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PracowniaProgramowaniaClient.Api.Models;
using PracowniaProgramowaniaClient.ServerRemote;
using Google.Protobuf.Collections;
using PracowniaProgramowaniaServer;
using P.P.Database.Models;

namespace PracowniaProgramowaniaClient.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TradeNotesController : ControllerBase
    {

        string _serverServiceAddress;

        public TradeNotesController(IConfiguration configuration)
        {
            _serverServiceAddress = configuration.GetValue<string>("ServerServiceAddress");
        }

        [HttpPost]
        [Route("create")]
        public TradeNote CreateTradeNote(TradeNoteField tradeNote)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.CreateTrade(tradeNote);
            return new TradeNote()
            {
                Id = reply.NewNote.Id,
                Tresc = reply.NewNote.Content,
                FirmaPowiazana = reply.NewNote.ConnectedCompanyId,
                IdUżytkownika = reply.NewNote.UserAddingNoteId
            };
        }

        [HttpGet]
        [Route("delete/{tradeNoteId}")]
        public string DeleteTradeNote(int tradeNoteId)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.DeleteTradeNote(tradeNoteId);
          
            return reply.Message;
            
        }

        [HttpGet]
        [Route("read")]

        public RepeatedField<TradeNoteField> ReadAllNotes()
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.ReadAllTradeNotes();
            return reply.ReadAllTradeNotes;
        }

        [HttpGet]
        [Route("read/{tradeNoteId}")]
        public string ReadRole(int roleId)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.ReadRole(roleId);
            return reply.RoleDetails;
        }

        [HttpPost]
        [Route("update")]
        public string UpdateTradeNote(TradeNoteField tradeNote)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.UpdateTrade(tradeNote);
            return reply.UpdatedTradeNote;

        }
    }
}
