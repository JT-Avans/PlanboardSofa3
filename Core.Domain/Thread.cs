using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Thread
    {
        public ITicket Ticket;
        public List<Messages> Messages;

        public Thread(ITicket ticket)
        {
            this.Ticket = ticket;
            Messages = new List<Messages>();
        }

    }
}
