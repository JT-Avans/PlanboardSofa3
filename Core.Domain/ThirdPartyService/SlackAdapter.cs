using Core.Domain.Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ThirdPartyService
{
    public class SlackAdapter
    {
        ThirdPartySlackAdapter service { get; set; }

        public SlackAdapter(ThirdPartySlackAdapter service)
        {
            this.service = service;
        }

        public void sendEmailAdapter(Report report)
        {
            service.SendSlack(report);
        }
    }
}
