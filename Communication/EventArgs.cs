using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunication
{
    [Serializable]
    public class MessageEventArgs
    {
        public readonly BaseMessage Message;

        public MessageEventArgs(BaseMessage message)
        {
            Message = message;
        }
    }
    [Serializable]
    public class GotRegisterdEventArgs
    {
        public readonly BaseMessage Message;

        public GotRegisterdEventArgs(BaseMessage message)
        {
            Message = message;
        }
    }
   
}
