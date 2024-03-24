using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Planboard
{
    public class Column
    {
        public string Name { get; set; }
        public List<ITicket> Tickets { get; set; }

        public Column(string name)
        {
            Name = name;
            Tickets = new List<ITicket>();
        }

        public void addTicket(ITicket ticket)
        {
            Tickets.Add(ticket);
        }

        public void removeTicket(ITicket ticket)
        {
            Tickets.Remove(ticket);
        }

    }
}
