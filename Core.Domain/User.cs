﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class User(int id, string name)
    {
        public string Name => name;
        public int ID => id;
    }
}
