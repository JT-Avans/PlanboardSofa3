using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class TicketActivity
    {
        int ID { get; set; }
        string Title { get; set; }
        string Description { get; set; }

        public TicketActivity(int id, string title, string description)
        {
            this.ID = id;
            this.Title = title;
            this.Description = description;
        }
    }
}
