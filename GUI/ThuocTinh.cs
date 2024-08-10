using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThuocTinh : Form
    {
        bool menu;
        private readonly IServiceProvider _serviceProvider;
        public ThuocTinh(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ThuocTinh_Load(object sender, EventArgs e)
        {

        }
        private void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            formphu.Controls.Clear();  // Clear any existing controls
            formphu.Controls.Add(form);
            form.Show();

        }

        private void btn_hangsp_Click(object sender, EventArgs e)
        {
            var hangsp = _serviceProvider.GetRequiredService<Hang>();
            ShowFormInPanel(hangsp);
        }

        private void btn_gioitinhsp_Click(object sender, EventArgs e)
        {
            var gioitinh = _serviceProvider.GetRequiredService<GioiTinh2>();
            ShowFormInPanel(gioitinh);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var kichco = _serviceProvider.GetRequiredService<KichCo2>();
            ShowFormInPanel(kichco);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var mausac = _serviceProvider.GetRequiredService<MauSac2>();
            ShowFormInPanel(mausac);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var giamgia = _serviceProvider.GetRequiredService<GiamGia1>();
            ShowFormInPanel(giamgia);
        }
    }
}
