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
            string username = txt_DangNhap.Text.Trim();
            string password = txt_MatKhau.Text.Trim();

            // Kiểm tra tài khoản và mật khẩu
            if (username == "admin" && password == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HoaDonBanHang hoaDonBanHangForm = new HoaDonBanHang();
                hoaDonBanHangForm.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
