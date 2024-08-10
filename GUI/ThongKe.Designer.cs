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
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            tp_soluong = new TabPage();
            panel3 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            label6 = new Label();
            label7 = new Label();
            tp_thongke.SuspendLayout();
            tp_doanhthu.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tp_soluong.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // tp_thongke
            // 
            tp_thongke.Controls.Add(tp_doanhthu);
            tp_thongke.Controls.Add(tp_soluong);
            tp_thongke.Location = new Point(-4, 1);
            tp_thongke.Name = "tp_thongke";
            tp_thongke.SelectedIndex = 0;
            tp_thongke.Size = new Size(1708, 936);
            tp_thongke.TabIndex = 0;
            // 
            // tp_doanhthu
            // 
            tp_doanhthu.BackColor = Color.Gainsboro;
            tp_doanhthu.BorderStyle = BorderStyle.FixedSingle;
            tp_doanhthu.Controls.Add(panel5);
            tp_doanhthu.Controls.Add(panel2);
            tp_doanhthu.Controls.Add(panel1);
            tp_doanhthu.Location = new Point(4, 34);
            tp_doanhthu.Name = "tp_doanhthu";
            tp_doanhthu.Padding = new Padding(3);
            tp_doanhthu.Size = new Size(1700, 898);
            tp_doanhthu.TabIndex = 0;
            tp_doanhthu.Text = "Doanh thu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(comboBox1);
            panel2.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(1178, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(508, 872);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 115);
            label2.Name = "label2";
            label2.Size = new Size(159, 43);
            label2.TabIndex = 10;
            label2.Text = "Tính theo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 643);
            label3.Name = "label3";
            label3.Size = new Size(150, 43);
            label3.TabIndex = 9;
            label3.Text = "Tổng tiền";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 35);
            label1.Name = "label1";
            label1.Size = new Size(157, 43);
            label1.TabIndex = 7;
            label1.Text = "Thời gian:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 737);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(421, 51);
            textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(244, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 51);
            dateTimePicker1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(244, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 51);
            comboBox1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(13, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 873);
            panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ControlLight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(22, 70);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(518, 781);
            dataGridView2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(518, 781);
            dataGridView1.TabIndex = 7;
            // 
            // tp_soluong
            // 
            tp_soluong.BackColor = Color.Gainsboro;
            tp_soluong.Controls.Add(panel3);
            tp_soluong.Controls.Add(panel4);
            tp_soluong.ForeColor = Color.Black;
            tp_soluong.Location = new Point(4, 34);
            tp_soluong.Name = "tp_soluong";
            tp_soluong.Padding = new Padding(3);
            tp_soluong.Size = new Size(1700, 898);
            tp_soluong.TabIndex = 1;
            tp_soluong.Text = "So luong";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Font = new Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(1177, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(510, 872);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 30);
            label4.Name = "label4";
            label4.Size = new Size(99, 43);
            label4.TabIndex = 13;
            label4.Text = "Ngày:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 685);
            label5.Name = "label5";
            label5.Size = new Size(249, 43);
            label5.TabIndex = 9;
            label5.Text = "Số lượng đã bán";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(14, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(1145, 873);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(dataGridView2);
            panel5.Location = new Point(599, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(561, 873);
            panel5.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto Condensed", 18F);
            label6.Location = new Point(85, 15);
            label6.Name = "label6";
            label6.Size = new Size(380, 43);
            label6.TabIndex = 11;
            label6.Text = "Số hóa đơn đã thanh toán";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto Condensed", 18F);
            label7.Location = new Point(31, 14);
            label7.Name = "label7";
            label7.Size = new Size(499, 43);
            label7.TabIndex = 18;
            label7.Text = "Chi tiết số lượng sản phẩm đã bán";
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1698, 931);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tp_soluong.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tp_thongke;
        private TabPage tp_doanhthu;
        private TabPage tp_soluong;
        private Panel panel2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Panel panel3;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private DataGridView dataGridView2;
        private Panel panel5;
        private Label label7;
        private Label label6;
    }
}