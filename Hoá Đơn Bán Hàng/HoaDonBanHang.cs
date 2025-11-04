using QuanLyBanHang;
using System.Data;
using System.Text;
using static Hoá_Đơn_Bán_Hàng.HoaDon;

namespace Hoá_Đơn_Bán_Hàng
{
    public partial class HoaDonBanHang : Form
    {
        private List<NhanVien> nvList;
        private List<Khach> khList;
        private List<Products> spList;
        private List<HoaDon.HoaDonChiTiet> danhSach = new List<HoaDon.HoaDonChiTiet>();
        public HoaDonBanHang()
        {
            InitializeComponent();
            dgv_HoaDon.AutoGenerateColumns = false;
            dgv_HoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // MÀU NỀN CÁCH DÒNG  
            dgv_HoaDon.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_HoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;


            //chặn lỗi hiển thị DataError
            //dgv_HoaDon.DataError += (s, e) => { e.ThrowException = false; };
        }

        private List<Khach> LoadKhachFromCSV(string filePath)
        {
            List<Khach> list = new List<Khach>();
            if (!System.IO.File.Exists(filePath)) return list;

            var lines = System.IO.File.ReadAllLines(filePath).Skip(1); // bỏ header
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 4)
                    list.Add(new Khach(parts[0], parts[1], parts[2], parts[3]));
            }
            return list;
        }

        public void HienThiSanPhamDaThanhToan(List<QuanLyBanHang.Products> danhSachSanPham)
        {
            dgv_HoaDon.Rows.Clear();

            decimal tongTien = 0;

            foreach (var sp in danhSachSanPham)
            {
                decimal thanhTien = sp.Gia * sp.soLuong;
                tongTien += thanhTien;

                dgv_HoaDon.Rows.Add(sp.maHang, sp.tenHang, sp.Gia, sp.soLuong, thanhTien);
            }

            if (txt_ThanhTien != null)
                txt_ThanhTien.Text = tongTien.ToString("N0");
        }

        private void LoadData()
        {
            NhanVien nv = new NhanVien();
            nvList = nv.GetList();
            cb_TenNV.DataSource = nvList;
            cb_TenNV.DisplayMember = "TenNV";
            cb_TenNV.ValueMember = "MaNV";
            cb_TenNV.SelectedIndex = -1;

            string fileKhach = GlobalSettings.khachhangFile;
            khList = LoadKhachFromCSV(fileKhach);
            cb_TenKH.DataSource = khList;
            cb_TenKH.DisplayMember = "TenKhach";
            cb_TenKH.ValueMember = "MaKhach";
            cb_TenKH.SelectedIndex = -1;
        }

        private List<Khach> LoadKhachHang()
        {
            string file = GlobalSettings.khachhangFile;
            List<Khach> list = new List<Khach>();

            if (!File.Exists(file)) return list;

            var lines = File.ReadAllLines(file).Skip(1); // bỏ header
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var p = line.Split(',');
                if (p.Length < 4) continue;
                list.Add(new Khach(p[0], p[1], p[2], p[3]));
            }
            return list;
        }


        public void HienThiDonHang()
        {
            string fileHoaDon = GlobalSettings.hoadonFile;
            danhSach = HoaDon.LoadFromFile(fileHoaDon);  // Gán vào biến toàn cục

            dgv_HoaDon.DataSource = null;
            dgv_HoaDon.DataSource = danhSach;

        }

        private void HoaDonBanHang_Load(object sender, EventArgs e)
        {
            nvList = new NhanVien().GetList();
            spList = new Products().GetList();
            khList = LoadKhachHang();
            HienThiDonHang();


            cb_TenNV.DataSource = nvList;
            cb_TenNV.DisplayMember = "TenNV";
            cb_TenNV.ValueMember = "MaNV";

            cb_TenKH.DataSource = khList;
            cb_TenKH.DisplayMember = "TenKhach";
            cb_TenKH.ValueMember = "MaKhach";



            txt_MaHD.ReadOnly = true;
        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucNhanVien danhMucNhanVien = new DanhMucNhanVien();
            danhMucNhanVien.Show();
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.Show();
        }

        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhMucHangHoa danhMucHangHoa = new DanhMucHangHoa();
            danhMucHangHoa.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DangNhap dangNhap = new DangNhap();
                dangNhap.Show();
            }
        }

        private void cb_TenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TenNV.SelectedIndex >= 0)
            {
                var nv = (NhanVien)cb_TenNV.SelectedItem;
                txt_MaNV.Text = nv.MaNV;
                txt_DiaChiNV.Text = nv.DiaChi;
                txt_DienThoaiNV.Text = nv.DienThoai;
            }
        }

        private void cb_TenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TenKH.SelectedIndex >= 0)
            {
                var kh = (Khach)cb_TenKH.SelectedItem;
                txt_MaKH.Text = kh.MaKhach;
                txt_DiaChiKH.Text = kh.DiaChi;
                txt_DienThoaiKH.Text = kh.DienThoai;
            }
        }

        private void btn_InDon_Click(object sender, EventArgs e)
        {
            HienThiDonHang();

            MessageBox.Show("Đã cập nhật danh sách hóa đơn mới nhất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_DongDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_HoaDon_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_HoaDon.CurrentRow == null ||
                    dgv_HoaDon.CurrentRow.DataBoundItem == null)
                    return;

                if (dgv_HoaDon.CurrentRow.DataBoundItem is HoaDonChiTiet sp)
                {
                    txt_MaHD.Text = sp.MaHD ?? "";
                    txt_MaHD2.Text = sp.MaHD ?? "";
                    txt_MaNV.Text = sp.MaNV ?? "";
                    txt_MaKH.Text = sp.MaKhach ?? "";
                    txt_NgayBan.Text = sp.NgayLap.ToString("dd/MM/yyyy");
                    txt_MaHang.Text = sp.MaHang ?? "";
                    txt_SoLuong.Text = sp.SoLuong.ToString();
                    txt_DonGia.Text = sp.DonGia.ToString("N0");
                    txt_ThanhTien.Text = (sp.DonGia * sp.SoLuong).ToString("N0");

                    if (cb_TenNV.DataSource != null)
                    {
                        cb_TenNV.SelectedValue = sp.MaNV;
                    }

                    if (cb_TenKH.DataSource != null)
                    {
                        cb_TenKH.SelectedValue = sp.MaKhach;
                    }
                }
            }
            catch (Exception)
            {
                // Bỏ qua lỗi khi DataGridView đang trong quá trình cập nhật
            }
        }

        private void btn_XoaDon_Click(object sender, EventArgs e)
        {
            if (dgv_HoaDon.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HoaDon.HoaDonChiTiet xoahoadon = dgv_HoaDon.CurrentRow.DataBoundItem as HoaDon.HoaDonChiTiet;
            if (xoahoadon == null) return;

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa sản phẩm '{xoahoadon.TenHang}' trong hóa đơn {xoahoadon.MaHD} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // TẮT EVENT TRƯỚC KHI CẬP NHẬT
                dgv_HoaDon.SelectionChanged -= dgv_HoaDon_SelectionChanged;

                try
                {
                    danhSach.Remove(xoahoadon);

                    string fileHoaDon = GlobalSettings.hoadonFile;
                    using (StreamWriter sw = new StreamWriter(fileHoaDon, false, Encoding.UTF8))
                    {
                        sw.WriteLine("MaHD,MaNV,MaKH,NgayLap,MaHang,TenHang,SoLuong,DonGia,ThanhTien");
                        foreach (var ct in danhSach)
                        {
                            sw.WriteLine($"{ct.MaHD},{ct.MaNV},{ct.MaKhach},{ct.NgayLap:yyyy-MM-dd},{ct.MaHang},{ct.TenHang},{ct.SoLuong},{ct.DonGia},{ct.ThanhTien}");
                        }
                    }

                    dgv_HoaDon.DataSource = null;
                    dgv_HoaDon.DataSource = danhSach;

                    MessageBox.Show("Đã xóa dòng sản phẩm khỏi hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    // BẬT LẠI EVENT SAU KHI HOÀN TẤT
                    dgv_HoaDon.SelectionChanged += dgv_HoaDon_SelectionChanged;
                }
            }
        }

        private void txt_timhoadon_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_timhoadon.Text.Trim().ToLower();

            dgv_HoaDon.SelectionChanged -= dgv_HoaDon_SelectionChanged;

            if (string.IsNullOrEmpty(filterText))
            {
                dgv_HoaDon.DataSource = null;
                dgv_HoaDon.DataSource = danhSach;
            }
            else
            {
                var filtered = danhSach.Where(hd =>
                    (hd.MaHD?.ToLower().Contains(filterText) ?? false) ||
                    (hd.MaNV?.ToLower().Contains(filterText) ?? false) ||
                    (hd.MaKhach?.ToLower().Contains(filterText) ?? false) ||
                    (hd.MaHang?.ToLower().Contains(filterText) ?? false) ||
                    (hd.TenHang?.ToLower().Contains(filterText) ?? false) ||
                    hd.SoLuong.ToString().Contains(filterText) ||
                    hd.DonGia.ToString().Contains(filterText) ||
                    hd.ThanhTien.ToString().Contains(filterText) ||
                    hd.NgayLap.ToString("dd/MM/yyyy").Contains(filterText)
                ).ToList();

                dgv_HoaDon.DataSource = null;
                dgv_HoaDon.DataSource = filtered;
            }

            dgv_HoaDon.Refresh();
            dgv_HoaDon.SelectionChanged += dgv_HoaDon_SelectionChanged;
        }
    }
}
