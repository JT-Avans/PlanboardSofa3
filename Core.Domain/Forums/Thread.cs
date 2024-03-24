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
        public List<Message> Messages;
        public IThreadState ThreadState;

        public Thread(ITicket ticket)
        {
            Ticket = ticket;
            Messages = new List<Message>();
            ThreadState = new OpenThreadState(this);
        }
        public void changeState(IThreadState state)
        {
            ThreadState = state;
        }
        public void AddMessage(Message message)
        {
            this.ThreadState.addMessage(message);
        }

    }
}
