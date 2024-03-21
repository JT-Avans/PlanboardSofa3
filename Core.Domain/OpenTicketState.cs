using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class OpenTicketState : ITicketState
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
            if(ticket is BugTicket bugTicket)
            {
                bugTicket.Severity = severity;
            } else
            {
                throw new InvalidOperationException("Cannot update severity for non bugTicket");
            }
        }
    }
}
