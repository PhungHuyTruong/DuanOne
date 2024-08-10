namespace GUI
{
    partial class MauSac2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MauSac2));
            panel1 = new Panel();
            label3 = new Label();
            button2 = new Button();
            txt_timkiemmausac = new TextBox();
            txt_mausac1 = new TextBox();
            panel2 = new Panel();
            btn_add13 = new Button();
            btn_sua13 = new Button();
            panel3 = new Panel();
            dtg_mausac1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_mausac1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txt_timkiemmausac);
            panel1.Controls.Add(txt_mausac1);
            panel1.Location = new Point(25, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 737);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 284);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 81;
            label3.Text = "Màu sắc";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(823, 44);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(52, 31);
            button2.TabIndex = 79;
            button2.UseVisualStyleBackColor = true;
            // 
            // txt_timkiemmausac
            // 
            txt_timkiemmausac.BorderStyle = BorderStyle.FixedSingle;
            txt_timkiemmausac.Location = new Point(488, 44);
            txt_timkiemmausac.Name = "txt_timkiemmausac";
            txt_timkiemmausac.Size = new Size(337, 31);
            txt_timkiemmausac.TabIndex = 35;
            txt_timkiemmausac.TextChanged += txt_timkiemmausac_TextChanged_1;
            // 
            // txt_mausac1
            // 
            txt_mausac1.Location = new Point(225, 281);
            txt_mausac1.Name = "txt_mausac1";
            txt_mausac1.Size = new Size(564, 31);
            txt_mausac1.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_add13);
            panel2.Controls.Add(btn_sua13);
            panel2.Location = new Point(25, 791);
            panel2.Name = "panel2";
            panel2.Size = new Size(925, 199);
            panel2.TabIndex = 1;
            // 
            // btn_add13
            // 
            btn_add13.BackColor = SystemColors.Control;
            btn_add13.Location = new Point(135, 69);
            btn_add13.Name = "btn_add13";
            btn_add13.Size = new Size(194, 60);
            btn_add13.TabIndex = 32;
            btn_add13.Text = "Add";
            btn_add13.UseVisualStyleBackColor = false;
            btn_add13.Click += btn_add13_Click_1;
            // 
            // btn_sua13
            // 
            btn_sua13.BackColor = SystemColors.Control;
            btn_sua13.Location = new Point(595, 69);
            btn_sua13.Name = "btn_sua13";
            btn_sua13.Size = new Size(194, 60);
            btn_sua13.TabIndex = 33;
            btn_sua13.Text = "Sua";
            btn_sua13.UseVisualStyleBackColor = false;
            btn_sua13.Click += btn_sua13_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dtg_mausac1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(986, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(632, 968);
            panel3.TabIndex = 2;
            // 
            // dtg_mausac1
            // 
            dtg_mausac1.BackgroundColor = SystemColors.ButtonFace;
            dtg_mausac1.BorderStyle = BorderStyle.None;
            dtg_mausac1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_mausac1.Location = new Point(20, 25);
            dtg_mausac1.Name = "dtg_mausac1";
            dtg_mausac1.RowHeadersWidth = 62;
            dtg_mausac1.Size = new Size(592, 923);
            dtg_mausac1.TabIndex = 30;
            dtg_mausac1.CellClick += dtg_mausac1_CellClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-650, 434);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 31;
            label1.Text = "Mau sac";
            // 
            // MauSac2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1650, 1017);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MauSac2";
            Text = "MauSac";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_mausac1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txt_timkiemmausac;
        private Button btn_add13;
        private TextBox txt_mausac1;
        private DataGridView dtg_mausac1;
        private Button btn_sua13;
        private Label label1;
        private Button button2;
        private Label label3;
    }
}