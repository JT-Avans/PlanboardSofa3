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
        public List<User> Assignees { get; set; }
        public int Severity {  get; set; }
        public ITicketState State { get; set; }

        public BugTicket(int iD, string title, string description, int priority, int severity)
        {
            ID = iD;
            Title = title;
            Description = description;
            Priority = priority;
            Severity = severity;
            Assignees = new List<User>();
            State = new OpenTicketState();
        }

        public void updateSeverity(int severity)
        {
            this.State.updateSeverity(this, severity);
        }

        public void assignAssignee(User assignee)
        {
            this.State.assignAssignee(this, assignee);
        }

        public void removeAssignee(User assignee)
        {
            this.State.removeAssignee(this, assignee);
        }

        public void setState(ITicketState state)
        {
            this.State = state;
        }
    }
}
