using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class TaskTicket : ITicket
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public List<User> Assignees { get; set; }
        public ITicketState State { get; set; }

        public TaskTicket(int id, string title, string description, int priority)
        {
            ID = id;
            Title = title;
            Description = description;
            Priority = priority;
            Assignees = new List<User>();
            State = new OpenTicketState();
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
