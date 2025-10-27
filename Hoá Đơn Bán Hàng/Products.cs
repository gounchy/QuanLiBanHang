using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace QuanLyBanHang
{
    public class Products
    {
        public string maHang { get; set; }
        public string tenHang { get; set; }
        public string Loai { get; set; }
        public decimal Gia { get; set; }
        public int soLuong { get; set; }

        public Products()
        {
            maHang = "";
            tenHang = "";
            Loai = "";
            Gia = 0;
            soLuong = 0;
        }

        public Products(string csvLine)
        {
            string[] values = csvLine.Split(',');
            this.maHang = values[0];
            this.tenHang = values[1];
            this.Loai = values[2];
            this.Gia = decimal.Parse(values[3]);
            this.soLuong = int.Parse(values[4]);
        }

        public List<Products> GetList(string fileName = "")
        {
            //List<Products> proList = new List<Products>();
            //fileName = (fileName == "") ? GlobalSettings.productsFile : fileName;

            //using (StreamReader reader = new StreamReader(fileName))
            //{
            //    if (!reader.EndOfStream) reader.ReadLine();

            //    string line = "";
            //    while (!reader.EndOfStream)
            //    {
            //        line = reader.ReadLine();
            //        Products pro = new Products(line);
            //        proList.Add(pro);
            //    }
            //}
            //return proList;

            List<Products> proList = new List<Products>();
            fileName = (fileName == "") ? GlobalSettings.productsFile : fileName;

            if (!File.Exists(fileName))
                return proList;

            // Đọc tất cả dòng vào mảng (File.ReadAllLines không giữ file mở lâu)
            var lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(',');
                if (parts.Length != 5) continue;

                if (!decimal.TryParse(parts[3], out decimal gia)) continue;
                if (!int.TryParse(parts[4], out int soLuong)) continue;

                proList.Add(new Products
                {
                    maHang = parts[0],
                    tenHang = parts[1],
                    Loai = parts[2],
                    Gia = gia,
                    soLuong = soLuong
                });
            }

            return proList;
        }

        public DataTable DataTable(List<Products> products)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hàng", typeof(string));
            dt.Columns.Add("Tên hàng", typeof(string));
            dt.Columns.Add("Loại", typeof(string));
            dt.Columns.Add("Giá", typeof(string));
            dt.Columns.Add("Số Lượng", typeof(string));
            foreach (Products pro in products)
            {
                dt.Rows.Add(pro.maHang, pro.tenHang, pro.Loai, pro.Gia, pro.soLuong);
            }
            return dt;
        }

        //Lưu danh sách sản phẩm
        private void SaveList(List<Products> list, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                foreach (Products pro in list)
                {
                    writer.WriteLine($"{pro.maHang},{pro.tenHang},{pro.Loai},{pro.Gia},{pro.soLuong}");
                }
            }
        }

        //Lưu toàn bộ danh sách sản phẩm
        public void SaveAll(List<Products> list, string fileName = "")
        {
            fileName = (fileName == "") ? GlobalSettings.productsFile : fileName;
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                foreach (Products p in list)
                {
                    writer.WriteLine($"{p.maHang},{p.tenHang},{p.Loai},{p.Gia},{p.soLuong}");
                }
            }
        }
        //Thêm sản phẩm
        public void AddProduct(Products newProduct, string fileName = "")
        {
            fileName = (fileName == "") ? GlobalSettings.productsFile : fileName;
            if (!File.Exists(fileName))
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("Mã hàng,Tên hàng,Loại,Giá,Số lượng");
                }
            }

            var list = GetList(fileName);

            if (list.Any(p => p.maHang == newProduct.maHang))
                throw new Exception("Mã hàng đã tồn tại!");

            list.Add(newProduct);
            SaveList(list, fileName);
        }

        //Xoá sản phẩm
        public void DeleteProduct(string maHang, string fileName = "")
        {
            fileName = (fileName == "") ? GlobalSettings.productsFile : fileName;
            List<Products> proList = GetList(fileName);
            proList = proList.Where(p => p.maHang != maHang).ToList();
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                writer.WriteLine("Mã hàng,Tên hàng,Loại,Giá,Số lượng");
                foreach (Products pro in proList)
                {
                    writer.WriteLine($"{pro.maHang},{pro.tenHang},{pro.Loai},{pro.Gia},{pro.soLuong}");
                }
            }
        }

        //Sửa sản phẩm
        public void UpdateProduct(Products updatedProduct, string fileName = "")
        {
            fileName = (fileName == "") ? GlobalSettings.productsFile : fileName;
            List<Products> proList = GetList(fileName);

            var existing = proList.FirstOrDefault(p => p.maHang == updatedProduct.maHang);
            if (existing == null)
                throw new Exception("Không tìm thấy sản phẩm cần sửa!");

            existing.tenHang = updatedProduct.tenHang;
            existing.Loai = updatedProduct.Loai;
            existing.Gia = updatedProduct.Gia;
            existing.soLuong = updatedProduct.soLuong;

            SaveList(proList, fileName);
        }

        public decimal TinhTien()
        {
            return Gia * soLuong;
        }

        public static void ThanhToan(List<Products> danhSach)
        {
            if (danhSach == null || danhSach.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm để thanh toán!", "Thông báo");
                return;
            }

            decimal tongTien = danhSach.Sum(p => p.TinhTien());

            DialogResult result = MessageBox.Show(
                $"Tổng tiền cần thanh toán: {tongTien:N0} VNĐ\nBạn có muốn tiếp tục không?",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Thanh toán thành công! Cảm ơn bạn đã mua hàng.", "Thành công");
            }

        }

        public void UpdateQuantity(string maHang, int soLuongMoi)
        {
            string fileName = GlobalSettings.productsFile;
            if (!File.Exists(fileName))
                throw new FileNotFoundException("Không tìm thấy file sản phẩm!");

            string tempFile = fileName + ".tmp";

            var lines = File.ReadAllLines(fileName).ToList();
            bool found = false;

            int startIndex = 0;
            if (lines.Count > 0 && lines[0].IndexOf("maHang", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                startIndex = 1;
            }

            for (int i = startIndex; i < lines.Count; i++)
            {
                var parts = lines[i].Split(',');
                if (parts.Length != 5) continue;
                if (parts[0] == maHang)
                {
                    parts[4] = soLuongMoi.ToString();
                    lines[i] = string.Join(",", parts);
                    found = true;
                }
            }

            if (!found)
                throw new Exception($"Không tìm thấy sản phẩm có mã '{maHang}' trong file.");
            File.WriteAllLines(tempFile, lines);
            File.Delete(fileName);
            File.Move(tempFile, fileName);
        }


    }

}
