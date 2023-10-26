using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Viết chương trình C# thực hiện các công việc sau:
//- Tạo giao diện IDrivable với hai phương thức Start và Stop và thuộc tính chỉ đọc
// Started.
//- Tạo giao diện ISteerable với hai phương thức TurnLeft, TurnRight
//- Tạo giao diện IMovable kế thừa từ 2 giao diện trên bổ sung thêm hai phương thức
// Accelerate và Brake
//- Tạo lớp Car thực thi từ giao diện IMovable và code cho tất cả các phương thức có
//thể
//- Trong Main code để test lớp Car.


namespace Lab4_I_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();    
            car.Start();
            car.Stop();
            car.TurnLeft();
            car.TurnRight();
            car.Accelerate();
            car.Brake();


            Console.ReadKey();
        }
    }
}
