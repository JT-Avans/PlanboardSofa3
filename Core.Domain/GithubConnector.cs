﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class GithubConnector : GitConnector
    {
        protected override void authenticate()
        {
            Console.WriteLine("Connect to GITHUB");
        }

        protected override void getSourceCode()
        {
            Console.WriteLine("Retrieve GITHUB code");
        }
    }
}
