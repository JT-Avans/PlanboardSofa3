using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public abstract class GitConnector
    {
        public  void issueConverter()
        {
            authenticate();
            convertIssuesToTickets();
        }

        void saveTickets(List<ITicket> list)
        {

        }

        protected abstract void authenticate();
        protected abstract void fetchIssues();
        protected abstract void convertIssuesToTickets();
    }
}
