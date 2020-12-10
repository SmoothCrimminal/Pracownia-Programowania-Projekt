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

        [HttpGet]
        [Route("create/{content} {companyId} {userAddingNoteID}")]
        public TradeNote CreateTradeNote(string content, int companyId, int userAddingNoteId)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.CreateTrade(content, companyId, userAddingNoteId);
            return new TradeNote() { Id = reply.TradeNoteId, Tresc = reply.TradeNoteContent, FirmaPowiazana = reply.ConnectedCompanyId,
            IdUżytkownika = userAddingNoteId};
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

        [HttpGet]
        [Route("update/{tradeNoteId} {content}")]
        public string UpdateTradeNote(int tradeNoteId, string content)
        {
            var remote = new ServerServiceRemote(_serverServiceAddress);
            var reply = remote.UpdateTrade(tradeNoteId, content);
            return reply.UpdatedTradeNote;

        }
    }
}
