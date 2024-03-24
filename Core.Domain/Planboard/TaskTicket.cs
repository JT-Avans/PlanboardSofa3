using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Observer;

namespace Core.Domain.Planboard
{
    public class TaskTicket : ITicket
    {
        private readonly Observable observable = new Observable();
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public User? Assignee { get; set; }
        public bool IsCompleted { get; set; }
        public List<TicketActivity> TicketActivities { get; set; }

        public TaskTicket(int id, string title, string description, int priority)
        {
            this.ID = id;
            this.Title = title;
            this.Description = description;
            this.Priority = priority;
            this.TicketActivities = new List<TicketActivity>();
        }

        public void assignAssignee(User assignee)
        {
            Assignee = assignee;
            observable.Notify(this);
        }

        public void removeAssignee()
        {
            Assignee = null;
            observable.Notify(this);
        }

        public void addTicketActivity(TicketActivity ticketActivity)
        {
            TicketActivities.Add(ticketActivity);
            observable.Notify(this);
        }
        
        public bool MarkAsCompleted()
        {
            observable.Notify(this);
            return IsCompleted = true;
        }
    }
}
