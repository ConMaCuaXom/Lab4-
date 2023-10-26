using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_I_4._1
{
    internal class ListBox : Window
    {
        public int content;


        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("ListBox da ghi de");
        }
    }
}
