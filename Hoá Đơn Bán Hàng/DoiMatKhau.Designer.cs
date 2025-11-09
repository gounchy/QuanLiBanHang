namespace Hoá_Đơn_Bán_Hàng
{
    partial class DoiMatKhau
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
            txt_MatKhauCu = new TextBox();
            btn_Luu = new Button();
            label2 = new Label();
            btn_Huy = new Button();
            label3 = new Label();
            txt_MatKhauMoi = new TextBox();
            label4 = new Label();
            txt_XacNhan = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSalmon;
            label1.Location = new Point(325, 33);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 0;
            label1.Text = "Đổi Mật Khẩu";
            // 
            // txt_MatKhauCu
            // 
            txt_MatKhauCu.Location = new Point(325, 109);
            txt_MatKhauCu.Name = "txt_MatKhauCu";
            txt_MatKhauCu.PasswordChar = '*';
            txt_MatKhauCu.Size = new Size(270, 27);
            txt_MatKhauCu.TabIndex = 1;
            // 
            // btn_Luu
            // 
            btn_Luu.Location = new Point(145, 276);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(126, 29);
            btn_Luu.TabIndex = 2;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            btn_Luu.Click += btn_Luu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 112);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu cũ";
            // 
            // btn_Huy
            // 
            btn_Huy.Location = new Point(349, 276);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(126, 29);
            btn_Huy.TabIndex = 2;
            btn_Huy.Text = "Huỷ";
            btn_Huy.UseVisualStyleBackColor = true;
            btn_Huy.Click += btn_Huy_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 158);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu mới";
            // 
            // txt_MatKhauMoi
            // 
            txt_MatKhauMoi.Location = new Point(325, 155);
            txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            txt_MatKhauMoi.PasswordChar = '*';
            txt_MatKhauMoi.Size = new Size(270, 27);
            txt_MatKhauMoi.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 202);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 3;
            label4.Text = "Xác nhận mật khẩu mới";
            // 
            // txt_XacNhan
            // 
            txt_XacNhan.Location = new Point(325, 199);
            txt_XacNhan.Name = "txt_XacNhan";
            txt_XacNhan.PasswordChar = '*';
            txt_XacNhan.Size = new Size(270, 27);
            txt_XacNhan.TabIndex = 4;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_XacNhan);
            Controls.Add(txt_MatKhauMoi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_Huy);
            Controls.Add(btn_Luu);
            Controls.Add(txt_MatKhauCu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DoiMatKhau";
            Text = "DoiMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_MatKhauCu;
        private Button btn_Luu;
        private Label label2;
        private Button btn_Huy;
        private Label label3;
        private TextBox txt_MatKhauMoi;
        private Label label4;
        private TextBox txt_XacNhan;
    }
}