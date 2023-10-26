using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Viết chương trình C# thực hiện các công việc sau:
//- Tạo lớp trừu tượng Shape với các trường radius, length, width. Khai báo hai
//phương thức trừu tượng tính diện tính Area và tính chu vi Cirumference
//- Tạo lớp Circle kế thừa từ Shape và thực thi các phương thức của lớp Shape
//- Tạo lơps Rectangle kế thừa từ Shape và thực thi các phương thức của lớp Shape
//- Trong Main viết code để test chương trình

namespace Lab4_I_4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Display();
            Console.WriteLine("Dien tich hinh tron: " +  circle.Area());
            Console.WriteLine("Chu vi hinh tron: " + circle.Cirumference());

            Rectangle rectangle = new Rectangle();
            rectangle.Display();
            Console.WriteLine("Dien tich hinh CN: " +  rectangle.Area());
            Console.WriteLine("Chu vi hinh CN: " + rectangle.Cirumference());
            

            Console.ReadKey();

        }
    }
}
