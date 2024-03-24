using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Planboard
{
    public class BugTicket : ITicket
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public User? Assignee { get; set; }
        public int Severity { get; set; }
        public List<TicketActivity> TicketActivities { get; set; }

        public BugTicket(int iD, string title, string description, int priority, int severity)
        {
            this.ID = iD;
            this.Title = title;
            this.Description = description;
            this.Priority = priority;
            this.Severity = severity;
            this.TicketActivities = new List<TicketActivity>();
        }

        public void updateSeverity(int severity)
        {
            Severity = severity;
        }

        public void assignAssignee(User assignee)
        {
            Assignee = assignee;
        }

        public void removeAssignee()
        {
            Assignee = null;
        }

        public void addTicketActivity(TicketActivity ticketActivity)
        {
            TicketActivities.Add(ticketActivity);
        }
    }
}
