using BUS.IService;
using BUS.Service;
using DAL.IRepo;
using DAL.Models;
using DAL.Repo;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class ThongKe : Form
    {
        private readonly IChucNangThongKe _hoaDonService;
        public ThongKe()
        {
            InitializeComponent();
            var context = new ShopSanPhamContext();
            IQuanLyThongKe hoaDonRepository = new QuanLyThongKe(context);
            _hoaDonService = new ChucNangThongKe(hoaDonRepository);
            comboBox1.SelectedIndexChanged += comboBox1_TextChanged;
        }


        private void ThongKe_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { "Ngày", "Tuần", "Tháng", "Năm" });
            comboBox1.SelectedIndex = 0;

            dateTimePicker1.Value = DateTime.Now;
        }

        private void UpdateData()
        {
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Ngày":
                    startDate = dateTimePicker1.Value.Date;
                    endDate = startDate.AddDays(1).AddSeconds(-1);
                    break;
                case "Tuần":
                    startDate = dateTimePicker1.Value.StartOfWeek(DayOfWeek.Monday);
                    endDate = startDate.AddDays(7).AddSeconds(-1);
                    break;
                case "Tháng":
                    startDate = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
                    endDate = startDate.AddMonths(1).AddSeconds(-1);
                    break;
                case "Năm":
                    startDate = new DateTime(dateTimePicker1.Value.Year, 1, 1);
                    endDate = startDate.AddYears(1).AddSeconds(-1);
                    break;
            }
            var hoaDons = _hoaDonService.GetHoaDonsByDateRange(startDate, endDate);
            dataGridView1.DataSource = hoaDons;

            dataGridView1.Columns["IdKhachHangNavigation"].Visible = false;
            dataGridView1.Columns["HoaDonChiTiets"].Visible = false;
            dataGridView1.Columns["IdKhachHang"].Visible = false;
            dataGridView1.Columns["User"].Visible = false;

            var cultureInfo = new CultureInfo("vi-VN");
            textBox1.Text = _hoaDonService.GetTongTienByDateRange(startDate, endDate).ToString("C", cultureInfo);

            var hoaDonChiTiets = _hoaDonService.LayThongKeSanPhamTheoNgay(startDate, endDate);
            DataTable groupedData = GetGroupedData(hoaDonChiTiets);
            dataGridView2.DataSource = groupedData;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private DataTable GetGroupedData(IEnumerable<HoaDonChiTiet> hoaDonChiTiets)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tên Sản Phẩm");
            dataTable.Columns.Add("Màu Sắc");
            //dataTable.Columns.Add("Kích Cỡ");
            dataTable.Columns.Add("Chất Liệu");
            dataTable.Columns.Add("Kiểu Giày");
            //dataTable.Columns.Add("Giới Tính");
            dataTable.Columns.Add("Số Lượng Đã Bán", typeof(int));

            var groupedData = hoaDonChiTiets
                .GroupBy(hdct => new
                {
                    TenSanPham = hdct.TenSanPham,
                    MauSac = hdct.IdSanPhamNavigation?.MauSac,
                    //KichCo1 = hdct.IdSanPhamNavigation?.KichCoNavigation?.KichCo1,
                    ChatLieu = hdct.IdSanPhamNavigation?.ChatLieu,
                    KieuGiay = hdct.IdSanPhamNavigation?.KieuGiay,
                    //TenGioiTinh = hdct.IdSanPhamNavigation?.IdGioiTinhNavigation?.TenGioiTinh
                })
                .Select(g => new
                {
                    TenSanPham = g.Key.TenSanPham,
                    MauSac = g.Key.MauSac,
                    //KichCo = g.Key.KichCo1,
                    ChatLieu = g.Key.ChatLieu,
                    KieuGiay = g.Key.KieuGiay,
                    //GioiTinh = g.Key.TenGioiTinh,
                    SoLuong = g.Sum(hdct => hdct.SoLuong)
                })
                .OrderByDescending(item => item.SoLuong);
                

            foreach (var item in groupedData)
            {
                DataRow row = dataTable.NewRow();
                row["Tên Sản Phẩm"] = item.TenSanPham;
                row["Màu Sắc"] = item.MauSac;
                //row["Kích Cỡ"] = item.KichCo;
                row["Chất Liệu"] = item.ChatLieu;
                row["Kiểu Giày"] = item.KieuGiay;
                //row["Giới Tính"] = item.GioiTinh;
                row["Số Lượng Đã Bán"] = item.SoLuong;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

    }
}