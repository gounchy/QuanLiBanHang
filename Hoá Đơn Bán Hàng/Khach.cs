using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoá_Đơn_Bán_Hàng
{
    public class Khach
    {
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        public Khach() { }

        public Khach(string ma, string ten, string diaChi, string dienThoai)
        {
            MaKhach = ma;
            TenKhach = ten;
            DiaChi = diaChi;
            DienThoai = dienThoai;
        }
    }
}
