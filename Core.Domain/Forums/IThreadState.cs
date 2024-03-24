using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Forums
{
    public abstract class ThreadState
    {
        protected Thread Thread { get; set; }
        protected ThreadState(Thread thread)
        {
            this.Thread = thread;
        }
        public abstract void addMessage(Message message);

    }
}
