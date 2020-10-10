using Microsoft.AspNetCore.SignalR;                                         // using this
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Public_Chat.Hubs
{
    public class ChatHub : Hub                                              // inherit this
    {
        public Task SendMessage1(string user, string message, DateTime date)               // Two parameters accepted
        {
            return Clients.All.SendAsync("ReceiveOne", user, message, date);    // Note this 'ReceiveOne' 
        }
    }
}