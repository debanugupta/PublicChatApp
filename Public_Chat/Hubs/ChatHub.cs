using Microsoft.AspNetCore.SignalR;                                         // using this
using Public_Chat.ReqDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Public_Chat.Hubs
{
    public class ChatHub : Hub                                              // inherit this
    {
        public Task SendMessage1(MessageDto msg)               // Two parameters accepted
        {
            return Clients.All.SendAsync("ReceiveOne", msg);    // Note this 'ReceiveOne' 
        }
    }
}