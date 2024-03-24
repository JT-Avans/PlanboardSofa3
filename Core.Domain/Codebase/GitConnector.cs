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
        public void issueConverter()
        {
            authenticate();
            getSourceCode();
            formatSourceCode();
        }

        protected abstract void authenticate();
        protected abstract void getSourceCode();
        protected abstract void formatSourceCode();
    }
}
