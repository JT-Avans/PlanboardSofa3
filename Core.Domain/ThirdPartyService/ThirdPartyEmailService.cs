using Core.Domain.Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ThirdPartyService
{
    public class ThirdPartyEmailService
    {
        public void SendEmail(Report report)
        {
            Console.WriteLine("EMAIL SENT" + report);
        }
    }
}
