using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Viết chương trình C# thực hiện các công việc sau:
//- Tạo lớp trừu tượng Student với các trường name, year, phương thức hiển thị,
// phương thức trừu tượng Average (tính trung bình điểm)
//- Tạo lớp StudentCollege kế thừa từ Student và bổ sung 3 trường score1, score2,
// score3. Ghi đè phương thức Average và tạo mới phương thức hiển thị.
//- Tạo lớp StudentUniversity kế thừa từ StudentCollege và bổ sung 1 trường score4.
// Ghi đè phương thức Average và tạo mới phương thức hiển thị.
//- Trong Main viết code để test chương trình.


namespace Lab4_I_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentCollege studentCollege = new StudentCollege();
            studentCollege.name = "Test1";
            studentCollege.year = 2;
            studentCollege.score1 = 5;
            studentCollege.score2 = 6;
            studentCollege.score3 = 8;
            studentCollege.Display();
            studentCollege.Average();

            StudentUniversity studentUniversity = new StudentUniversity();
            studentUniversity.name = "Test2";
            studentUniversity.year = 3;
            studentUniversity.score1 = 4;
            studentUniversity.score2 = 5;
            studentUniversity.score3 = 6;
            studentUniversity.score4 = 7;
            studentUniversity.Display();
            studentUniversity.Average();

            Console.ReadKey();

        }
    }
}
