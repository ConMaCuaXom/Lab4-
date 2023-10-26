using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_I_4._1
{
    internal class Window
    {
        public int top;
        public int left;

        public virtual void DrawWindow()
        {
            Console.WriteLine("Window have: ");
            Console.WriteLine("Top: " + top);
            Console.WriteLine("Left: " + left);
        }

    }
}
