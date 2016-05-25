using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Comunication
{
    [Serializable]
    public abstract class TextMessage : BaseMessage
    {
        public string Text = "";
        public string NickName { get; set;  }
        public  Color Colors { get; set; }

        public DateTime time = DateTime.Now;
    }
}
