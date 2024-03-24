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
            throw new NotImplementedException();
        }

        protected override void formatSourceCode()
        {
            throw new NotImplementedException();
        }

        protected override void getSourceCode()
        {
            throw new NotImplementedException();
        }
    }
}
