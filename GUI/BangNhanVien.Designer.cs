namespace GUI
{
    partial class BangNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangNhanVien));
            button1 = new Button();
            txt_timkiem = new TextBox();
            dtg_nhanvien = new DataGridView();
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            pn_thongtin = new Panel();
            pn_trangthai = new Panel();
            rb_conlam = new RadioButton();
            rb_thoilam = new RadioButton();
            cbb_role = new ComboBox();
            rb_nu = new RadioButton();
            rb_nam = new RadioButton();
            label8 = new Label();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label9 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label1 = new Label();
            btn_uploadanh = new Button();
            btn_update = new Button();
            btn_add = new Button();
            txt_password = new TextBox();
            btn_clear = new Button();
            txt_diachi = new TextBox();
            txt_sodienthoai = new TextBox();
            txt_ngayvaolam = new TextBox();
            txt_ngaysinh = new TextBox();
            txt_email = new TextBox();
            txt_ten = new TextBox();
            txt_roleid = new TextBox();
            pt_avater = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtg_nhanvien).BeginInit();
            panel1.SuspendLayout();
            pn_thongtin.SuspendLayout();
            pn_trangthai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pt_avater).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(257, 31);
            button1.Name = "button1";
            button1.Size = new Size(45, 28);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(16, 31);
            txt_timkiem.Multiline = true;
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(244, 28);
            txt_timkiem.TabIndex = 1;
            txt_timkiem.TextChanged += txt_timkiem_TextChanged;
            // 
            // dtg_nhanvien
            // 
            dtg_nhanvien.AllowUserToAddRows = false;
            dtg_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_nhanvien.BackgroundColor = Color.FromArgb(242, 242, 242);
            dtg_nhanvien.BorderStyle = BorderStyle.None;
            dtg_nhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_nhanvien.GridColor = SystemColors.InactiveBorder;
            dtg_nhanvien.Location = new Point(16, 76);
            dtg_nhanvien.Name = "dtg_nhanvien";
            dtg_nhanvien.RowHeadersVisible = false;
            dtg_nhanvien.RowHeadersWidth = 51;
            dtg_nhanvien.Size = new Size(975, 862);
            dtg_nhanvien.TabIndex = 0;
            dtg_nhanvien.CellClick += dtg_nhanvien_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txt_timkiem);
            panel1.Controls.Add(dtg_nhanvien);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 950);
            panel1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(800, 31);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(191, 28);
            comboBox2.TabIndex = 3;
            // 
            // pn_thongtin
            // 
            pn_thongtin.BackColor = Color.White;
            pn_thongtin.Controls.Add(pn_trangthai);
            pn_thongtin.Controls.Add(cbb_role);
            pn_thongtin.Controls.Add(rb_nu);
            pn_thongtin.Controls.Add(rb_nam);
            pn_thongtin.Controls.Add(label8);
            pn_thongtin.Controls.Add(label10);
            pn_thongtin.Controls.Add(label6);
            pn_thongtin.Controls.Add(label5);
            pn_thongtin.Controls.Add(label4);
            pn_thongtin.Controls.Add(label9);
            pn_thongtin.Controls.Add(label3);
            pn_thongtin.Controls.Add(label2);
            pn_thongtin.Controls.Add(label7);
            pn_thongtin.Controls.Add(label1);
            pn_thongtin.Controls.Add(btn_uploadanh);
            pn_thongtin.Controls.Add(btn_update);
            pn_thongtin.Controls.Add(btn_add);
            pn_thongtin.Controls.Add(txt_password);
            pn_thongtin.Controls.Add(btn_clear);
            pn_thongtin.Controls.Add(txt_diachi);
            pn_thongtin.Controls.Add(txt_sodienthoai);
            pn_thongtin.Controls.Add(txt_ngayvaolam);
            pn_thongtin.Controls.Add(txt_ngaysinh);
            pn_thongtin.Controls.Add(txt_email);
            pn_thongtin.Controls.Add(txt_ten);
            pn_thongtin.Controls.Add(txt_roleid);
            pn_thongtin.Controls.Add(pt_avater);
            pn_thongtin.Location = new Point(1031, 0);
            pn_thongtin.Margin = new Padding(0);
            pn_thongtin.Name = "pn_thongtin";
            pn_thongtin.Size = new Size(550, 950);
            pn_thongtin.TabIndex = 3;
            // 
            // pn_trangthai
            // 
            pn_trangthai.Controls.Add(rb_conlam);
            pn_trangthai.Controls.Add(rb_thoilam);
            pn_trangthai.Location = new Point(3, 165);
            pn_trangthai.Name = "pn_trangthai";
            pn_trangthai.Size = new Size(126, 77);
            pn_trangthai.TabIndex = 7;
            // 
            // rb_conlam
            // 
            rb_conlam.AutoSize = true;
            rb_conlam.Location = new Point(16, 14);
            rb_conlam.Name = "rb_conlam";
            rb_conlam.Size = new Size(88, 24);
            rb_conlam.TabIndex = 6;
            rb_conlam.TabStop = true;
            rb_conlam.Text = "Còn Làm";
            rb_conlam.UseVisualStyleBackColor = true;
            // 
            // rb_thoilam
            // 
            rb_thoilam.AutoSize = true;
            rb_thoilam.Location = new Point(16, 44);
            rb_thoilam.Name = "rb_thoilam";
            rb_thoilam.Size = new Size(91, 24);
            rb_thoilam.TabIndex = 6;
            rb_thoilam.TabStop = true;
            rb_thoilam.Text = "Thôi Làm";
            rb_thoilam.UseVisualStyleBackColor = true;
            // 
            // cbb_role
            // 
            cbb_role.FormattingEnabled = true;
            cbb_role.Items.AddRange(new object[] { "AD", "NV" });
            cbb_role.Location = new Point(420, 315);
            cbb_role.Name = "cbb_role";
            cbb_role.Size = new Size(114, 28);
            cbb_role.TabIndex = 5;
            // 
            // rb_nu
            // 
            rb_nu.AutoSize = true;
            rb_nu.Location = new Point(254, 388);
            rb_nu.Name = "rb_nu";
            rb_nu.Size = new Size(50, 24);
            rb_nu.TabIndex = 4;
            rb_nu.TabStop = true;
            rb_nu.Text = "Nữ";
            rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            rb_nam.AutoSize = true;
            rb_nam.Location = new Point(140, 388);
            rb_nam.Name = "rb_nam";
            rb_nam.Size = new Size(62, 24);
            rb_nam.TabIndex = 4;
            rb_nam.TabStop = true;
            rb_nam.Text = "Nam";
            rb_nam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label8.Location = new Point(14, 835);
            label8.Name = "label8";
            label8.Size = new Size(94, 21);
            label8.TabIndex = 3;
            label8.Text = "Vào Làm:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label10.Location = new Point(18, 901);
            label10.Name = "label10";
            label10.Size = new Size(98, 21);
            label10.TabIndex = 3;
            label10.Text = "Mật Khẩu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label6.Location = new Point(12, 694);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 3;
            label6.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label5.Location = new Point(12, 622);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 3;
            label5.Text = "SĐT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label4.Location = new Point(12, 536);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label9.Location = new Point(18, 391);
            label9.Name = "label9";
            label9.Size = new Size(97, 21);
            label9.TabIndex = 3;
            label9.Text = "GIới Tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label3.Location = new Point(12, 459);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 3;
            label3.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label2.Location = new Point(14, 264);
            label2.Name = "label2";
            label2.Size = new Size(49, 21);
            label2.TabIndex = 3;
            label2.Text = "Tên:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(321, 322);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 3;
            label7.Text = "Chức Vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 322);
            label1.Name = "label1";
            label1.Size = new Size(35, 21);
            label1.TabIndex = 3;
            label1.Text = "ID:";
            // 
            // btn_uploadanh
            // 
            btn_uploadanh.BackColor = Color.White;
            btn_uploadanh.Image = (Image)resources.GetObject("btn_uploadanh.Image");
            btn_uploadanh.Location = new Point(499, 14);
            btn_uploadanh.Name = "btn_uploadanh";
            btn_uploadanh.Size = new Size(39, 28);
            btn_uploadanh.TabIndex = 2;
            btn_uploadanh.UseVisualStyleBackColor = false;
            btn_uploadanh.Click += btn_uploadanh_Click;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Image = (Image)resources.GetObject("btn_update.Image");
            btn_update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update.Location = new Point(14, 124);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(115, 35);
            btn_update.TabIndex = 2;
            btn_update.Text = "           SỬA";
            btn_update.TextAlign = ContentAlignment.MiddleLeft;
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.Image = (Image)resources.GetObject("btn_add.Image");
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(14, 65);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(115, 35);
            btn_add.TabIndex = 2;
            btn_add.Text = "        THÊM";
            btn_add.TextAlign = ContentAlignment.MiddleLeft;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(117, 895);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(419, 27);
            txt_password.TabIndex = 1;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.White;
            btn_clear.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.Image = (Image)resources.GetObject("btn_clear.Image");
            btn_clear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clear.Location = new Point(14, 12);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(115, 35);
            btn_clear.TabIndex = 2;
            btn_clear.Text = "       LÀM MỚI";
            btn_clear.TextAlign = ContentAlignment.MiddleLeft;
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(119, 694);
            txt_diachi.Multiline = true;
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(419, 88);
            txt_diachi.TabIndex = 1;
            // 
            // txt_sodienthoai
            // 
            txt_sodienthoai.Location = new Point(117, 614);
            txt_sodienthoai.Name = "txt_sodienthoai";
            txt_sodienthoai.Size = new Size(421, 27);
            txt_sodienthoai.TabIndex = 1;
            // 
            // txt_ngayvaolam
            // 
            txt_ngayvaolam.Location = new Point(117, 829);
            txt_ngayvaolam.Name = "txt_ngayvaolam";
            txt_ngayvaolam.ReadOnly = true;
            txt_ngayvaolam.Size = new Size(421, 27);
            txt_ngayvaolam.TabIndex = 1;
            // 
            // txt_ngaysinh
            // 
            txt_ngaysinh.Location = new Point(117, 455);
            txt_ngaysinh.Name = "txt_ngaysinh";
            txt_ngaysinh.Size = new Size(421, 27);
            txt_ngaysinh.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(117, 528);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(421, 27);
            txt_email.TabIndex = 1;
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(119, 260);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(415, 27);
            txt_ten.TabIndex = 1;
            // 
            // txt_roleid
            // 
            txt_roleid.Location = new Point(123, 317);
            txt_roleid.Name = "txt_roleid";
            txt_roleid.ReadOnly = true;
            txt_roleid.Size = new Size(155, 27);
            txt_roleid.TabIndex = 1;
            // 
            // pt_avater
            // 
            pt_avater.BorderStyle = BorderStyle.FixedSingle;
            pt_avater.Image = Properties.Resource.avatarmacdinh;
            pt_avater.Location = new Point(254, 12);
            pt_avater.Name = "pt_avater";
            pt_avater.Size = new Size(237, 213);
            pt_avater.SizeMode = PictureBoxSizeMode.Zoom;
            pt_avater.TabIndex = 0;
            pt_avater.TabStop = false;
            // 
            // BangNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1581, 950);
            Controls.Add(pn_thongtin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BangNhanVien";
            Text = "NhanVien";
            ((System.ComponentModel.ISupportInitialize)dtg_nhanvien).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pn_thongtin.ResumeLayout(false);
            pn_thongtin.PerformLayout();
            pn_trangthai.ResumeLayout(false);
            pn_trangthai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pt_avater).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private TextBox txt_timkiem;
        private DataGridView dtg_nhanvien;
        private Panel panel1;
        private Panel pn_thongtin;
        private TextBox txt_sodienthoai;
        private TextBox txt_email;
        private TextBox txt_ten;
        private TextBox txt_roleid;
        private PictureBox pt_avater;
        private Button btn_clear;
        private Label label2;
        private Label label1;
        private Label label3;
        private RadioButton rb_nam;
        private RadioButton rb_nu;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txt_diachi;
        private ComboBox cbb_role;
        private Label label7;
        private Label label8;
        private Button btn_uploadanh;
        private ComboBox comboBox2;
        private Button btn_update;
        private Button btn_add;
        private Label label9;
        private Label label10;
        private TextBox txt_password;
        private TextBox txt_ngayvaolam;
        private TextBox txt_ngaysinh;
        private RadioButton rb_thoilam;
        private RadioButton rb_conlam;
        private Panel pn_trangthai;
    }
}