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
            panel1 = new Panel();
            btn_Dong = new Button();
            btn_BoQua = new Button();
            btn_Luu = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_Them = new Button();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            txt_TenKhach = new TextBox();
            txt_DienThoai = new TextBox();
            txt_DiaChi = new TextBox();
            txt_MaKhach = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvKhachHang = new DataGridView();
            MaKhach = new DataGridViewTextBoxColumn();
            TenKhach = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Dong);
            panel1.Controls.Add(btn_BoQua);
            panel1.Controls.Add(btn_Luu);
            panel1.Controls.Add(btn_Sua);
            panel1.Controls.Add(btn_Xoa);
            panel1.Controls.Add(btn_Them);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 591);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 46);
            panel1.TabIndex = 0;
            // 
            // btn_Dong
            // 
            btn_Dong.Location = new Point(857, 13);
            btn_Dong.Margin = new Padding(3, 2, 3, 2);
            btn_Dong.Name = "btn_Dong";
            btn_Dong.Size = new Size(82, 22);
            btn_Dong.TabIndex = 0;
            btn_Dong.Text = "Đóng";
            btn_Dong.UseVisualStyleBackColor = true;
            btn_Dong.Click += btn_Dong_Click;
            // 
            // btn_BoQua
            // 
            btn_BoQua.Location = new Point(710, 13);
            btn_BoQua.Margin = new Padding(3, 2, 3, 2);
            btn_BoQua.Name = "btn_BoQua";
            btn_BoQua.Size = new Size(82, 22);
            btn_BoQua.TabIndex = 0;
            btn_BoQua.Text = "Bỏ Qua";
            btn_BoQua.UseVisualStyleBackColor = true;
            btn_BoQua.Click += btn_BoQua_Click;
            // 
            // btn_Luu
            // 
            btn_Luu.Location = new Point(544, 13);
            btn_Luu.Margin = new Padding(3, 2, 3, 2);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(82, 22);
            btn_Luu.TabIndex = 0;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            btn_Luu.Click += btn_Luu_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(376, 13);
            btn_Sua.Margin = new Padding(3, 2, 3, 2);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(82, 22);
            btn_Sua.TabIndex = 0;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(199, 13);
            btn_Xoa.Margin = new Padding(3, 2, 3, 2);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(82, 22);
            btn_Xoa.TabIndex = 0;
            btn_Xoa.Text = "Xoá";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(44, 13);
            btn_Them.Margin = new Padding(3, 2, 3, 2);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(82, 22);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvKhachHang);
            splitContainer1.Size = new Size(1016, 591);
            splitContainer1.SplitterDistance = 195;
            splitContainer1.SplitterWidth = 3;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_TenKhach);
            groupBox1.Controls.Add(txt_DienThoai);
            groupBox1.Controls.Add(txt_DiaChi);
            groupBox1.Controls.Add(txt_MaKhach);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(17, 51);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(974, 118);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // txt_TenKhach
            // 
            txt_TenKhach.Location = new Point(115, 62);
            txt_TenKhach.Margin = new Padding(3, 2, 3, 2);
            txt_TenKhach.Name = "txt_TenKhach";
            txt_TenKhach.Size = new Size(326, 22);
            txt_TenKhach.TabIndex = 2;
            // 
            // txt_DienThoai
            // 
            txt_DienThoai.Location = new Point(606, 67);
            txt_DienThoai.Margin = new Padding(3, 2, 3, 2);
            txt_DienThoai.Name = "txt_DienThoai";
            txt_DienThoai.Size = new Size(316, 22);
            txt_DienThoai.TabIndex = 2;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(606, 36);
            txt_DiaChi.Margin = new Padding(3, 2, 3, 2);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(316, 22);
            txt_DiaChi.TabIndex = 2;
            // 
            // txt_MaKhach
            // 
            txt_MaKhach.Location = new Point(115, 31);
            txt_MaKhach.Margin = new Padding(3, 2, 3, 2);
            txt_MaKhach.Name = "txt_MaKhach";
            txt_MaKhach.Size = new Size(326, 22);
            txt_MaKhach.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(527, 69);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 1;
            label5.Text = "Điện Thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(529, 41);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 1;
            label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 67);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 1;
            label3.Text = "Tên Khách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 36);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Khách";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(389, 27);
            label1.Name = "label1";
            label1.Size = new Size(237, 21);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { MaKhach, TenKhach, DiaChi, DienThoai });
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 0);
            dgvKhachHang.Margin = new Padding(3, 2, 3, 2);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(1016, 393);
            dgvKhachHang.TabIndex = 0;
            dgvKhachHang.SelectionChanged += dgvKhachHang_SelectionChanged;
            // 
            // MaKhach
            // 
            MaKhach.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            MaKhach.DataPropertyName = "MaKhach";
            MaKhach.HeaderText = "Mã";
            MaKhach.Name = "MaKhach";
            MaKhach.Width = 150;
            // 
            // TenKhach
            // 
            TenKhach.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenKhach.DataPropertyName = "TenKhach";
            TenKhach.HeaderText = "Tên Khách Hàng";
            TenKhach.Name = "TenKhach";
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.Name = "DiaChi";
            // 
            // DienThoai
            // 
            DienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "SDT";
            DienThoai.Name = "DienThoai";
            // 
            // KhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 637);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KhachHang";
            Text = "DANH MỤC KHÁCH HÀNG";
            Load += KhachHang_Load;
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_Dong;
        private Button btn_BoQua;
        private Button btn_Luu;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_Them;
        private TextBox txt_TenKhach;
        private TextBox txt_DienThoai;
        private TextBox txt_DiaChi;
        private TextBox txt_MaKhach;
        private Label label5;
        private Label label4;
        private DataGridView dgvKhachHang;
        private DataGridViewTextBoxColumn MaKhach;
        private DataGridViewTextBoxColumn TenKhach;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn DienThoai;
        private GroupBox groupBox1;
    }
}