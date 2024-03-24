using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Codebase
{
    public abstract class GitConnector
    {
        public void SourceCode()
        {
            authenticate();
            getSourceCode();
            formatSourceCode();
        }

        public abstract void authenticate();
        public abstract void getSourceCode();
        public abstract void formatSourceCode();
    }
}
