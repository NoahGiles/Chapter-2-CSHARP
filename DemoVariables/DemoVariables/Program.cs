﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVariables
{
    using static System.Console;
    class DemoVariables
    {
        static void Main()
        {
            int anInt = -123;
            uint anUnassignedInt = 567;

            WriteLine("The int is {0} and the unassigned int is {1}.", anInt, anUnassignedInt);
        }
    }
}
