namespace QuanLyBanHang
{
    partial class DanhMucNhanVien
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
            btn_skip = new Button();
            btn_luu = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_themnv = new Button();
            dtp_NgaySinh = new DateTimePicker();
            chk_Nu = new CheckBox();
            chk_Nam = new CheckBox();
            txt_ten = new TextBox();
            txt_sdt = new TextBox();
            txt_diachi = new TextBox();
            txt_manv = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgv_nhanvien = new DataGridView();
            Manv = new DataGridViewTextBoxColumn();
            Tennv = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            dienthoai = new DataGridViewTextBoxColumn();
            Diachi = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btn_Dong = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_nhanvien).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_skip
            // 
            btn_skip.Location = new Point(1127, 199);
            btn_skip.Margin = new Padding(3, 2, 3, 2);
            btn_skip.Name = "btn_skip";
            btn_skip.Size = new Size(82, 31);
            btn_skip.TabIndex = 0;
            btn_skip.Text = "Bỏ Qua";
            btn_skip.UseVisualStyleBackColor = true;
            btn_skip.Click += btn_skip_Click;
            // 
            // btn_luu
            // 
            btn_luu.Location = new Point(928, 199);
            btn_luu.Margin = new Padding(3, 2, 3, 2);
            btn_luu.Name = "btn_luu";
            btn_luu.Size = new Size(82, 31);
            btn_luu.TabIndex = 0;
            btn_luu.Text = "Lưu";
            btn_luu.UseVisualStyleBackColor = true;
            btn_luu.Click += btn_luu_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(754, 199);
            btn_sua.Margin = new Padding(3, 2, 3, 2);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(82, 31);
            btn_sua.TabIndex = 0;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(558, 199);
            btn_xoa.Margin = new Padding(3, 2, 3, 2);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(82, 31);
            btn_xoa.TabIndex = 0;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_themnv
            // 
            btn_themnv.Location = new Point(361, 199);
            btn_themnv.Margin = new Padding(3, 2, 3, 2);
            btn_themnv.Name = "btn_themnv";
            btn_themnv.Size = new Size(82, 31);
            btn_themnv.TabIndex = 0;
            btn_themnv.Text = "Thêm";
            btn_themnv.UseVisualStyleBackColor = true;
            btn_themnv.Click += btn_themnv_Click;
            // 
            // dtp_NgaySinh
            // 
            dtp_NgaySinh.Format = DateTimePickerFormat.Short;
            dtp_NgaySinh.Location = new Point(1109, 120);
            dtp_NgaySinh.Margin = new Padding(3, 2, 3, 2);
            dtp_NgaySinh.Name = "dtp_NgaySinh";
            dtp_NgaySinh.Size = new Size(303, 26);
            dtp_NgaySinh.TabIndex = 5;
            // 
            // chk_Nu
            // 
            chk_Nu.AutoSize = true;
            chk_Nu.Location = new Point(588, 138);
            chk_Nu.Margin = new Padding(3, 2, 3, 2);
            chk_Nu.Name = "chk_Nu";
            chk_Nu.Size = new Size(52, 23);
            chk_Nu.TabIndex = 3;
            chk_Nu.Text = "Nữ";
            chk_Nu.UseVisualStyleBackColor = true;
            chk_Nu.CheckedChanged += chk_Nu_CheckedChanged;
            // 
            // chk_Nam
            // 
            chk_Nam.AutoSize = true;
            chk_Nam.Location = new Point(467, 138);
            chk_Nam.Margin = new Padding(3, 2, 3, 2);
            chk_Nam.Name = "chk_Nam";
            chk_Nam.Size = new Size(63, 23);
            chk_Nam.TabIndex = 3;
            chk_Nam.Text = "Nam";
            chk_Nam.UseVisualStyleBackColor = true;
            chk_Nam.CheckedChanged += chk_Nam_CheckedChanged;
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(469, 87);
            txt_ten.Margin = new Padding(3, 2, 3, 2);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(284, 26);
            txt_ten.TabIndex = 2;
            txt_ten.TextChanged += txt_ten_TextChanged;
            // 
            // txt_sdt
            // 
            txt_sdt.Location = new Point(1109, 84);
            txt_sdt.Margin = new Padding(3, 2, 3, 2);
            txt_sdt.Name = "txt_sdt";
            txt_sdt.Size = new Size(303, 26);
            txt_sdt.TabIndex = 2;
            txt_sdt.TextChanged += txt_diachi_TextChanged;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(1109, 44);
            txt_diachi.Margin = new Padding(3, 2, 3, 2);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(303, 26);
            txt_diachi.TabIndex = 2;
            txt_diachi.TextChanged += txt_diachi_TextChanged;
            // 
            // txt_manv
            // 
            txt_manv.Location = new Point(469, 49);
            txt_manv.Margin = new Padding(3, 2, 3, 2);
            txt_manv.Name = "txt_manv";
            txt_manv.Size = new Size(284, 26);
            txt_manv.TabIndex = 2;
            txt_manv.TextChanged += txt_manv_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(985, 127);
            label7.Name = "label7";
            label7.Size = new Size(76, 19);
            label7.TabIndex = 1;
            label7.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 138);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 1;
            label4.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(985, 52);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 1;
            label6.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 52);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 1;
            label3.Text = "Mã nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(985, 87);
            label5.Name = "label5";
            label5.Size = new Size(80, 19);
            label5.TabIndex = 1;
            label5.Text = "Điện thoại";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 94);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 1;
            label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(716, 6);
            label1.Name = "label1";
            label1.Size = new Size(276, 31);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // dgv_nhanvien
            // 
            dgv_nhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_nhanvien.Columns.AddRange(new DataGridViewColumn[] { Manv, Tennv, NgaySinh, GioiTinh, dienthoai, Diachi });
            dgv_nhanvien.Dock = DockStyle.Fill;
            dgv_nhanvien.Location = new Point(3, 259);
            dgv_nhanvien.Margin = new Padding(3, 2, 3, 2);
            dgv_nhanvien.Name = "dgv_nhanvien";
            dgv_nhanvien.RowHeadersWidth = 51;
            dgv_nhanvien.Size = new Size(1612, 421);
            dgv_nhanvien.TabIndex = 2;
            dgv_nhanvien.CellFormatting += dgv_nhanvien_CellFormatting;
            // 
            // Manv
            // 
            Manv.DataPropertyName = "MaNV";
            Manv.HeaderText = "Mã NV";
            Manv.MinimumWidth = 6;
            Manv.Name = "Manv";
            Manv.Width = 83;
            // 
            // Tennv
            // 
            Tennv.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Tennv.DataPropertyName = "TenNV";
            Tennv.HeaderText = "Tên NV";
            Tennv.MinimumWidth = 6;
            Tennv.Name = "Tennv";
            Tennv.Width = 90;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.Width = 125;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 125;
            // 
            // dienthoai
            // 
            dienthoai.DataPropertyName = "DienThoai";
            dienthoai.HeaderText = "Điện Thoại";
            dienthoai.MinimumWidth = 6;
            dienthoai.Name = "dienthoai";
            dienthoai.Width = 125;
            // 
            // Diachi
            // 
            Diachi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Diachi.DataPropertyName = "DiaChi";
            Diachi.HeaderText = "Địa Chỉ";
            Diachi.MinimumWidth = 6;
            Diachi.Name = "Diachi";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgv_nhanvien, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.82991F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.17009F));
            tableLayoutPanel1.Size = new Size(1618, 682);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Dong);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_diachi);
            panel1.Controls.Add(dtp_NgaySinh);
            panel1.Controls.Add(txt_manv);
            panel1.Controls.Add(btn_skip);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_sdt);
            panel1.Controls.Add(btn_themnv);
            panel1.Controls.Add(chk_Nu);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btn_xoa);
            panel1.Controls.Add(btn_luu);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_ten);
            panel1.Controls.Add(chk_Nam);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_sua);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1612, 251);
            panel1.TabIndex = 0;
            // 
            // btn_Dong
            // 
            btn_Dong.Location = new Point(1318, 201);
            btn_Dong.Name = "btn_Dong";
            btn_Dong.Size = new Size(94, 29);
            btn_Dong.TabIndex = 6;
            btn_Dong.Text = "Đóng";
            btn_Dong.UseVisualStyleBackColor = true;
            btn_Dong.Click += btn_Dong_Click;
            // 
            // DanhMucNhanVien
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1618, 682);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DanhMucNhanVien";
            Text = "DANH MỤC NHÂN VIÊN";
            WindowState = FormWindowState.Maximized;
            FormClosing += DanhMucNhanVien_FormClosing;
            Load += DanhMucNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_nhanvien).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label7;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private CheckBox chk_Nam;
        private TextBox txt_ten;
        private TextBox txt_diachi;
        private TextBox txt_manv;
        private Button btn_xoa;
        private Button btn_themnv;
        private DateTimePicker dtp_NgaySinh;
        private Button btn_skip;
        private Button btn_luu;
        private Button btn_sua;
        private TextBox txt_sdt;
        private CheckBox chk_Nu;
        private DataGridView dgv_nhanvien;
        private DataGridViewTextBoxColumn Manv;
        private DataGridViewTextBoxColumn Tennv;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn dienthoai;
        private DataGridViewTextBoxColumn Diachi;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btn_Dong;
    }
}