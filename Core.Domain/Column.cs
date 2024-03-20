using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Column
    {
        public string Name { get; set; }
        public int MaxTickets { get; set; }
        public List<ITicket> Tickets { get; set; }

        public Column(string name, int maxTickets) {
            this.Name = name;
            this.MaxTickets = maxTickets;
            this.Tickets = new List<ITicket>();
        }

        public void addTicket(ITicket ticket)
        {
            this.Tickets.Add(ticket);
        }

        public void removeTicket(ITicket ticket)
        {
            this.Tickets.Remove(ticket);
        }

    }
}
