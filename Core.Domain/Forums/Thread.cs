using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Planboard;

namespace Core.Domain.Forums
{
    public class Thread
    {
        public ITicket Ticket;
        public List<Messages> Messages;

        public Thread(ITicket ticket)
        {
            Ticket = ticket;
            Messages = new List<Messages>();
        }

    }
}
