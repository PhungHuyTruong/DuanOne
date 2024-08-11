

using DAL.Models;
using BUS.CurrentHolder;
using BUS.IService;
using DAL.Repo;
using GUI.Properties;
using Microsoft.VisualBasic.ApplicationServices;
namespace GUI
{
    public partial class GiaoDich : Form
    {
        private readonly IChucNangKhachHang _khachhangservices;
        private readonly IChucNangGiaoDich _services;
        private NhanVien currentuser = CurrentUser.CurrentNhavien;

        private int idvanchuyen = -1;
        private int idhoantat = -1;

        public GiaoDich(IChucNangGiaoDich services, IChucNangKhachHang khachanhservices)
        {
            _khachhangservices = khachanhservices;
            _services = services;
            InitializeComponent();
            taogiohang();
            LoadAsync();

        }
        public void taogiohang()
        {
            txt_giohang.Text = string.Empty;
            if (CurrentCart.currentcart == null)
            {
                var gh = _services.AddGioHang();
                if (gh != null)
                {
                    CurrentCart.SetCurrentGH(gh);
                }
            }
            txt_giohang.Text = $"GH-{CurrentCart.currentcart.IdGioHang}";
        }
        public void cleargiohang()
        {

            if (CurrentCart.currentcart != null)
            {
                CurrentCart.DeleteCurrentGH();
            }

        }

        public async void LoadAsync()
        {
            var ct = await _services.AllChiTietTrongXe(CurrentCart.currentcart.IdGioHang);
            loadsptrongxe(ct);

            var datasp = await _services.AllSanPham();
            loaddatasp(datasp);

            var datagiohang = await _services.AllGioHangCho();
            loaddatagiohang(datagiohang);

            var hdvc = await _services.AllHoaDonVanChuyen();
            LoadDataVanChuyen(hdvc);

            var hdht = await _services.AllHoaDonDaThanhToan();
            LoadDataHoanTat(hdht);
        }
        public void loaddatagiohang(IEnumerable<GioHang> data)
        {
            flo_giohangcho.Controls.Clear();
            flo_giohangcho.AutoScroll = true;
            foreach (var item in data)
            {
                Panel itemPanel = new Panel
                {
                    Width = 110,
                    Height = 118,
                    Padding = new Padding(10),
                    Margin = new Padding(5),
                    Cursor = Cursors.Hand,
                    Enabled = true,
                    Visible = true,
                    Tag = item

                };
                PictureBox pic = new PictureBox
                {
                    Image = Resource.order_history,
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Width = 50,
                    Height = 50,
                    Top = 10,
                    Left = 30,
                    Enabled = false
                };
                Label label = new Label
                {
                    Text = $"GH_{item.IdGioHang}",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = 90,
                    Top = pic.Bottom,
                    Left = 12,
                    Enabled = false

                };
                itemPanel.Controls.Add(pic);
                itemPanel.Controls.Add(label);
                itemPanel.BringToFront();
                itemPanel.DoubleClick += ItemPanel_DoubleClick;

                flo_giohangcho.Controls.Add(itemPanel);
                flo_giohangcho.SendToBack();
            }
        }
        private void ItemPanel_DoubleClick(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            GioHang selectedCart = (GioHang)panel.Tag;
            ReturnCart(selectedCart);
        }
        private void ReturnCart(GioHang cart)
        {
            // Implement the logic to return the cart
            // For example:
            cleargiohang();
            CurrentCart.SetCurrentGH(cart);
            txt_giohang.Text = $"GH-{CurrentCart.currentcart.IdGioHang}";
            LoadAsync();
            // Add any other necessary logic
        }

        public void loaddatasp(IEnumerable<SanPham> data)
        {
            dtg_sanpham.Rows.Clear();
            dtg_sanpham.ColumnCount = 4;
            dtg_sanpham.Columns[0].Name = "Id";
            dtg_sanpham.Columns[1].Name = "Ten";
            dtg_sanpham.Columns[2].Name = "Gia";
            dtg_sanpham.Columns[3].Name = "SoLuong";

            dtg_sanpham.Columns[0].Visible = false;
            foreach (SanPham item in data)
            {
                dtg_sanpham.Rows.Add(item.IdSanPham, item.TenSanPham, item.Gia,item.SoLuong);
            }

        }
        private async void dtg_sanpham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var spchon = dtg_sanpham.Rows[index];
            if (index >= 0)
            {
                int id = Convert.ToInt32(spchon.Cells[0].Value);
                CheckResult result = await _services.AddChiTietGioHang(CurrentCart.currentcart.IdGioHang, id);
                switch (result)
                {
                    case CheckResult.KoDuSoLuong:
                        MessageBox.Show("Ko Du So Luong");
                        break;
                    case CheckResult.KoThanhCong:
                        MessageBox.Show("Ko Thanh Cong");
                        break;
                    case CheckResult.ThanhCong:
                        LoadAsync();
                        break;
                    default:
                        MessageBox.Show("Ko Thanh Cong");
                        break;
                }
            }
        }

