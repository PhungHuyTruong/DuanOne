namespace GUI
{
    partial class KichCo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KichCo2));
            btn_sua12 = new Button();
            btn_add12 = new Button();
            label1 = new Label();
            dtg_kichco1 = new DataGridView();
            txt_kichco = new TextBox();
            txt_timkiemkichco = new TextBox();
            panel1 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtg_kichco1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btn_sua12
            // 
            btn_sua12.BackColor = SystemColors.ButtonFace;
            btn_sua12.Location = new Point(580, 65);
            btn_sua12.Name = "btn_sua12";
            btn_sua12.Size = new Size(194, 68);
            btn_sua12.TabIndex = 21;
            btn_sua12.Text = "Sua";
            btn_sua12.UseVisualStyleBackColor = false;
            btn_sua12.Click += btn_sua12_Click;
            // 
            // btn_add12
            // 
            btn_add12.BackColor = SystemColors.ButtonFace;
            btn_add12.Location = new Point(136, 65);
            btn_add12.Name = "btn_add12";
            btn_add12.Size = new Size(194, 68);
            btn_add12.TabIndex = 20;
            btn_add12.Text = "Add";
            btn_add12.UseVisualStyleBackColor = false;
            btn_add12.Click += btn_add12_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 329);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 18;
            label1.Text = "Kich co";
            // 
            // dtg_kichco1
            // 
            dtg_kichco1.BackgroundColor = SystemColors.ButtonFace;
            dtg_kichco1.BorderStyle = BorderStyle.None;
            dtg_kichco1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_kichco1.Location = new Point(25, 19);
            dtg_kichco1.Name = "dtg_kichco1";
            dtg_kichco1.RowHeadersWidth = 62;
            dtg_kichco1.Size = new Size(581, 930);
            dtg_kichco1.TabIndex = 17;
            dtg_kichco1.CellClick += dtg_kichco1_CellClick;
            // 
            // txt_kichco
            // 
            txt_kichco.Location = new Point(200, 326);
            txt_kichco.Name = "txt_kichco";
            txt_kichco.Size = new Size(623, 31);
            txt_kichco.TabIndex = 22;
            // 
            // txt_timkiemkichco
            // 
            txt_timkiemkichco.BorderStyle = BorderStyle.FixedSingle;
            txt_timkiemkichco.Location = new Point(477, 47);
            txt_timkiemkichco.Name = "txt_timkiemkichco";
            txt_timkiemkichco.Size = new Size(346, 31);
            txt_timkiemkichco.TabIndex = 23;
            txt_timkiemkichco.TextChanged += txt_timkiemkichco_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txt_timkiemkichco);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_kichco);
            panel1.Location = new Point(29, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 731);
            panel1.TabIndex = 24;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(820, 47);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(52, 31);
            button2.TabIndex = 82;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_sua12);
            panel2.Controls.Add(btn_add12);
            panel2.Location = new Point(29, 794);
            panel2.Name = "panel2";
            panel2.Size = new Size(919, 208);
            panel2.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dtg_kichco1);
            panel3.Location = new Point(993, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(634, 974);
            panel3.TabIndex = 26;
            // 
            // KichCo2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1655, 1027);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KichCo2";
            Text = "KichCo";
            ((System.ComponentModel.ISupportInitialize)dtg_kichco1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_sua12;
        private Button btn_add12;
        private Label label1;
        private DataGridView dtg_kichco1;
        private TextBox txt_kichco;
        private TextBox txt_timkiemkichco;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
    }
}