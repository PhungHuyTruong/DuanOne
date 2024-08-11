namespace GUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txt_taikhoan = new TextBox();
            txt_matkhau = new TextBox();
            btn_dangnhap = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.BackColor = SystemColors.Window;
            txt_taikhoan.ForeColor = Color.YellowGreen;
            txt_taikhoan.Location = new Point(680, 464);
            txt_taikhoan.Margin = new Padding(4);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(333, 31);
            txt_taikhoan.TabIndex = 0;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(680, 554);
            txt_matkhau.Margin = new Padding(4);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(332, 31);
            txt_matkhau.TabIndex = 0;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.BackColor = Color.BurlyWood;
            btn_dangnhap.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dangnhap.Location = new Point(741, 689);
            btn_dangnhap.Margin = new Padding(4);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(161, 63);
            btn_dangnhap.TabIndex = 1;
            btn_dangnhap.Text = "Đăng nhập";
            btn_dangnhap.UseVisualStyleBackColor = false;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(557, 464);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 2;
            label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(557, 554);
            label2.Name = "label2";
            label2.Size = new Size(107, 27);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(621, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 362);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1670, 937);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_dangnhap);
            Controls.Add(txt_matkhau);
            Controls.Add(txt_taikhoan);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_taikhoan;
        private TextBox txt_matkhau;
        private Button btn_dangnhap;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
