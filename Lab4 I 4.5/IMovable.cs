﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_I_4._5
{
    internal interface IMovable : IDrivable, ISteerable
    {
        void Accelerate();
        void Brake();
    }
}
