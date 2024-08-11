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
            comboBox2.SelectedIndexChanged += comboBox2_TextChanged;
            dataGridView4.CellClick += dataGridView4_CellClick;
        }


        private void ThongKe_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { "Ngày", "Tuần", "Tháng", "Năm" });
            comboBox1.SelectedIndex = 0;

            dateTimePicker1.Value = DateTime.Now;

            comboBox2.Items.AddRange(new object[] { "Ngày", "Tuần", "Tháng", "Năm" });
            comboBox2.SelectedIndex = 0;

            dateTimePicker2.Value = DateTime.Now;
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

            dataGridView1.Columns["HoaDonChiTiets"].Visible = false;

            var cultureInfo = new CultureInfo("vi-VN");
            textBox1.Text = _hoaDonService.GetTongTienByDateRange(startDate, endDate).ToString("C", cultureInfo);

            var hoaDonChiTiets = _hoaDonService.LayThongKeSanPhamTheoNgay(startDate, endDate);
            DataTable groupedData = GetGroupedData(hoaDonChiTiets);
            dataGridView2.DataSource = groupedData;
        }

        private void UpdateData1()
        {
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;

            switch (comboBox2.SelectedItem.ToString())
            {
                case "Ngày":
                    startDate = dateTimePicker2.Value.Date;
                    endDate = startDate.AddDays(1).AddSeconds(-1);
                    break;
                case "Tuần":
                    startDate = dateTimePicker2.Value.StartOfWeek(DayOfWeek.Monday);
                    endDate = startDate.AddDays(7).AddSeconds(-1);
                    break;
                case "Tháng":
                    startDate = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, 1);
                    endDate = startDate.AddMonths(1).AddSeconds(-1);
                    break;
                case "Năm":
                    startDate = new DateTime(dateTimePicker2.Value.Year, 1, 1);
                    endDate = startDate.AddYears(1).AddSeconds(-1);
                    break;
            }

            Console.WriteLine($"Start Date: {startDate}, End Date: {endDate}");

            var hoaDons = _hoaDonService.GetHoaDonsByDateRange(startDate, endDate);

            Console.WriteLine($"Number of HoaDons: {hoaDons.Count()}");

            dataGridView4.DataSource = hoaDons;

            dataGridView4.Columns["HoaDonChiTiets"].Visible = false;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateData1();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView4.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView4.Rows[e.RowIndex];
                int hoaDonId = Convert.ToInt32(selectedRow.Cells["IdHoaDon"].Value);

                var hoaDon = _hoaDonService.GetHoaDonById(hoaDonId);

                if (hoaDon == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn.");
                    return;
                }

                var nhanVien = hoaDon.User;
                if (nhanVien == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên.");
                    return;
                }

                txt_name.Text = nhanVien.Name ?? "Không có tên";
                txt_ngaysinh.Text = nhanVien.DateOfBirth != default ? nhanVien.DateOfBirth.ToString("dd/MM/yyyy") : "Không có ngày sinh";
                txt_gioitinh.Text = nhanVien.Gender ?? "Không có giới tính";
                txt_email.Text = nhanVien.Email ?? "Không có email";
                txt_phone.Text = nhanVien.PhoneNumber ?? "Không có số điện thoại";
                txt_role.Text = nhanVien.Role ?? "Không có vai trò";

                var khachHang = hoaDon.IdKhachHangNavigation;
                if (khachHang != null)
                {
                    txt_ten2.Text = khachHang.Ten ?? "Không có tên";
                    txt_sdt2.Text = khachHang.SoDienThoai ?? "Không có số điện thoại";
                    txt_email2.Text = khachHang.Email ?? "Không có email";
                    txt_diachi2.Text = khachHang.DiaChi ?? "Không có địa chỉ";
                }
                else
                {
                    txt_ten2.Text = "Không có";
                    txt_sdt2.Text = "Không có";
                    txt_email2.Text = "Không có";
                    txt_diachi2.Text = "Không có";
                }

                var chiTietHoaDons = _hoaDonService.GetChiTietHoaDonByHoaDonId(hoaDonId);
                dataGridView3.DataSource = chiTietHoaDons;

                if (dataGridView3.Columns.Contains("IdHoaDon"))
                {
                    dataGridView3.Columns["IdHoaDon"].Visible = false;
                }
                if (dataGridView3.Columns.Contains("IdSanPham"))
                {
                    dataGridView3.Columns["IdSanPham"].Visible = false;
                }
                if (dataGridView3.Columns.Contains("IdHoaDonNavigation"))
                {
                    dataGridView3.Columns["IdHoaDonNavigation"].Visible = false;
                }
                if (dataGridView3.Columns.Contains("IdSanPhamNavigation"))
                {
                    dataGridView3.Columns["IdSanPhamNavigation"].Visible = false;
                }
            }
        }
    }
}