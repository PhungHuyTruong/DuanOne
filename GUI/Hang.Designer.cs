namespace GUI
{
    partial class Hang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hang));
            dtg_hang1 = new DataGridView();
            txt_tenhang1 = new TextBox();
            label1 = new Label();
            txt_diachi1 = new TextBox();
            label2 = new Label();
            btn_add10 = new Button();
            btn_sua10 = new Button();
            txt_timkiemhang = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtg_hang1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dtg_hang1
            // 
            dtg_hang1.BackgroundColor = SystemColors.ButtonFace;
            dtg_hang1.BorderStyle = BorderStyle.None;
            dtg_hang1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hang1.Location = new Point(22, 19);
            dtg_hang1.Name = "dtg_hang1";
            dtg_hang1.RowHeadersWidth = 62;
            dtg_hang1.Size = new Size(580, 934);
            dtg_hang1.TabIndex = 0;
            dtg_hang1.CellClick += dtg_hang1_CellClick;
            // 
            // txt_tenhang1
            // 
            txt_tenhang1.Location = new Point(197, 236);
            txt_tenhang1.Name = "txt_tenhang1";
            txt_tenhang1.Size = new Size(623, 31);
            txt_tenhang1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 144);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 2;
            label1.Text = "Ten hang";
            // 
            // txt_diachi1
            // 
            txt_diachi1.Location = new Point(197, 371);
            txt_diachi1.Name = "txt_diachi1";
            txt_diachi1.Size = new Size(623, 31);
            txt_diachi1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 245);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 4;
            label2.Text = "Dia chi";
            // 
            // btn_add10
            // 
            btn_add10.BackColor = SystemColors.ButtonFace;
            btn_add10.Location = new Point(123, 60);
            btn_add10.Name = "btn_add10";
            btn_add10.Size = new Size(194, 69);
            btn_add10.TabIndex = 6;
            btn_add10.Text = "Add";
            btn_add10.UseVisualStyleBackColor = false;
            btn_add10.Click += btn_add10_Click;
            // 
            // btn_sua10
            // 
            btn_sua10.BackColor = SystemColors.ButtonFace;
            btn_sua10.Location = new Point(603, 60);
            btn_sua10.Name = "btn_sua10";
            btn_sua10.Size = new Size(194, 69);
            btn_sua10.TabIndex = 7;
            btn_sua10.Text = "Sua";
            btn_sua10.UseVisualStyleBackColor = false;
            btn_sua10.Click += btn_sua10_Click;
            // 
            // txt_timkiemhang
            // 
            txt_timkiemhang.BorderStyle = BorderStyle.FixedSingle;
            txt_timkiemhang.Location = new Point(493, 41);
            txt_timkiemhang.Name = "txt_timkiemhang";
            txt_timkiemhang.Size = new Size(327, 31);
            txt_timkiemhang.TabIndex = 8;
            txt_timkiemhang.TextChanged += txt_timkiemhang_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txt_diachi1);
            panel1.Controls.Add(txt_timkiemhang);
            panel1.Controls.Add(txt_tenhang1);
            panel1.Location = new Point(28, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(921, 737);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 371);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 84;
            label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 239);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 83;
            label5.Text = "Tên hãng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 236);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 82;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(818, 41);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(52, 31);
            button2.TabIndex = 80;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_add10);
            panel2.Controls.Add(btn_sua10);
            panel2.Location = new Point(28, 792);
            panel2.Name = "panel2";
            panel2.Size = new Size(921, 202);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dtg_hang1);
            panel3.Location = new Point(990, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(623, 970);
            panel3.TabIndex = 11;
            // 
            // Hang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1648, 1020);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Hang";
            Text = "Hang";
            ((System.ComponentModel.ISupportInitialize)dtg_hang1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_hang1;
        private TextBox txt_tenhang1;
        private Label label1;
        private TextBox txt_diachi1;
        private Label label2;
        private Button btn_add10;
        private Button btn_sua10;
        private TextBox txt_timkiemhang;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}