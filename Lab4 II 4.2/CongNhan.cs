using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_II_4._2
{
    internal class CongNhan : NhanVien
    {
        public float soLuongSanPham;

        public override void TinhLuong()
        {
            Console.WriteLine("Tinh Luong");
        }

        public override void HienThi()
        {
            Console.WriteLine("Hien Thi");
        }
    }
}
