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

namespace GUI
{
    public partial class Hang : Form
    {
        private readonly IChucNangThuocTinh ser;
        private int seletedid;
        public Hang(IChucNangThuocTinh service)
        {
            InitializeComponent();
            ser = service;
            LoadDataGrid1(ser.GetAllHang());
        }
        public void LoadDataGrid1(IEnumerable<HangSanPham> hangSanPhams)
        {
            dtg_hang1.Rows.Clear();
            dtg_hang1.ColumnCount = 3;
            dtg_hang1.Columns[0].Name = "IdHang";
            dtg_hang1.Columns[0].Visible = false;
            dtg_hang1.Columns[1].Name = "TenHang";
            dtg_hang1.Columns[2].Name = "DiaChi";
            foreach (HangSanPham hsp in hangSanPhams)
            {
                dtg_hang1.Rows.Add(hsp.IdHang,
                                        hsp.TenHang,
                                        hsp.DiaChi
                                        );
            }
        }

        private void dtg_hang1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                var hanghientai = dtg_hang1.Rows[index];
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

                txt_tenhang1.Text = cellvalue.ContainsKey("1") ? cellvalue["1"].ToString() : string.Empty;
                txt_diachi1.Text = cellvalue.ContainsKey("2") ? cellvalue["2"].ToString() : string.Empty;
            }
        }

        private void btn_add10_Click(object sender, EventArgs e)
        {
            var ten = txt_tenhang1.Text;
            var diachi = txt_diachi1.Text;

            if (!ser.CreateHangSP(ten, diachi))
            {
                MessageBox.Show("Bị Trùng Thông Tin");
                return;
            }

            LoadDataGrid1(ser.GetAllHang());
        }

        private void btn_sua10_Click(object sender, EventArgs e)
        {
            var id = seletedid;
            var ten = txt_tenhang1.Text;
            var diachi = txt_diachi1.Text;
            if (!ser.UpdateHangSP(id, ten, diachi))
            {
                MessageBox.Show("Bị Trùng Thông Tin");
                return;
            }
            LoadDataGrid1(ser.GetAllHang());
        }

        private void txt_timkiemhang_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txt_timkiemhang.Text;
            LoadDataGrid1(ser.TimKiemHang(timkiem));
        }
    }
}
