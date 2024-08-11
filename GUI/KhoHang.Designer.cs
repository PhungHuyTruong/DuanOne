namespace GUI
{
    partial class KhoHang
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoHang));
            panel1 = new Panel();
            comboBox2 = new ComboBox();
            txt_timkiem = new TextBox();
            dtg_sanpham = new DataGridView();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel2 = new Panel();
            lb_ersoluong = new LinkLabel();
            lb_ergia = new LinkLabel();
            lb_ermota = new LinkLabel();
            lb_erbarcode = new LinkLabel();
            lb_erkieugiay = new LinkLabel();
            lb_erchatlieu = new LinkLabel();
            lb_erten = new LinkLabel();
            pt_hinhanh = new PictureBox();
            rb_ngungknihdoanh = new RadioButton();
            rb_kinhdoanh = new RadioButton();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label11 = new Label();
            label15 = new Label();
            label14 = new Label();
            label12 = new Label();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label13 = new Label();
            txt_tengiamgia = new TextBox();
            txt_mucgiam = new TextBox();
            cbb_kichco = new ComboBox();
            cbb_gioitinh = new ComboBox();
            cbb_hangsanpham = new ComboBox();
            txt_soluong = new TextBox();
            cbb_mausac = new ComboBox();
            txt_gia = new TextBox();
            txt_mota = new TextBox();
            txt_barcode = new TextBox();
            txt_kieugiay = new TextBox();
            txt_chatlieu = new TextBox();
            txt_ten = new TextBox();
            txt_id = new TextBox();
            btn_kopic = new Button();
            btn_uploadanh = new Button();
            btn_update = new Button();
            btn_add = new Button();
            btn_clear = new Button();
            tabPage2 = new TabPage();
            panel4 = new Panel();
            cbb_boolkhuyemai = new ComboBox();
            dtg_sanphamkhuyenmai = new DataGridView();
            textBox2 = new TextBox();
            panel3 = new Panel();
            btn_capnhat = new Button();
            button2 = new Button();
            btn_themkhuyenmai = new Button();
            btn_huykhuyenmai = new Button();
            txt2_denngay = new TextBox();
            txt2_giagiam = new TextBox();
            txt2_tungay = new TextBox();
            txt2_giagoc = new TextBox();
            txt2_mucgiam = new TextBox();
            txt2_chuongtrinh = new TextBox();
            txt2_kichco = new TextBox();
            txt2_phai = new TextBox();
            txt2_mausac = new TextBox();
            txt2_hang = new TextBox();
            txt2_ten = new TextBox();
            txt2_barcode = new TextBox();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label29 = new Label();
            label31 = new Label();
            label30 = new Label();
            label28 = new Label();
            label27 = new Label();
            label23 = new Label();
            label21 = new Label();
            label20 = new Label();
            label22 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            textBox1 = new TextBox();
            dtg_khuyenmai = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_sanpham).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pt_hinhanh).BeginInit();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_sanphamkhuyenmai).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_khuyenmai).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(txt_timkiem);
            panel1.Controls.Add(dtg_sanpham);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, -1);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1011, 929);
            panel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(802, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(191, 28);
            comboBox2.TabIndex = 7;
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(18, 22);
            txt_timkiem.Multiline = true;
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(244, 28);
            txt_timkiem.TabIndex = 5;
            txt_timkiem.TextChanged += txt_timkiem_TextChanged;
            // 
            // dtg_sanpham
            // 
            dtg_sanpham.AllowUserToAddRows = false;
            dtg_sanpham.BackgroundColor = Color.FromArgb(244, 243, 243);
            dtg_sanpham.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_sanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 252, 252);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_sanpham.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_sanpham.GridColor = SystemColors.MenuBar;
            dtg_sanpham.Location = new Point(18, 67);
            dtg_sanpham.Name = "dtg_sanpham";
            dtg_sanpham.RowHeadersVisible = false;
            dtg_sanpham.RowHeadersWidth = 51;
            dtg_sanpham.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtg_sanpham.Size = new Size(975, 843);
            dtg_sanpham.TabIndex = 4;
            dtg_sanpham.CellClick += dtg_sanpham_CellClick;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(259, 22);
            button1.Name = "button1";
            button1.Size = new Size(45, 28);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(-4, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1589, 957);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(242, 242, 242);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1581, 924);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sản Phẩm";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lb_ersoluong);
            panel2.Controls.Add(lb_ergia);
            panel2.Controls.Add(lb_ermota);
            panel2.Controls.Add(lb_erbarcode);
            panel2.Controls.Add(lb_erkieugiay);
            panel2.Controls.Add(lb_erchatlieu);
            panel2.Controls.Add(lb_erten);
            panel2.Controls.Add(pt_hinhanh);
            panel2.Controls.Add(rb_ngungknihdoanh);
            panel2.Controls.Add(rb_kinhdoanh);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txt_tengiamgia);
            panel2.Controls.Add(txt_mucgiam);
            panel2.Controls.Add(cbb_kichco);
            panel2.Controls.Add(cbb_gioitinh);
            panel2.Controls.Add(cbb_hangsanpham);
            panel2.Controls.Add(txt_soluong);
            panel2.Controls.Add(cbb_mausac);
            panel2.Controls.Add(txt_gia);
            panel2.Controls.Add(txt_mota);
            panel2.Controls.Add(txt_barcode);
            panel2.Controls.Add(txt_kieugiay);
            panel2.Controls.Add(txt_chatlieu);
            panel2.Controls.Add(txt_ten);
            panel2.Controls.Add(txt_id);
            panel2.Controls.Add(btn_kopic);
            panel2.Controls.Add(btn_uploadanh);
            panel2.Controls.Add(btn_update);
            panel2.Controls.Add(btn_add);
            panel2.Controls.Add(btn_clear);
            panel2.Location = new Point(1035, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 951);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // lb_ersoluong
            // 
            lb_ersoluong.AutoSize = true;
            lb_ersoluong.LinkColor = Color.Red;
            lb_ersoluong.Location = new Point(376, 892);
            lb_ersoluong.Name = "lb_ersoluong";
            lb_ersoluong.Size = new Size(0, 20);
            lb_ersoluong.TabIndex = 14;
            // 
            // lb_ergia
            // 
            lb_ergia.AutoSize = true;
            lb_ergia.LinkColor = Color.Red;
            lb_ergia.Location = new Point(83, 892);
            lb_ergia.Name = "lb_ergia";
            lb_ergia.Size = new Size(0, 20);
            lb_ergia.TabIndex = 14;
            // 
            // lb_ermota
            // 
            lb_ermota.AutoSize = true;
            lb_ermota.LinkColor = Color.Red;
            lb_ermota.Location = new Point(95, 825);
            lb_ermota.Name = "lb_ermota";
            lb_ermota.Size = new Size(0, 20);
            lb_ermota.TabIndex = 14;
            // 
            // lb_erbarcode
            // 
            lb_erbarcode.AutoSize = true;
            lb_erbarcode.LinkColor = Color.Red;
            lb_erbarcode.Location = new Point(94, 498);
            lb_erbarcode.Name = "lb_erbarcode";
            lb_erbarcode.Size = new Size(0, 20);
            lb_erbarcode.TabIndex = 14;
            // 
            // lb_erkieugiay
            // 
            lb_erkieugiay.AutoSize = true;
            lb_erkieugiay.LinkColor = Color.Red;
            lb_erkieugiay.Location = new Point(94, 443);
            lb_erkieugiay.Name = "lb_erkieugiay";
            lb_erkieugiay.Size = new Size(0, 20);
            lb_erkieugiay.TabIndex = 14;
            // 
            // lb_erchatlieu
            // 
            lb_erchatlieu.AutoSize = true;
            lb_erchatlieu.LinkColor = Color.Red;
            lb_erchatlieu.Location = new Point(94, 390);
            lb_erchatlieu.Name = "lb_erchatlieu";
            lb_erchatlieu.Size = new Size(0, 20);
            lb_erchatlieu.TabIndex = 14;
            // 
            // lb_erten
            // 
            lb_erten.AutoSize = true;
            lb_erten.LinkColor = Color.Red;
            lb_erten.Location = new Point(93, 278);
            lb_erten.Name = "lb_erten";
            lb_erten.Size = new Size(0, 20);
            lb_erten.TabIndex = 14;
            // 
            // pt_hinhanh
            // 
            pt_hinhanh.BorderStyle = BorderStyle.Fixed3D;
            pt_hinhanh.Location = new Point(248, 13);
            pt_hinhanh.Name = "pt_hinhanh";
            pt_hinhanh.Size = new Size(255, 229);
            pt_hinhanh.SizeMode = PictureBoxSizeMode.Zoom;
            pt_hinhanh.TabIndex = 3;
            pt_hinhanh.TabStop = false;
            // 
            // rb_ngungknihdoanh
            // 
            rb_ngungknihdoanh.AutoSize = true;
            rb_ngungknihdoanh.FlatStyle = FlatStyle.System;
            rb_ngungknihdoanh.Location = new Point(17, 165);
            rb_ngungknihdoanh.Name = "rb_ngungknihdoanh";
            rb_ngungknihdoanh.Size = new Size(166, 25);
            rb_ngungknihdoanh.TabIndex = 13;
            rb_ngungknihdoanh.Text = "Ngừng Kinh Doanh";
            rb_ngungknihdoanh.UseVisualStyleBackColor = true;
            // 
            // rb_kinhdoanh
            // 
            rb_kinhdoanh.AutoSize = true;
            rb_kinhdoanh.FlatStyle = FlatStyle.System;
            rb_kinhdoanh.Location = new Point(16, 196);
            rb_kinhdoanh.Name = "rb_kinhdoanh";
            rb_kinhdoanh.Size = new Size(116, 25);
            rb_kinhdoanh.TabIndex = 13;
            rb_kinhdoanh.Text = "Kinh Doanh";
            rb_kinhdoanh.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(406, 528);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 12;
            label9.Text = "Kích Cỡ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 528);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 12;
            label8.Text = "Phái:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(94, 528);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 12;
            label7.Text = "Màu Sắc:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(205, 599);
            label11.Name = "label11";
            label11.Size = new Size(100, 20);
            label11.TabIndex = 12;
            label11.Text = "Chương Trình:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(319, 868);
            label15.Name = "label15";
            label15.Size = new Size(75, 20);
            label15.TabIndex = 12;
            label15.Text = "Số Lượng:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 868);
            label14.Name = "label14";
            label14.Size = new Size(34, 20);
            label14.TabIndex = 12;
            label14.Text = "Giá:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 475);
            label12.Name = "label12";
            label12.Size = new Size(67, 20);
            label12.TabIndex = 12;
            label12.Text = "Barcode:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(95, 599);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 12;
            label10.Text = "GIảm:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 560);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 12;
            label6.Text = "Chi Tiết:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 420);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 12;
            label5.Text = "Kiểu Giày:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 367);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 12;
            label4.Text = "Chất Liệu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 687);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 12;
            label3.Text = "Mô Tả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 312);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 12;
            label2.Text = "Hãng:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 255);
            label13.Name = "label13";
            label13.Size = new Size(35, 20);
            label13.TabIndex = 12;
            label13.Text = "Tên:";
            // 
            // txt_tengiamgia
            // 
            txt_tengiamgia.BackColor = Color.White;
            txt_tengiamgia.Location = new Point(205, 631);
            txt_tengiamgia.Name = "txt_tengiamgia";
            txt_tengiamgia.ReadOnly = true;
            txt_tengiamgia.Size = new Size(334, 27);
            txt_tengiamgia.TabIndex = 11;
            // 
            // txt_mucgiam
            // 
            txt_mucgiam.BackColor = Color.White;
            txt_mucgiam.Location = new Point(95, 631);
            txt_mucgiam.Name = "txt_mucgiam";
            txt_mucgiam.ReadOnly = true;
            txt_mucgiam.Size = new Size(89, 27);
            txt_mucgiam.TabIndex = 11;
            // 
            // cbb_kichco
            // 
            cbb_kichco.FormattingEnabled = true;
            cbb_kichco.Location = new Point(406, 560);
            cbb_kichco.Name = "cbb_kichco";
            cbb_kichco.Size = new Size(132, 28);
            cbb_kichco.TabIndex = 10;
            // 
            // cbb_gioitinh
            // 
            cbb_gioitinh.FormattingEnabled = true;
            cbb_gioitinh.Location = new Point(248, 560);
            cbb_gioitinh.Name = "cbb_gioitinh";
            cbb_gioitinh.Size = new Size(140, 28);
            cbb_gioitinh.TabIndex = 10;
            // 
            // cbb_hangsanpham
            // 
            cbb_hangsanpham.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_hangsanpham.FormattingEnabled = true;
            cbb_hangsanpham.Location = new Point(93, 304);
            cbb_hangsanpham.Name = "cbb_hangsanpham";
            cbb_hangsanpham.Size = new Size(444, 28);
            cbb_hangsanpham.TabIndex = 10;
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(399, 865);
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(140, 27);
            txt_soluong.TabIndex = 9;
            // 
            // cbb_mausac
            // 
            cbb_mausac.FormattingEnabled = true;
            cbb_mausac.Location = new Point(94, 560);
            cbb_mausac.Name = "cbb_mausac";
            cbb_mausac.Size = new Size(140, 28);
            cbb_mausac.TabIndex = 10;
            // 
            // txt_gia
            // 
            txt_gia.Location = new Point(95, 865);
            txt_gia.Name = "txt_gia";
            txt_gia.Size = new Size(140, 27);
            txt_gia.TabIndex = 9;
            // 
            // txt_mota
            // 
            txt_mota.Location = new Point(94, 684);
            txt_mota.Multiline = true;
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(444, 138);
            txt_mota.TabIndex = 9;
            // 
            // txt_barcode
            // 
            txt_barcode.Location = new Point(94, 468);
            txt_barcode.Name = "txt_barcode";
            txt_barcode.Size = new Size(444, 27);
            txt_barcode.TabIndex = 9;
            // 
            // txt_kieugiay
            // 
            txt_kieugiay.Location = new Point(94, 413);
            txt_kieugiay.Name = "txt_kieugiay";
            txt_kieugiay.Size = new Size(444, 27);
            txt_kieugiay.TabIndex = 9;
            // 
            // txt_chatlieu
            // 
            txt_chatlieu.Location = new Point(93, 360);
            txt_chatlieu.Name = "txt_chatlieu";
            txt_chatlieu.Size = new Size(444, 27);
            txt_chatlieu.TabIndex = 9;
            // 
            // txt_ten
            // 
            txt_ten.BackColor = Color.White;
            txt_ten.Location = new Point(93, 248);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(445, 27);
            txt_ten.TabIndex = 9;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(93, 248);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(74, 27);
            txt_id.TabIndex = 9;
            // 
            // btn_kopic
            // 
            btn_kopic.BackColor = Color.White;
            btn_kopic.Image = Properties.Resource.cross;
            btn_kopic.Location = new Point(498, 39);
            btn_kopic.Name = "btn_kopic";
            btn_kopic.Size = new Size(39, 28);
            btn_kopic.TabIndex = 4;
            btn_kopic.UseVisualStyleBackColor = false;
            btn_kopic.Click += btn_kopic_Click;
            // 
            // btn_uploadanh
            // 
            btn_uploadanh.BackColor = Color.White;
            btn_uploadanh.Image = (Image)resources.GetObject("btn_uploadanh.Image");
            btn_uploadanh.Location = new Point(498, 13);
            btn_uploadanh.Name = "btn_uploadanh";
            btn_uploadanh.Size = new Size(39, 28);
            btn_uploadanh.TabIndex = 4;
            btn_uploadanh.UseVisualStyleBackColor = false;
            btn_uploadanh.Click += btn_uploadanh_Click;
            // 
            // btn_update
            // 
            btn_update.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.Image = (Image)resources.GetObject("btn_update.Image");
            btn_update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update.Location = new Point(16, 124);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(115, 35);
            btn_update.TabIndex = 5;
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
            btn_add.Location = new Point(16, 66);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(115, 35);
            btn_add.TabIndex = 7;
            btn_add.Text = "        THÊM";
            btn_add.TextAlign = ContentAlignment.MiddleLeft;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.Image = (Image)resources.GetObject("btn_clear.Image");
            btn_clear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clear.Location = new Point(16, 14);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(115, 35);
            btn_clear.TabIndex = 8;
            btn_clear.Text = "       LÀM MỚI";
            btn_clear.TextAlign = ContentAlignment.MiddleLeft;
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(242, 242, 242);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1581, 924);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sản Phẩm Giảm Giá";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(cbb_boolkhuyemai);
            panel4.Controls.Add(dtg_sanphamkhuyenmai);
            panel4.Controls.Add(textBox2);
            panel4.Location = new Point(1188, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(397, 923);
            panel4.TabIndex = 1;
            // 
            // cbb_boolkhuyemai
            // 
            cbb_boolkhuyemai.FormattingEnabled = true;
            cbb_boolkhuyemai.Location = new Point(239, 5);
            cbb_boolkhuyemai.Name = "cbb_boolkhuyemai";
            cbb_boolkhuyemai.Size = new Size(142, 28);
            cbb_boolkhuyemai.TabIndex = 2;
            cbb_boolkhuyemai.SelectedIndexChanged += cbb_boolkhuyemai_SelectedIndexChanged;
            // 
            // dtg_sanphamkhuyenmai
            // 
            dtg_sanphamkhuyenmai.AllowUserToAddRows = false;
            dtg_sanphamkhuyenmai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_sanphamkhuyenmai.BackgroundColor = Color.FromArgb(244, 243, 243);
            dtg_sanphamkhuyenmai.BorderStyle = BorderStyle.None;
            dtg_sanphamkhuyenmai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_sanphamkhuyenmai.GridColor = SystemColors.InactiveBorder;
            dtg_sanphamkhuyenmai.Location = new Point(17, 39);
            dtg_sanphamkhuyenmai.Name = "dtg_sanphamkhuyenmai";
            dtg_sanphamkhuyenmai.RowHeadersVisible = false;
            dtg_sanphamkhuyenmai.RowHeadersWidth = 51;
            dtg_sanphamkhuyenmai.Size = new Size(364, 869);
            dtg_sanphamkhuyenmai.TabIndex = 0;
            dtg_sanphamkhuyenmai.CellClick += dtg_sanphamkhuyenmai_CellClick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 27);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btn_capnhat);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(btn_themkhuyenmai);
            panel3.Controls.Add(btn_huykhuyenmai);
            panel3.Controls.Add(txt2_denngay);
            panel3.Controls.Add(txt2_giagiam);
            panel3.Controls.Add(txt2_tungay);
            panel3.Controls.Add(txt2_giagoc);
            panel3.Controls.Add(txt2_mucgiam);
            panel3.Controls.Add(txt2_chuongtrinh);
            panel3.Controls.Add(txt2_kichco);
            panel3.Controls.Add(txt2_phai);
            panel3.Controls.Add(txt2_mausac);
            panel3.Controls.Add(txt2_hang);
            panel3.Controls.Add(txt2_ten);
            panel3.Controls.Add(txt2_barcode);
            panel3.Controls.Add(label26);
            panel3.Controls.Add(label25);
            panel3.Controls.Add(label24);
            panel3.Controls.Add(label29);
            panel3.Controls.Add(label31);
            panel3.Controls.Add(label30);
            panel3.Controls.Add(label28);
            panel3.Controls.Add(label27);
            panel3.Controls.Add(label23);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(dtg_khuyenmai);
            panel3.Location = new Point(-4, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1171, 550);
            panel3.TabIndex = 1;
            // 
            // btn_capnhat
            // 
            btn_capnhat.Location = new Point(109, 492);
            btn_capnhat.Name = "btn_capnhat";
            btn_capnhat.Size = new Size(144, 29);
            btn_capnhat.TabIndex = 5;
            btn_capnhat.Text = "Cập Nhật";
            btn_capnhat.UseVisualStyleBackColor = true;
            btn_capnhat.Click += btn_capnhat_Click;
            // 
            // button2
            // 
            button2.Location = new Point(983, 492);
            button2.Name = "button2";
            button2.Size = new Size(174, 29);
            button2.TabIndex = 5;
            button2.Text = "Loại ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_themkhuyenmai
            // 
            btn_themkhuyenmai.Location = new Point(803, 492);
            btn_themkhuyenmai.Name = "btn_themkhuyenmai";
            btn_themkhuyenmai.Size = new Size(174, 29);
            btn_themkhuyenmai.TabIndex = 5;
            btn_themkhuyenmai.Text = "Thêm ";
            btn_themkhuyenmai.UseVisualStyleBackColor = true;
            btn_themkhuyenmai.Click += btn_themkhuyenmai_Click;
            // 
            // btn_huykhuyenmai
            // 
            btn_huykhuyenmai.Location = new Point(259, 492);
            btn_huykhuyenmai.Name = "btn_huykhuyenmai";
            btn_huykhuyenmai.Size = new Size(144, 29);
            btn_huykhuyenmai.TabIndex = 5;
            btn_huykhuyenmai.Text = "Hủy";
            btn_huykhuyenmai.UseVisualStyleBackColor = true;
            btn_huykhuyenmai.Click += btn_huykhuyenmai_Click;
            // 
            // txt2_denngay
            // 
            txt2_denngay.BackColor = Color.White;
            txt2_denngay.Location = new Point(259, 439);
            txt2_denngay.Name = "txt2_denngay";
            txt2_denngay.ReadOnly = true;
            txt2_denngay.Size = new Size(144, 27);
            txt2_denngay.TabIndex = 4;
            // 
            // txt2_giagiam
            // 
            txt2_giagiam.BackColor = Color.White;
            txt2_giagiam.Location = new Point(635, 439);
            txt2_giagiam.Name = "txt2_giagiam";
            txt2_giagiam.ReadOnly = true;
            txt2_giagiam.Size = new Size(144, 27);
            txt2_giagiam.TabIndex = 4;
            // 
            // txt2_tungay
            // 
            txt2_tungay.BackColor = Color.White;
            txt2_tungay.Location = new Point(109, 439);
            txt2_tungay.Name = "txt2_tungay";
            txt2_tungay.ReadOnly = true;
            txt2_tungay.Size = new Size(144, 27);
            txt2_tungay.TabIndex = 4;
            // 
            // txt2_giagoc
            // 
            txt2_giagoc.BackColor = Color.White;
            txt2_giagoc.Location = new Point(485, 439);
            txt2_giagoc.Name = "txt2_giagoc";
            txt2_giagoc.ReadOnly = true;
            txt2_giagoc.Size = new Size(144, 27);
            txt2_giagoc.TabIndex = 4;
            // 
            // txt2_mucgiam
            // 
            txt2_mucgiam.BackColor = Color.White;
            txt2_mucgiam.Location = new Point(592, 384);
            txt2_mucgiam.Name = "txt2_mucgiam";
            txt2_mucgiam.ReadOnly = true;
            txt2_mucgiam.Size = new Size(187, 27);
            txt2_mucgiam.TabIndex = 4;
            // 
            // txt2_chuongtrinh
            // 
            txt2_chuongtrinh.BackColor = Color.White;
            txt2_chuongtrinh.Location = new Point(109, 384);
            txt2_chuongtrinh.Name = "txt2_chuongtrinh";
            txt2_chuongtrinh.ReadOnly = true;
            txt2_chuongtrinh.Size = new Size(477, 27);
            txt2_chuongtrinh.TabIndex = 4;
            // 
            // txt2_kichco
            // 
            txt2_kichco.BackColor = Color.White;
            txt2_kichco.Location = new Point(91, 303);
            txt2_kichco.Name = "txt2_kichco";
            txt2_kichco.ReadOnly = true;
            txt2_kichco.Size = new Size(688, 27);
            txt2_kichco.TabIndex = 4;
            // 
            // txt2_phai
            // 
            txt2_phai.BackColor = Color.White;
            txt2_phai.Location = new Point(91, 248);
            txt2_phai.Name = "txt2_phai";
            txt2_phai.ReadOnly = true;
            txt2_phai.Size = new Size(688, 27);
            txt2_phai.TabIndex = 4;
            // 
            // txt2_mausac
            // 
            txt2_mausac.BackColor = Color.White;
            txt2_mausac.Location = new Point(91, 198);
            txt2_mausac.Name = "txt2_mausac";
            txt2_mausac.ReadOnly = true;
            txt2_mausac.Size = new Size(688, 27);
            txt2_mausac.TabIndex = 4;
            // 
            // txt2_hang
            // 
            txt2_hang.BackColor = Color.White;
            txt2_hang.Location = new Point(91, 146);
            txt2_hang.Name = "txt2_hang";
            txt2_hang.ReadOnly = true;
            txt2_hang.Size = new Size(688, 27);
            txt2_hang.TabIndex = 4;
            // 
            // txt2_ten
            // 
            txt2_ten.BackColor = Color.White;
            txt2_ten.Location = new Point(91, 98);
            txt2_ten.Name = "txt2_ten";
            txt2_ten.ReadOnly = true;
            txt2_ten.Size = new Size(688, 27);
            txt2_ten.TabIndex = 4;
            // 
            // txt2_barcode
            // 
            txt2_barcode.BackColor = Color.White;
            txt2_barcode.Location = new Point(91, 49);
            txt2_barcode.Name = "txt2_barcode";
            txt2_barcode.ReadOnly = true;
            txt2_barcode.Size = new Size(688, 27);
            txt2_barcode.TabIndex = 4;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(434, 446);
            label26.Name = "label26";
            label26.Size = new Size(34, 20);
            label26.TabIndex = 3;
            label26.Text = "Giá:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(592, 361);
            label25.Name = "label25";
            label25.Size = new Size(47, 20);
            label25.TabIndex = 3;
            label25.Text = "Giảm:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(109, 361);
            label24.Name = "label24";
            label24.Size = new Size(100, 20);
            label24.TabIndex = 3;
            label24.Text = "Chương Trình:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(259, 414);
            label29.Name = "label29";
            label29.Size = new Size(39, 20);
            label29.TabIndex = 3;
            label29.Text = "Đến:";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(635, 414);
            label31.Name = "label31";
            label31.Size = new Size(47, 20);
            label31.TabIndex = 3;
            label31.Text = "Giảm:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(485, 416);
            label30.Name = "label30";
            label30.Size = new Size(38, 20);
            label30.TabIndex = 3;
            label30.Text = "Gốc:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(109, 416);
            label28.Name = "label28";
            label28.Size = new Size(29, 20);
            label28.TabIndex = 3;
            label28.Text = "Từ:";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(10, 446);
            label27.Name = "label27";
            label27.Size = new Size(75, 20);
            label27.TabIndex = 3;
            label27.Text = "Thời Gian:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(10, 391);
            label23.Name = "label23";
            label23.Size = new Size(73, 20);
            label23.TabIndex = 3;
            label23.Text = "Giảm Giá:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(10, 310);
            label21.Name = "label21";
            label21.Size = new Size(62, 20);
            label21.TabIndex = 3;
            label21.Text = "Kích Cỡ:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(10, 255);
            label20.Name = "label20";
            label20.Size = new Size(40, 20);
            label20.TabIndex = 3;
            label20.Text = "Phái:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(10, 205);
            label22.Name = "label22";
            label22.Size = new Size(68, 20);
            label22.TabIndex = 3;
            label22.Text = "Màu Sắc:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(27, 205);
            label19.Name = "label19";
            label19.Size = new Size(0, 20);
            label19.TabIndex = 3;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(10, 153);
            label18.Name = "label18";
            label18.Size = new Size(48, 20);
            label18.TabIndex = 3;
            label18.Text = "Hãng:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 105);
            label17.Name = "label17";
            label17.Size = new Size(35, 20);
            label17.TabIndex = 3;
            label17.Text = "Tên:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(10, 56);
            label16.Name = "label16";
            label16.Size = new Size(67, 20);
            label16.TabIndex = 3;
            label16.Text = "Barcode:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(803, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 27);
            textBox1.TabIndex = 1;
            // 
            // dtg_khuyenmai
            // 
            dtg_khuyenmai.AllowUserToAddRows = false;
            dtg_khuyenmai.BackgroundColor = Color.FromArgb(244, 243, 243);
            dtg_khuyenmai.BorderStyle = BorderStyle.None;
            dtg_khuyenmai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_khuyenmai.GridColor = SystemColors.InactiveBorder;
            dtg_khuyenmai.Location = new Point(803, 39);
            dtg_khuyenmai.Name = "dtg_khuyenmai";
            dtg_khuyenmai.RowHeadersVisible = false;
            dtg_khuyenmai.RowHeadersWidth = 51;
            dtg_khuyenmai.Size = new Size(353, 427);
            dtg_khuyenmai.TabIndex = 0;
            dtg_khuyenmai.CellContentClick += dtg_khuyenmai_CellContentClick;
            // 
            // KhoHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1581, 950);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KhoHang";
            Text = "KhoHang";
            Load += KhoHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_sanpham).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pt_hinhanh).EndInit();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_sanphamkhuyenmai).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_khuyenmai).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox comboBox2;
        private Button button1;
        private TextBox txt_timkiem;
        private DataGridView dtg_sanpham;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label11;
        private Label label12;
        private Label label10;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label13;
        private TextBox txt_tengiamgia;
        private TextBox txt_mucgiam;
        private ComboBox cbb_kichco;
        private ComboBox cbb_gioitinh;
        private ComboBox cbb_mausac;
        private TextBox txt_mota;
        private TextBox txt_barcode;
        private TextBox txt_kieugiay;
        private TextBox txt_chatlieu;
        private TextBox txt_ten;
        private TextBox txt_id;
        private Button btn_uploadanh;
        private Button btn_update;
        private Button btn_add;
        private Button btn_clear;
        private PictureBox pt_hinhanh;
        private ComboBox cbb_hangsanpham;
        private RadioButton rb_ngungknihdoanh;
        private RadioButton rb_kinhdoanh;
        private Label label14;
        private TextBox txt_gia;
        private Label label15;
        private TextBox txt_soluong;
        private Button btn_kopic;
        private Panel panel3;
        private DataGridView dtg_khuyenmai;
        private Panel panel4;
        private DataGridView dtg_sanphamkhuyenmai;
        private ComboBox cbb_boolkhuyemai;
        private TextBox textBox2;
        private Label label16;
        private TextBox textBox1;
        private TextBox txt2_kichco;
        private TextBox txt2_phai;
        private TextBox txt2_hang;
        private TextBox txt2_ten;
        private TextBox txt2_barcode;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private TextBox txt2_giagiam;
        private TextBox txt2_giagoc;
        private TextBox txt2_mucgiam;
        private TextBox txt2_chuongtrinh;
        private Button btn_huykhuyenmai;
        private Button btn_capnhat;
        private TextBox txt2_mausac;
        private Label label22;
        private TextBox txt2_denngay;
        private TextBox txt2_tungay;
        private Label label24;
        private Label label23;
        private Label label26;
        private Label label25;
        private Label label29;
        private Label label31;
        private Label label30;
        private Label label28;
        private Label label27;
        private Button btn_themkhuyenmai;
        private Button button2;
        private LinkLabel lb_erbarcode;
        private LinkLabel lb_erkieugiay;
        private LinkLabel lb_erten;
        private LinkLabel lb_ermota;
        private LinkLabel lb_erchatlieu;
        private LinkLabel lb_ersoluong;
        private LinkLabel lb_ergia;
    }
}