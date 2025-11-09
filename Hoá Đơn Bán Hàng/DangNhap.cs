using QuanLyBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoá_Đơn_Bán_Hàng
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            this.AcceptButton = btn_DangNhap; // Nhấn Enter để đăng nhập
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txt_DangNhap.Text.Trim();
            string matKhau = txt_MatKhau.Text.Trim();

            // Giả sử danh sách tài khoản lưu sẵn trong GlobalSettings
            var taiKhoan = GlobalSettings.DanhSachTaiKhoan
                .FirstOrDefault(tk => tk.TenDangNhap == tenDN && tk.MatKhau == matKhau);

            if (taiKhoan != null)
            {
                GlobalSettings.TaiKhoanHienTai = taiKhoan;
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();

                // mở form chính sau khi đăng nhập
                var formChinh = new HoaDonBanHang();
                formChinh.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DoiMatKhau_Click(object sender, EventArgs e)
        {
            string tenDN = txt_DangNhap.Text.Trim();

            if (string.IsNullOrEmpty(tenDN))
            {
                MessageBox.Show("Vui lòng nhập tài khoản trước khi đổi mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tìm tài khoản trong danh sách
            var tk = GlobalSettings.DanhSachTaiKhoan.FirstOrDefault(x => x.TenDangNhap == tenDN);
            if (tk == null)
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mở form đổi mật khẩu, truyền tài khoản tương ứng
            DoiMatKhau form = new DoiMatKhau(tk);
            form.ShowDialog();

            txt_DangNhap.Clear();
            txt_MatKhau.Clear();
        }
    }
}
