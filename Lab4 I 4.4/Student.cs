using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_I_4._4
{
    internal class Student : IPerson
    {
        public int id;
        public string name;
        public int age;

        public void Insert(object obj)
        {
            Console.WriteLine("Da them doi tuong.. " +  obj);
        }

        public void Update(object obj)
        {
            Console.WriteLine("Da update doi tuong.." + obj);
        }

        public void Delete(object obj)
        {
            Console.WriteLine("Da xoa doi tuong.." + obj);
        }

        public void Display(object obj)
        {
            Student student = obj as Student;
            Console.WriteLine("ID: " +  student.id);
            Console.WriteLine("Name: " + student.name);
            Console.WriteLine("Age: " + student.age);
        }
    }
}
