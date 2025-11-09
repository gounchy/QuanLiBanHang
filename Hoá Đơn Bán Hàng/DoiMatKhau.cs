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
using static QuanLyBanHang.GlobalSettings;

namespace Hoá_Đơn_Bán_Hàng
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private TaiKhoan taiKhoan;

        public DoiMatKhau(TaiKhoan tk)
        {
            InitializeComponent();
            taiKhoan = tk;
            this.Text = $"Đổi mật khẩu - {tk.TenDangNhap}";
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string mkCu = txt_MatKhauCu.Text.Trim();
            string mkMoi = txt_MatKhauMoi.Text.Trim();
            string mkXacNhan = txt_XacNhan.Text.Trim();

            if (string.IsNullOrEmpty(mkCu) || string.IsNullOrEmpty(mkMoi) || string.IsNullOrEmpty(mkXacNhan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            if (mkCu != taiKhoan.MatKhau)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mkMoi != mkXacNhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            taiKhoan.MatKhau = mkMoi;
            MessageBox.Show("Đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
