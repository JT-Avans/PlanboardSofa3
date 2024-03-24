using Core.Domain.Planboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Analysis
{
    public class CsvExport : IExport
    {
        public void visitBugTicket(BugTicket bugTicket)
        {
            Console.WriteLine("Export BugTickets to CSV");
        }

        public void visitTaskTicket(TaskTicket taskTicket)
        {
            Console.WriteLine("Export TaskTicket to CSV");
        }
    }
}
