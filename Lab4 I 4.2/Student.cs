using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_I_4._2
{
    internal abstract class Student
    {
        public string name;
        public int year;

        public void Display()
        {
            Console.WriteLine("Student name: " +  name);
            Console.WriteLine("Student year: " +  year);
        }

        public abstract void Average();

    }

    
}
