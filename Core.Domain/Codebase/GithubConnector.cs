using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Codebase
{
    public class GithubConnector : GitConnector
    {
        public override void authenticate()
        {
            Console.WriteLine("Authenticate to Github");
        }
    public override void getSourceCode()
        {
            Console.WriteLine("GetSourceCode Github");
        }

        public override void formatSourceCode()
        {
            Console.WriteLine("Format sourceCode Github");
        }
    }
}
