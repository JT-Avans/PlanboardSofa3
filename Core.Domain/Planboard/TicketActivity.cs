using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Planboard
{
    public class TicketActivity
    {
        int ID { get; set; }
        string Title { get; set; }
        string Description { get; set; }

        public TicketActivity(int id, string title, string description)
        {
            ID = id;
            Title = title;
            Description = description;
        }
    }
}
