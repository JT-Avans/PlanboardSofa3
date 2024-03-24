using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Forums
{
    public class Forum
    {
        readonly List<Thread> threads;

        public Forum()
        {
            threads = new List<Thread>();
        }

        public void addThread(Thread thread)
        {
            threads.Add(thread);
        }

    }
}
