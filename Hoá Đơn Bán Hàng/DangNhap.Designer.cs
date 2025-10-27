namespace Hoá_Đơn_Bán_Hàng
{
    partial class DangNhap
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
            label1 = new Label();
            label2 = new Label();
            txt_DangNhap = new TextBox();
            txt_MatKhau = new TextBox();
            btn_DangNhap = new Button();
            btn_Thoat = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 112);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 161);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu";
            // 
            // txt_DangNhap
            // 
            txt_DangNhap.Location = new Point(146, 110);
            txt_DangNhap.Margin = new Padding(3, 2, 3, 2);
            txt_DangNhap.Name = "txt_DangNhap";
            txt_DangNhap.Size = new Size(258, 22);
            txt_DangNhap.TabIndex = 0;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(146, 156);
            txt_MatKhau.Margin = new Padding(3, 2, 3, 2);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.PasswordChar = '*';
            txt_MatKhau.Size = new Size(258, 22);
            txt_MatKhau.TabIndex = 1;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(146, 223);
            btn_DangNhap.Margin = new Padding(3, 2, 3, 2);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(113, 34);
            btn_DangNhap.TabIndex = 2;
            btn_DangNhap.Text = "Đăng Nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(291, 223);
            btn_Thoat.Margin = new Padding(3, 2, 3, 2);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(113, 34);
            btn_Thoat.TabIndex = 3;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(212, 48);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 0;
            label3.Text = "Đăng Nhập";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 298);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_DangNhap);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_DangNhap);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DangNhap";
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_DangNhap;
        private TextBox txt_MatKhau;
        private Button btn_DangNhap;
        private Button btn_Thoat;
        private Label label3;
    }
}