namespace GUI
{
    partial class BangKhachHang
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
            dtg_khachhang = new DataGridView();
            panel2 = new Panel();
            btn_them = new Button();
            btn_capnhat = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txt_diachi = new TextBox();
            txt_email = new TextBox();
            txt_sodienthoai = new TextBox();
            txt_ten = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_khachhang).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dtg_khachhang);
            panel1.Location = new Point(1144, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 950);
            panel1.TabIndex = 0;
            // 
            // dtg_khachhang
            // 
            dtg_khachhang.AllowUserToAddRows = false;
            dtg_khachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_khachhang.Location = new Point(15, 14);
            dtg_khachhang.Name = "dtg_khachhang";
            dtg_khachhang.RowHeadersVisible = false;
            dtg_khachhang.RowHeadersWidth = 51;
            dtg_khachhang.Size = new Size(410, 926);
            dtg_khachhang.TabIndex = 0;
            dtg_khachhang.CellClick += dtg_khachhang_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btn_them);
            panel2.Controls.Add(btn_capnhat);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_diachi);
            panel2.Controls.Add(txt_email);
            panel2.Controls.Add(txt_sodienthoai);
            panel2.Controls.Add(txt_ten);
            panel2.Location = new Point(1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1137, 467);
            panel2.TabIndex = 1;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(819, 411);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(132, 39);
            btn_them.TabIndex = 3;
            btn_them.Text = "THÊM";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_capnhat
            // 
            btn_capnhat.Location = new Point(978, 411);
            btn_capnhat.Name = "btn_capnhat";
            btn_capnhat.Size = new Size(132, 39);
            btn_capnhat.TabIndex = 3;
            btn_capnhat.Text = "CẬP NHẬT";
            btn_capnhat.UseVisualStyleBackColor = true;
            btn_capnhat.Click += btn_capnhat_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 212);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 1;
            label4.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 144);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 1;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 91);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Số Điện Thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 30);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên:";
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(117, 209);
            txt_diachi.Multiline = true;
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(993, 175);
            txt_diachi.TabIndex = 0;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(117, 141);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(993, 27);
            txt_email.TabIndex = 0;
            // 
            // txt_sodienthoai
            // 
            txt_sodienthoai.Location = new Point(117, 84);
            txt_sodienthoai.Name = "txt_sodienthoai";
            txt_sodienthoai.Size = new Size(993, 27);
            txt_sodienthoai.TabIndex = 0;
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(117, 27);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(993, 27);
            txt_ten.TabIndex = 0;
            // 
            // BangKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1581, 950);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BangKhachHang";
            Text = "BangKhachHang";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_khachhang).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dtg_khachhang;
        private Panel panel2;
        private TextBox txt_diachi;
        private TextBox txt_email;
        private TextBox txt_sodienthoai;
        private TextBox txt_ten;
        private Button btn_them;
        private Button btn_capnhat;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}