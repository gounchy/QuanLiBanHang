using QuanLyBanHang;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Hoá_Đơn_Bán_Hàng
{
    public class Khach
    {
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        private static string filePath = GlobalSettings.khachhangFile;

        public Khach() { }

        public Khach(string ma, string ten, string diaChi, string dienThoai)
        {
            MaKhach = ma;
            TenKhach = ten;
            DiaChi = diaChi;
            DienThoai = dienThoai;
        }

        // Đọc file CSV
        public static List<Khach> DocFileCSV()
        {
            List<Khach> ds = new List<Khach>();

            if (!File.Exists(filePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, "MaKhach,TenKhach,DiaChi,DienThoai\n", new UTF8Encoding(true));
                return ds;
            }

            var lines = File.ReadAllLines(filePath, new UTF8Encoding(true)).Skip(1);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var p = line.Split(',');
                if (p.Length == 4)
                    ds.Add(new Khach(p[0], p[1], p[2], p[3]));
            }
            return ds;
        }

        // Ghi file CSV
        public static void GhiFileCSV(List<Khach> ds)
        {
            var sb = new StringBuilder();
            sb.AppendLine("MaKhach,TenKhach,DiaChi,DienThoai");
            foreach (var k in ds)
                sb.AppendLine($"{k.MaKhach},{k.TenKhach},{k.DiaChi},{k.DienThoai}");
            File.WriteAllText(filePath, sb.ToString(), new UTF8Encoding(true));
        }

        // Sinh mã KH tự động
        public static string TaoMaKhachTuDong(List<Khach> ds)
        {
            if (ds == null || ds.Count == 0) return "KH001";

            int maxSo = ds.Select(k =>
            {
                string so = new string(k.MaKhach.Where(char.IsDigit).ToArray());
                return int.TryParse(so, out int n) ? n : 0;
            }).Max();

            return $"KH{(maxSo + 1):D3}";
        }

        // Thêm khách
        public static Khach ThemKhach(List<Khach> ds, string ten, string diaChi, string dienThoai)
        {
            string maMoi = TaoMaKhachTuDong(ds);
            var kh = new Khach(maMoi, ten, diaChi, dienThoai);
            ds.Add(kh);
            GhiFileCSV(ds);
            return kh;
        }

        // Sửa khách
        public static bool SuaKhach(List<Khach> ds, Khach khMoi)
        {
            var kh = ds.FirstOrDefault(k => k.MaKhach == khMoi.MaKhach);
            if (kh != null)
            {
                kh.TenKhach = khMoi.TenKhach;
                kh.DiaChi = khMoi.DiaChi;
                kh.DienThoai = khMoi.DienThoai;
                GhiFileCSV(ds);
                return true;
            }
            return false;
        }

        // Xóa khách
        public static bool XoaKhachTheoMa(List<Khach> ds, string ma)
        {
            var kh = ds.FirstOrDefault(k => k.MaKhach.Equals(ma, StringComparison.OrdinalIgnoreCase));
            if (kh != null)
            {
                ds.Remove(kh);
                GhiFileCSV(ds);
                return true;
            }
            return false;
        }

        // Tìm kiếm theo tất cả trường hơpkj
        public static List<Khach> TimKiem(List<Khach> ds, string tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa)) return ds;
            tuKhoa = tuKhoa.Trim().ToLower();

            return ds.Where(k =>
                k.MaKhach.ToLower().Contains(tuKhoa) ||
                k.TenKhach.ToLower().Contains(tuKhoa) ||
                k.DiaChi.ToLower().Contains(tuKhoa) ||
                k.DienThoai.ToLower().Contains(tuKhoa)
            ).ToList();
        }
    }
}
