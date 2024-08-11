using BUS.IService;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;
using BUS.CurrentHolder;

namespace GUI
{
    public partial class Login : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IChucNangDangNhap _chucnang;
        public Login(IChucNangDangNhap chucnang, IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _chucnang = chucnang;

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            var tk = txt_taikhoan.Text;
            var mk = txt_matkhau.Text;
            var nhanvien = _chucnang.KiemTra(tk, mk);
            if (nhanvien != null)
            {
                CurrentUser.SetCurrentUser(nhanvien);
                var mainform = _serviceProvider.GetRequiredService<Mainform>();
                mainform.Show();
            }
            else 
            {
                MessageBox.Show("Mật khẩu hoặc tài khoản không đúng");
            }


        }
    }
}
