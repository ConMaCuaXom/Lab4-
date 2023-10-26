using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tạo ứng dụng C# minh họa lớp abstract và kế thừa như hình sau


namespace Lab4_II_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CongNhan congNhan = new CongNhan();
            congNhan.TinhLuong();
            congNhan.HienThi();

            NhanVienBanHang nhanVienBanHang = new NhanVienBanHang();
            nhanVienBanHang.HienThi();
            nhanVienBanHang.TinhLuong();

            Console.ReadKey();
        }
    }
}
