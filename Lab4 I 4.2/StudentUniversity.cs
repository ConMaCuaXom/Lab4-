using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_I_4._2
{
    internal class StudentUniversity : StudentCollege
    {
        public double score4;

        public override void Average()
        {
            Console.Write("Diem trung binh: ");
            double dtb = ((score1 + score2 + score3 + score4) / 4) * 1.0f;
            Console.WriteLine(dtb);
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Diem mon 4: " + score4);
        }

    }
}
