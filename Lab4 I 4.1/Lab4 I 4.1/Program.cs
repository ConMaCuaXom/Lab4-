using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Viết chương trình C# thực hiện các công việc sau:
//- Tạo lớp Window với 2 trường top, left. Tạo phương thức DrawWindow và in ra
// thông báo.
//- Tạo lớp Button kế thừa từ Window và ghi đè phương thức DrawWindow
//- Tạo lớp ListBox kế thừa từ Window bổ sung thêm trường content và ghi đè
//phương thức DrawWindow.
//- Trong program viết code test 2 lớp trên.

namespace Lab4_I_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Window window = new Window();
            window.top = 5;
            window.left = 7;
            window.DrawWindow();

            Button btn = new Button();
            btn.left = 10;
            btn.top = 12;
            btn.DrawWindow();

            ListBox listBox = new ListBox();
            listBox.top = 20;
            listBox.left = 22;
            listBox.content = 55;
            listBox.DrawWindow();

            Console.ReadKey();
        }
    }
}
