using Core.Domain.Planboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Analysis
{
    public interface IExport
    {
        void visitTaskTicket(TaskTicket taskTicket);
        void visitBugTicket(BugTicket bugTicket);
    }
}
