using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class TakenTicketState : ITicketState
    {
        public void assignAssignee(ITicket ticket, User assignee)
        {
            ticket.Assignees = assignee;
        }

        public void removeAssignee(ITicket ticket)
        {
            ticket.Assignees = null;
        }

        public void updateSeverity(ITicket ticket, int severity)
        {
            //locked
        }
    }
}
