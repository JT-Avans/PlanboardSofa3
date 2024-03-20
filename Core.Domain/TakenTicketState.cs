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
            ticket.Assignees.Add(assignee);
        }

        public void removeAssignee(ITicket ticket, User assignee)
        {
            ticket.Assignees.Remove(assignee);
        }

        public void updateSeverity(ITicket ticket, int severity)
        {
            //locked
        }
    }
}
