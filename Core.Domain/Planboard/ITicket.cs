using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Planboard
{
    public interface ITicket
    {
        int ID { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        int Priority { get; set; }
        User? Assignee { get; set; }
        List<TicketActivity> TicketActivities { get; set; }

        void assignAssignee(User assignee);
        void removeAssignee();

        void addTicketActivity(TicketActivity ticketActivity);

        bool MarkAsCompleted();

    }
}
