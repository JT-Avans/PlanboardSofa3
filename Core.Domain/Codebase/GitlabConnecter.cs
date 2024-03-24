using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Codebase
{
    public class GitlabConnecter : GitConnector
    {
        public override void authenticate()
        {
            Console.WriteLine("Authenticate to Gitlab");
        }
        public override void getSourceCode()
        {
            Console.WriteLine("GetSourceCode Gitlab");
        }

        public override void formatSourceCode()
        {
            Console.WriteLine("Format sourceCode Gitlab");
        }
    }
}
