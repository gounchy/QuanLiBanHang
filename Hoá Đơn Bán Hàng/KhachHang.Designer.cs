namespace QuanLyBanHang
{
    partial class KhachHang
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
            btn_Dong = new Button();
            btn_BoQua = new Button();
            btn_Luu = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_Them = new Button();
            label2 = new Label();
            label4 = new Label();
            txt_MaKhach = new TextBox();
            label5 = new Label();
            txt_DiaChi = new TextBox();
            txt_DienThoai = new TextBox();
            label3 = new Label();
            txt_TenKhach = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvKhachHang = new DataGridView();
            MaKhach = new DataGridViewTextBoxColumn();
            TenKhach = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Dong
            // 
            btn_Dong.Location = new Point(1281, 249);
            btn_Dong.Margin = new Padding(3, 2, 3, 2);
            btn_Dong.Name = "btn_Dong";
            btn_Dong.Size = new Size(82, 33);
            btn_Dong.TabIndex = 0;
            btn_Dong.Text = "Đóng";
            btn_Dong.UseVisualStyleBackColor = true;
            btn_Dong.Click += btn_Dong_Click;
            // 
            // btn_BoQua
            // 
            btn_BoQua.Location = new Point(1134, 249);
            btn_BoQua.Margin = new Padding(3, 2, 3, 2);
            btn_BoQua.Name = "btn_BoQua";
            btn_BoQua.Size = new Size(82, 33);
            btn_BoQua.TabIndex = 0;
            btn_BoQua.Text = "Bỏ Qua";
            btn_BoQua.UseVisualStyleBackColor = true;
            btn_BoQua.Click += btn_BoQua_Click;
            // 
            // btn_Luu
            // 
            btn_Luu.Location = new Point(968, 249);
            btn_Luu.Margin = new Padding(3, 2, 3, 2);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(82, 33);
            btn_Luu.TabIndex = 0;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            btn_Luu.Click += btn_Luu_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(800, 249);
            btn_Sua.Margin = new Padding(3, 2, 3, 2);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(82, 33);
            btn_Sua.TabIndex = 0;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(623, 249);
            btn_Xoa.Margin = new Padding(3, 2, 3, 2);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(82, 33);
            btn_Xoa.TabIndex = 0;
            btn_Xoa.Text = "Xoá";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(468, 249);
            btn_Them.Margin = new Padding(3, 2, 3, 2);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(82, 33);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(36, 34);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 1;
            label2.Text = "Mã Khách";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(64, 33);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 1;
            label4.Text = "Địa Chỉ";
            // 
            // txt_MaKhach
            // 
            txt_MaKhach.Location = new Point(138, 34);
            txt_MaKhach.Margin = new Padding(3, 2, 3, 2);
            txt_MaKhach.Name = "txt_MaKhach";
            txt_MaKhach.Size = new Size(326, 26);
            txt_MaKhach.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(64, 81);
            label5.Name = "label5";
            label5.Size = new Size(102, 23);
            label5.TabIndex = 1;
            label5.Text = "Điện Thoại";
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(174, 33);
            txt_DiaChi.Margin = new Padding(3, 2, 3, 2);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(316, 26);
            txt_DiaChi.TabIndex = 2;
            // 
            // txt_DienThoai
            // 
            txt_DienThoai.Location = new Point(174, 79);
            txt_DienThoai.Margin = new Padding(3, 2, 3, 2);
            txt_DienThoai.Name = "txt_DienThoai";
            txt_DienThoai.Size = new Size(316, 26);
            txt_DienThoai.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label3.Location = new Point(36, 85);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 1;
            label3.Text = "Tên Khách";
            // 
            // txt_TenKhach
            // 
            txt_TenKhach.Location = new Point(138, 85);
            txt_TenKhach.Margin = new Padding(3, 2, 3, 2);
            txt_TenKhach.Name = "txt_TenKhach";
            txt_TenKhach.Size = new Size(326, 26);
            txt_TenKhach.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvKhachHang, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.59544F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.40456F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1619, 702);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeight = 29;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKhach, TenKhach, DiaChi, DienThoai });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(3, 293);
            dgvKhachHang.Margin = new Padding(3, 2, 3, 2);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(1613, 407);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.SelectionChanged += dgvKhachHang_SelectionChanged;
            // 
            // MaKhach
            // 
            MaKhach.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MaKhach.DataPropertyName = "MaKhach";
            MaKhach.HeaderText = "Mã";
            MaKhach.MinimumWidth = 6;
            MaKhach.Name = "MaKhach";
            MaKhach.Width = 150;
            // 
            // TenKhach
            // 
            TenKhach.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenKhach.DataPropertyName = "TenKhach";
            TenKhach.HeaderText = "Tên Khách Hàng";
            TenKhach.MinimumWidth = 6;
            TenKhach.Name = "TenKhach";
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // DienThoai
            // 
            DienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "SDT";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btn_Dong);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_Them);
            panel1.Controls.Add(btn_BoQua);
            panel1.Controls.Add(btn_Xoa);
            panel1.Controls.Add(btn_Luu);
            panel1.Controls.Add(btn_Sua);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1613, 285);
            panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_DienThoai);
            groupBox2.Controls.Add(txt_DiaChi);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(921, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(548, 132);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_MaKhach);
            groupBox1.Controls.Add(txt_TenKhach);
            groupBox1.Location = new Point(382, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 132);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(798, 24);
            label1.Name = "label1";
            label1.Size = new Size(471, 42);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC KHÁCH HÀNG";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 702);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KhachHang";
            Text = "DANH MỤC KHÁCH HÀNG";
            WindowState = FormWindowState.Maximized;
            Load += KhachHang_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Dong;
        private Button btn_BoQua;
        private Button btn_Luu;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_Them;
        private Label label2;
        private Label label4;
        private TextBox txt_MaKhach;
        private Label label5;
        private TextBox txt_DiaChi;
        private TextBox txt_DienThoai;
        private Label label3;
        private TextBox txt_TenKhach;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvKhachHang;
        private DataGridViewTextBoxColumn MaKhach;
        private DataGridViewTextBoxColumn TenKhach;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn DienThoai;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
    }
}