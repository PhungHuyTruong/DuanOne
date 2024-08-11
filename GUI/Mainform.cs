using BUS.CurrentHolder;
using Microsoft.Extensions.DependencyInjection;

namespace GUI
{

    public partial class Mainform : Form
    {

        bool menu;
        private readonly IServiceProvider _serviceProvider;

        public Mainform(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            this.StartPosition = FormStartPosition.CenterScreen;
            UpdateUIBasedOnRole();
        }
        private void UpdateUIBasedOnRole()
        {
            var userRole = CurrentUser.CurrentNhavien?.Role;

            if (userRole == "AD")
            {
                btn_thongke.Visible = true;
                btn_thuoctinh.Visible = true;
                btn_quanlynguoidung.Visible = true;
            }
            else if (userRole == "NV")
            {
                btn_thongke.Visible = false;
                btn_thuoctinh.Visible = false;
                btn_quanlynguoidung.Visible = false;
            }
        }
        private void menuexpand_Tick(object sender, EventArgs e)
        {
            if (menu)
            {
                menubar.Width -= 10;
                if (menubar.Width == menubar.MinimumSize.Width)
                {
                    menu = false;
                    menuexpand.Stop();
                }
            }
            else
            {
                menubar.Width += 10;
                if (menubar.Width == menubar.MaximumSize.Width)
                {
                    menu = true;
                    menuexpand.Stop();
                }
            }

        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            menuexpand.Start();
        }
        private void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            showform.Controls.Clear();  // Clear any existing controls
            showform.Controls.Add(form);
            form.Show();

        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            var giaodich = _serviceProvider.GetRequiredService<GiaoDich>();
            ShowFormInPanel(giaodich);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            var khohang = _serviceProvider.GetRequiredService<KhoHang>();
            ShowFormInPanel(khohang);
        }

        private void btn_quanlynguoidung_Click(object sender, EventArgs e)
        {
            var nhanVien = _serviceProvider.GetRequiredService<BangNhanVien>();
            ShowFormInPanel(nhanVien);
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            var thongKe = _serviceProvider.GetRequiredService<ThongKe>();
            ShowFormInPanel(thongKe);
        }

        private void btn_logoff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {

        }

        private void btn_trangchu_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_thuoctinh_Click(object sender, EventArgs e)
        {
            var thuoctinh = _serviceProvider.GetRequiredService<ThuocTinh>();
            ShowFormInPanel(thuoctinh);
        }
        private void btn_formkhachhang_Click(object sender, EventArgs e)
        {
            var khachhang = _serviceProvider.GetRequiredService<BangKhachHang>();
            ShowFormInPanel(khachhang);
        }
    }
}
