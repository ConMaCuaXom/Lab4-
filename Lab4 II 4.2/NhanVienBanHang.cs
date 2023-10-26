using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_II_4._2
{
    internal class NhanVienBanHang : NhanVien
    {
        public float soLuongBanDuoc;

        public override void TinhLuong()
        {
            Console.WriteLine("Tinh Luong Ban Hang");
        }

        public override void HienThi()
        {
            Console.WriteLine("Hien thi ban hang");
        }
    }
}
