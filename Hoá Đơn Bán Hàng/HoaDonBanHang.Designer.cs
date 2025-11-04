namespace Hoá_Đơn_Bán_Hàng
{
    partial class HoaDonBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txt_DienThoaiKH = new TextBox();
            txt_DiaChiKH = new TextBox();
            label16 = new Label();
            lbl_DiaChiKH = new Label();
            cb_TenKH = new ComboBox();
            txt_MaNV = new TextBox();
            txt_NgayBan = new TextBox();
            txt_MaKH = new TextBox();
            txt_MaHD = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            thêmNhânViênToolStripMenuItem = new ToolStripMenuItem();
            thêmKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thêmSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            txt_DiaChiNV = new TextBox();
            txt_DienThoaiNV = new TextBox();
            cb_TenNV = new ComboBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            txt_timhoadon = new TextBox();
            label11 = new Label();
            label15 = new Label();
            label13 = new Label();
            txt_ThanhTien = new TextBox();
            txt_SoLuong = new TextBox();
            label10 = new Label();
            label14 = new Label();
            txt_MaHD2 = new TextBox();
            txt_DonGia = new TextBox();
            label9 = new Label();
            txt_MaHang = new TextBox();
            dgv_HoaDon = new DataGridView();
            colMaHD = new DataGridViewTextBoxColumn();
            colMaNV = new DataGridViewTextBoxColumn();
            colMaKH = new DataGridViewTextBoxColumn();
            colNgayLap = new DataGridViewTextBoxColumn();
            colMaHang = new DataGridViewTextBoxColumn();
            colTenHang = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            btn_DongDon = new Button();
            btn_InDon = new Button();
            btn_XoaDon = new Button();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_DienThoaiKH);
            panel1.Controls.Add(txt_DiaChiKH);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(lbl_DiaChiKH);
            panel1.Controls.Add(cb_TenKH);
            panel1.Controls.Add(txt_MaNV);
            panel1.Controls.Add(txt_NgayBan);
            panel1.Controls.Add(txt_MaKH);
            panel1.Controls.Add(txt_MaHD);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menuStrip1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1415, 283);
            panel1.TabIndex = 0;
            // 
            // txt_DienThoaiKH
            // 
            txt_DienThoaiKH.Enabled = false;
            txt_DienThoaiKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_DienThoaiKH.Location = new Point(1067, 116);
            txt_DienThoaiKH.Name = "txt_DienThoaiKH";
            txt_DienThoaiKH.Size = new Size(260, 27);
            txt_DienThoaiKH.TabIndex = 19;
            // 
            // txt_DiaChiKH
            // 
            txt_DiaChiKH.Enabled = false;
            txt_DiaChiKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_DiaChiKH.Location = new Point(1067, 69);
            txt_DiaChiKH.Name = "txt_DiaChiKH";
            txt_DiaChiKH.Size = new Size(260, 27);
            txt_DiaChiKH.TabIndex = 19;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(918, 116);
            label16.Name = "label16";
            label16.Size = new Size(78, 20);
            label16.TabIndex = 18;
            label16.Text = "Điện thoại";
            // 
            // lbl_DiaChiKH
            // 
            lbl_DiaChiKH.AutoSize = true;
            lbl_DiaChiKH.Location = new Point(918, 67);
            lbl_DiaChiKH.Name = "lbl_DiaChiKH";
            lbl_DiaChiKH.Size = new Size(55, 20);
            lbl_DiaChiKH.TabIndex = 18;
            lbl_DiaChiKH.Text = "Địa chỉ";
            // 
            // cb_TenKH
            // 
            cb_TenKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cb_TenKH.FormattingEnabled = true;
            cb_TenKH.Location = new Point(1067, 205);
            cb_TenKH.Name = "cb_TenKH";
            cb_TenKH.Size = new Size(260, 28);
            cb_TenKH.TabIndex = 16;
            cb_TenKH.SelectedIndexChanged += cb_TenKH_SelectedIndexChanged;
            // 
            // txt_MaNV
            // 
            txt_MaNV.Enabled = false;
            txt_MaNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_MaNV.Location = new Point(177, 164);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(245, 27);
            txt_MaNV.TabIndex = 14;
            // 
            // txt_NgayBan
            // 
            txt_NgayBan.Location = new Point(177, 116);
            txt_NgayBan.Name = "txt_NgayBan";
            txt_NgayBan.Size = new Size(245, 27);
            txt_NgayBan.TabIndex = 13;
            // 
            // txt_MaKH
            // 
            txt_MaKH.Enabled = false;
            txt_MaKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_MaKH.Location = new Point(1067, 164);
            txt_MaKH.Name = "txt_MaKH";
            txt_MaKH.Size = new Size(260, 27);
            txt_MaKH.TabIndex = 15;
            // 
            // txt_MaHD
            // 
            txt_MaHD.Enabled = false;
            txt_MaHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txt_MaHD.Location = new Point(177, 67);
            txt_MaHD.Name = "txt_MaHD";
            txt_MaHD.Size = new Size(245, 27);
            txt_MaHD.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(918, 209);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 0;
            label6.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 171);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(918, 164);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 0;
            label5.Text = "Mã khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 119);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 0;
            label2.Text = "Ngày bán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 67);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hoá đơn";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { thêmNhânViênToolStripMenuItem, thêmKháchHàngToolStripMenuItem, thêmSảnPhẩmToolStripMenuItem, đăngXuấtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1415, 30);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // thêmNhânViênToolStripMenuItem
            // 
            thêmNhânViênToolStripMenuItem.Name = "thêmNhânViênToolStripMenuItem";
            thêmNhânViênToolStripMenuItem.Size = new Size(132, 24);
            thêmNhânViênToolStripMenuItem.Text = "Thêm Nhân Viên";
            thêmNhânViênToolStripMenuItem.Click += thêmNhânViênToolStripMenuItem_Click;
            // 
            // thêmKháchHàngToolStripMenuItem
            // 
            thêmKháchHàngToolStripMenuItem.Name = "thêmKháchHàngToolStripMenuItem";
            thêmKháchHàngToolStripMenuItem.Size = new Size(144, 24);
            thêmKháchHàngToolStripMenuItem.Text = "Thêm Khách Hàng";
            thêmKháchHàngToolStripMenuItem.Click += thêmKháchHàngToolStripMenuItem_Click;
            // 
            // thêmSảnPhẩmToolStripMenuItem
            // 
            thêmSảnPhẩmToolStripMenuItem.Name = "thêmSảnPhẩmToolStripMenuItem";
            thêmSảnPhẩmToolStripMenuItem.Size = new Size(121, 24);
            thêmSảnPhẩmToolStripMenuItem.Text = "Mua Sản Phẩm";
            thêmSảnPhẩmToolStripMenuItem.Click += thêmSảnPhẩmToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(93, 24);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txt_DiaChiNV);
            groupBox1.Controls.Add(txt_DienThoaiNV);
            groupBox1.Controls.Add(cb_TenNV);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.DarkGreen;
            groupBox1.Location = new Point(22, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(789, 225);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên và Đơn hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(442, 35);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 0;
            label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(442, 85);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 0;
            label8.Text = "Điện thoại";
            // 
            // txt_DiaChiNV
            // 
            txt_DiaChiNV.Enabled = false;
            txt_DiaChiNV.Location = new Point(535, 33);
            txt_DiaChiNV.Name = "txt_DiaChiNV";
            txt_DiaChiNV.Size = new Size(249, 30);
            txt_DiaChiNV.TabIndex = 17;
            // 
            // txt_DienThoaiNV
            // 
            txt_DienThoaiNV.Enabled = false;
            txt_DienThoaiNV.Location = new Point(535, 83);
            txt_DienThoaiNV.Name = "txt_DienThoaiNV";
            txt_DienThoaiNV.Size = new Size(249, 30);
            txt_DienThoaiNV.TabIndex = 0;
            // 
            // cb_TenNV
            // 
            cb_TenNV.FormattingEnabled = true;
            cb_TenNV.Location = new Point(155, 173);
            cb_TenNV.Name = "cb_TenNV";
            cb_TenNV.Size = new Size(245, 31);
            cb_TenNV.TabIndex = 10;
            cb_TenNV.SelectedIndexChanged += cb_TenNV_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(32, 183);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 0;
            label4.Text = "Tên nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.DarkGreen;
            groupBox2.Location = new Point(885, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(495, 225);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(1415, 316);
            panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_timhoadon);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txt_ThanhTien);
            groupBox3.Controls.Add(txt_SoLuong);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(txt_MaHD2);
            groupBox3.Controls.Add(txt_DonGia);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txt_MaHang);
            groupBox3.Location = new Point(22, 4);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(862, 173);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            // 
            // txt_timhoadon
            // 
            txt_timhoadon.Location = new Point(150, 24);
            txt_timhoadon.Name = "txt_timhoadon";
            txt_timhoadon.Size = new Size(247, 27);
            txt_timhoadon.TabIndex = 10;
            txt_timhoadon.TextChanged += txt_timhoadon_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(40, 27);
            label11.Name = "label11";
            label11.Size = new Size(98, 20);
            label11.TabIndex = 9;
            label11.Text = "Tìm Hóa Đơn";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(442, 128);
            label15.Name = "label15";
            label15.Size = new Size(78, 20);
            label15.TabIndex = 0;
            label15.Text = "Thành tiền";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(442, 24);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 0;
            label13.Text = "Số lượng";
            // 
            // txt_ThanhTien
            // 
            txt_ThanhTien.Enabled = false;
            txt_ThanhTien.Location = new Point(562, 128);
            txt_ThanhTien.Name = "txt_ThanhTien";
            txt_ThanhTien.Size = new Size(245, 27);
            txt_ThanhTien.TabIndex = 8;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Enabled = false;
            txt_SoLuong.Location = new Point(562, 20);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(245, 27);
            txt_SoLuong.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 83);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 0;
            label10.Text = "Mã hoá đơn";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(449, 79);
            label14.Name = "label14";
            label14.Size = new Size(62, 20);
            label14.TabIndex = 0;
            label14.Text = "Đơn giá";
            // 
            // txt_MaHD2
            // 
            txt_MaHD2.Enabled = false;
            txt_MaHD2.Location = new Point(152, 79);
            txt_MaHD2.Name = "txt_MaHD2";
            txt_MaHD2.Size = new Size(245, 27);
            txt_MaHD2.TabIndex = 1;
            // 
            // txt_DonGia
            // 
            txt_DonGia.Enabled = false;
            txt_DonGia.Location = new Point(562, 76);
            txt_DonGia.Name = "txt_DonGia";
            txt_DonGia.Size = new Size(245, 27);
            txt_DonGia.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 128);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 0;
            label9.Text = "Mã hàng";
            // 
            // txt_MaHang
            // 
            txt_MaHang.Enabled = false;
            txt_MaHang.Location = new Point(150, 125);
            txt_MaHang.Name = "txt_MaHang";
            txt_MaHang.Size = new Size(245, 27);
            txt_MaHang.TabIndex = 0;
            // 
            // dgv_HoaDon
            // 
            dgv_HoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HoaDon.Columns.AddRange(new DataGridViewColumn[] { colMaHD, colMaNV, colMaKH, colNgayLap, colMaHang, colTenHang, colSoLuong, colDonGia, colThanhTien });
            dgv_HoaDon.Location = new Point(3, 473);
            dgv_HoaDon.Name = "dgv_HoaDon";
            dgv_HoaDon.ReadOnly = true;
            dgv_HoaDon.RowHeadersWidth = 51;
            dgv_HoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_HoaDon.Size = new Size(1415, 423);
            dgv_HoaDon.TabIndex = 1;
            dgv_HoaDon.SelectionChanged += dgv_HoaDon_SelectionChanged;
            // 
            // colMaHD
            // 
            colMaHD.DataPropertyName = "MaHD";
            colMaHD.HeaderText = "Mã Hóa Đơn";
            colMaHD.MinimumWidth = 6;
            colMaHD.Name = "colMaHD";
            colMaHD.ReadOnly = true;
            colMaHD.Width = 180;
            // 
            // colMaNV
            // 
            colMaNV.DataPropertyName = "MaNV";
            colMaNV.HeaderText = "Mã NV";
            colMaNV.MinimumWidth = 6;
            colMaNV.Name = "colMaNV";
            colMaNV.ReadOnly = true;
            colMaNV.Width = 125;
            // 
            // colMaKH
            // 
            colMaKH.DataPropertyName = "MaKhach";
            colMaKH.HeaderText = "Mã KH";
            colMaKH.MinimumWidth = 6;
            colMaKH.Name = "colMaKH";
            colMaKH.ReadOnly = true;
            colMaKH.Width = 125;
            // 
            // colNgayLap
            // 
            colNgayLap.DataPropertyName = "NgayLap";
            colNgayLap.HeaderText = "Ngày Lập";
            colNgayLap.MinimumWidth = 6;
            colNgayLap.Name = "colNgayLap";
            colNgayLap.ReadOnly = true;
            colNgayLap.Width = 125;
            // 
            // colMaHang
            // 
            colMaHang.DataPropertyName = "MaHang";
            colMaHang.HeaderText = "Mã Hàng";
            colMaHang.MinimumWidth = 6;
            colMaHang.Name = "colMaHang";
            colMaHang.ReadOnly = true;
            colMaHang.Width = 125;
            // 
            // colTenHang
            // 
            colTenHang.DataPropertyName = "TenHang";
            colTenHang.HeaderText = "Tên Hàng";
            colTenHang.MinimumWidth = 6;
            colTenHang.Name = "colTenHang";
            colTenHang.ReadOnly = true;
            colTenHang.Width = 185;
            // 
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số Lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            colSoLuong.ReadOnly = true;
            colSoLuong.Width = 125;
            // 
            // colDonGia
            // 
            colDonGia.DataPropertyName = "DonGia";
            colDonGia.HeaderText = "Đơn Giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            colDonGia.ReadOnly = true;
            colDonGia.Width = 200;
            // 
            // colThanhTien
            // 
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành Tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            colThanhTien.Width = 200;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_DongDon);
            panel4.Controls.Add(btn_InDon);
            panel4.Controls.Add(btn_XoaDon);
            panel4.Location = new Point(3, 901);
            panel4.Name = "panel4";
            panel4.Size = new Size(1415, 47);
            panel4.TabIndex = 0;
            // 
            // btn_DongDon
            // 
            btn_DongDon.Location = new Point(1007, 9);
            btn_DongDon.Name = "btn_DongDon";
            btn_DongDon.Size = new Size(94, 29);
            btn_DongDon.TabIndex = 0;
            btn_DongDon.Text = "Đóng đơn";
            btn_DongDon.UseVisualStyleBackColor = true;
            btn_DongDon.Click += btn_DongDon_Click;
            // 
            // btn_InDon
            // 
            btn_InDon.Location = new Point(646, 9);
            btn_InDon.Name = "btn_InDon";
            btn_InDon.Size = new Size(94, 29);
            btn_InDon.TabIndex = 0;
            btn_InDon.Text = "In đơn";
            btn_InDon.UseVisualStyleBackColor = true;
            btn_InDon.Click += btn_InDon_Click;
            // 
            // btn_XoaDon
            // 
            btn_XoaDon.Location = new Point(293, 9);
            btn_XoaDon.Name = "btn_XoaDon";
            btn_XoaDon.Size = new Size(94, 29);
            btn_XoaDon.TabIndex = 0;
            btn_XoaDon.Text = "Xoá đơn";
            btn_XoaDon.UseVisualStyleBackColor = true;
            btn_XoaDon.Click += btn_XoaDon_Click;
            // 
            // HoaDonBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 963);
            Controls.Add(dgv_HoaDon);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "HoaDonBanHang";
            Text = "HoaDonBanHang";
            Load += HoaDonBanHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HoaDon).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_DienThoaiNV;
        private TextBox txt_DiaChiNV;
        private TextBox txt_MaNV;
        private TextBox txt_NgayBan;
        private TextBox txt_MaKH;
        private TextBox txt_MaHD;
        private Label label8;
        private Label label7;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label10;
        private TextBox txt_MaHD2;
        private Label label9;
        private TextBox txt_MaHang;
        private DataGridView dgv_HoaDon;
        private Panel panel4;
        private Button btn_DongDon;
        private Button btn_InDon;
        private Button btn_XoaDon;
        private Label label13;
        private TextBox txt_SoLuong;
        private Label label15;
        private TextBox txt_ThanhTien;
        private Label label14;
        private TextBox txt_DonGia;
        private ComboBox cb_TenKH;
        private ComboBox cb_TenNV;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem thêmNhânViênToolStripMenuItem;
        private ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private ToolStripMenuItem thêmSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private GroupBox groupBox1;
        private TextBox txt_DienThoaiKH;
        private TextBox txt_DiaChiKH;
        private Label label16;
        private Label lbl_DiaChiKH;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridViewTextBoxColumn colMaHD;
        private DataGridViewTextBoxColumn colMaNV;
        private DataGridViewTextBoxColumn colMaKH;
        private DataGridViewTextBoxColumn colNgayLap;
        private DataGridViewTextBoxColumn colMaHang;
        private DataGridViewTextBoxColumn colTenHang;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private TextBox txt_timhoadon;
        private Label label11;
    }
}