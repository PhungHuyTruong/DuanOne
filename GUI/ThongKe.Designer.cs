namespace GUI
{
    partial class ThongKe
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
            tp_thongke = new TabControl();
            tp_doanhthu = new TabPage();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            tp_soluong = new TabPage();
            panel5 = new Panel();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            txt_role = new TextBox();
            txt_phone = new TextBox();
            txt_email = new TextBox();
            txt_gioitinh = new TextBox();
            txt_ngaysinh = new TextBox();
            txt_name = new TextBox();
            label9 = new Label();
            panel3 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label13 = new Label();
            txt_diachi2 = new TextBox();
            txt_email2 = new TextBox();
            txt_sdt2 = new TextBox();
            txt_ten2 = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            dataGridView4 = new DataGridView();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            comboBox2 = new ComboBox();
            panel4 = new Panel();
            dataGridView3 = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            tp_thongke.SuspendLayout();
            tp_doanhthu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tp_soluong.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tp_thongke
            // 
            tp_thongke.Controls.Add(tp_doanhthu);
            tp_thongke.Controls.Add(tp_soluong);
            tp_thongke.Location = new Point(3, 1);
            tp_thongke.Name = "tp_thongke";
            tp_thongke.SelectedIndex = 0;
            tp_thongke.Size = new Size(1965, 1184);
            tp_thongke.TabIndex = 0;
            // 
            // tp_doanhthu
            // 
            tp_doanhthu.BackColor = Color.Gainsboro;
            tp_doanhthu.BorderStyle = BorderStyle.FixedSingle;
            tp_doanhthu.Controls.Add(panel2);
            tp_doanhthu.Location = new Point(4, 34);
            tp_doanhthu.Name = "tp_doanhthu";
            tp_doanhthu.Padding = new Padding(3);
            tp_doanhthu.Size = new Size(1957, 1146);
            tp_doanhthu.TabIndex = 0;
            tp_doanhthu.Text = "Thống kê";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(comboBox1);
            panel2.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(17, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1920, 1111);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(831, 85);
            label7.Name = "label7";
            label7.Size = new Size(394, 43);
            label7.TabIndex = 18;
            label7.Text = "Số lượng sản phẩm đã bán";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(185, 85);
            label6.Name = "label6";
            label6.Size = new Size(340, 43);
            label6.TabIndex = 17;
            label6.Text = "Hóa đơn đã thanh toán";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1417, 246);
            label2.Name = "label2";
            label2.Size = new Size(159, 43);
            label2.TabIndex = 10;
            label2.Text = "Tính theo:";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(715, 145);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(620, 781);
            dataGridView2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(620, 781);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1566, 611);
            label3.Name = "label3";
            label3.Size = new Size(150, 43);
            label3.TabIndex = 9;
            label3.Text = "Tổng tiền";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1419, 166);
            label1.Name = "label1";
            label1.Size = new Size(157, 43);
            label1.TabIndex = 7;
            label1.Text = "Thời gian:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1424, 705);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(421, 51);
            textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(1603, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 51);
            dateTimePicker1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1603, 238);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 51);
            comboBox1.TabIndex = 5;
            // 
            // tp_soluong
            // 
            tp_soluong.BackColor = Color.Gainsboro;
            tp_soluong.Controls.Add(panel5);
            tp_soluong.Controls.Add(panel3);
            tp_soluong.Controls.Add(panel1);
            tp_soluong.Controls.Add(panel4);
            tp_soluong.ForeColor = Color.Black;
            tp_soluong.Location = new Point(4, 34);
            tp_soluong.Name = "tp_soluong";
            tp_soluong.Padding = new Padding(3);
            tp_soluong.Size = new Size(1957, 1146);
            tp_soluong.TabIndex = 1;
            tp_soluong.Text = "Hóa đơn";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(txt_role);
            panel5.Controls.Add(txt_phone);
            panel5.Controls.Add(txt_email);
            panel5.Controls.Add(txt_gioitinh);
            panel5.Controls.Add(txt_ngaysinh);
            panel5.Controls.Add(txt_name);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(1309, 352);
            panel5.Name = "panel5";
            panel5.Size = new Size(626, 573);
            panel5.TabIndex = 5;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(38, 482);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(50, 25);
            label19.TabIndex = 27;
            label19.Text = "Role:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(38, 405);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(66, 25);
            label18.TabIndex = 26;
            label18.Text = "Phone:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(38, 330);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(58, 25);
            label17.TabIndex = 25;
            label17.Text = "Email:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(38, 252);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(82, 25);
            label16.TabIndex = 24;
            label16.Text = "Giới tính:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(38, 179);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(95, 25);
            label15.TabIndex = 23;
            label15.Text = "Ngày sinh:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(38, 114);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(42, 25);
            label14.TabIndex = 17;
            label14.Text = "Tên:";
            // 
            // txt_role
            // 
            txt_role.Location = new Point(158, 476);
            txt_role.Margin = new Padding(4);
            txt_role.Name = "txt_role";
            txt_role.Size = new Size(358, 31);
            txt_role.TabIndex = 22;
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(158, 405);
            txt_phone.Margin = new Padding(4);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(358, 31);
            txt_phone.TabIndex = 21;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(158, 330);
            txt_email.Margin = new Padding(4);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(358, 31);
            txt_email.TabIndex = 20;
            // 
            // txt_gioitinh
            // 
            txt_gioitinh.Location = new Point(158, 252);
            txt_gioitinh.Margin = new Padding(4);
            txt_gioitinh.Name = "txt_gioitinh";
            txt_gioitinh.Size = new Size(358, 31);
            txt_gioitinh.TabIndex = 19;
            // 
            // txt_ngaysinh
            // 
            txt_ngaysinh.Location = new Point(158, 176);
            txt_ngaysinh.Margin = new Padding(4);
            txt_ngaysinh.Name = "txt_ngaysinh";
            txt_ngaysinh.Size = new Size(358, 31);
            txt_ngaysinh.TabIndex = 18;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(158, 108);
            txt_name.Margin = new Padding(4);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(358, 31);
            txt_name.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(232, 40);
            label9.Name = "label9";
            label9.Size = new Size(171, 25);
            label9.TabIndex = 1;
            label9.Text = "Thông tin người tạo";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txt_diachi2);
            panel3.Controls.Add(txt_email2);
            panel3.Controls.Add(txt_sdt2);
            panel3.Controls.Add(txt_ten2);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(651, 352);
            panel3.Name = "panel3";
            panel3.Size = new Size(627, 573);
            panel3.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(62, 110);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(42, 25);
            label12.TabIndex = 11;
            label12.Text = "Tên:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(62, 184);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(48, 25);
            label11.TabIndex = 12;
            label11.Text = "SĐT:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(62, 260);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(58, 25);
            label10.TabIndex = 13;
            label10.Text = "Email:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(62, 339);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(72, 25);
            label13.TabIndex = 14;
            label13.Text = "Địa Chỉ:";
            // 
            // txt_diachi2
            // 
            txt_diachi2.Location = new Point(173, 333);
            txt_diachi2.Margin = new Padding(4);
            txt_diachi2.Multiline = true;
            txt_diachi2.Name = "txt_diachi2";
            txt_diachi2.Size = new Size(358, 154);
            txt_diachi2.TabIndex = 9;
            // 
            // txt_email2
            // 
            txt_email2.Location = new Point(173, 254);
            txt_email2.Margin = new Padding(4);
            txt_email2.Name = "txt_email2";
            txt_email2.Size = new Size(358, 31);
            txt_email2.TabIndex = 10;
            // 
            // txt_sdt2
            // 
            txt_sdt2.Location = new Point(173, 178);
            txt_sdt2.Margin = new Padding(4);
            txt_sdt2.Name = "txt_sdt2";
            txt_sdt2.Size = new Size(358, 31);
            txt_sdt2.TabIndex = 15;
            // 
            // txt_ten2
            // 
            txt_ten2.Location = new Point(173, 104);
            txt_ten2.Margin = new Padding(4);
            txt_ten2.Name = "txt_ten2";
            txt_ten2.Size = new Size(358, 31);
            txt_ten2.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(227, 40);
            label8.Name = "label8";
            label8.Size = new Size(184, 25);
            label8.TabIndex = 0;
            label8.Text = "Thông tin khách hàng";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox2);
            panel1.Location = new Point(17, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 912);
            panel1.TabIndex = 3;
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.ControlLight;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(18, 21);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.Size = new Size(566, 436);
            dataGridView4.TabIndex = 17;
            dataGridView4.CellClick += dataGridView4_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(115, 752);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 9;
            label5.Text = "Tính theo:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(215, 640);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(242, 31);
            dateTimePicker2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 640);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 13;
            label4.Text = "Ngày:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(215, 744);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(242, 33);
            comboBox2.TabIndex = 14;
            comboBox2.TextChanged += comboBox2_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(dataGridView3);
            panel4.Location = new Point(651, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(1284, 327);
            panel4.TabIndex = 2;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.ControlLight;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(23, 20);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(1236, 281);
            dataGridView3.TabIndex = 2;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(2092, 1452);
            Controls.Add(tp_thongke);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThongKe";
            Load += ThongKe_Load;
            tp_thongke.ResumeLayout(false);
            tp_doanhthu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tp_soluong.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tp_thongke;
        private TabPage tp_doanhthu;
        private TabPage tp_soluong;
        private Panel panel2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView4;
        private Label label7;
        private Label label6;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
        private Panel panel5;
        private Label label9;
        private Panel panel3;
        private Label label8;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label13;
        private TextBox txt_diachi2;
        private TextBox txt_email2;
        private TextBox txt_sdt2;
        private TextBox txt_ten2;
        private TextBox txt_role;
        private TextBox txt_phone;
        private TextBox txt_email;
        private TextBox txt_gioitinh;
        private TextBox txt_ngaysinh;
        private TextBox txt_name;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
    }
}