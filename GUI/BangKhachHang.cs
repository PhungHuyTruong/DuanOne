using BUS.IService;
using DAL.Models;
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
    public partial class BangKhachHang : Form
    {
        private readonly IChucNangKhachHang _services;
        private int selectedid = -1;
        public BangKhachHang(IChucNangKhachHang services)
        {
            _services = services;
            InitializeComponent();
            LoadAsync();
        }
        public async void LoadAsync()
        {
            var data = await _services.GetAllKHachHang();
            LoadData(data);
        }
        public void LoadData(IEnumerable<KhachHang> data)
        {
            dtg_khachhang.Rows.Clear();
            dtg_khachhang.ColumnCount = 5;

            dtg_khachhang.Columns[0].Name = "Id";
            dtg_khachhang.Columns[0].Visible = false;
            dtg_khachhang.Columns[1].Name = "Ten";
            dtg_khachhang.Columns[2].Name = "SoDienThoai";
            dtg_khachhang.Columns[3].Name = "Email";
            dtg_khachhang.Columns[4].Name = "DiaChi";
            foreach (var item in data)
            {
                dtg_khachhang.Rows.Add(item.IdKhachHang, item.Ten, item.SoDienThoai, item.Email, item.DiaChi);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (CheckText())
            {
                KhachHang kh = new KhachHang
                {
                    Ten = txt_ten.Text,
                    SoDienThoai = txt_sodienthoai.Text,
                    Email = txt_email.Text,
                    DiaChi = txt_diachi.Text,
                };
                if (!_services.AddKhachHang(kh)){
                    MessageBox.Show("Trùng Thông Tin");
                };
                LoadAsync();
            }
        }
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (CheckText()) 
            {
                KhachHang kh = new KhachHang
                {
                    IdKhachHang = selectedid,
                    Ten = txt_ten.Text,
                    SoDienThoai = txt_sodienthoai.Text,
                    Email = txt_email.Text,
                    DiaChi = txt_diachi.Text,
                };
                if (!_services.UpdateKhachHang(kh))
                {
                    MessageBox.Show("Trùng Thông Tin");
                }
                LoadAsync();
            }
           
        }

        private void dtg_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var chon = dtg_khachhang.Rows[index];
            if (index >= 0)
            {
                txt_ten.Text = chon.Cells[1].Value.ToString();
                txt_sodienthoai.Text = chon.Cells[2].Value.ToString();
                txt_email.Text = chon.Cells[3].Value.ToString();
                txt_diachi.Text = chon.Cells[4].Value.ToString();
                selectedid = Convert.ToInt32(chon.Cells[0].Value);
            }
        }
        public bool CheckThongTinNhap()
        {
            if (String.IsNullOrEmpty(txt_ten.Text))
            {
                MessageBox.Show("Hay Nhap Ten");
                return false;
            }
            if (String.IsNullOrEmpty(txt_sodienthoai.Text))
            {
                MessageBox.Show("Hay Nhap So Dien Thoai");
                return false;
            }
            if (String.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Hay Nhap Emaail");
                return false;
            }
            if (String.IsNullOrEmpty(txt_diachi.Text))
            {
                MessageBox.Show("Hay Nhap Dia Chi");
                return false;
            }

            return true;
        }
        public bool CheckText()
        {
            bool isValid = true;
            var ten = ValidateText.CheckTen(txt_ten.Text);
            switch (ten)
            {
                case ValidateText.Vali.KoDuThongTin:
                    lb_erten.Text = "Hãy Nhập Nhiều Hơn 6 Chữ";
                    isValid = false;
                    break;
                case ValidateText.Vali.KoDcDeTrong:
                    lb_erten.Text = "Không Được Để Trống Thông Tin";
                    isValid = false;
                    break;
                case ValidateText.Vali.ChinhXac:
                    lb_erten.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }

            var sdt = ValidateText.CheckSDT(txt_sodienthoai.Text);
            switch (sdt)
            {
                case ValidateText.Vali.KoPhaiSo:
                    lb_ersdt.Text = "Hãy Nhập Số";
                    isValid = false;
                    break;
                case ValidateText.Vali.KoDcDeTrong:
                    lb_ersdt.Text = "Không Được Để Trống Thông Tin";
                    isValid = false;
                    break;
                case ValidateText.Vali.KoDuThongTin:
                    lb_ersdt.Text = "Hãy Nhập Đủ 10 số";
                    isValid = false;
                    break;
                case ValidateText.Vali.ChinhXac:
                    lb_ersdt.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }

 
            var email = ValidateText.CheckEmail(txt_email.Text);
            switch (email)  
            {
                case ValidateText.Vali.KoDungEmail:
                    lb_eremail.Text = "Hãy Nhập Đúng Email VD:abc@.gmail.com";
                    isValid = false;
                    break;
                case ValidateText.Vali.KoDcDeTrong:
                    lb_eremail.Text = "Không Được Để Trống Thông Tin";
                    isValid = false;
                    break;
                case ValidateText.Vali.KoDungDomain:
                    lb_eremail.Text = "Hãy Nhập Domain Thật VD:Email,Gmail,Yahoo,...";
                    isValid = false;
                    break;
                case ValidateText.Vali.ChinhXac:
                    lb_eremail.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }
            var diachi = ValidateText.CheckMayCaiDaiDong(txt_diachi.Text);
            switch (diachi)
            {
                case ValidateText.Vali.KoDcDeTrong:
                    lb_erdiachi.Text = "Không Được Để Trống Thông Tin";
                    isValid = false;
                    break;
                case ValidateText.Vali.KoDuThongTin:
                    lb_erdiachi.Text = "Hãy Điền Nhiều Hơn 10 Ký Tự";
                    isValid = false;
                    break;
                case ValidateText.Vali.ChinhXac:
                    lb_erdiachi.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }

            return isValid;

        }

    }
}
