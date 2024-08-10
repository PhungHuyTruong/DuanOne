namespace GUI
{
    partial class ThuocTinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThuocTinh));
            tb_thuoctinh = new TabPage();
            panel2 = new Panel();
            formphu = new Panel();
            menubar = new Panel();
            panel10 = new Panel();
            button6 = new Button();
            panel11 = new Panel();
            button8 = new Button();
            panel4 = new Panel();
            button7 = new Button();
            panel1 = new Panel();
            btn_hangsp = new Button();
            panel9 = new Panel();
            btn_gioitinhsp = new Button();
            panel8 = new Panel();
            btn_logoff = new Button();
            tabs1 = new TabControl();
            tb_thuoctinh.SuspendLayout();
            panel2.SuspendLayout();
            menubar.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            tabs1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_thuoctinh
            // 
            tb_thuoctinh.BackColor = Color.FromArgb(242, 242, 242);
            tb_thuoctinh.Controls.Add(panel2);
            tb_thuoctinh.Location = new Point(4, 39);
            tb_thuoctinh.Margin = new Padding(4);
            tb_thuoctinh.Name = "tb_thuoctinh";
            tb_thuoctinh.Size = new Size(1992, 1159);
            tb_thuoctinh.TabIndex = 0;
            tb_thuoctinh.Text = "Thuoc Tinh";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 242, 242);
            panel2.Controls.Add(formphu);
            panel2.Controls.Add(menubar);
            panel2.Location = new Point(-4, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1996, 1141);
            panel2.TabIndex = 1;
            // 
            // formphu
            // 
            formphu.BackColor = Color.White;
            formphu.Location = new Point(329, 23);
            formphu.Name = "formphu";
            formphu.Size = new Size(1637, 1088);
            formphu.TabIndex = 6;
            // 
            // menubar
            // 
            menubar.BackColor = Color.White;
            menubar.Controls.Add(panel10);
            menubar.Controls.Add(panel11);
            menubar.Controls.Add(panel4);
            menubar.Controls.Add(panel1);
            menubar.Controls.Add(panel9);
            menubar.Controls.Add(panel8);
            menubar.Dock = DockStyle.Left;
            menubar.Location = new Point(0, 0);
            menubar.Margin = new Padding(4);
            menubar.MaximumSize = new Size(300, 0);
            menubar.MinimumSize = new Size(300, 0);
            menubar.Name = "menubar";
            menubar.Size = new Size(300, 1141);
            menubar.TabIndex = 5;
            // 
            // panel10
            // 
            panel10.Controls.Add(button6);
            panel10.Location = new Point(4, 484);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(281, 121);
            panel10.TabIndex = 5;
            // 
            // button6
            // 
            button6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-26, -10);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Padding = new Padding(50, 0, 0, 0);
            button6.Size = new Size(321, 140);
            button6.TabIndex = 7;
            button6.Text = "                Giảm Giá";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(button8);
            panel11.Location = new Point(4, 242);
            panel11.Margin = new Padding(0);
            panel11.Name = "panel11";
            panel11.Size = new Size(281, 121);
            panel11.TabIndex = 5;
            // 
            // button8
            // 
            button8.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-18, -10);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Padding = new Padding(50, 0, 0, 0);
            button8.Size = new Size(321, 140);
            button8.TabIndex = 9;
            button8.Text = "                Kích cỡ";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button7);
            panel4.Location = new Point(4, 363);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(281, 121);
            panel4.TabIndex = 4;
            // 
            // button7
            // 
            button7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-17, -10);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Padding = new Padding(50, 0, 0, 0);
            button7.Size = new Size(321, 140);
            button7.TabIndex = 8;
            button7.Text = "                Màu sắc";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_hangsp);
            panel1.Location = new Point(4, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 121);
            panel1.TabIndex = 3;
            // 
            // btn_hangsp
            // 
            btn_hangsp.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_hangsp.Image = (Image)resources.GetObject("btn_hangsp.Image");
            btn_hangsp.ImageAlign = ContentAlignment.MiddleLeft;
            btn_hangsp.Location = new Point(-25, -9);
            btn_hangsp.Margin = new Padding(4);
            btn_hangsp.Name = "btn_hangsp";
            btn_hangsp.Padding = new Padding(50, 0, 0, 0);
            btn_hangsp.Size = new Size(321, 140);
            btn_hangsp.TabIndex = 2;
            btn_hangsp.Text = "                Hãng sản phẩm\r\n";
            btn_hangsp.TextAlign = ContentAlignment.MiddleLeft;
            btn_hangsp.UseVisualStyleBackColor = true;
            btn_hangsp.Click += btn_hangsp_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(btn_gioitinhsp);
            panel9.Location = new Point(4, 121);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(281, 121);
            panel9.TabIndex = 5;
            // 
            // btn_gioitinhsp
            // 
            btn_gioitinhsp.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_gioitinhsp.Image = (Image)resources.GetObject("btn_gioitinhsp.Image");
            btn_gioitinhsp.ImageAlign = ContentAlignment.MiddleLeft;
            btn_gioitinhsp.Location = new Point(-22, -10);
            btn_gioitinhsp.Margin = new Padding(4);
            btn_gioitinhsp.Name = "btn_gioitinhsp";
            btn_gioitinhsp.Padding = new Padding(50, 0, 0, 0);
            btn_gioitinhsp.Size = new Size(321, 140);
            btn_gioitinhsp.TabIndex = 10;
            btn_gioitinhsp.Text = "                Giới Tính";
            btn_gioitinhsp.TextAlign = ContentAlignment.MiddleLeft;
            btn_gioitinhsp.UseVisualStyleBackColor = true;
            btn_gioitinhsp.Click += btn_gioitinhsp_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btn_logoff);
            panel8.Location = new Point(0, 1165);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(281, 96);
            panel8.TabIndex = 0;
            // 
            // btn_logoff
            // 
            btn_logoff.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logoff.Image = Properties.Resource.power;
            btn_logoff.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logoff.Location = new Point(-24, -18);
            btn_logoff.Margin = new Padding(4);
            btn_logoff.Name = "btn_logoff";
            btn_logoff.Padding = new Padding(50, 0, 0, 0);
            btn_logoff.Size = new Size(315, 140);
            btn_logoff.TabIndex = 1;
            btn_logoff.Text = "                ĐĂNG XUẤT";
            btn_logoff.TextAlign = ContentAlignment.MiddleLeft;
            btn_logoff.UseVisualStyleBackColor = true;
            // 
            // tabs1
            // 
            tabs1.Controls.Add(tb_thuoctinh);
            tabs1.ItemSize = new Size(100, 35);
            tabs1.Location = new Point(1, 1);
            tabs1.Margin = new Padding(4);
            tabs1.Name = "tabs1";
            tabs1.SelectedIndex = 0;
            tabs1.Size = new Size(2000, 1202);
            tabs1.TabIndex = 2;
            // 
            // ThuocTinh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1998, 1185);
            Controls.Add(tabs1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThuocTinh";
            Text = "ThuocTinh";
            Load += ThuocTinh_Load;
            tb_thuoctinh.ResumeLayout(false);
            panel2.ResumeLayout(false);
            menubar.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tabs1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tb_thuoctinh;
        private Panel panel2;
        private TabControl tabs1;
        private Panel menubar;
        private Button btn_hangsp;
        private Panel panel8;
        private Button btn_logoff;
        private Button btn_gioitinhsp;
        private Button button8;
        private Button button7;
        private Button button6;
        private Panel panel1;
        private Panel panel4;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel formphu;
    }
}