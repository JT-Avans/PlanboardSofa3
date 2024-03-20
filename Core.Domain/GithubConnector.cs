using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class GithubConnector : GitConnector
    {
        protected override void authenticate()
        {
            Console.WriteLine("authenticated to github");
        }

        protected override void convertIssuesToTickets()
        {
            fetchIssues();
        }

        protected override void fetchIssues()
        {
            throw new NotImplementedException();
        }
    }
}
