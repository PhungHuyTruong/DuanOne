using BUS.IService;
using BUS.Service;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class GiamGia1 : Form
    {
        private readonly IChucNangThuocTinh ser;
        private int seletedid;
        public GiamGia1(IChucNangThuocTinh service)
        {
            InitializeComponent();
            ser = service;
            LoadDataGrid5(ser.GetAllGiamGia());
            //LoadComboBoxStates();
            LoadComboBoxGG();
        }
        public void LoadDataGrid5(IEnumerable<GiamGium> giamGia)
        {
            dtg_giamgia1.Rows.Clear();
            dtg_giamgia1.ColumnCount = 6;
            dtg_giamgia1.Columns[0].Name = "IdGiamGia";
            dtg_giamgia1.Columns[0].Visible = false;
            dtg_giamgia1.Columns[1].Name = "LoaiGiamGia";
            dtg_giamgia1.Columns[2].Name = "MucGiam";
            dtg_giamgia1.Columns[3].Name = "NgayBatDau";
            dtg_giamgia1.Columns[4].Name = "NgayKetThuc";
            dtg_giamgia1.Columns[5].Name = "TrangThai";
            foreach (GiamGium gg in giamGia)
            {
                dtg_giamgia1.Rows.Add(gg.IdGiamGia,
                                      gg.LoaiGiamGia,
                                      gg.MucGiamGia,
                                      gg.NgayBatDau,
                                      gg.NgayKetThuc,
                                      gg.TrangThai ? "True" : "False");
            }
        }

        private void LoadComboBoxGG()
        {
            cmbx_trangthai2.Items.Clear();
            cmbx_trangthai2.Items.Add("True");
            cmbx_trangthai2.Items.Add("False");
            cmbx_trangthai2.SelectedIndex = 0;
        }

        private void txt_timkiemgiamgia_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string timkiem = txt_timkiemgiamgia.Text;
                var result = ser.TimKiemGiamGia(timkiem);
                LoadDataGrid5(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching GiamGia: {ex.Message}");
            }
        }

        private void btn_add14_Click_1(object sender, EventArgs e)
        {
            var existingGiamGia = ser.GetAllGiamGia().FirstOrDefault(gg => gg.LoaiGiamGia.Equals(txt_loaigiamgia1.Text, StringComparison.OrdinalIgnoreCase) && gg.IdGiamGia != seletedid);
            if (existingGiamGia != null)
            {
                MessageBox.Show("Loại giảm giá đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CheckText2())
            {
                var ten = txt_loaigiamgia1.Text;
                var mucgiam = Convert.ToInt32(txt_mucgiam1.Text);
                var ngaybatdau = DateTime.Parse(txt_ngaybatdau1.Text);
                var ngayketthuc = DateTime.Parse(txt_ngayketthuc2.Text);
                bool trangthai = cmbx_trangthai2.SelectedItem.ToString() == "True";

                if (!ser.CreateGiamGiaSP(ten, mucgiam, ngaybatdau, ngayketthuc, trangthai))
                {
                    MessageBox.Show("Bị Trùng Thông Tin");
                    return;
                }

                LoadDataGrid5(ser.GetAllGiamGia());
            }
        }

        private void btn_sua14_Click(object sender, EventArgs e)
        {
            var existingGiamGia = ser.GetAllGiamGia().FirstOrDefault(gg => gg.LoaiGiamGia.Equals(txt_loaigiamgia1.Text, StringComparison.OrdinalIgnoreCase) && gg.IdGiamGia != seletedid);
            if (existingGiamGia != null)
            {
                MessageBox.Show("Loại giảm giá đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CheckText2())
            {
                var id = seletedid;
                var ten = txt_loaigiamgia1.Text;
                var mucgiam = Convert.ToDecimal(txt_mucgiam1.Text);
                var ngaybatdau = DateTime.Parse(txt_ngaybatdau1.Text);
                var ngayketthuc = DateTime.Parse(txt_ngayketthuc2.Text);
                bool trangthai = cmbx_trangthai2.SelectedItem.ToString() == "True";

                if (!ser.UpdateGiamGiaSP(id, ten, mucgiam, ngaybatdau, ngayketthuc, trangthai))
                {
                    MessageBox.Show("Bị Trùng Thông Tin");
                    return;
                }

                LoadDataGrid5(ser.GetAllGiamGia());
            }
        }

        private void dtg_giamgia1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                var giamgiaht = dtg_giamgia1.Rows[index];
                var cellvalue = Enumerable.Range(0, giamgiaht.Cells.Count)
                                          .ToDictionary(i => $"{i}", i => giamgiaht.Cells[i].Value ?? "null");
                if (cellvalue.ContainsKey("0") && int.TryParse(cellvalue["0"].ToString(), out int parsedId))
                {
                    seletedid = parsedId;
                }
                else
                {
                    seletedid = 0;
                }

                txt_loaigiamgia1.Text = cellvalue.ContainsKey("1") ? cellvalue["1"].ToString() : string.Empty;
                txt_mucgiam1.Text = cellvalue.ContainsKey("2") ? cellvalue["2"].ToString() : string.Empty;
                txt_ngaybatdau1.Text = cellvalue.ContainsKey("3") ? cellvalue["3"].ToString() : string.Empty;
                txt_ngayketthuc2.Text = cellvalue.ContainsKey("4") ? cellvalue["4"].ToString() : string.Empty;
                cmbx_trangthai2.SelectedIndex = cellvalue.ContainsKey("5") && cellvalue["5"].ToString() == "True" ? 0 : 1;
            }
        }

        public bool CheckText2()
        {
            bool isValid = true;
            var ten = Validate1.CheckTen(txt_loaigiamgia1.Text);
            switch (ten)
            {
                case Validate1.Vali1.KoDuThongTin:
                    lb_loaigiamgia.Text = "Hãy Nhập Nhiều Hơn 6 Chữ";
                    isValid = false;
                    break;
                case Validate1.Vali1.KoDcDeTrong:
                    lb_loaigiamgia.Text = "Không Được Để Trống Thông Tin";
                    isValid = false;
                    break;
                case Validate1.Vali1.ChinhXac:
                    lb_loaigiamgia.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }
            var so = Validate1.CheckSo(txt_mucgiam1.Text); 
            switch (so)
            {
                case Validate1.Vali1.KoDcDeTrong:
                    lb_mucgiam.Text = "Không Được Để Trống Thông Tin"; 
                    isValid = false;
                    break;
                case Validate1.Vali1.KoPhaiSo:
                    lb_mucgiam.Text = "Phải Nhập Một Số"; 
                    isValid = false;
                    break;
                case Validate1.Vali1.KoDuThongTin:
                    lb_mucgiam.Text = "Số Phải Lớn Hơn 0 Và Nhỏ Hơn 100"; 
                    isValid = false;
                    break;
                case Validate1.Vali1.ChinhXac:
                    lb_mucgiam.Text = ""; 
                    break;
                default:
                    isValid = false;
                    break;
            }
            if (DateTime.TryParse(txt_ngaybatdau1.Text, out DateTime ngayBatDauDateTime) &&
                DateTime.TryParse(txt_ngayketthuc2.Text, out DateTime ngayKetThucDateTime))
            {
                var ngayBatDauKetThuc = Validate1.CheckNgay(ngayBatDauDateTime, ngayKetThucDateTime);

                switch (ngayBatDauKetThuc)
                {
                    case Validate1.Vali1.KoDcDeTrong:
                        lb_ngaybatdau.Text = "Không Được Để Trống Ngày Bắt Đầu hoặc Ngày Kết Thúc";
                        isValid = false;
                        break;
                    case Validate1.Vali1.NgayBatDauLonHonNgayKetthuc:
                        lb_ngaybatdau.Text = "Ngày Bắt Đầu Phải Nhỏ Hơn Ngày Kết Thúc";
                        isValid = false;
                        break;
                    case Validate1.Vali1.ChinhXac:
                        lb_ngaybatdau.Text = "";
                        break;
                    default:
                        isValid = false;
                        break;
                }
            }
            else
            {
                lb_ngaybatdau.Text = "Định Dạng Ngày Không Hợp Lệ";
                isValid = false;
            }

            var comboBox = Validate1.CheckComboBoxSelected(cmbx_trangthai2);
            switch (comboBox)
            {
                case Validate1.Vali1.KoDcDeTrong:
                    lb_trangthai.Text = "Bạn phải chọn một trạng thái";
                    isValid = false;
                    break;
                case Validate1.Vali1.ChinhXac:
                    lb_trangthai.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }

            return isValid;
        }


        //private void LoadComboBoxStates()
        //{
        //    var items = new List<ComboItem>
        //{
        //new ComboItem { Id = "1", Name = "Hoạt Động" },
        //new ComboItem { Id = "0", Name = "Không Hoạt Động" }
        //};

        //    cmbx_trangthai2.DataSource = items;
        //    cmbx_trangthai2.DisplayMember = "Name";
        //    cmbx_trangthai2.ValueMember = "Id";
        //}

    }
}
