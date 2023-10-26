using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Tạo ứng dụng C# với các yêu cầu sau.
//- Lớp Account lưu thông tin về tài khoản (Balance – số tiền trong tài khoản). Tạo 1
//phương thức constructor với tham số đầu vào là initialize (số tiền ban đầu).
//- Tạo 2 phương thức cho lớp Account.
//* Deposit(money): là phương thức gửi tiền cho ghi đè, money là số tiền cần
//gửi, hãy kiểm tra các thông tin cho phù hợp và xuất thông báo.
//* WithDraw(money): là phương thức rút tiền cho ghi đè, money là số tiền rút,
//hãy kiểm tra các thông tin cho phù hợp và xuất thông báo.
//* GetBalance(): là phương thức trả về số tiền trong tài khoản.
//- Lớp SavingAccount (gửi tiết kiệm) kế thừa từ lớp Account có thêm thông số rate(tỉ
//lệ lãi suất), tạo phương thức constructor với 2 tham số đầu vào, initialize (số tiền
//ban đầu), rate, kế thừa constructor của lớp Account. Tạo phương thức
//GetInterest() (lấy tiền lãi).
//- Lớp CheckAccount(vấn tin, gửi tiền, rút tiền) kế thừa từ lớp Account và có thêm
//biến FeeTransfer (phí giao dịch). Tạo phương thức constructor với 2 tham số đầu
//vào Balance, FeeTransfer, sau đó ghi đè 2 phương thức Deposit và WithDraw,
//GetBalance, mỗi khi gọi phương thức thành công thì số tiền trong tài khoản sẽ bị
//trừ đi 1 khoản bằng FeeTransfer.
//Lớp Program để kiểm thử ứng dụng.

namespace Lab4_II_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accTest = new Account(100000);
            accTest.Initialize(50000);
            accTest.WithDraw(60000);

            SavingAccount savingAccount = new SavingAccount(100000, 0.2f);
            savingAccount.GetInterest();

            CheckAccount checkAccount = new CheckAccount(100000, 0.1f);
            checkAccount.Initialize(20000);
            checkAccount.WithDraw(10000);

            Console.ReadKey();

        }
    }
}
