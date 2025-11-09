using Hoá_Đơn_Bán_Hàng;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class KhachHang : Form
    {
        private List<Khach> danhSachKhach = new List<Khach>();
        private bool isAdding = false;

        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            // Load danh sách gốc
            danhSachKhach = Khach.DocFileCSV();
            HienThiDanhSach(danhSachKhach);
            SetEnable(false);

            // Gắn tìm kiếm realtime
            txt_TenKhach.TextChanged += TimKiemTuDong;
            txt_DiaChi.TextChanged += TimKiemTuDong;
            txt_DienThoai.TextChanged += TimKiemTuDong;

            txt_MaKhach.Enabled = false; // mã KH không sửa
        }

        // Hiển thị danh sách lên DataGridView
        private void HienThiDanhSach(List<Khach> ds)
        {
            dgvKhachHang.SelectionChanged -= dgvKhachHang_SelectionChanged;
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = ds;
            dgvKhachHang.SelectionChanged += dgvKhachHang_SelectionChanged;
        }


        // Bật/tắt các control nhập liệu và nút chức năng
        private void SetEnable(bool enable)
        {
            txt_MaKhach.Enabled = false;
            txt_TenKhach.Enabled = true; // luôn mở cho tìm kiếm
            txt_DiaChi.Enabled = enable;
            txt_DienThoai.Enabled = enable;

            btn_Luu.Enabled = enable;
            btn_BoQua.Enabled = enable;

            btn_Them.Enabled = !enable;
            btn_Sua.Enabled = !enable;
            btn_Xoa.Enabled = !enable;
        }

        private void ClearText()
        {
            txt_MaKhach.Clear();
            txt_TenKhach.Clear();
            txt_DiaChi.Clear();
            txt_DienThoai.Clear();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ClearText();
            SetEnable(true);
            txt_MaKhach.Text = Khach.TaoMaKhachTuDong(danhSachKhach);
            txt_TenKhach.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TenKhach.Text))
            {
                MessageBox.Show("Tên khách không được để trống!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_DiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống!");
                return;
            }

            if (!Regex.IsMatch(txt_DienThoai.Text.Trim(), @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải có đúng 10 chữ số!");
                return;
            }

            if (isAdding)
            {
                var kh = Khach.ThemKhach(
                    danhSachKhach,
                    txt_TenKhach.Text.Trim(),
                    txt_DiaChi.Text.Trim(),
                    txt_DienThoai.Text.Trim()
                );
                MessageBox.Show($"Đã thêm khách hàng {kh.TenKhach} ({kh.MaKhach}) thành công!");
            }
            else
            {
                var khMoi = new Khach(
                    txt_MaKhach.Text.Trim(),
                    txt_TenKhach.Text.Trim(),
                    txt_DiaChi.Text.Trim(),
                    txt_DienThoai.Text.Trim()
                );

                bool ok = Khach.SuaKhach(danhSachKhach, khMoi);
                if (ok)
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
                else
                    MessageBox.Show("Không tìm thấy khách hàng để sửa!");
            }

            danhSachKhach = Khach.DocFileCSV();
            HienThiDanhSach(danhSachKhach);
            SetEnable(false);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
                return;
            }

            isAdding = false;
            SetEnable(true);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string ma = txt_MaKhach.Text.Trim();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Vui lòng chọn khách cần xóa!");
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa khách có mã {ma} không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool ok = Khach.XoaKhachTheoMa(danhSachKhach, ma);
                if (ok)
                {
                    MessageBox.Show("Đã xóa khách hàng!");
                    danhSachKhach = Khach.DocFileCSV();
                    HienThiDanhSach(danhSachKhach);
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng!");
                }
            }
        }

        private void TimKiemTuDong(object sender, EventArgs e)
        {
            // Luôn lọc trên danh sách gốc
            string tuKhoa = $"{txt_TenKhach.Text} {txt_DiaChi.Text} {txt_DienThoai.Text}".Trim();

            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                HienThiDanhSach(danhSachKhach);
                return;
            }

            var ketQua = Khach.TimKiem(danhSachKhach, tuKhoa);
            HienThiDanhSach(ketQua);
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            ClearText();
            SetEnable(false);
            HienThiDanhSach(danhSachKhach);
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvKhachHang_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null || dgvKhachHang.CurrentRow.Index < 0)
                return;

            txt_TenKhach.TextChanged -= TimKiemTuDong;
            txt_DiaChi.TextChanged -= TimKiemTuDong;
            txt_DienThoai.TextChanged -= TimKiemTuDong;

            if (dgvKhachHang.CurrentRow.DataBoundItem is Khach kh)
            {
                txt_MaKhach.Text = kh.MaKhach;
                txt_TenKhach.Text = kh.TenKhach;
                txt_DiaChi.Text = kh.DiaChi;
                txt_DienThoai.Text = kh.DienThoai;
            }

            txt_TenKhach.TextChanged += TimKiemTuDong;
            txt_DiaChi.TextChanged += TimKiemTuDong;
            txt_DienThoai.TextChanged += TimKiemTuDong;
        }
    }
}
