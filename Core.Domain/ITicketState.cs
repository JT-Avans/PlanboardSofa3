using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public interface ITicketState
    {
        void updateSeverity(ITicket ticket, int severity);
        void assignAssignee(ITicket ticket, User assignee);
        void removeAssignee(ITicket ticket, User assignee);
    }
}
