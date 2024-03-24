using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Pipeline
    {
        public void DevopPipeline()
        {
            Console.WriteLine("Retrieve source");
            Console.WriteLine("Install packages");
            Console.WriteLine("Building");
            Console.WriteLine("Run tests");
            Console.WriteLine("Deploy");
        }
    }
}
