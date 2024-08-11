using BUS.IService;
using BUS.Service;
using DAL.IRepo;
using DAL.Models;
using DAL.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            using (var scope = serviceProvider.CreateScope())
            {
                var login = scope.ServiceProvider.GetRequiredService<Login>();
                Application.Run(login);
            }
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ShopSanPhamContext>(options =>
                options.UseSqlServer("Server=ANHDUC;Database=ShopSanPham;Trusted_Connection=True;TrustServerCertificate=true"));

            services.AddScoped<IQuanLyDangNhap,QuanLyDangNhap>();
            services.AddScoped<IChucNangDangNhap, ChucNangDangNhap>();
            services.AddScoped<IQuanLyNhanVien, QuanLyNhanVien>();
            services.AddScoped<IChucNangNhanVien, ChucNangNhanVien>();
            services.AddScoped<IQuanLyKhoHang, QuanLyKhoHang>();
            services.AddScoped<IChucNangKhoHang, ChucNangKhoHang>();
            services.AddScoped<IQuanLyGiaoDich, QuanLyGiaoDich>();
            services.AddScoped<IChucNangGiaoDich,ChucNangGiaoDich>();
            services.AddScoped<IQuanLyKhachHang, QuanLyKhachHang>();
            services.AddScoped<IChucNangKhachHang, ChucNangKhachHang>();
            services.AddScoped<IQuanLyThongKe, QuanLyThongKe>();
            services.AddScoped<IChucNangThongKe, ChucNangThongKe>();
            services.AddScoped<IQuanLyThuocTinh, QuanLyThuocTinh>();
            services.AddScoped<IChucNangThuocTinh, ChucNangThuocTinh>();

            // Register forms
            services.AddScoped<Mainform>();
            services.AddTransient<Login>();
            services.AddTransient<BangNhanVien>();
            services.AddTransient<ThongKe>();
            services.AddTransient<KhoHang>();
            services.AddTransient<GiaoDich>();
            services.AddTransient<BangKhachHang>();
            services.AddTransient<ThuocTinh>();
            services.AddTransient<GiamGia1>();
            services.AddTransient<Hang>();
            services.AddTransient<KichCo2>();
            services.AddTransient<GioiTinh2>();
            services.AddTransient<MauSac2>();

        }
    }
}