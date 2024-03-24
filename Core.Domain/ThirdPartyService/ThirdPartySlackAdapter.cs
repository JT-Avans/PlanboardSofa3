using Core.Domain.Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ThirdPartyService
{
    public class ThirdPartySlackAdapter
    {
        public void SendSlack(Report report)
        {
            Console.WriteLine("SLACK SENT" + report);
        }
    }
}
