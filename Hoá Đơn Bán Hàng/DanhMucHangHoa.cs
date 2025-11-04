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
using static Hoá_Đơn_Bán_Hàng.HoaDon;

namespace QuanLyBanHang
{
    public partial class DanhMucHangHoa : Form
    {
        private string productsFile = GlobalSettings.productsFile;
        private bool isEditing = false;
        private string fileHoaDon = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"SanPham\HoaDon.csv");

        List<Products> proList = new List<Products>();
        public DanhMucHangHoa()
        {
            InitializeComponent();
        }

        public void LoadProducts(string fileName = "")
        {
            fileName = (fileName == "") ? GlobalSettings.productsFile : fileName;

            List<Products> list = new List<Products>();

            if (!File.Exists(fileName)) return;

            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length != 5) continue;

                if (!decimal.TryParse(parts[3], out decimal gia)) continue;
                if (!int.TryParse(parts[4], out int soLuong)) continue;

                list.Add(new Products
                {
                    maHang = parts[0],
                    tenHang = parts[1],
                    Loai = parts[2],
                    Gia = gia,
                    soLuong = soLuong
                });
            }


            dgv_HangHoa.DataSource = null;
            dgv_HangHoa.DataSource = list;
        }

        private void DanhMucHangHoa_Load(object sender, EventArgs e)
        {
            Products pro = new Products();
            proList = pro.GetList();
            dgv_HangHoa.DataSource = proList;
        }

        private void txt_Filter_TextChanged(object sender, EventArgs e)
        {
            string filterText = txt_Filter.Text.ToLower();
            if (string.IsNullOrEmpty(filterText))
            {
                dgv_HangHoa.DataSource = proList;
            }
            else
            {
                var filtered = proList.Where(s =>
                    s.maHang.ToLower().Contains(filterText) ||
                    s.tenHang.ToLower().Contains(filterText) ||
                    s.Loai.ToLower().Contains(filterText)
                //s.soLuong.ToLower().Contains(filterText)
                ).ToList();

                dgv_HangHoa.DataSource = filtered;
            }
            dgv_HangHoa.Refresh();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                Products newProduct = new Products()
                {
                    maHang = txt_MaHang.Text,
                    tenHang = txt_TenHang.Text,
                    Loai = txt_Loai.Text,
                    Gia = decimal.Parse(txt_Gia.Text),
                    soLuong = int.Parse(txt_SoLuong.Text)
                };

                Products pro = new Products();
                pro.AddProduct(newProduct);
                LoadProducts();
                MessageBox.Show("Thêm sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_Gia.Text = "";
            txt_Loai.Text = "";
            txt_MaHang.Text = "";
            txt_SoLuong.Text = "";
            txt_TenHang.Text = "";

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maHang = txt_MaHang.Text;
            if (string.IsNullOrWhiteSpace(maHang))
            {
                MessageBox.Show("Vui lòng nhập mã hàng để xóa");
                return;
            }

            Products pro = new Products();
            pro.DeleteProduct(maHang);
            LoadProducts();
            MessageBox.Show("Xóa sản phẩm thành công!");
            txt_Gia.Text = "";
            txt_Loai.Text = "";
            txt_MaHang.Text = "";
            txt_SoLuong.Text = "";
            txt_TenHang.Text = "";

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dgv_HangHoa.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            DataGridViewRow row = dgv_HangHoa.CurrentRow;
            txt_MaHang.Text = row.Cells["maHang"].Value.ToString();
            txt_TenHang.Text = row.Cells["tenHang"].Value.ToString();
            txt_Loai.Text = row.Cells["Loai"].Value.ToString();
            txt_Gia.Text = row.Cells["Gia"].Value.ToString();
            txt_SoLuong.Text = row.Cells["soLuong"].Value.ToString();
            txt_TenHang.Enabled = true;
            txt_Loai.Enabled = true;
            txt_Gia.Enabled = true;
            txt_SoLuong.Enabled = true;
            txt_MaHang.Enabled = false;
            isEditing = true;

            MessageBox.Show("Bạn có thể sửa thông tin sản phẩm, sau đó nhấn Lưu để cập nhật!");
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEditing)
                {
                    Products updated = new Products()
                    {
                        maHang = txt_MaHang.Text,
                        tenHang = txt_TenHang.Text,
                        Loai = txt_Loai.Text,
                        Gia = decimal.Parse(txt_Gia.Text),
                        soLuong = int.Parse(txt_SoLuong.Text)
                    };

                    Products pro = new Products();
                    pro.UpdateProduct(updated);

                    MessageBox.Show("Đã lưu chỉnh sửa sản phẩm thành công!");
                }
                else
                {
                    List<Products> listToSave = new List<Products>();
                    foreach (DataGridViewRow row in dgv_HangHoa.Rows)
                    {
                        if (row.IsNewRow) continue;
                        listToSave.Add(new Products()
                        {
                            maHang = row.Cells["maHang"].Value?.ToString() ?? "",
                            tenHang = row.Cells["tenHang"].Value?.ToString() ?? "",
                            Loai = row.Cells["Loai"].Value?.ToString() ?? "",
                            Gia = row.Cells["Gia"].Value != null ? Convert.ToDecimal(row.Cells["Gia"].Value) : 0m,
                            soLuong = row.Cells["soLuong"].Value != null ? Convert.ToInt32(row.Cells["soLuong"].Value) : 0
                        });
                    }

                    Products pro = new Products();
                    pro.SaveAll(listToSave);

                    MessageBox.Show("Dữ liệu đã được lưu lại toàn bộ!");
                }

                LoadProducts();
                txt_MaHang.Clear();
                txt_TenHang.Clear();
                txt_Loai.Clear();
                txt_Gia.Clear();
                txt_SoLuong.Clear();
                isEditing = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }

        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {

            if (dgv_HangHoa.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để thanh toán!");
                return;
            }

            // Lấy dữ liệu từ dòng được chọn
            DataGridViewRow row = dgv_HangHoa.CurrentRow;
            string maHang = row.Cells["maHang"].Value.ToString();
            string tenHang = row.Cells["tenHang"].Value.ToString();
            decimal gia = Convert.ToDecimal(row.Cells["Gia"].Value);
            int soLuongTon = Convert.ToInt32(row.Cells["soLuong"].Value);

            // Hỏi người dùng số lượng muốn mua
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Nhập số lượng muốn mua cho sản phẩm '{tenHang}' (tồn kho: {soLuongTon}):",
                "Thanh toán sản phẩm",
                "1");

            if (string.IsNullOrWhiteSpace(input)) return;

            if (!int.TryParse(input, out int soLuongMua) || soLuongMua <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            if (soLuongMua > soLuongTon)
            {
                MessageBox.Show("Số lượng mua vượt quá tồn kho!");
                return;
            }
            int soHoaDon = 1;
            if (File.Exists(fileHoaDon))
                soHoaDon = File.ReadAllLines(fileHoaDon).Length; // tính dòng (có header)
            string maHD = soHoaDon.ToString("D3");
            // Tính tổng tiền
            decimal tongTien = gia * soLuongMua;

            // Cập nhật số lượng tồn
            int soLuongConLai = soLuongTon - soLuongMua;
            row.Cells["soLuong"].Value = soLuongConLai;

            // Cập nhật vào file
            Products pro = new Products();
            pro.UpdateQuantity(maHang, soLuongConLai);


            var hoaDon = new HoaDon
            {
                MaHD = maHD,
                MaNV = "01",
                MaKhach = "KH001",
                NgayLap = DateTime.Now
            };

            hoaDon.ChiTiet.Add(new HoaDonChiTiet
            {
                MaHD = maHD,
                MaNV = hoaDon.MaNV,
                MaKhach = hoaDon.MaKhach,
                NgayLap = hoaDon.NgayLap,
                MaHang = maHang,
                TenHang = tenHang,
                SoLuong = soLuongMua,
                DonGia = gia
            });

            // Lưu vào file HoaDon.csv
            hoaDon.SaveToFile(fileHoaDon);

            // Thông báo kết quả
            MessageBox.Show(
                $"Thanh toán thành công!\n" +
                $"Sản phẩm: {tenHang}\n" +
                $"Số lượng mua: {soLuongMua}\n" +
                $"Tổng tiền: {tongTien:N0} đ\n" +
                $"Số lượng còn lại: {soLuongConLai}",
                "Thanh toán",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Cập nhật lại bảng
            //LoadProducts();
            
        }
    }
}
