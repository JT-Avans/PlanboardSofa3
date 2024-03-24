using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Forums
{
    public class Message
    {
        public User User { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }

        public Message(User user, string text)
        {
            User = user;
            Text = text;
            DateTime = DateTime.Now;
        }
    }
}
