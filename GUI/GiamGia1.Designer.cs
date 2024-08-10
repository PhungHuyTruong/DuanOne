namespace GUI
{
    partial class GiamGia1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiamGia1));
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            txt_timkiemgiamgia = new TextBox();
            txt_loaigiamgia1 = new TextBox();
            txt_mucgiam1 = new TextBox();
            txt_ngaybatdau1 = new TextBox();
            txt_ngayketthuc2 = new TextBox();
            cmbx_trangthai2 = new ComboBox();
            panel2 = new Panel();
            label3 = new Label();
            label1 = new Label();
            dtg_giamgia1 = new DataGridView();
            panel3 = new Panel();
            btn_sua14 = new Button();
            btn_add14 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_giamgia1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txt_timkiemgiamgia);
            panel1.Controls.Add(txt_loaigiamgia1);
            panel1.Controls.Add(txt_mucgiam1);
            panel1.Controls.Add(txt_ngaybatdau1);
            panel1.Controls.Add(txt_ngayketthuc2);
            panel1.Controls.Add(cmbx_trangthai2);
            panel1.Location = new Point(25, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 735);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(504, 333);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 83;
            label8.Text = "Trạng thái";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(104, 494);
            label7.Name = "label7";
            label7.Size = new Size(122, 25);
            label7.TabIndex = 82;
            label7.Text = "Ngày kết thúc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 410);
            label6.Name = "label6";
            label6.Size = new Size(120, 25);
            label6.TabIndex = 81;
            label6.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 333);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 80;
            label5.Text = "Mức giảm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 247);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 79;
            label4.Text = "Loại giảm giá";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(824, 45);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(52, 31);
            button2.TabIndex = 78;
            button2.UseVisualStyleBackColor = true;
            // 
            // txt_timkiemgiamgia
            // 
            txt_timkiemgiamgia.BorderStyle = BorderStyle.FixedSingle;
            txt_timkiemgiamgia.Location = new Point(487, 45);
            txt_timkiemgiamgia.Name = "txt_timkiemgiamgia";
            txt_timkiemgiamgia.Size = new Size(341, 31);
            txt_timkiemgiamgia.TabIndex = 75;
            txt_timkiemgiamgia.TextChanged += txt_timkiemgiamgia_TextChanged_1;
            // 
            // txt_loaigiamgia1
            // 
            txt_loaigiamgia1.BackColor = SystemColors.HighlightText;
            txt_loaigiamgia1.Location = new Point(228, 244);
            txt_loaigiamgia1.Name = "txt_loaigiamgia1";
            txt_loaigiamgia1.Size = new Size(573, 31);
            txt_loaigiamgia1.TabIndex = 62;
            // 
            // txt_mucgiam1
            // 
            txt_mucgiam1.Location = new Point(228, 330);
            txt_mucgiam1.Name = "txt_mucgiam1";
            txt_mucgiam1.Size = new Size(204, 31);
            txt_mucgiam1.TabIndex = 63;
            // 
            // txt_ngaybatdau1
            // 
            txt_ngaybatdau1.Location = new Point(228, 410);
            txt_ngaybatdau1.Name = "txt_ngaybatdau1";
            txt_ngaybatdau1.Size = new Size(573, 31);
            txt_ngaybatdau1.TabIndex = 64;
            // 
            // txt_ngayketthuc2
            // 
            txt_ngayketthuc2.Location = new Point(228, 494);
            txt_ngayketthuc2.Name = "txt_ngayketthuc2";
            txt_ngayketthuc2.Size = new Size(573, 31);
            txt_ngayketthuc2.TabIndex = 65;
            // 
            // cmbx_trangthai2
            // 
            cmbx_trangthai2.FormattingEnabled = true;
            cmbx_trangthai2.Location = new Point(619, 330);
            cmbx_trangthai2.Name = "cmbx_trangthai2";
            cmbx_trangthai2.Size = new Size(182, 33);
            cmbx_trangthai2.TabIndex = 66;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtg_giamgia1);
            panel2.Location = new Point(985, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(637, 966);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-181, 336);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 69;
            label3.Text = "Ngay bat dau";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-181, 225);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 67;
            label1.Text = "Loai giam gia";
            // 
            // dtg_giamgia1
            // 
            dtg_giamgia1.BackgroundColor = SystemColors.ButtonFace;
            dtg_giamgia1.BorderStyle = BorderStyle.None;
            dtg_giamgia1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_giamgia1.Location = new Point(17, 22);
            dtg_giamgia1.Name = "dtg_giamgia1";
            dtg_giamgia1.RowHeadersWidth = 62;
            dtg_giamgia1.Size = new Size(600, 925);
            dtg_giamgia1.TabIndex = 59;
            dtg_giamgia1.CellClick += dtg_giamgia1_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btn_sua14);
            panel3.Controls.Add(btn_add14);
            panel3.Location = new Point(27, 789);
            panel3.Name = "panel3";
            panel3.Size = new Size(923, 201);
            panel3.TabIndex = 2;
            // 
            // btn_sua14
            // 
            btn_sua14.BackColor = SystemColors.Control;
            btn_sua14.Font = new Font("Segoe UI", 11F);
            btn_sua14.Location = new Point(606, 68);
            btn_sua14.Name = "btn_sua14";
            btn_sua14.Size = new Size(194, 73);
            btn_sua14.TabIndex = 63;
            btn_sua14.Text = "Sua";
            btn_sua14.UseVisualStyleBackColor = false;
            btn_sua14.Click += btn_sua14_Click;
            // 
            // btn_add14
            // 
            btn_add14.BackColor = SystemColors.Control;
            btn_add14.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add14.Location = new Point(103, 68);
            btn_add14.Name = "btn_add14";
            btn_add14.Size = new Size(194, 73);
            btn_add14.TabIndex = 62;
            btn_add14.Text = "Add";
            btn_add14.UseVisualStyleBackColor = false;
            btn_add14.Click += btn_add14_Click_1;
            // 
            // GiamGia1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1650, 1016);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GiamGia1";
            Text = "GiamGia";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_giamgia1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_timkiemgiamgia;
        private TextBox txt_loaigiamgia1;
        private TextBox txt_mucgiam1;
        private TextBox txt_ngaybatdau1;
        private TextBox txt_ngayketthuc2;
        private ComboBox cmbx_trangthai2;
        private Panel panel2;
        private Label label3;
        private Label label1;
        private DataGridView dtg_giamgia1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button2;
        private Panel panel3;
        private Button btn_sua14;
        private Button btn_add14;
    }
}