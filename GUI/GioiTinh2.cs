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
    public partial class GioiTinh2 : Form
    {
        private readonly IChucNangThuocTinh ser;
        private int seletedid;
        public GioiTinh2(IChucNangThuocTinh service)
        {
            InitializeComponent();
            ser = service;
            LoadDataGrid4(ser.GetAllGioiTinh());
        }

        public void LoadDataGrid4(IEnumerable<GioiTinh> gioiTinhs)
        {
            dtg_gioitinh1.Rows.Clear();
            dtg_gioitinh1.ColumnCount = 2;
            dtg_gioitinh1.Columns[0].Name = "IdGioiTinh";
            dtg_gioitinh1.Columns[0].Visible = false;
            dtg_gioitinh1.Columns[1].Name = "GioiTinh";
            foreach (GioiTinh gt in gioiTinhs)
            {
                dtg_gioitinh1.Rows.Add(gt.IdGioiTinh,
                                        gt.TenGioiTinh
                                        );
            }
        }

        private void dtg_gioitinh1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                var hanghientai = dtg_gioitinh1.Rows[index];
                var cellvalue = Enumerable.Range(0, hanghientai.Cells.Count)
                                          .ToDictionary(i => $"{i}", i => hanghientai.Cells[i].Value ?? "null");
                if (cellvalue.ContainsKey("0") && int.TryParse(cellvalue["0"].ToString(), out int parsedId))
                {
                    seletedid = parsedId;
                }
                else
                {
                    seletedid = 0;
                }

                txt_gioitinh.Text = cellvalue.ContainsKey("1") ? cellvalue["1"].ToString() : string.Empty;
            }
        }

        private void btn_add11_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            var ten = txt_gioitinh.Text;
            var existingGioiTinh = ser.TimKiemGioiTinh(ten);
            if (existingGioiTinh != null && existingGioiTinh.Any())
            {
                MessageBox.Show("Giới tính này đã tồn tại.");
                return;
            }

            if (!ser.CreateGioiTinhSP(ten))
            {
                MessageBox.Show("Bị Trùng Thông Tin");
                return;
            }

            LoadDataGrid4(ser.GetAllGioiTinh());
        }

        private void btn_sua11_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            var id = seletedid;
            var ten = txt_gioitinh.Text;
            var existingGioiTinh = ser.TimKiemGioiTinh(ten);
            if (existingGioiTinh != null && existingGioiTinh.Any(gg => gg.IdGioiTinh != id))
            {
                MessageBox.Show("Giới tính này đã tồn tại.");
                return;
            }
            if (!ser.UpdateGioiTinhSP(id, ten))
            {
                MessageBox.Show("Bị Trùng Thông Tin");
                return;
            }
            LoadDataGrid4(ser.GetAllGioiTinh());
        }

        private void txt_timkiemgioitinh_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txt_timkiemgioitinh.Text;
            LoadDataGrid4(ser.TimKiemGioiTinh(timkiem));
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txt_gioitinh.Text))
            {
                MessageBox.Show("Tên giới tính không được để trống.");
                return false;
            }

            return true;
        }
    }
}
