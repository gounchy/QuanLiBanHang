using QuanLyBanHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Hoá_Đơn_Bán_Hàng.HoaDon;

namespace Hoá_Đơn_Bán_Hàng
{
    public partial class HoaDonBanHang : Form
    {
        private List<NhanVien> nvList;
        private List<Khach> khList;
        private List<Products> spList;
        private string fileHoaDon = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HoaDon.xlsx");

        public HoaDonBanHang()
        {
            InitializeComponent();
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

            string fileKhach = @"SanPham\khachhang.csv";
            khList = LoadKhachFromCSV(fileKhach);
            cb_TenKH.DataSource = khList;
            cb_TenKH.DisplayMember = "TenKhach";
            cb_TenKH.ValueMember = "MaKhach";
            cb_TenKH.SelectedIndex = -1;
        }

        private List<Khach> LoadKhachHang()
        {
            string file = @"SanPham\khachhang.csv";
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

        private void HienThiDonHang()
        {
            var danhSach = HoaDon.LoadFromFile(fileHoaDon);
            dgv_HoaDon.AutoGenerateColumns = false; // 🔒 Không cho tự tạo cột
            dgv_HoaDon.DataSource = danhSach;
        }

        private void HoaDonBanHang_Load(object sender, EventArgs e)
        {
            HienThiDonHang();

            nvList = new NhanVien().GetList();
            spList = new Products().GetList();
            khList = LoadKhachHang();

            cb_TenNV.DataSource = nvList;
            cb_TenNV.DisplayMember = "TenNV";
            cb_TenNV.ValueMember = "MaNV";

            cb_TenKH.DataSource = khList;
            cb_TenKH.DisplayMember = "TenKhach";
            cb_TenKH.ValueMember = "MaKhach";

            // ✅ Quan trọng: Tắt auto-generate cột
            dgv_HoaDon.AutoGenerateColumns = false;

            // ✅ Nếu chưa có cột thì thêm thủ công
            if (dgv_HoaDon.Columns.Count == 0)
            {
                dgv_HoaDon.Columns.Add("MaHang", "Mã hàng");
                dgv_HoaDon.Columns.Add("TenHang", "Tên hàng");
                dgv_HoaDon.Columns.Add("DonGia", "Đơn giá");
                dgv_HoaDon.Columns.Add("SoLuong", "Số lượng");
                dgv_HoaDon.Columns.Add("ThanhTien", "Thành tiền");
            }

            // ✅ Gán datasource sau khi tắt auto-generate
            dgv_HoaDon.DataSource = spList;
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
            // TODO: In hóa đơn
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            var selectedProducts = spList.Where(p => p.soLuong > 0).ToList();
            if (selectedProducts.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để thanh toán!");
                return;
            }

            var nv = (NhanVien)cb_TenNV.SelectedItem;
            var kh = (Khach)cb_TenKH.SelectedItem;

            string maHD = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");

            var hoaDon = new HoaDon
            {
                MaHD = maHD,
                MaNV = nv.MaNV,
                MaKhach = kh.MaKhach,
                NgayLap = DateTime.Now
            };

            foreach (var sp in selectedProducts)
            {
                hoaDon.ChiTiet.Add(new HoaDonChiTiet
                {
                    MaHD = maHD,
                    MaHang = sp.maHang,
                    TenHang = sp.tenHang,
                    SoLuong = sp.soLuong,
                    DonGia = sp.Gia
                });
            }

            hoaDon.SaveToFile(fileHoaDon);

            MessageBox.Show($"Đã tạo hóa đơn {maHD}\nTổng tiền: {hoaDon.TongTien:N0} VNĐ",
                "Thanh toán thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_DongDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