        public void loadsptrongxe(List<GioHangChiTiet> data)
        {
            dtg_xesanpham.Rows.Clear();
            dtg_xesanpham.ColumnCount = 7;
            dtg_xesanpham.RowTemplate.Height = 50;
            dtg_xesanpham.Columns[0].Name = "IdChiTiet";
            dtg_xesanpham.Columns[1].Name = "IdSanPham";
            dtg_xesanpham.Columns[2].Name = "TenSanPham";
            dtg_xesanpham.Columns[3].Name = "Gia";
            dtg_xesanpham.Columns[4].Name = "GiaGiam";
            dtg_xesanpham.Columns[5].Name = "SoLuong";
            dtg_xesanpham.Columns[6].Name = "ThanhTien";

            dtg_xesanpham.Columns[0].ReadOnly = true;
            dtg_xesanpham.Columns[1].ReadOnly = true;
            dtg_xesanpham.Columns[2].ReadOnly = true;
            dtg_xesanpham.Columns[3].ReadOnly = true;
            dtg_xesanpham.Columns[4].ReadOnly = true;
            dtg_xesanpham.Columns[6].ReadOnly = true;

            dtg_xesanpham.Columns[0].Visible = false;
            dtg_xesanpham.Columns[1].Visible = false;

            DataGridViewImageColumn delete = new DataGridViewImageColumn();
            delete.Name = "Delete";
            delete.Image = Properties.Resource.trash_xmark;
            //delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dtg_xesanpham.Columns.Add(delete);
            foreach (var item in data)
            {
                var phantram = item.GiamGia / 100 ?? 0;
                decimal giagiam = item.DonGia * (1 - phantram);
                dtg_xesanpham.Rows.Add(item.IdGioHangChiTiet, item.IdSanPham, item.TenSanPham, item.DonGia, giagiam, item.SoLuong, item.ThanhTien);
            }
            txt_tongtien.Text = data.Sum(ct => ct.ThanhTien).ToString();
        }

