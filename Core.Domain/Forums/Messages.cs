using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Forums
{
    public class Messages
    {
        public User User { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }

        public Messages(User user, string message)
        {
            User = user;
            Message = message;
            DateTime = DateTime.Now;
        }
    }
}
