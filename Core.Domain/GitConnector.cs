using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            getSourceCode();
            validateSourceCode();
            formatSourceCode();
            logSuccess();

        }

        protected abstract void authenticate();
        protected abstract void getSourceCode();

        public void validateSourceCode()
        {
            Console.WriteLine("Validating if current version is correct");
        }
        public void formatSourceCode()
        {
            Console.WriteLine("Formatting code");
        }
        public void logSuccess()
        {
            Console.WriteLine("Git: Success in retrieving source code");
        }
    }
}
