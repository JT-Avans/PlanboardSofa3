using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public interface ITicket
    {
        int ID { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        int Priority { get; set; }
        User? Assignees { get; set; }
        ITicketState State { get; set; }

        void setState(ITicketState state);
        void assignAssignee(User assignee);
        void removeAssignee();

    }
}
