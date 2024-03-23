using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Messages
    {
        public User User { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }

        public Messages(User user, string message)
        {
            this.User = user;
            this.Message = message;
            this.DateTime = DateTime.Now;
        }
    }
}
