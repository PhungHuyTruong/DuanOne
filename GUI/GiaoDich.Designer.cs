namespace GUI
{
    partial class GiaoDich
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabs = new TabControl();
            tb_thanhtoan = new TabPage();
            flo_giohangcho = new FlowLayoutPanel();
            panel4 = new Panel();
            dtg_sanpham = new DataGridView();
            panel3 = new Panel();
            btn_vanchuyen = new Button();
            btn_treodon = new Button();
            btn_huydon = new Button();
            btn_thanhtoan = new Button();
            panel2 = new Panel();
            txt_tongtien = new TextBox();
            label1 = new Label();
            dtg_xesanpham = new DataGridView();
            panel1 = new Panel();
            txt_giohang = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            tb_hoadon = new TabPage();
            panel6 = new Panel();
            txt_timkiem2 = new TextBox();
            label15 = new Label();
            txt_tongtien2 = new TextBox();
            label14 = new Label();
            label13 = new Label();
            txt_thoigian2 = new TextBox();
            label12 = new Label();
            dtp_hoadon2 = new DateTimePicker();
            label11 = new Label();
            dtp_hoadon1 = new DateTimePicker();
            label10 = new Label();
            btn_timdatagrid2 = new Button();
            btn_dtp2 = new Button();
            btn_hoantra = new Button();
            label9 = new Label();
            dtg_chitiethoantat = new DataGridView();
            txt_diachi2 = new TextBox();
            txt_email2 = new TextBox();
            txt_sdt2 = new TextBox();
            txt_ten2 = new TextBox();
            dtg_hoadondaxong = new DataGridView();
            panel5 = new Panel();
            txt_timkiem1 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_tongtien1 = new TextBox();
            txt_thoigian1 = new TextBox();
            dtp_vanchuyen1 = new DateTimePicker();
            btn_timdatagrid1 = new Button();
            btn_dtp1 = new Button();
            dtp_vanchuyen2 = new DateTimePicker();
            btn_huyvanchuyen = new Button();
            btn_xacnhanvanchuyen = new Button();
            dtg_chittietvanchuyen = new DataGridView();
            txt_diachi1 = new TextBox();
            txt_email1 = new TextBox();
            txt_sdt1 = new TextBox();
            txt_ten1 = new TextBox();
            dtg_hoadonvanchuyen = new DataGridView();
            tabs.SuspendLayout();
            tb_thanhtoan.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_sanpham).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_xesanpham).BeginInit();
            panel1.SuspendLayout();
            tb_hoadon.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_chitiethoantat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_hoadondaxong).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_chittietvanchuyen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_hoadonvanchuyen).BeginInit();
            SuspendLayout();
            // 
            // tabs
            // 
            tabs.Controls.Add(tb_thanhtoan);
            tabs.Controls.Add(tb_hoadon);
            tabs.ItemSize = new Size(100, 35);
            tabs.Location = new Point(-4, 1);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1603, 962);
            tabs.TabIndex = 0;
            // 
            // tb_thanhtoan
            // 
            tb_thanhtoan.BackColor = Color.FromArgb(242, 242, 242);
            tb_thanhtoan.Controls.Add(flo_giohangcho);
            tb_thanhtoan.Controls.Add(panel4);
            tb_thanhtoan.Controls.Add(panel3);
            tb_thanhtoan.Controls.Add(panel2);
            tb_thanhtoan.Controls.Add(panel1);
            tb_thanhtoan.Location = new Point(4, 39);
            tb_thanhtoan.Name = "tb_thanhtoan";
            tb_thanhtoan.Size = new Size(1595, 919);
            tb_thanhtoan.TabIndex = 0;
            tb_thanhtoan.Text = "Thanh Toán";
            // 
            // flo_giohangcho
            // 
            flo_giohangcho.BackColor = Color.White;
            flo_giohangcho.Location = new Point(1445, 0);
            flo_giohangcho.Name = "flo_giohangcho";
            flo_giohangcho.Size = new Size(141, 916);
            flo_giohangcho.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dtg_sanpham);
            panel4.Location = new Point(1052, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(375, 916);
            panel4.TabIndex = 2;
            // 
            // dtg_sanpham
            // 
            dtg_sanpham.AllowUserToAddRows = false;
            dtg_sanpham.AllowUserToResizeColumns = false;
            dtg_sanpham.AllowUserToResizeRows = false;
            dtg_sanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_sanpham.BackgroundColor = Color.FromArgb(244, 243, 243);
            dtg_sanpham.BorderStyle = BorderStyle.None;
            dtg_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_sanpham.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtg_sanpham.DefaultCellStyle = dataGridViewCellStyle1;
            dtg_sanpham.GridColor = SystemColors.MenuBar;
            dtg_sanpham.Location = new Point(13, 82);
            dtg_sanpham.Name = "dtg_sanpham";
            dtg_sanpham.ReadOnly = true;
            dtg_sanpham.RowHeadersVisible = false;
            dtg_sanpham.RowHeadersWidth = 51;
            dtg_sanpham.Size = new Size(348, 815);
            dtg_sanpham.TabIndex = 0;
            dtg_sanpham.CellContentDoubleClick += dtg_sanpham_CellContentDoubleClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btn_vanchuyen);
            panel3.Controls.Add(btn_treodon);
            panel3.Controls.Add(btn_huydon);
            panel3.Controls.Add(btn_thanhtoan);
            panel3.Location = new Point(0, 831);
            panel3.Name = "panel3";
            panel3.Size = new Size(1033, 79);
            panel3.TabIndex = 1;
            // 
            // btn_vanchuyen
            // 
            btn_vanchuyen.Location = new Point(787, 11);
            btn_vanchuyen.Margin = new Padding(0);
            btn_vanchuyen.Name = "btn_vanchuyen";
            btn_vanchuyen.Size = new Size(238, 59);
            btn_vanchuyen.TabIndex = 0;
            btn_vanchuyen.Text = "VẬN CHUYỂN";
            btn_vanchuyen.UseVisualStyleBackColor = true;
            btn_vanchuyen.Click += btn_vanchuyen_Click;
            // 
            // btn_treodon
            // 
            btn_treodon.Location = new Point(528, 11);
            btn_treodon.Margin = new Padding(0);
            btn_treodon.Name = "btn_treodon";
            btn_treodon.Size = new Size(238, 59);
            btn_treodon.TabIndex = 0;
            btn_treodon.Text = "TREO ĐƠN";
            btn_treodon.UseVisualStyleBackColor = true;
            btn_treodon.Click += btn_treodon_Click;
            // 
            // btn_huydon
            // 
            btn_huydon.Location = new Point(268, 11);
            btn_huydon.Margin = new Padding(0);
            btn_huydon.Name = "btn_huydon";
            btn_huydon.Size = new Size(238, 59);
            btn_huydon.TabIndex = 0;
            btn_huydon.Text = "HỦY ĐƠN";
            btn_huydon.UseVisualStyleBackColor = true;
            btn_huydon.Click += btn_huydon_Click;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.Location = new Point(9, 11);
            btn_thanhtoan.Margin = new Padding(0);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(238, 59);
            btn_thanhtoan.TabIndex = 0;
            btn_thanhtoan.Text = "THANH TOÁN";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            btn_thanhtoan.Click += btn_thanhtoan_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txt_tongtien);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtg_xesanpham);
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1033, 752);
            panel2.TabIndex = 1;
            // 
            // txt_tongtien
            // 
            txt_tongtien.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_tongtien.Location = new Point(831, 712);
            txt_tongtien.Multiline = true;
            txt_tongtien.Name = "txt_tongtien";
            txt_tongtien.Size = new Size(191, 30);
            txt_tongtien.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(670, 712);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 2;
            label1.Text = "TỔNG TIỀN:";
            // 
            // dtg_xesanpham
            // 
            dtg_xesanpham.AllowUserToAddRows = false;
            dtg_xesanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_xesanpham.BackgroundColor = Color.FromArgb(244, 243, 243);
            dtg_xesanpham.BorderStyle = BorderStyle.None;
            dtg_xesanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_xesanpham.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_xesanpham.GridColor = SystemColors.ScrollBar;
            dtg_xesanpham.Location = new Point(9, 12);
            dtg_xesanpham.Name = "dtg_xesanpham";
            dtg_xesanpham.RowHeadersVisible = false;
            dtg_xesanpham.RowHeadersWidth = 51;
            dtg_xesanpham.Size = new Size(1013, 683);
            dtg_xesanpham.TabIndex = 0;
            dtg_xesanpham.CellContentClick += dtg_xesanpham_CellContentClick;
            dtg_xesanpham.CellValueChanged += dtg_xesanpham_CellValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txt_giohang);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 55);
            panel1.TabIndex = 1;
            // 
            // txt_giohang
            // 
            txt_giohang.Cursor = Cursors.IBeam;
            txt_giohang.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_giohang.Location = new Point(897, 11);
            txt_giohang.Multiline = true;
            txt_giohang.Name = "txt_giohang";
            txt_giohang.ReadOnly = true;
            txt_giohang.Size = new Size(125, 34);
            txt_giohang.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 11);
            textBox1.Margin = new Padding(0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(380, 34);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Image = Properties.Resource.search;
            button1.Location = new Point(381, 10);
            button1.Name = "button1";
            button1.Size = new Size(62, 36);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // tb_hoadon
            // 
            tb_hoadon.BackColor = Color.FromArgb(242, 242, 242);
            tb_hoadon.Controls.Add(panel6);
            tb_hoadon.Controls.Add(panel5);
            tb_hoadon.Location = new Point(4, 39);
            tb_hoadon.Name = "tb_hoadon";
            tb_hoadon.Padding = new Padding(3);
            tb_hoadon.Size = new Size(1595, 919);
            tb_hoadon.TabIndex = 1;
            tb_hoadon.Text = "Hóa Đơn";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(txt_timkiem2);
            panel6.Controls.Add(label15);
            panel6.Controls.Add(txt_tongtien2);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(txt_thoigian2);
            panel6.Controls.Add(label12);
            panel6.Controls.Add(dtp_hoadon2);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(dtp_hoadon1);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(btn_timdatagrid2);
            panel6.Controls.Add(btn_dtp2);
            panel6.Controls.Add(btn_hoantra);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(dtg_chitiethoantat);
            panel6.Controls.Add(txt_diachi2);
            panel6.Controls.Add(txt_email2);
            panel6.Controls.Add(txt_sdt2);
            panel6.Controls.Add(txt_ten2);
            panel6.Controls.Add(dtg_hoadondaxong);
            panel6.Location = new Point(911, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(674, 912);
            panel6.TabIndex = 1;
            // 
            // txt_timkiem2
            // 
            txt_timkiem2.Location = new Point(14, 6);
            txt_timkiem2.Name = "txt_timkiem2";
            txt_timkiem2.Size = new Size(181, 27);
            txt_timkiem2.TabIndex = 8;
            txt_timkiem2.TextChanged += txt_timkiem2_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(293, 42);
            label15.Name = "label15";
            label15.Size = new Size(0, 20);
            label15.TabIndex = 7;
            // 
            // txt_tongtien2
            // 
            txt_tongtien2.Location = new Point(486, 831);
            txt_tongtien2.Name = "txt_tongtien2";
            txt_tongtien2.Size = new Size(165, 27);
            txt_tongtien2.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(293, 42);
            label14.Name = "label14";
            label14.Size = new Size(29, 20);
            label14.TabIndex = 7;
            label14.Text = "Từ:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(293, 75);
            label13.Name = "label13";
            label13.Size = new Size(39, 20);
            label13.TabIndex = 7;
            label13.Text = "Đến:";
            // 
            // txt_thoigian2
            // 
            txt_thoigian2.Location = new Point(293, 831);
            txt_thoigian2.Name = "txt_thoigian2";
            txt_thoigian2.Size = new Size(172, 27);
            txt_thoigian2.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(293, 133);
            label12.Name = "label12";
            label12.Size = new Size(35, 20);
            label12.TabIndex = 7;
            label12.Text = "Tên:";
            // 
            // dtp_hoadon2
            // 
            dtp_hoadon2.Location = new Point(364, 70);
            dtp_hoadon2.Name = "dtp_hoadon2";
            dtp_hoadon2.Size = new Size(241, 27);
            dtp_hoadon2.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(293, 192);
            label11.Name = "label11";
            label11.Size = new Size(39, 20);
            label11.TabIndex = 7;
            label11.Text = "SĐT:";
            // 
            // dtp_hoadon1
            // 
            dtp_hoadon1.Checked = false;
            dtp_hoadon1.Location = new Point(364, 37);
            dtp_hoadon1.Name = "dtp_hoadon1";
            dtp_hoadon1.Size = new Size(241, 27);
            dtp_hoadon1.TabIndex = 11;
            dtp_hoadon1.Value = new DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(293, 253);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 7;
            label10.Text = "Email:";
            // 
            // btn_timdatagrid2
            // 
            btn_timdatagrid2.Enabled = false;
            btn_timdatagrid2.Image = Properties.Resource.search;
            btn_timdatagrid2.Location = new Point(188, 5);
            btn_timdatagrid2.Name = "btn_timdatagrid2";
            btn_timdatagrid2.Size = new Size(49, 29);
            btn_timdatagrid2.TabIndex = 5;
            btn_timdatagrid2.UseVisualStyleBackColor = true;
            // 
            // btn_dtp2
            // 
            btn_dtp2.Image = Properties.Resource.search;
            btn_dtp2.Location = new Point(602, 36);
            btn_dtp2.Name = "btn_dtp2";
            btn_dtp2.Size = new Size(49, 29);
            btn_dtp2.TabIndex = 5;
            btn_dtp2.UseVisualStyleBackColor = true;
            btn_dtp2.Click += btn_dtp2_Click;
            // 
            // btn_hoantra
            // 
            btn_hoantra.Location = new Point(293, 869);
            btn_hoantra.Name = "btn_hoantra";
            btn_hoantra.Size = new Size(358, 29);
            btn_hoantra.TabIndex = 3;
            btn_hoantra.Text = "Hoản Trả";
            btn_hoantra.UseVisualStyleBackColor = true;
            btn_hoantra.Click += btn_hoantra_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(293, 316);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 7;
            label9.Text = "Địa Chỉ:";
            // 
            // dtg_chitiethoantat
            // 
            dtg_chitiethoantat.AllowUserToAddRows = false;
            dtg_chitiethoantat.AllowUserToResizeColumns = false;
            dtg_chitiethoantat.AllowUserToResizeRows = false;
            dtg_chitiethoantat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_chitiethoantat.BackgroundColor = Color.FromArgb(244, 243, 243);
            dtg_chitiethoantat.BorderStyle = BorderStyle.None;
            dtg_chitiethoantat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtg_chitiethoantat.DefaultCellStyle = dataGridViewCellStyle3;
            dtg_chitiethoantat.GridColor = SystemColors.ScrollBar;
            dtg_chitiethoantat.Location = new Point(293, 457);
            dtg_chitiethoantat.Name = "dtg_chitiethoantat";
            dtg_chitiethoantat.ReadOnly = true;
            dtg_chitiethoantat.RowHeadersVisible = false;
            dtg_chitiethoantat.RowHeadersWidth = 51;
            dtg_chitiethoantat.Size = new Size(358, 368);
            dtg_chitiethoantat.TabIndex = 9;
            // 
            // txt_diachi2
            // 
            txt_diachi2.Location = new Point(364, 313);
            txt_diachi2.Multiline = true;
            txt_diachi2.Name = "txt_diachi2";
            txt_diachi2.Size = new Size(287, 124);
            txt_diachi2.TabIndex = 5;
            // 
            // txt_email2
            // 
            txt_email2.Location = new Point(364, 250);
            txt_email2.Name = "txt_email2";
            txt_email2.Size = new Size(287, 27);
            txt_email2.TabIndex = 6;
            // 
            // txt_sdt2
            // 
            txt_sdt2.Location = new Point(364, 189);
            txt_sdt2.Name = "txt_sdt2";
            txt_sdt2.Size = new Size(287, 27);
            txt_sdt2.TabIndex = 7;
            // 
            // txt_ten2
            // 
            txt_ten2.Location = new Point(364, 130);
            txt_ten2.Name = "txt_ten2";
            txt_ten2.Size = new Size(287, 27);
            txt_ten2.TabIndex = 8;
            // 
            // dtg_hoadondaxong
            // 
            dtg_hoadondaxong.AllowUserToAddRows = false;
            dtg_hoadondaxong.AllowUserToResizeColumns = false;
            dtg_hoadondaxong.AllowUserToResizeRows = false;
            dtg_hoadondaxong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_hoadondaxong.BackgroundColor = Color.FromArgb(244, 243, 243);
            dtg_hoadondaxong.BorderStyle = BorderStyle.None;
            dtg_hoadondaxong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtg_hoadondaxong.DefaultCellStyle = dataGridViewCellStyle4;
            dtg_hoadondaxong.GridColor = SystemColors.ScrollBar;
            dtg_hoadondaxong.Location = new Point(14, 37);
            dtg_hoadondaxong.Name = "dtg_hoadondaxong";
            dtg_hoadondaxong.ReadOnly = true;
            dtg_hoadondaxong.RowHeadersVisible = false;
            dtg_hoadondaxong.RowHeadersWidth = 51;
            dtg_hoadondaxong.Size = new Size(257, 861);
            dtg_hoadondaxong.TabIndex = 0;
            dtg_hoadondaxong.CellContentClick += dtg_hoadondaxong_CellContentClick;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(txt_timkiem1);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txt_tongtien1);
            panel5.Controls.Add(txt_thoigian1);
            panel5.Controls.Add(dtp_vanchuyen1);
            panel5.Controls.Add(btn_timdatagrid1);
            panel5.Controls.Add(btn_dtp1);
            panel5.Controls.Add(dtp_vanchuyen2);
            panel5.Controls.Add(btn_huyvanchuyen);
            panel5.Controls.Add(btn_xacnhanvanchuyen);
            panel5.Controls.Add(dtg_chittietvanchuyen);
            panel5.Controls.Add(txt_diachi1);
            panel5.Controls.Add(txt_email1);
            panel5.Controls.Add(txt_sdt1);
            panel5.Controls.Add(txt_ten1);
            panel5.Controls.Add(dtg_hoadonvanchuyen);
            panel5.Location = new Point(-4, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(871, 913);
            panel5.TabIndex = 0;
            // 
            // txt_timkiem1
            // 
            txt_timkiem1.Location = new Point(11, 6);
            txt_timkiem1.Name = "txt_timkiem1";
            txt_timkiem1.Size = new Size(181, 27);
            txt_timkiem1.TabIndex = 8;
            txt_timkiem1.TextChanged += txt_timkiem1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(424, 26);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(424, 26);
            label8.Name = "label8";
            label8.Size = new Size(29, 20);
            label8.TabIndex = 7;
            label8.Text = "Từ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(424, 59);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 7;
            label6.Text = "Đến:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(424, 134);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 7;
            label5.Text = "Tên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 193);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 7;
            label4.Text = "SĐT:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 254);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 317);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 7;
            label2.Text = "Địa Chỉ:";
            // 
            // txt_tongtien1
            // 
            txt_tongtien1.Location = new Point(644, 832);
            txt_tongtien1.Name = "txt_tongtien1";
            txt_tongtien1.Size = new Size(209, 27);
            txt_tongtien1.TabIndex = 6;
            // 
            // txt_thoigian1
            // 
            txt_thoigian1.Location = new Point(424, 832);
            txt_thoigian1.Name = "txt_thoigian1";
            txt_thoigian1.Size = new Size(209, 27);
            txt_thoigian1.TabIndex = 6;
            // 
            // dtp_vanchuyen1
            // 
            dtp_vanchuyen1.Checked = false;
            dtp_vanchuyen1.Location = new Point(530, 21);
            dtp_vanchuyen1.Name = "dtp_vanchuyen1";
            dtp_vanchuyen1.Size = new Size(250, 27);
            dtp_vanchuyen1.TabIndex = 4;
            dtp_vanchuyen1.Value = new DateTime(2019, 12, 1, 0, 0, 0, 0);
            // 
            // btn_timdatagrid1
            // 
            btn_timdatagrid1.Enabled = false;
            btn_timdatagrid1.Image = Properties.Resource.search;
            btn_timdatagrid1.Location = new Point(185, 5);
            btn_timdatagrid1.Name = "btn_timdatagrid1";
            btn_timdatagrid1.Size = new Size(49, 29);
            btn_timdatagrid1.TabIndex = 5;
            btn_timdatagrid1.UseVisualStyleBackColor = true;
            // 
            // btn_dtp1
            // 
            btn_dtp1.Image = Properties.Resource.search;
            btn_dtp1.Location = new Point(776, 20);
            btn_dtp1.Name = "btn_dtp1";
            btn_dtp1.Size = new Size(77, 29);
            btn_dtp1.TabIndex = 5;
            btn_dtp1.UseVisualStyleBackColor = true;
            btn_dtp1.Click += btn_dtp1_Click;
            // 
            // dtp_vanchuyen2
            // 
            dtp_vanchuyen2.Checked = false;
            dtp_vanchuyen2.Location = new Point(530, 54);
            dtp_vanchuyen2.Name = "dtp_vanchuyen2";
            dtp_vanchuyen2.Size = new Size(250, 27);
            dtp_vanchuyen2.TabIndex = 4;
            // 
            // btn_huyvanchuyen
            // 
            btn_huyvanchuyen.Location = new Point(644, 870);
            btn_huyvanchuyen.Name = "btn_huyvanchuyen";
            btn_huyvanchuyen.Size = new Size(209, 29);
            btn_huyvanchuyen.TabIndex = 3;
            btn_huyvanchuyen.Text = "Hủy";
            btn_huyvanchuyen.UseVisualStyleBackColor = true;
            btn_huyvanchuyen.Click += btn_huyvanchuyen_Click;
            // 
            // btn_xacnhanvanchuyen
            // 
            btn_xacnhanvanchuyen.Location = new Point(424, 870);
            btn_xacnhanvanchuyen.Name = "btn_xacnhanvanchuyen";
            btn_xacnhanvanchuyen.Size = new Size(209, 29);
            btn_xacnhanvanchuyen.TabIndex = 3;
            btn_xacnhanvanchuyen.Text = "Xác Nhận";
            btn_xacnhanvanchuyen.UseVisualStyleBackColor = true;
            btn_xacnhanvanchuyen.Click += btn_xacnhanvanchuyen_Click;
            // 
            // dtg_chittietvanchuyen
            // 
            dtg_chittietvanchuyen.AllowUserToAddRows = false;
            dtg_chittietvanchuyen.AllowUserToResizeColumns = false;
            dtg_chittietvanchuyen.AllowUserToResizeRows = false;
            dtg_chittietvanchuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_chittietvanchuyen.BackgroundColor = Color.FromArgb(244, 243, 243);
            dtg_chittietvanchuyen.BorderStyle = BorderStyle.None;
            dtg_chittietvanchuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtg_chittietvanchuyen.DefaultCellStyle = dataGridViewCellStyle5;
            dtg_chittietvanchuyen.GridColor = SystemColors.ScrollBar;
            dtg_chittietvanchuyen.Location = new Point(424, 458);
            dtg_chittietvanchuyen.Name = "dtg_chittietvanchuyen";
            dtg_chittietvanchuyen.ReadOnly = true;
            dtg_chittietvanchuyen.RowHeadersVisible = false;
            dtg_chittietvanchuyen.RowHeadersWidth = 51;
            dtg_chittietvanchuyen.Size = new Size(429, 368);
            dtg_chittietvanchuyen.TabIndex = 2;
            // 
            // txt_diachi1
            // 
            txt_diachi1.Location = new Point(530, 314);
            txt_diachi1.Multiline = true;
            txt_diachi1.Name = "txt_diachi1";
            txt_diachi1.Size = new Size(323, 124);
            txt_diachi1.TabIndex = 1;
            // 
            // txt_email1
            // 
            txt_email1.Location = new Point(530, 251);
            txt_email1.Name = "txt_email1";
            txt_email1.Size = new Size(323, 27);
            txt_email1.TabIndex = 1;
            // 
            // txt_sdt1
            // 
            txt_sdt1.Location = new Point(530, 190);
            txt_sdt1.Name = "txt_sdt1";
            txt_sdt1.Size = new Size(323, 27);
            txt_sdt1.TabIndex = 1;
            // 
            // txt_ten1
            // 
            txt_ten1.Location = new Point(530, 131);
            txt_ten1.Name = "txt_ten1";
            txt_ten1.Size = new Size(323, 27);
            txt_ten1.TabIndex = 1;
            // 
            // dtg_hoadonvanchuyen
            // 
            dtg_hoadonvanchuyen.AllowUserToAddRows = false;
            dtg_hoadonvanchuyen.AllowUserToResizeColumns = false;
            dtg_hoadonvanchuyen.AllowUserToResizeRows = false;
            dtg_hoadonvanchuyen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_hoadonvanchuyen.BackgroundColor = Color.FromArgb(244, 243, 243);
            dtg_hoadonvanchuyen.BorderStyle = BorderStyle.None;
            dtg_hoadonvanchuyen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dtg_hoadonvanchuyen.DefaultCellStyle = dataGridViewCellStyle6;
            dtg_hoadonvanchuyen.GridColor = SystemColors.ScrollBar;
            dtg_hoadonvanchuyen.Location = new Point(11, 37);
            dtg_hoadonvanchuyen.Name = "dtg_hoadonvanchuyen";
            dtg_hoadonvanchuyen.ReadOnly = true;
            dtg_hoadonvanchuyen.RowHeadersVisible = false;
            dtg_hoadonvanchuyen.RowHeadersWidth = 51;
            dtg_hoadonvanchuyen.Size = new Size(388, 862);
            dtg_hoadonvanchuyen.TabIndex = 0;
            dtg_hoadonvanchuyen.CellContentClick += dtg_hoadonvanchuyen_CellContentClick;
            // 
            // GiaoDich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1575, 950);
            Controls.Add(tabs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GiaoDich";
            Text = "GiaoDich";
            tabs.ResumeLayout(false);
            tb_thanhtoan.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_sanpham).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_xesanpham).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tb_hoadon.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_chitiethoantat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_hoadondaxong).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_chittietvanchuyen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_hoadonvanchuyen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tb_thanhtoan;
        private TabPage tb_hoadon;
        private TabControl tabs;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private Panel panel3;
        private Button btn_treodon;
        private Button btn_huydon;
        private Button btn_thanhtoan;
        private DataGridView dtg_xesanpham;
        private Panel panel4;
        private DataGridView dtg_sanpham;
        private Button btn_vanchuyen;
        private TextBox txt_tongtien;
        private Label label1;
        private TextBox txt_giohang;
        private FlowLayoutPanel flo_giohangcho;
        private Panel panel5;
        private TextBox txt_ten1;
        private DataGridView dtg_hoadonvanchuyen;
        private Button btn_xacnhanvanchuyen;
        private DataGridView dtg_chittietvanchuyen;
        private TextBox txt_diachi1;
        private TextBox txt_email1;
        private TextBox txt_sdt1;
        private Panel panel6;
        private DataGridView dtg_hoadondaxong;
        private Button btn_huyvanchuyen;
        private DateTimePicker dtp_hoadon2;
        private DateTimePicker dtp_hoadon1;
        private Button btn_hoantra;
        private DataGridView dtg_chitiethoantat;
        private TextBox txt_diachi2;
        private TextBox txt_email2;
        private TextBox txt_sdt2;
        private TextBox txt_ten2;
        private DateTimePicker dtp_vanchuyen2;
        private DateTimePicker dtp_vanchuyen1;
        private TextBox txt_thoigian2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_tongtien1;
        private TextBox txt_thoigian1;
        private Button btn_dtp1;
        private TextBox txt_tongtien2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btn_dtp2;
        private Label label9;
        private Label label8;
        private TextBox txt_timkiem1;
        private Button btn_timdatagrid1;
        private TextBox txt_timkiem2;
        private Button btn_timdatagrid2;
    }
}