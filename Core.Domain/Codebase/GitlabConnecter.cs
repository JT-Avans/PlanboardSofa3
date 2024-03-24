using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Codebase
{
    public class GitlabConnecter : GitConnector
    {
        protected override void authenticate()
        {
            Console.WriteLine("Authenticate to Gitlab");
        }
        protected override void getSourceCode()
        {
            Console.WriteLine("GetSourceCode Gitlab");
        }

        protected override void formatSourceCode()
        {
            Console.WriteLine("Format sourceCode Gitlab");
        }
    }
}
