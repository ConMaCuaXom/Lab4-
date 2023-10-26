using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_I_4._3
{
    internal abstract class Shape
    {
        public double radius;
        public double length;
        public double width;

        public abstract double Area();
        public abstract double Cirumference();
    }
}
