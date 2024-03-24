using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Forums
{
    public class OpenThreadState : IThreadState
    {
        public OpenThreadState(Thread thread) : base(thread)
        {
        }

        public override void addMessage(Message message)
        {
            this.Thread.Messages.Add(message);
        }
    }
}
