using Core.Domain.ThirdPartyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Analysis
{
    public class Report
    {
        public string Header {  get; set; }
        public string Footer { get; set; }
        public IExport Content {  get; set; }

        public Report(string header, string footer, IExport conent) {
            this.Footer = footer;
            this.Header = header;
            this.Content = conent;
        }

        public void sendEmail()
        {
            EmailAdapter emailAdapter = new EmailAdapter(new ThirdPartyEmailService());
            emailAdapter.sendEmailAdapter(this);
        }
    }
}
