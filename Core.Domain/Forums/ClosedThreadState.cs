using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Forums
{
    public class ClosedThreadState : IThreadState
    {
        public ClosedThreadState(Thread thread) : base(thread)
        {
        }

        public override void addMessage(Message message)
        {
            //locked
        }
    }
}
