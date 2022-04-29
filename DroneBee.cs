﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beeAppLibrary
{
    public class DroneBee : HoneyBee
    {
        public DroneBee(string id) : base(id)
        {
            
        }

        public DroneBee(DroneBee bee) : base(bee)
        {
        }
    }
}
