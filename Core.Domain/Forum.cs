using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Forum
    {
        List<Thread> threads;

        public Forum()
        {
            this.threads = new List<Thread>();
        }

        void addThread(Thread thread)
        {
            threads.Add(thread);
        }

    }
}
