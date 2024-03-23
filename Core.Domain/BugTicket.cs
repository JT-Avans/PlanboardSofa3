using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class BugTicket : ITicket
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public User? Assignee { get; set; }
        public int Severity {  get; set; }
        public List<TicketActivity> TicketActivities { get; set; }

        public BugTicket(int iD, string title, string description, int priority, int severity)
        {
            ID = iD;
            Title = title;
            Description = description;
            Priority = priority;
            Severity = severity;
        }

        public void updateSeverity(int severity)
        {
            this.Severity = severity;
        }

        public void assignAssignee(User assignee)
        {
            this.Assignee = assignee;
        }

        public void removeAssignee()
        {
            this.Assignee = null;
        }

        public void addTicketActivity(TicketActivity ticketActivity)
        {
            this.TicketActivities.Add(ticketActivity);
        }
    }
}
