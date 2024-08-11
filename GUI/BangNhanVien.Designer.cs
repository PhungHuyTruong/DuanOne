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
            lb_gioitinh = new LinkLabel();
            lb_lam = new LinkLabel();
            lb_chucvu = new LinkLabel();
            lb_pass = new LinkLabel();
            Id_erdiachi = new LinkLabel();
            Id_ersdt = new LinkLabel();
            Id_eremail = new LinkLabel();
            Id_erngaysinh = new LinkLabel();
            Ib_erhoten = new LinkLabel();
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
            button1.Location = new Point(321, 39);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(56, 35);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(20, 39);
            txt_timkiem.Margin = new Padding(4);
            txt_timkiem.Multiline = true;
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(304, 34);
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
            dtg_nhanvien.Location = new Point(20, 95);
            dtg_nhanvien.Margin = new Padding(4);
            dtg_nhanvien.Name = "dtg_nhanvien";
            dtg_nhanvien.RowHeadersVisible = false;
            dtg_nhanvien.RowHeadersWidth = 51;
            dtg_nhanvien.Size = new Size(1219, 1078);
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
            panel1.Size = new Size(1264, 1188);
            panel1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1000, 39);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(238, 33);
            comboBox2.TabIndex = 3;
            // 
            // pn_thongtin
            // 
            pn_thongtin.BackColor = Color.White;
            pn_thongtin.Controls.Add(lb_gioitinh);
            pn_thongtin.Controls.Add(lb_lam);
            pn_thongtin.Controls.Add(lb_chucvu);
            pn_thongtin.Controls.Add(lb_pass);
            pn_thongtin.Controls.Add(Id_erdiachi);
            pn_thongtin.Controls.Add(Id_ersdt);
            pn_thongtin.Controls.Add(Id_eremail);
            pn_thongtin.Controls.Add(Id_erngaysinh);
            pn_thongtin.Controls.Add(Ib_erhoten);
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
            pn_thongtin.Location = new Point(1289, 0);
            pn_thongtin.Margin = new Padding(0);
            pn_thongtin.Name = "pn_thongtin";
            pn_thongtin.Size = new Size(688, 1188);
            pn_thongtin.TabIndex = 3;
            // 
            // lb_gioitinh
            // 
            lb_gioitinh.AutoSize = true;
            lb_gioitinh.LinkColor = Color.Red;
            lb_gioitinh.Location = new Point(175, 518);
            lb_gioitinh.Margin = new Padding(4, 0, 4, 0);
            lb_gioitinh.Name = "lb_gioitinh";
            lb_gioitinh.Size = new Size(0, 25);
            lb_gioitinh.TabIndex = 23;
            // 
            // lb_lam
            // 
            lb_lam.AutoSize = true;
            lb_lam.LinkColor = Color.Red;
            lb_lam.Location = new Point(39, 294);
            lb_lam.Margin = new Padding(4, 0, 4, 0);
            lb_lam.Name = "lb_lam";
            lb_lam.Size = new Size(0, 25);
            lb_lam.TabIndex = 22;
            // 
            // lb_chucvu
            // 
            lb_chucvu.AutoSize = true;
            lb_chucvu.LinkColor = Color.Red;
            lb_chucvu.Location = new Point(417, 428);
            lb_chucvu.Margin = new Padding(4, 0, 4, 0);
            lb_chucvu.Name = "lb_chucvu";
            lb_chucvu.Size = new Size(0, 25);
            lb_chucvu.TabIndex = 21;
            // 
            // lb_pass
            // 
            lb_pass.AutoSize = true;
            lb_pass.LinkColor = Color.Red;
            lb_pass.Location = new Point(160, 1154);
            lb_pass.Margin = new Padding(4, 0, 4, 0);
            lb_pass.Name = "lb_pass";
            lb_pass.Size = new Size(0, 25);
            lb_pass.TabIndex = 20;
            // 
            // Id_erdiachi
            // 
            Id_erdiachi.AutoSize = true;
            Id_erdiachi.LinkColor = Color.Red;
            Id_erdiachi.Location = new Point(160, 981);
            Id_erdiachi.Margin = new Padding(4, 0, 4, 0);
            Id_erdiachi.Name = "Id_erdiachi";
            Id_erdiachi.Size = new Size(0, 25);
            Id_erdiachi.TabIndex = 19;
            // 
            // Id_ersdt
            // 
            Id_ersdt.AutoSize = true;
            Id_ersdt.LinkColor = Color.Red;
            Id_ersdt.Location = new Point(160, 803);
            Id_ersdt.Margin = new Padding(4, 0, 4, 0);
            Id_ersdt.Name = "Id_ersdt";
            Id_ersdt.Size = new Size(0, 25);
            Id_ersdt.TabIndex = 18;
            // 
            // Id_eremail
            // 
            Id_eremail.AutoSize = true;
            Id_eremail.LinkColor = Color.Red;
            Id_eremail.Location = new Point(160, 695);
            Id_eremail.Margin = new Padding(4, 0, 4, 0);
            Id_eremail.Name = "Id_eremail";
            Id_eremail.Size = new Size(0, 25);
            Id_eremail.TabIndex = 17;
            // 
            // Id_erngaysinh
            // 
            Id_erngaysinh.AutoSize = true;
            Id_erngaysinh.LinkColor = Color.Red;
            Id_erngaysinh.Location = new Point(160, 604);
            Id_erngaysinh.Margin = new Padding(4, 0, 4, 0);
            Id_erngaysinh.Name = "Id_erngaysinh";
            Id_erngaysinh.Size = new Size(0, 25);
            Id_erngaysinh.TabIndex = 16;
            // 
            // Ib_erhoten
            // 
            Ib_erhoten.AutoSize = true;
            Ib_erhoten.LinkColor = Color.Red;
            Ib_erhoten.Location = new Point(160, 360);
            Ib_erhoten.Margin = new Padding(4, 0, 4, 0);
            Ib_erhoten.Name = "Ib_erhoten";
            Ib_erhoten.Size = new Size(0, 25);
            Ib_erhoten.TabIndex = 15;
            // 
            // pn_trangthai
            // 
            pn_trangthai.Controls.Add(rb_conlam);
            pn_trangthai.Controls.Add(rb_thoilam);
            pn_trangthai.Location = new Point(4, 206);
            pn_trangthai.Margin = new Padding(4);
            pn_trangthai.Name = "pn_trangthai";
            pn_trangthai.Size = new Size(158, 96);
            pn_trangthai.TabIndex = 7;
            // 
            // rb_conlam
            // 
            rb_conlam.AutoSize = true;
            rb_conlam.Location = new Point(20, 18);
            rb_conlam.Margin = new Padding(4);
            rb_conlam.Name = "rb_conlam";
            rb_conlam.Size = new Size(107, 29);
            rb_conlam.TabIndex = 6;
            rb_conlam.TabStop = true;
            rb_conlam.Text = "Còn Làm";
            rb_conlam.UseVisualStyleBackColor = true;
            // 
            // rb_thoilam
            // 
            rb_thoilam.AutoSize = true;
            rb_thoilam.Location = new Point(20, 55);
            rb_thoilam.Margin = new Padding(4);
            rb_thoilam.Name = "rb_thoilam";
            rb_thoilam.Size = new Size(109, 29);
            rb_thoilam.TabIndex = 6;
            rb_thoilam.TabStop = true;
            rb_thoilam.Text = "Thôi Làm";
            rb_thoilam.UseVisualStyleBackColor = true;
            // 
            // cbb_role
            // 
            cbb_role.FormattingEnabled = true;
            cbb_role.Items.AddRange(new object[] { "AD", "NV" });
            cbb_role.Location = new Point(525, 394);
            cbb_role.Margin = new Padding(4);
            cbb_role.Name = "cbb_role";
            cbb_role.Size = new Size(142, 33);
            cbb_role.TabIndex = 5;
            // 
            // rb_nu
            // 
            rb_nu.AutoSize = true;
            rb_nu.Location = new Point(318, 485);
            rb_nu.Margin = new Padding(4);
            rb_nu.Name = "rb_nu";
            rb_nu.Size = new Size(61, 29);
            rb_nu.TabIndex = 4;
            rb_nu.TabStop = true;
            rb_nu.Text = "Nữ";
            rb_nu.UseVisualStyleBackColor = true;
            // 
            // rb_nam
            // 
            rb_nam.AutoSize = true;
            rb_nam.Location = new Point(175, 485);
            rb_nam.Margin = new Padding(4);
            rb_nam.Name = "rb_nam";
            rb_nam.Size = new Size(75, 29);
            rb_nam.TabIndex = 4;
            rb_nam.TabStop = true;
            rb_nam.Text = "Nam";
            rb_nam.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label8.Location = new Point(18, 1044);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 24);
            label8.TabIndex = 3;
            label8.Text = "Vào Làm:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label10.Location = new Point(22, 1126);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(112, 24);
            label10.TabIndex = 3;
            label10.Text = "Mật Khẩu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label6.Location = new Point(15, 868);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(88, 24);
            label6.TabIndex = 3;
            label6.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label5.Location = new Point(15, 778);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 24);
            label5.TabIndex = 3;
            label5.Text = "SĐT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label4.Location = new Point(15, 670);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 24);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label9.Location = new Point(22, 489);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(108, 24);
            label9.TabIndex = 3;
            label9.Text = "GIới Tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label3.Location = new Point(15, 574);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 3;
            label3.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.5F, FontStyle.Bold);
            label2.Location = new Point(18, 330);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 24);
            label2.TabIndex = 3;
            label2.Text = "Tên:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(401, 402);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 26);
            label7.TabIndex = 3;
            label7.Text = "Chức Vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 402);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 26);
            label1.TabIndex = 3;
            label1.Text = "ID:";
            // 
            // btn_uploadanh
            // 
            btn_uploadanh.BackColor = Color.White;
            btn_uploadanh.Image = (Image)resources.GetObject("btn_uploadanh.Image");
            btn_uploadanh.Location = new Point(624, 18);
            btn_uploadanh.Margin = new Padding(4);
            btn_uploadanh.Name = "btn_uploadanh";
            btn_uploadanh.Size = new Size(49, 35);
            btn_uploadanh.TabIndex = 2;
            btn_uploadanh.UseVisualStyleBackColor = false;
            btn_uploadanh.Click += btn_uploadanh_Click;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Image = (Image)resources.GetObject("btn_update.Image");
            btn_update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update.Location = new Point(18, 155);
            btn_update.Margin = new Padding(4);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(144, 44);
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
            btn_add.Location = new Point(18, 81);
            btn_add.Margin = new Padding(4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(144, 44);
            btn_add.TabIndex = 2;
            btn_add.Text = "        THÊM";
            btn_add.TextAlign = ContentAlignment.MiddleLeft;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(146, 1119);
            txt_password.Margin = new Padding(4);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(523, 31);
            txt_password.TabIndex = 1;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.White;
            btn_clear.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.Image = (Image)resources.GetObject("btn_clear.Image");
            btn_clear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clear.Location = new Point(18, 15);
            btn_clear.Margin = new Padding(4);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(144, 44);
            btn_clear.TabIndex = 2;
            btn_clear.Text = "       LÀM MỚI";
            btn_clear.TextAlign = ContentAlignment.MiddleLeft;
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(149, 868);
            txt_diachi.Margin = new Padding(4);
            txt_diachi.Multiline = true;
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(523, 109);
            txt_diachi.TabIndex = 1;
            // 
            // txt_sodienthoai
            // 
            txt_sodienthoai.Location = new Point(146, 768);
            txt_sodienthoai.Margin = new Padding(4);
            txt_sodienthoai.Name = "txt_sodienthoai";
            txt_sodienthoai.Size = new Size(525, 31);
            txt_sodienthoai.TabIndex = 1;
            // 
            // txt_ngayvaolam
            // 
            txt_ngayvaolam.Location = new Point(146, 1036);
            txt_ngayvaolam.Margin = new Padding(4);
            txt_ngayvaolam.Name = "txt_ngayvaolam";
            txt_ngayvaolam.ReadOnly = true;
            txt_ngayvaolam.Size = new Size(525, 31);
            txt_ngayvaolam.TabIndex = 1;
            // 
            // txt_ngaysinh
            // 
            txt_ngaysinh.Location = new Point(146, 569);
            txt_ngaysinh.Margin = new Padding(4);
            txt_ngaysinh.Name = "txt_ngaysinh";
            txt_ngaysinh.Size = new Size(525, 31);
            txt_ngaysinh.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(146, 660);
            txt_email.Margin = new Padding(4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(525, 31);
            txt_email.TabIndex = 1;
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(149, 325);
            txt_ten.Margin = new Padding(4);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(518, 31);
            txt_ten.TabIndex = 1;
            // 
            // txt_roleid
            // 
            txt_roleid.Location = new Point(154, 396);
            txt_roleid.Margin = new Padding(4);
            txt_roleid.Name = "txt_roleid";
            txt_roleid.ReadOnly = true;
            txt_roleid.Size = new Size(193, 31);
            txt_roleid.TabIndex = 1;
            // 
            // pt_avater
            // 
            pt_avater.BorderStyle = BorderStyle.FixedSingle;
            pt_avater.Image = Properties.Resource.avatarmacdinh;
            pt_avater.Location = new Point(318, 15);
            pt_avater.Margin = new Padding(4);
            pt_avater.Name = "pt_avater";
            pt_avater.Size = new Size(296, 266);
            pt_avater.SizeMode = PictureBoxSizeMode.Zoom;
            pt_avater.TabIndex = 0;
            pt_avater.TabStop = false;
            // 
            // BangNhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1976, 1188);
            Controls.Add(pn_thongtin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
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
        private LinkLabel Ib_erhoten;
        private LinkLabel Id_erdiachi;
        private LinkLabel Id_ersdt;
        private LinkLabel Id_eremail;
        private LinkLabel Id_erngaysinh;
        private LinkLabel lb_pass;
        private LinkLabel lb_lam;
        private LinkLabel lb_chucvu;
        private LinkLabel lb_gioitinh;
    }
}