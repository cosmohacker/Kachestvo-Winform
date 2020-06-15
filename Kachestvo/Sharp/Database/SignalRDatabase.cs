using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Kachestvo.Sharp.Database
{
    [HubName("kachestvoDatabaseHub")]
    public class SignalRDatabase : Hub
    {

        public void sendNextPrompt(string next)
        {
            Clients.All.addNextPrompt(next);
        }

    }
}
