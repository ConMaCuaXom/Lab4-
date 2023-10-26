using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_I_4._3
{
    internal class Circle : Shape
    {
        public void Display()
        {
            Console.WriteLine("Nhap vao ban kinh: ");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public override double Area()
        {
            return radius * radius * 3.14;
        }

        public override double Cirumference()
        {
            return 2 * radius * 3.14;
        }
    }
}
