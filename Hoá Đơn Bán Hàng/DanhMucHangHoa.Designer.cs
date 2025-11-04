namespace QuanLyBanHang
{
    partial class DanhMucHangHoa
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn_ThanhToan = new Button();
            btn_Dong = new Button();
            btn_Luu = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_Them = new Button();
            panel2 = new Panel();
            txt_SoLuong = new TextBox();
            txt_Gia = new TextBox();
            txt_Loai = new TextBox();
            txt_TenHang = new TextBox();
            label4 = new Label();
            txt_Filter = new TextBox();
            txt_MaHang = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dgv_HangHoa = new DataGridView();
            MaHang = new DataGridViewTextBoxColumn();
            TenHang = new DataGridViewTextBoxColumn();
            Loai = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            cb_TenNV = new ComboBox();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HangHoa).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_ThanhToan);
            panel1.Controls.Add(btn_Dong);
            panel1.Controls.Add(btn_Luu);
            panel1.Controls.Add(btn_Sua);
            panel1.Controls.Add(btn_Xoa);
            panel1.Controls.Add(btn_Them);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 518);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 50);
            panel1.TabIndex = 0;
            // 
            // btn_ThanhToan
            // 
            btn_ThanhToan.Location = new Point(776, 17);
            btn_ThanhToan.Margin = new Padding(3, 2, 3, 2);
            btn_ThanhToan.Name = "btn_ThanhToan";
            btn_ThanhToan.Size = new Size(82, 22);
            btn_ThanhToan.TabIndex = 1;
            btn_ThanhToan.Text = "Thanh toán";
            btn_ThanhToan.UseVisualStyleBackColor = true;
            btn_ThanhToan.Click += btn_ThanhToan_Click;
            // 
            // btn_Dong
            // 
            btn_Dong.Location = new Point(639, 17);
            btn_Dong.Margin = new Padding(3, 2, 3, 2);
            btn_Dong.Name = "btn_Dong";
            btn_Dong.Size = new Size(82, 22);
            btn_Dong.TabIndex = 0;
            btn_Dong.Text = "Đóng";
            btn_Dong.UseVisualStyleBackColor = true;
            btn_Dong.Click += btn_Dong_Click;
            // 
            // btn_Luu
            // 
            btn_Luu.Location = new Point(512, 17);
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
            btn_Sua.Location = new Point(377, 17);
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
            btn_Xoa.Location = new Point(248, 17);
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
            btn_Them.Location = new Point(118, 17);
            btn_Them.Margin = new Padding(3, 2, 3, 2);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(82, 22);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_SoLuong);
            panel2.Controls.Add(txt_Gia);
            panel2.Controls.Add(txt_Loai);
            panel2.Controls.Add(txt_TenHang);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_Filter);
            panel2.Controls.Add(txt_MaHang);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 214);
            panel2.TabIndex = 1;
            // 
            // txt_SoLuong
            // 
            txt_SoLuong.Location = new Point(526, 130);
            txt_SoLuong.Margin = new Padding(3, 2, 3, 2);
            txt_SoLuong.Name = "txt_SoLuong";
            txt_SoLuong.Size = new Size(210, 26);
            txt_SoLuong.TabIndex = 4;
            // 
            // txt_Gia
            // 
            txt_Gia.Location = new Point(526, 101);
            txt_Gia.Margin = new Padding(3, 2, 3, 2);
            txt_Gia.Name = "txt_Gia";
            txt_Gia.Size = new Size(210, 26);
            txt_Gia.TabIndex = 1;
            // 
            // txt_Loai
            // 
            txt_Loai.Location = new Point(526, 74);
            txt_Loai.Margin = new Padding(3, 2, 3, 2);
            txt_Loai.Name = "txt_Loai";
            txt_Loai.Size = new Size(210, 26);
            txt_Loai.TabIndex = 1;
            // 
            // txt_TenHang
            // 
            txt_TenHang.Location = new Point(182, 129);
            txt_TenHang.Margin = new Padding(3, 2, 3, 2);
            txt_TenHang.Name = "txt_TenHang";
            txt_TenHang.Size = new Size(206, 26);
            txt_TenHang.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 132);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 0;
            label4.Text = "Số lượng";
            // 
            // txt_Filter
            // 
            txt_Filter.Location = new Point(182, 76);
            txt_Filter.Margin = new Padding(3, 2, 3, 2);
            txt_Filter.Name = "txt_Filter";
            txt_Filter.Size = new Size(206, 26);
            txt_Filter.TabIndex = 1;
            txt_Filter.TextChanged += txt_Filter_TextChanged;
            // 
            // txt_MaHang
            // 
            txt_MaHang.Location = new Point(182, 101);
            txt_MaHang.Margin = new Padding(3, 2, 3, 2);
            txt_MaHang.Name = "txt_MaHang";
            txt_MaHang.Size = new Size(206, 26);
            txt_MaHang.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(417, 104);
            label7.Name = "label7";
            label7.Size = new Size(89, 19);
            label7.TabIndex = 0;
            label7.Text = "Đơn giá bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(417, 77);
            label5.Name = "label5";
            label5.Size = new Size(40, 19);
            label5.TabIndex = 0;
            label5.Text = "Loại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 76);
            label6.Name = "label6";
            label6.Size = new Size(102, 19);
            label6.TabIndex = 0;
            label6.Text = "Tìm sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 132);
            label3.Name = "label3";
            label3.Size = new Size(69, 19);
            label3.TabIndex = 0;
            label3.Text = "Tên hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 101);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 0;
            label2.Text = "Mã hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(417, 15);
            label1.Name = "label1";
            label1.Size = new Size(203, 23);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC HÀNG HOÁ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_TenNV);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.LightSalmon;
            groupBox1.Location = new Point(10, 36);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1012, 158);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // dgv_HangHoa
            // 
            dgv_HangHoa.AllowUserToAddRows = false;
            dgv_HangHoa.AllowUserToDeleteRows = false;
            dgv_HangHoa.AllowUserToOrderColumns = true;
            dgv_HangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_HangHoa.Columns.AddRange(new DataGridViewColumn[] { MaHang, TenHang, Loai, Gia, SoLuong });
            dgv_HangHoa.Dock = DockStyle.Fill;
            dgv_HangHoa.Location = new Point(0, 214);
            dgv_HangHoa.Margin = new Padding(3, 2, 3, 2);
            dgv_HangHoa.Name = "dgv_HangHoa";
            dgv_HangHoa.ReadOnly = true;
            dgv_HangHoa.RowHeadersWidth = 51;
            dgv_HangHoa.Size = new Size(1029, 304);
            dgv_HangHoa.TabIndex = 2;
            // 
            // MaHang
            // 
            MaHang.DataPropertyName = "maHang";
            MaHang.HeaderText = "Mã Hàng";
            MaHang.MinimumWidth = 6;
            MaHang.Name = "MaHang";
            MaHang.ReadOnly = true;
            MaHang.Width = 120;
            // 
            // TenHang
            // 
            TenHang.DataPropertyName = "tenHang";
            TenHang.HeaderText = "Tên Hàng";
            TenHang.MinimumWidth = 6;
            TenHang.Name = "TenHang";
            TenHang.ReadOnly = true;
            TenHang.Width = 250;
            // 
            // Loai
            // 
            Loai.DataPropertyName = "Loai";
            Loai.HeaderText = "Loại";
            Loai.MinimumWidth = 6;
            Loai.Name = "Loai";
            Loai.ReadOnly = true;
            Loai.Width = 200;
            // 
            // Gia
            // 
            Gia.DataPropertyName = "Gia";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.BottomRight;
            Gia.DefaultCellStyle = dataGridViewCellStyle3;
            Gia.HeaderText = "Giá";
            Gia.MinimumWidth = 6;
            Gia.Name = "Gia";
            Gia.ReadOnly = true;
            Gia.Width = 300;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "soLuong";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle4;
            SoLuong.HeaderText = "Số Lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            SoLuong.Width = 120;
            // 
            // cb_TenNV
            // 
            cb_TenNV.FormattingEnabled = true;
            cb_TenNV.Location = new Point(172, 122);
            cb_TenNV.Name = "cb_TenNV";
            cb_TenNV.Size = new Size(206, 31);
            cb_TenNV.TabIndex = 12;
            cb_TenNV.SelectedIndexChanged += cb_TenNV_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(49, 132);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 11;
            label8.Text = "Tên nhân viên";
            // 
            // DanhMucHangHoa
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 568);
            Controls.Add(dgv_HangHoa);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DanhMucHangHoa";
            Text = "DANH MỤC HÀNG HOÁ";
            Load += DanhMucHangHoa_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_HangHoa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button7;
        private Button btn_Dong;
        private Button btn_BoQua;
        private Button btn_Luu;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_Them;
        private Panel panel2;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_HangHoa;
        private TextBox txt_Gia;
        private TextBox txt_Loai;
        private TextBox txt_TenHang;
        private TextBox txt_MaHang;
        private TextBox txt_SoLuong;
        private Label label4;
        private TextBox txt_Filter;
        private Label label6;
        private GroupBox groupBox1;
        private Button btn_ThanhToan;
        private DataGridViewTextBoxColumn MaHang;
        private DataGridViewTextBoxColumn TenHang;
        private DataGridViewTextBoxColumn Loai;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn SoLuong;
        private ComboBox cb_TenNV;
        private Label label8;
    }
}