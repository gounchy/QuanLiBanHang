using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hoá_Đơn_Bán_Hàng
{
    public class NhanVien
    {
        public string MaNV { get; }
        public string TenNV { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }

        public NhanVien()
        {

        }
        public NhanVien(string maNV, string tenNV)
        {
            MaNV = maNV;
            TenNV = tenNV;
        }
        public NhanVien(string maNV, string tenNV, DateTime ngaySinh, bool gioiTinh, string dienThoai, string diaChi)
        {
            MaNV = maNV;
            TenNV = tenNV;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DienThoai = dienThoai;
            DiaChi = diaChi;
        }
        public NhanVien(string line)
        {
            string[] parts = line.Split(',');
            if (parts.Length >= 6)
            {
                MaNV = parts[0];
                TenNV = parts[1];
                NgaySinh = DateTime.Parse(parts[2]);
                GioiTinh = parts[3].Trim().ToLower() == "nam";
                DienThoai = parts[4];
                DiaChi = parts[5];
            }
        }

        public List<NhanVien> GetList()
        {
            List<NhanVien> nvlist = new List<NhanVien>();
            string fileName = @"SanPham\NhanVien.csv";
            ;

            using (StreamReader reader = new StreamReader(fileName))
            {
                // Skip the column names row (Skip Header)            
                if (!reader.EndOfStream) reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] columns = line.Split(',');

                    string maNV = columns[0];
                    string tenNV = columns[1];
                    DateTime ngaySinh = DateTime.Parse(columns[2]);
                    bool gioiTinh = columns[3].Trim().ToLower() == "nam";
                    string dienThoai = columns[4];
                    string diaChi = columns[5];

                    nvlist.Add(new NhanVien(maNV, tenNV, ngaySinh, gioiTinh, dienThoai, diaChi));
                }
            }
            return nvlist;
        }

        public static void SaveList(List<NhanVien> nvList, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Ghi header
                writer.WriteLine("MaNV,TenNV,NgaySinh,GioiTinh,DienThoai,DiaChi");

                foreach (var nv in nvList)
                {
                    string gioiTinhStr = nv.GioiTinh ? "Nam" : "Nữ";
                    string line = $"{nv.MaNV},{nv.TenNV},{nv.NgaySinh:yyyy-MM-dd},{gioiTinhStr},{nv.DienThoai},{nv.DiaChi}";
                    writer.WriteLine(line);
                }
            }
        }

    }
}
