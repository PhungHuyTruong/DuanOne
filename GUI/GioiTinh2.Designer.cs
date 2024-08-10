namespace GUI
{
    partial class GioiTinh2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GioiTinh2));
            btn_sua11 = new Button();
            btn_add11 = new Button();
            label1 = new Label();
            dtg_gioitinh1 = new DataGridView();
            txt_gioitinh = new TextBox();
            txt_timkiemgioitinh = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtg_gioitinh1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_sua11
            // 
            btn_sua11.BackColor = SystemColors.ButtonFace;
            btn_sua11.Location = new Point(575, 57);
            btn_sua11.Name = "btn_sua11";
            btn_sua11.Size = new Size(194, 76);
            btn_sua11.TabIndex = 15;
            btn_sua11.Text = "Sua";
            btn_sua11.UseVisualStyleBackColor = false;
            btn_sua11.Click += btn_sua11_Click;
            // 
            // btn_add11
            // 
            btn_add11.BackColor = SystemColors.ButtonFace;
            btn_add11.Location = new Point(104, 57);
            btn_add11.Name = "btn_add11";
            btn_add11.Size = new Size(194, 76);
            btn_add11.TabIndex = 14;
            btn_add11.Text = "Add";
            btn_add11.UseVisualStyleBackColor = false;
            btn_add11.Click += btn_add11_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 314);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 10;
            label1.Text = "Gioi tinh";
            // 
            // dtg_gioitinh1
            // 
            dtg_gioitinh1.BackgroundColor = SystemColors.ButtonFace;
            dtg_gioitinh1.BorderStyle = BorderStyle.None;
            dtg_gioitinh1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_gioitinh1.Location = new Point(22, 21);
            dtg_gioitinh1.Name = "dtg_gioitinh1";
            dtg_gioitinh1.RowHeadersWidth = 62;
            dtg_gioitinh1.Size = new Size(581, 923);
            dtg_gioitinh1.TabIndex = 8;
            dtg_gioitinh1.CellClick += dtg_gioitinh1_CellClick;
            // 
            // txt_gioitinh
            // 
            txt_gioitinh.Location = new Point(211, 311);
            txt_gioitinh.Name = "txt_gioitinh";
            txt_gioitinh.Size = new Size(588, 31);
            txt_gioitinh.TabIndex = 16;
            // 
            // txt_timkiemgioitinh
            // 
            txt_timkiemgioitinh.BorderStyle = BorderStyle.FixedSingle;
            txt_timkiemgioitinh.Location = new Point(482, 43);
            txt_timkiemgioitinh.Name = "txt_timkiemgioitinh";
            txt_timkiemgioitinh.Size = new Size(336, 31);
            txt_timkiemgioitinh.TabIndex = 17;
            txt_timkiemgioitinh.TextChanged += txt_timkiemgioitinh_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txt_gioitinh);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_timkiemgioitinh);
            panel1.Location = new Point(27, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 730);
            panel1.TabIndex = 18;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(815, 43);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(52, 31);
            button2.TabIndex = 81;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_add11);
            panel2.Controls.Add(btn_sua11);
            panel2.Location = new Point(31, 791);
            panel2.Name = "panel2";
            panel2.Size = new Size(916, 204);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dtg_gioitinh1);
            panel3.Location = new Point(992, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(625, 969);
            panel3.TabIndex = 20;
            // 
            // GioiTinh1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1657, 1019);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GioiTinh1";
            Text = "GioiTinh";
            ((System.ComponentModel.ISupportInitialize)dtg_gioitinh1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_sua11;
        private Button btn_add11;
        private Label label1;
        private DataGridView dtg_gioitinh1;
        private TextBox txt_gioitinh;
        private TextBox txt_timkiemgioitinh;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
    }
}