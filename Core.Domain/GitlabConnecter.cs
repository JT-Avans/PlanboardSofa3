using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class GitlabConnecter : GitConnector
    {
        protected override void authenticate()
        {
            Console.WriteLine("Connect to GITLAB");
        }

        protected override void getSourceCode()
        {
            Console.WriteLine("Retrieve GITLAB code");
        }
    }
}
