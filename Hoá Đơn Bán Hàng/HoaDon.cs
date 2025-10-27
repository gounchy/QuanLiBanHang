using QuanLyBanHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoá_Đơn_Bán_Hàng
{
    public class HoaDon
    {
        //public string MaHD { get; set; }
        //public NhanVien NhanVienBan { get; set; }
        //public Khach KhachMua { get; set; }
        //public List<Products> DanhSachHang { get; set; }
        //public DateTime NgayLap { get; set; }

        //public decimal TongTien => DanhSachHang.Sum(p => p.TinhTien());

        //public HoaDon()
        //{
        //    DanhSachHang = new List<Products>();
        //    NgayLap = DateTime.Now;
        //}

        //public HoaDon(string maHD, NhanVien nv, Khach kh, List<Products> danhSach)
        //{
        //    MaHD = maHD;
        //    NhanVienBan = nv;
        //    KhachMua = kh;
        //    DanhSachHang = danhSach;
        //    NgayLap = DateTime.Now;
        //}

        //public override string ToString()
        //{
        //    return $"{MaHD} - {NhanVienBan.TenNV} - {KhachMua.TenKhach} - {TongTien:N0} VNĐ";
        //}

        public class HoaDonChiTiet
        {
            public string MaHD { get; set; }        
            public string MaHang { get; set; }     
            public string TenHang { get; set; }
            public int SoLuong { get; set; }
            public decimal DonGia { get; set; }
            public decimal ThanhTien => SoLuong * DonGia;
        }

        public string MaHD { get; set; }
        public string MaNV { get; set; }
        public string MaKhach { get; set; }
        public DateTime NgayLap { get; set; }
        public List<HoaDonChiTiet> ChiTiet { get; set; }

        public decimal TongTien => ChiTiet.Sum(c => c.ThanhTien);

        public HoaDon()
        {
            ChiTiet = new List<HoaDonChiTiet>();
            NgayLap = DateTime.Now;
        }

        // Lưu hóa đơn ra file CSV
        public void SaveToFile(string filePath)
        {
            bool fileTonTai = File.Exists(filePath);
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                if (!fileTonTai)
                    sw.WriteLine("MaHD,MaNV,MaKhach,NgayLap,MaHang,TenHang,SoLuong,DonGia,ThanhTien");

                foreach (var ct in ChiTiet)
                {
                    sw.WriteLine($"{MaHD},{MaNV},{MaKhach},{NgayLap:yyyy-MM-dd},{ct.MaHang},{ct.TenHang},{ct.SoLuong},{ct.DonGia},{ct.ThanhTien}");
                }
            }
        }

        // Đọc toàn bộ hóa đơn từ file
        public static List<HoaDonChiTiet> LoadFromFile(string filePath)
        {
            var list = new List<HoaDonChiTiet>();
            if (!File.Exists(filePath)) return list;

            var lines = File.ReadAllLines(filePath).Skip(1);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(',');
                if (parts.Length < 9) continue;

                list.Add(new HoaDonChiTiet
                {
                    MaHD = parts[0],
                    MaHang = parts[4],
                    TenHang = parts[5],
                    SoLuong = int.Parse(parts[6]),
                    DonGia = decimal.Parse(parts[7])
                });
            }

            return list;
        }
    }
}


