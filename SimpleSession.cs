using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSession
{
    public class SimpleSession
    {
        /*

                 in future, add IPadress?
                 add Thread
                 add Timers

        */
        private string _sessionId;

        public string SessionId
        {
            get => _sessionId;
            set => _sessionId = value;
        }

        public string? Username { get; set; }

        public SimpleSession(string sessionId, string? userName)
        {
            _sessionId = sessionId;
            Username = userName;
        }
    }
}
