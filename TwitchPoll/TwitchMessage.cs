using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchPoll
{
    public class TwitchMessage
    {
        public string PlayerName { get; set; }
        public string Message { get; set; }


        public TwitchMessage(string message, string playerName)
        {
            Message = message;
            PlayerName = playerName;
        }
    }
}
