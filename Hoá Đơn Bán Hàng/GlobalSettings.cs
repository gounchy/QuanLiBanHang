using Hoá_Đơn_Bán_Hàng;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    public static class GlobalSettings
    {
        public static readonly string BasePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\" // trở về thư mục project
        );

        public static readonly string DataFolder = Path.Combine(BasePath, "SanPham");
        public static readonly string nhanvienFile = Path.Combine(DataFolder, "NhanVien.csv");
        public static readonly string productsFile = Path.Combine(DataFolder, "SanPham.csv");
        public static readonly string khachhangFile = Path.Combine(DataFolder, "KhachHang.csv");
        public static readonly string hoadonFile = Path.Combine(DataFolder, "HoaDon.csv");

        public static List<TaiKhoan> DanhSachTaiKhoan = new List<TaiKhoan>()
        {
            new TaiKhoan { TenDangNhap = "admin", MatKhau = "123" }
        };

        // Người dùng hiện tại
        public static TaiKhoan TaiKhoanHienTai { get; set; }

        public class TaiKhoan
        {
            public string TenDangNhap { get; set; }
            public string MatKhau { get; set; }
        }
    }
}
