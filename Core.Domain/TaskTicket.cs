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
        public User? Assignee { get; set; }
        public List<TicketActivity> TicketActivities { get; set; }

        public TaskTicket(int id, string title, string description, int priority)
        {
            ID = id;
            Title = title;
            Description = description;
            Priority = priority;
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
