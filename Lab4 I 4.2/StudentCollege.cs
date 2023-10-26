using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_I_4._2
{
    internal class StudentCollege : Student
    {
        public double score1;
        public double score2;
        public double score3;

        public override void Average()
        {
            Console.Write("Diem trung binh: ");
            double dtb = (score1 + score2 + score3)/3;
            Console.WriteLine(dtb * 1.0);
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Diem mon 1: " + score1);
            Console.WriteLine("Diem mon 2: " + score2);
            Console.WriteLine("Diem mon 3: " + score3);
            
        }

    }
}
