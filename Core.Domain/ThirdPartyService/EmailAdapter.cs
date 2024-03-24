using Core.Domain.Analysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.ThirdPartyService
{
    public class EmailAdapter
    {
        ThirdPartyEmailService service {  get; set; }

        public EmailAdapter(ThirdPartyEmailService service)
        {
            this.service = service;
        }

        public void sendEmailAdapter(Report report)
        {
            service.SendEmail(report);
        }
    }
}
