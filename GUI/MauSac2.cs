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
    public partial class MauSac2 : Form
    {
        private readonly IChucNangThuocTinh ser;
        private int seletedid;
        public MauSac2(IChucNangThuocTinh service)
        {
            InitializeComponent();
            ser = service;
            LoadDataGrid2(ser.GetAllMauSac());
        }
        public void LoadDataGrid2(IEnumerable<MauSac> mauSacs)
        {
            dtg_mausac1.Rows.Clear();
            dtg_mausac1.ColumnCount = 2;
            dtg_mausac1.Columns[0].Name = "IdMau";
            dtg_mausac1.Columns[0].Visible = false;
            dtg_mausac1.Columns[1].Name = "TenMau";
            foreach (MauSac mc in mauSacs)
            {
                dtg_mausac1.Rows.Add(mc.IdMau,
                                        mc.MauSac1
                                        );
            }
        }


        private void txt_timkiemmausac_TextChanged_1(object sender, EventArgs e)
        {
            string timkiem = txt_timkiemmausac.Text;
            LoadDataGrid2(ser.TimKiemMau(timkiem));
        }

        private void btn_add13_Click_1(object sender, EventArgs e)
        {
            var ten = txt_mausac1.Text;

            if (!ser.CreateMauSacSP(ten))
            {
                MessageBox.Show("Bị Trùng Thông Tin");
                return;
            }

            LoadDataGrid2(ser.GetAllMauSac());
        }

        private void btn_sua13_Click_1(object sender, EventArgs e)
        {
            var id = seletedid;
            var ten = txt_mausac1.Text;
            if (!ser.UpdateMauSacSP(id, ten))
            {
                MessageBox.Show("Bị Trùng Thông Tin");
                return;
            }
            LoadDataGrid2(ser.GetAllMauSac());
        }

        private void dtg_mausac1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                var mausacht = dtg_mausac1.Rows[index];
                var cellvalue = Enumerable.Range(0, mausacht.Cells.Count)
                                          .ToDictionary(i => $"{i}", i => mausacht.Cells[i].Value ?? "null");
                if (cellvalue.ContainsKey("0") && int.TryParse(cellvalue["0"].ToString(), out int parsedId))
                {
                    seletedid = parsedId;
                }
                else
                {
                    seletedid = 0;
                }

                txt_mausac1.Text = cellvalue.ContainsKey("1") ? cellvalue["1"].ToString() : string.Empty;
            }
        }
    }
}
