using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Viết chương trình C# thực hiện các công việc sau:
//- Tạo giao diện IPerson với các phương thức Insert, Delete, Update, Display.
//- Tạo lớp Staff thực thi các phương thức trong giao diện IPerson.
//- Tạo lớp Student với các trường id, name, age và thực thi các phương thức trong
//giao diện IPerson.
//- Trong Main code để test.

namespace Lab4_I_4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff();
            Object obj = "Green";
            staff.Insert(obj);
            staff.Update(obj);
            staff.Delete(obj);
            staff.Display(obj);

            Student student = new Student();
            student.id = 1;
            student.name = "Test";
            student.age = 19;
            Object obj2 = new Object();
            obj2 = "test2";
            student.Insert(obj2);
            student.Update(obj2);
            student.Delete(obj2);
            student.Display(student);

            Console.ReadKey();
        }
    }
}
