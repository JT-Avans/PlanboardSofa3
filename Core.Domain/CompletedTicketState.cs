using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class CompletedTicketState : ITicketState
    {
        public void assignAssignee(ITicket ticket, User assignee)
        {
            //locked
        }

        public void removeAssignee(ITicket ticket, User assignee)
        {
            //locked
        }

        public void updateSeverity(ITicket ticket, int severity)
        {
            //locked
        }
    }
}
