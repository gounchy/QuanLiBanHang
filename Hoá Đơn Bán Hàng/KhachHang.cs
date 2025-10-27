using Hoá_Đơn_Bán_Hàng;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class KhachHang : Form
    {
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SanPham", "khachhang.csv");
        private List<Khach> danhSachKhach = new List<Khach>();
        private bool isAdding = false;

        public KhachHang()
        {
            InitializeComponent();
        }

        // 📄 Đọc file CSV
        private void DocFileCSV()
        {
            danhSachKhach.Clear();

            // Nếu chưa có file thì tạo file mới có header
            if (!File.Exists(filePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath)); // tạo folder nếu chưa có
                using (var fs = new StreamWriter(filePath, false, new UTF8Encoding(true)))
                {
                    fs.WriteLine("MaKhach,TenKhach,DiaChi,DienThoai");
                }
                return;
            }

            var lines = File.ReadAllLines(filePath, new UTF8Encoding(true)).Skip(1);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(',');
                if (parts.Length == 4)
                {
                    danhSachKhach.Add(new Khach(parts[0], parts[1], parts[2], parts[3]));
                }
            }
        }

        // 🧱 Ghi lại CSV
        private void GhiFileCSV()
        {
            var sb = new StringBuilder();
            sb.AppendLine("MaKhach,TenKhach,DiaChi,DienThoai");
            foreach (var kh in danhSachKhach)
            {
                sb.AppendLine($"{kh.MaKhach},{kh.TenKhach},{kh.DiaChi},{kh.DienThoai}");
            }
            File.WriteAllText(filePath, sb.ToString(), new UTF8Encoding(true));
        }
        

        // ❌ Xóa khách
        private bool XoaKhachTheoMa(string maKhach)
        {
            var khach = danhSachKhach.FirstOrDefault(k => k.MaKhach.Equals(maKhach, StringComparison.OrdinalIgnoreCase));
            if (khach != null)
            {
                danhSachKhach.Remove(khach);
                GhiFileCSV();
                return true;
            }
            return false;
        }

        // 📊 Hiển thị danh sách khách
        private void HienThiDanhSach()
        {
          
            dgvKhachHang.AutoGenerateColumns = false;
            //dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = danhSachKhach;
        }

        // 🧼 Clear form
        private void ClearText()
        {
            txt_MaKhach.Clear();
            txt_TenKhach.Clear();
            txt_DiaChi.Clear();
            txt_DienThoai.Clear();
        }

        // ⚙️ Enable/disable controls
        private void SetEnable(bool enable)
        {
            txt_MaKhach.Enabled = enable;
            txt_TenKhach.Enabled = enable;
            txt_DiaChi.Enabled = enable;
            txt_DienThoai.Enabled = enable;

            btn_Luu.Enabled = enable;
            btn_BoQua.Enabled = enable;
            btn_Them.Enabled = !enable;
            btn_Sua.Enabled = !enable;
            btn_Xoa.Enabled = !enable;
        }

        // 🧩 Khi load form
        private void KhachHang_Load(object sender, EventArgs e)
        {
            DocFileCSV();

            // Tạo cột thủ công
            dgvKhachHang.AutoGenerateColumns = false;
            //dgvKhachHang.Columns.Clear();

            //dgvKhachHang.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    HeaderText = "Mã Khách",
            //    DataPropertyName = "MaKhach",
            //    Name = "colMaKhach"
            //});
            //dgvKhachHang.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    HeaderText = "Tên Khách",
            //    DataPropertyName = "TenKhach",
            //    Name = "colTenKhach"
            //});
            //dgvKhachHang.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    HeaderText = "Địa Chỉ",
            //    DataPropertyName = "DiaChi",
            //    Name = "colDiaChi"
            //});
            //dgvKhachHang.Columns.Add(new DataGridViewTextBoxColumn
            //{
            //    HeaderText = "Điện Thoại",
            //    DataPropertyName = "DienThoai",
            //    Name = "colDienThoai"
            //});

            HienThiDanhSach();
            SetEnable(false);
        }

        // ➕ Thêm khách
        private void btn_Them_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearText();
            SetEnable(true);
        }

        // 💾 Lưu khách
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MaKhach.Text) || string.IsNullOrWhiteSpace(txt_TenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng!");
                return;
            }

            if (isAdding)
            {
                // Không cho trùng mã khách
                if (danhSachKhach.Any(k => k.MaKhach.Equals(txt_MaKhach.Text, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Mã khách đã tồn tại!");
                    return;
                }

                var kh = new Khach(
                    txt_MaKhach.Text.Trim(),
                    txt_TenKhach.Text.Trim(),
                    txt_DiaChi.Text.Trim(),
                    txt_DienThoai.Text.Trim()
                );
                danhSachKhach.Add(kh);
            }
            else
            {
                if (dgvKhachHang.CurrentRow == null) return;
                var kh = (Khach)dgvKhachHang.CurrentRow.DataBoundItem;
                kh.MaKhach = txt_MaKhach.Text.Trim();
                kh.TenKhach = txt_TenKhach.Text.Trim();
                kh.DiaChi = txt_DiaChi.Text.Trim();
                kh.DienThoai = txt_DienThoai.Text.Trim();
            }

            GhiFileCSV();
            HienThiDanhSach();
            SetEnable(false);
        }

        // 🛠 Sửa khách
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null) return;
            isAdding = false;
            SetEnable(true);
        }

        // 🔁 Bỏ qua
        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            ClearText();
            SetEnable(false);
        }

        // ❌ Đóng
        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 📋 Khi chọn dòng khác
        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null) return;
            var kh = (Khach)dgvKhachHang.CurrentRow.DataBoundItem;
            txt_MaKhach.Text = kh.MaKhach;
            txt_TenKhach.Text = kh.TenKhach;
            txt_DiaChi.Text = kh.DiaChi;
            txt_DienThoai.Text = kh.DienThoai;
        }

        // 🗑 Xóa khách
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maKhach = txt_MaKhach.Text.Trim();
            if (string.IsNullOrEmpty(maKhach))
            {
                MessageBox.Show("Vui lòng nhập mã khách cần xóa!");
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa khách hàng có mã '{maKhach}' không?",
                                          "Xác nhận xóa",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool ketQua = XoaKhachTheoMa(maKhach);
                if (ketQua)
                {
                    MessageBox.Show("Đã xóa khách hàng thành công!");
                    HienThiDanhSach();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng có mã này!");
                }
            }
        }
    }
}
