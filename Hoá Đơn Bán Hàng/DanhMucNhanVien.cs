using Hoá_Đơn_Bán_Hàng;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyBanHang
{
    public partial class DanhMucNhanVien : Form
    {
        List<NhanVien> nhanvienList = new List<NhanVien>();
        private bool isModified = false;
        private bool isEditing = false;
        private NhanVien originalNV = null;
        public DanhMucNhanVien()
        {
            InitializeComponent();
            dgv_nhanvien.AutoGenerateColumns = false;
            dgv_nhanvien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // MÀU NỀN CÁCH DÒNG  
            dgv_nhanvien.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_nhanvien.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

        }


        private void DanhMucNhanVien_Load(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nhanvienList = nv.GetList();
            dgv_nhanvien.DataSource = nhanvienList;
        }

        private void txt_manv_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void txt_ten_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void chk_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Nam.Checked && chk_Nu.Checked) chk_Nu.Checked = false;
            ApplyFilters();
        }

        private void chk_Nu_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Nu.Checked && chk_Nam.Checked) chk_Nam.Checked = false;
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            List<NhanVien> result = nhanvienList;

            // Lọc theo Mã NV
            string filterMa = txt_manv.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(filterMa))
            {
                result = result.FindAll(nv => nv.MaNV.ToLower().Contains(filterMa));
            }

            // Lọc theo Tên NV
            string filterTen = txt_ten.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(filterTen))
            {
                result = result.FindAll(nv => nv.TenNV.ToLower().Contains(filterTen));
            }

            // Lọc theo Số điện thoại
            string filterSdt = txt_sdt.Text.Trim();
            if (!string.IsNullOrEmpty(filterSdt))
            {
                result = result.FindAll(nv => nv.DienThoai.Contains(filterSdt));
            }

            // Lọc theo Địa chỉ
            string filterDiaChi = txt_diachi.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(filterDiaChi))
            {
                result = result.FindAll(nv => nv.DiaChi.ToLower().Contains(filterDiaChi));
            }

            // Lọc theo giới tính
            if (chk_Nam.Checked != chk_Nu.Checked)
            {
                bool isMale = chk_Nam.Checked; // checkBox1 = Nam
                result = result.FindAll(nv => nv.GioiTinh == isMale);
            }

            dgv_nhanvien.DataSource = null;
            dgv_nhanvien.DataSource = result;
            dgv_nhanvien.Refresh();
        }



        private void dgv_nhanvien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgv_nhanvien.Columns["GioiTinh"].Index && e.Value != null)
            {
                bool gioiTinh = (bool)e.Value; // giá trị gốc là bool
                e.Value = gioiTinh ? "Nam" : "Nữ"; // hiển thị "Nam"/"Nữ"
                e.FormattingApplied = true;
            }
        }

        private void btn_themnv_Click(object sender, EventArgs e)
        {
            // Validate bắt buộc
            if (string.IsNullOrWhiteSpace(txt_manv.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã NV!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_manv.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_ten.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Nhân Viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_ten.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_sdt.Text))
            {
                MessageBox.Show("Vui lòng nhập Điện thoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_diachi.Text))
            {
                MessageBox.Show("Vui lòng nhập Địa chỉ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_diachi.Focus();
                return;
            }

            if (chk_Nam.Checked == chk_Nu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SDT chỉ chứa chữ số (bỏ khoảng trắng nếu có)
            string phone = txt_sdt.Text.Trim();
            if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Điện thoại chỉ được chứa chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_sdt.Focus();
                return;
            }

            // Mã NV không trùng (không phân biệt hoa thường)
            string maNv = txt_manv.Text.Trim();
            if (nhanvienList.Any(nv0 => string.Equals(nv0.MaNV, maNv, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã Nhân Viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_manv.Focus();
                return;
            }

            // Tạo nhân viên mới từ input (MaNV là get-only => truyền qua constructor)
            NhanVien nv = new NhanVien(
                maNv,
                txt_ten.Text.Trim(),
                dtp_NgaySinh.Value.Date,
                chk_Nam.Checked,
                phone,
                txt_diachi.Text.Trim()
            );

            nhanvienList.Add(nv);

            // Refresh lưới và chọn dòng vừa thêm
            capnhap(maNv);
            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInputs();
            isModified = true;
        }

        private void capnhap(string maNvToSelect)
        {
            dgv_nhanvien.DataSource = null;
            dgv_nhanvien.DataSource = nhanvienList;
            dgv_nhanvien.Refresh();
            if (!string.IsNullOrEmpty(maNvToSelect))
            {
                foreach (DataGridViewRow row in dgv_nhanvien.Rows)
                {
                    if (row.DataBoundItem is NhanVien nv && string.Equals(nv.MaNV, maNvToSelect, StringComparison.OrdinalIgnoreCase))
                    {
                        row.Selected = true;
                        dgv_nhanvien.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
        }

        private void ClearInputs()
        {
            txt_manv.Text = "";
            txt_ten.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            dtp_NgaySinh.Value = DateTime.Today;
            chk_Nam.Checked = false;
            chk_Nu.Checked = false;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_nhanvien.CurrentRow == null)
                return;

            NhanVien xoanhanvien = dgv_nhanvien.CurrentRow.DataBoundItem as NhanVien;
            if (xoanhanvien == null) return;

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa nhân viên {xoanhanvien.TenNV} không?",
                                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa khỏi danh sách
                nhanvienList.Remove(xoanhanvien);

                // Cập nhật DataGridView
                capnhap(null);

                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isModified = true;
            }

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (isEditing && originalNV != null)
            {
                // Validate
                if (string.IsNullOrWhiteSpace(txt_ten.Text) ||
                    string.IsNullOrWhiteSpace(txt_sdt.Text) ||
                    string.IsNullOrWhiteSpace(txt_diachi.Text))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (chk_Nam.Checked == chk_Nu.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string phone = txt_sdt.Text.Trim();
                if (!phone.All(char.IsDigit))
                {
                    MessageBox.Show("Điện thoại chỉ được chứa chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_sdt.Focus();
                    return;
                }

                // ⭐ Cập nhật trực tiếp object originalNV
                originalNV.TenNV = txt_ten.Text.Trim();
                originalNV.DiaChi = txt_diachi.Text.Trim();
                originalNV.DienThoai = phone;
                originalNV.NgaySinh = dtp_NgaySinh.Value.Date;
                originalNV.GioiTinh = chk_Nam.Checked;

                capnhap(originalNV.MaNV);
                isModified = true;
                isEditing = false;
                originalNV = null;

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                return;
            }

            // Nếu không phải đang sửa, thì không làm gì cả
            if (!isModified)
            {
                MessageBox.Show("Không có thay đổi nào để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string filePath = @"SanPham\NhanVien.csv";
            NhanVien.SaveList(nhanvienList, filePath);
            isModified = false;

            MessageBox.Show("Đã lưu thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_skip_Click(object sender, EventArgs e)
        {
            //Dừng sửa
            if (isEditing)
            {
                isEditing = false;
                originalNV = null;
            }

            if (isModified)
            {
                // Tải lại dữ liệu từ file để khôi phục trạng thái đã lưu
                ReloadFromFile();
                isModified = false;
                MessageBox.Show("Đã khôi phục dữ liệu từ tệp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Xóa hết các input trên form
            ClearInputs();

        }

        private void ReloadFromFile()
        {
            NhanVien nvLoader = new NhanVien();
            nhanvienList = nvLoader.GetList();

            ApplyFilters();
        }

        private void DanhMucNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isModified)
            {
                var result = MessageBox.Show(
                    "Bạn có muốn lưu thay đổi trước khi đóng không?",
                    "Chưa lưu",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                if (result == DialogResult.Yes)
                {
                    string filePath = @"SanPham\NhanVien.csv";
                    NhanVien.SaveList(nhanvienList, filePath);
                    isModified = false;
                    MessageBox.Show("Đã lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            txt_manv.Enabled = false; // Khóa Mã NV khi sửa
            if (dgv_nhanvien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy object NhanVien từ dòng đang chọn
            if (dgv_nhanvien.CurrentRow.DataBoundItem is NhanVien nv)
            {
                txt_manv.Text = nv.MaNV; // get-only
                txt_ten.Text = nv.TenNV;
                txt_diachi.Text = nv.DiaChi;
                txt_sdt.Text = nv.DienThoai;
                dtp_NgaySinh.Value = nv.NgaySinh == default ? DateTime.Today : nv.NgaySinh;
                chk_Nam.Checked = nv.GioiTinh;
                chk_Nu.Checked = !nv.GioiTinh;

                //Lưu reference đến nhân viên đang sửa
                isEditing = true;
                originalNV = nv;
            }
        }

        private void btn_esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