        private async void dtg_xesanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtg_xesanpham.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int chitiet = Convert.ToInt32(dtg_xesanpham.Rows[e.RowIndex].Cells["IdChiTiet"].Value);
                var delete = await _services.DeleteChiTiet(chitiet);
                if (delete)
                {
                    LoadAsync();
                }
            }
        }

        private async void dtg_xesanpham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtg_xesanpham.Columns["SoLuong"].Index && e.RowIndex >= 0)
            {
                int chitiet = Convert.ToInt32(dtg_xesanpham.Rows[e.RowIndex].Cells["IdChiTiet"].Value);
                int sp = Convert.ToInt32(dtg_xesanpham.Rows[e.RowIndex].Cells["IdSanPham"].Value);
                if (int.TryParse(dtg_xesanpham.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out int soluong))
                {
                    var result = await _services.UpdateChiTiet(chitiet, sp, soluong);
                    switch (result)
                    {
                        case CheckResult.ThanhCong:
                            LoadAsync();
                            break;
                        case CheckResult.KoThanhCong:
                            MessageBox.Show("Sua Ko Thanh Cong");
                            LoadAsync();
                            break;
                        case CheckResult.KoTimThayChiTiet:
                            MessageBox.Show("Ko Thay Chi Tiet");
                            LoadAsync();
                            break;
                        case CheckResult.KoTimThaySP:
                            MessageBox.Show("Ko Tim Thay San Pham");
                            LoadAsync();
                            break;
                        case CheckResult.KoDuSoLuong:
                            MessageBox.Show("Ko Du So Luong");
                            LoadAsync();
                            break;
                        default:
                            MessageBox.Show("Sua Ko Thanh Cong");
                            LoadAsync();
                            break;
                    }
                }
            }
        }

        private async void btn_treodon_Click(object sender, EventArgs e)
        {
            bool trangthai = false;
            int giohang = CurrentCart.currentcart.IdGioHang;
            await _services.UpdateGioHang(giohang, trangthai);
            cleargiohang();
            taogiohang();
            LoadAsync();
        }

        private async void btn_huydon_Click(object sender, EventArgs e)
        {
            int idgiohang = CurrentCart.currentcart.IdGioHang;
            await _services.XoaGioHang(idgiohang);
            cleargiohang();
            taogiohang();
            LoadAsync();
        }

        private async void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            decimal tongtien = Convert.ToDecimal(txt_tongtien.Text);
            decimal tien = 0;
            using (var formthanhtoan = new ThanhToanWindow(tongtien))
            {
                if (formthanhtoan.ShowDialog() == DialogResult.OK)
                {
                    tien = formthanhtoan.tiennhap;
                }
                else
                {
                    return;
                }
            }
            int idgiohang = CurrentCart.currentcart.IdGioHang;
            int userid = currentuser.UserId;
            bool phuongthuc = true;
            bool vanchuyen = false;

            var result = await _services.ThanhToan(idgiohang, userid, tien, phuongthuc, 0, vanchuyen);
            switch (result)
            {
                case CheckResult.ThanhCong:
                    await _services.XoaGioHang(idgiohang);
                    cleargiohang();
                    taogiohang();
                    LoadAsync();
                    break;
                case CheckResult.KoThanhCong:
                    MessageBox.Show("Ko Thanh Cong");
                    break;
                case CheckResult.ThieuTien:
                    MessageBox.Show("Ko Du Tien");
                    break;
                case CheckResult.KoTimThayGH:
                    MessageBox.Show("Ko Co Gio Hang");
                    break;
                default:
                    MessageBox.Show("Ko Thanh Cong");
                    break;
            }

        }

        private async void btn_vanchuyen_Click(object sender, EventArgs e)
        {
            decimal tongtien = Convert.ToDecimal(txt_tongtien.Text);
            using (var formthanhtoan = new VanChuyenWindow(tongtien, _khachhangservices))
            {
                if (formthanhtoan.ShowDialog() == DialogResult.OK)
                {
                    decimal tien = formthanhtoan.tiennhap;
                    int kh = formthanhtoan.KhachHang;
                    int idgiohang = CurrentCart.currentcart.IdGioHang;
                    int userid = currentuser.UserId;
                    bool phuongthuc = false;
                    bool vanchuyen = true;

                    var result = await _services.ThanhToan(idgiohang, userid, tien, phuongthuc, kh, vanchuyen);
                    switch (result)
                    {
                        case CheckResult.ThanhCong:
                            await _services.XoaGioHang(idgiohang);
                            cleargiohang();
                            taogiohang();
                            LoadAsync();
                            break;
                        case CheckResult.KoThanhCong:
                            MessageBox.Show("Ko Thanh Cong");
                            break;
                        case CheckResult.ThieuTien:
                            MessageBox.Show("Ko Du Tien");
                            break;
                        case CheckResult.KoTimThayGH:
                            MessageBox.Show("Ko Co Gio Hang");
                            break;
                        default:
                            MessageBox.Show("Ko Thanh Cong");
                            break;
                    }
                }
                else
                {
                    return;
                }
            }

        }
        public void LoadDataVanChuyen(IEnumerable<HoaDon> data)
        {
            dtg_hoadonvanchuyen.Rows.Clear();
            dtg_hoadonvanchuyen.ColumnCount = 7;
            dtg_hoadonvanchuyen.Columns[0].Name = "IdHoaDon";
            dtg_hoadonvanchuyen.Columns[1].Name = "TenKhach";
            dtg_hoadonvanchuyen.Columns[2].Name = "SĐt";
            dtg_hoadonvanchuyen.Columns[3].Name = "Email";
            dtg_hoadonvanchuyen.Columns[4].Name = "DiaChi";
            dtg_hoadonvanchuyen.Columns[5].Name = "NgayTao";
            dtg_hoadonvanchuyen.Columns[6].Name = "TongTien";

            dtg_hoadonvanchuyen.Columns[0].Visible = false;
            dtg_hoadonvanchuyen.Columns[1].Visible = false;
            dtg_hoadonvanchuyen.Columns[3].Visible = false;
            dtg_hoadonvanchuyen.Columns[4].Visible = false;
            dtg_hoadonvanchuyen.Columns[6].Visible = false;

            foreach (var item in data)
            {
                dtg_hoadonvanchuyen.Rows.Add(item.IdHoaDon, item.IdKhachHangNavigation.Ten, item.IdKhachHangNavigation.SoDienThoai,
                                             item.IdKhachHangNavigation.Email, item.IdKhachHangNavigation.DiaChi, item.NgayTao, item.TongTien);
            }

        }
        public void LoadChiTietVanChuyen(IEnumerable<HoaDonChiTiet> data)
        {
            dtg_chittietvanchuyen.Rows.Clear();
            dtg_chittietvanchuyen.ColumnCount = 3;
            dtg_chittietvanchuyen.Columns[0].Name = "TenSanPham";
            dtg_chittietvanchuyen.Columns[1].Name = "SoLuong";
            dtg_chittietvanchuyen.Columns[2].Name = "TongTien";
            foreach (var item in data)
            {
                dtg_chittietvanchuyen.Rows.Add(item.TenSanPham, item.SoLuong, item.ThanhTien);
            }
        }


        private async void dtg_hoadonvanchuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var hdchon = dtg_hoadonvanchuyen.Rows[index];
            if (index >= 0)
            {
                txt_ten1.Text = hdchon.Cells[1].Value.ToString();
                txt_sdt1.Text = hdchon.Cells[2].Value.ToString();
                txt_email1.Text = hdchon.Cells[3].Value.ToString();
                txt_diachi1.Text = hdchon.Cells[4].Value.ToString();
                txt_thoigian1.Text = hdchon.Cells[5].Value.ToString();
                txt_tongtien1.Text = hdchon.Cells[6].Value.ToString();
                idvanchuyen = Convert.ToInt32(hdchon.Cells[0].Value);

                var list = await _services.AllChiTietHoaDon(idvanchuyen);
                LoadChiTietVanChuyen(list);

            }
        }
        public void LoadDataHoanTat(IEnumerable<HoaDon> data)
        {
            dtg_hoadondaxong.Rows.Clear();
            dtg_hoadondaxong.ColumnCount = 7;
            dtg_hoadondaxong.Columns[0].Name = "IdHoaDon";
            dtg_hoadondaxong.Columns[1].Name = "TenKhach";
            dtg_hoadondaxong.Columns[2].Name = "SĐt";
            dtg_hoadondaxong.Columns[3].Name = "Email";
            dtg_hoadondaxong.Columns[4].Name = "DiaChi";
            dtg_hoadondaxong.Columns[5].Name = "NgayTao";
            dtg_hoadondaxong.Columns[6].Name = "TongTien";

            dtg_hoadondaxong.Columns[0].Visible = false;
            dtg_hoadondaxong.Columns[1].Visible = false;
            dtg_hoadondaxong.Columns[2].Visible = false;
            dtg_hoadondaxong.Columns[3].Visible = false;
            dtg_hoadondaxong.Columns[4].Visible = false;
            dtg_hoadondaxong.Columns[6].Visible = false;

            foreach (var item in data)
            {

                var ten = item.IdKhachHangNavigation?.Ten ?? "";
                var sdt = item.IdKhachHangNavigation?.SoDienThoai ?? "";
                var email = item.IdKhachHangNavigation?.Email ?? "";
                var diachi = item.IdKhachHangNavigation?.DiaChi ?? "";

                dtg_hoadondaxong.Rows.Add(item.IdHoaDon, ten, sdt, email, diachi, item.NgayTao, item.TongTien);

            }
        }
        public void LoadChiTietHoanDaXong(IEnumerable<HoaDonChiTiet> data)
        {
            dtg_chitiethoantat.Rows.Clear();
            dtg_chitiethoantat.ColumnCount = 3;
            dtg_chitiethoantat.Columns[0].Name = "TenSanPham";
            dtg_chitiethoantat.Columns[1].Name = "SoLuong";
            dtg_chitiethoantat.Columns[2].Name = "TongTien";
            foreach (var item in data)
            {
                dtg_chitiethoantat.Rows.Add(item.TenSanPham, item.SoLuong, item.ThanhTien);
            }
        }

        private async void dtg_hoadondaxong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var hdchon = dtg_hoadondaxong.Rows[index];
            if (index >= 0)
            {
                txt_ten2.Text = hdchon.Cells[1].Value.ToString();
                txt_sdt2.Text = hdchon.Cells[2].Value.ToString();
                txt_email2.Text = hdchon.Cells[3].Value.ToString();
                txt_diachi2.Text = hdchon.Cells[4].Value.ToString();
                txt_thoigian2.Text = hdchon.Cells[5].Value.ToString();
                txt_tongtien2.Text = hdchon.Cells[6].Value.ToString();
                idhoantat = Convert.ToInt32(hdchon.Cells[0].Value);

                var list = await _services.AllChiTietHoaDon(idhoantat);
                LoadChiTietHoanDaXong(list);

            }
        }

        private async void btn_xacnhanvanchuyen_Click(object sender, EventArgs e)
        {
            await _services.XacThucHoaDon(idvanchuyen);
            LoadAsync();
            idvanchuyen = -1;
            txt_ten1.Text = "";
            txt_sdt1.Text = "";
            txt_email1.Text = "";
            txt_diachi1.Text = "";
            txt_thoigian1.Text = "";
            txt_tongtien1.Text = "";
            dtg_chittietvanchuyen.Rows.Clear();

        }

        private async void btn_huyvanchuyen_Click(object sender, EventArgs e)
        {
            await _services.HUyHoaDon(idvanchuyen);
            LoadAsync();
            idvanchuyen = -1;
            txt_ten1.Text = "";
            txt_sdt1.Text = "";
            txt_email1.Text = "";
            txt_diachi1.Text = "";
            txt_thoigian1.Text = "";
            txt_tongtien1.Text = "";
            dtg_chittietvanchuyen.Rows.Clear();

        }

        private async void btn_hoantra_Click(object sender, EventArgs e)
        {
            await _services.HoanTraHoaDon(idhoantat);
            LoadAsync();
            idhoantat = -1;
            txt_ten2.Text = "";
            txt_sdt2.Text = "";
            txt_email2.Text = "";
            txt_diachi2.Text = "";
            txt_thoigian2.Text = "";
            txt_tongtien2.Text = "";
            dtg_chitiethoantat.Rows.Clear();

        }
        private async void TimkKiemVanChuyen()
        {
            string timkiem = txt_timkiem1.Text;
            DateTime? startDate = dtp_vanchuyen1.Value.Date == DateTime.MinValue ? (DateTime?)null : dtp_vanchuyen1.Value;
            DateTime? endDate = dtp_vanchuyen2.Value.Date == DateTime.MinValue ? (DateTime?)null : dtp_vanchuyen2.Value.Date.AddDays(1).AddTicks(-1);

            var list = await _services.TimKiemVanChuyen(timkiem, startDate, endDate);
            LoadDataVanChuyen(list);

        }

        private void txt_timkiem1_TextChanged(object sender, EventArgs e)
        {
            TimkKiemVanChuyen();
        }

        private void btn_dtp1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (dtp_vanchuyen1.Value > now || dtp_vanchuyen1.Value > dtp_vanchuyen2.Value)
            {
                MessageBox.Show("Ko dc");
                return;
            }
            else
            {
                TimkKiemVanChuyen();
            }
        }
        private async void TimkKiemHoanTat()
        {
            string timkiem = txt_timkiem1.Text;
            DateTime? startDate = dtp_vanchuyen1.Value.Date == DateTime.MinValue ? (DateTime?)null : dtp_vanchuyen1.Value;
            DateTime? endDate = dtp_vanchuyen2.Value.Date == DateTime.MinValue ? (DateTime?)null : dtp_vanchuyen2.Value.Date.AddDays(1).AddTicks(-1);

            var list = await _services.TimKiemHoanTat(timkiem, startDate, endDate);
            LoadDataHoanTat(list);

        }

        private void txt_timkiem2_TextChanged(object sender, EventArgs e)
        {
            TimkKiemHoanTat();
        }

        private void btn_dtp2_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            if (dtp_hoadon1.Value > now || dtp_hoadon1.Value > dtp_hoadon2.Value)
            {
                MessageBox.Show("Ko dc");
                return;
            }
            else
            {
                TimkKiemHoanTat();
            }
         
        }
    }
}
