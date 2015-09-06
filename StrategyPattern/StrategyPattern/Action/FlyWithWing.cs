﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class FlyWithWing : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can Fly");
        }
    }
}
