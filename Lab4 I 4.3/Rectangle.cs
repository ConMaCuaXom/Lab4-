using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_I_4._3
{
    internal class Rectangle : Shape
    {
        public void Display()
        {
            Console.WriteLine("Nhap vao chieu dai: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao chieu rong: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public override double Area()
        {
            return length * width;
        }

        public override double Cirumference()
        {
            return (length + width) * 2;
        }
    }
}
