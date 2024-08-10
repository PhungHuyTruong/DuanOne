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
    public partial class KichCo2 : Form
    {
        private readonly IChucNangThuocTinh ser1;
        private int seletedid;
        public KichCo2(IChucNangThuocTinh service1)
        {
            InitializeComponent();
            ser1 = service1;
            LoadDataGrid3(ser1.GetAllKichCo());
        }

        private void LoadDataGrid3(IEnumerable<KichCo> kichCos)
        {
            dtg_kichco1.Rows.Clear();
            dtg_kichco1.ColumnCount = 2;
            dtg_kichco1.Columns[0].Name = "IdKichCo";
            dtg_kichco1.Columns[0].Visible = false;
            dtg_kichco1.Columns[1].Name = "KichCo1";
            foreach (KichCo kichCo in kichCos)
            {
                dtg_kichco1.Rows.Add(kichCo.IdKichCo, kichCo.KichCo1);
            }
        }

        private void dtg_kichco1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                var kichcoht = dtg_kichco1.Rows[index];
                var cellvalue = Enumerable.Range(0, kichcoht.Cells.Count)
                                          .ToDictionary(i => $"{i}", i => kichcoht.Cells[i].Value ?? "null");
                if (cellvalue.ContainsKey("0") && int.TryParse(cellvalue["0"].ToString(), out int parsedId))
                {
                    seletedid = parsedId;
                }
                else
                {
                    seletedid = 0;
                }

                txt_kichco.Text = cellvalue.ContainsKey("1") ? cellvalue["1"].ToString() : string.Empty;
            }
        }

        private void btn_add12_Click(object sender, EventArgs e)
        {
            var kichco = Convert.ToInt32(txt_kichco.Text);

            if (!ser1.CreateKichCoSP(kichco))
            {
                MessageBox.Show("Bị Trùng Thông Tin");
                return;
            }

            LoadDataGrid3(ser1.GetAllKichCo());
        }

        private void btn_sua12_Click(object sender, EventArgs e)
        {
            var id = seletedid;
            var kichco = Convert.ToInt32(txt_kichco.Text);
            if (!ser1.UpdateKichCoSP(id, kichco))
            {
                MessageBox.Show("Bị Trùng Thông Tin");
                return;
            }
            LoadDataGrid3(ser1.GetAllKichCo());
        }


        private void txt_timkiemkichco_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string timkiem = txt_timkiemkichco.Text;
                var result = ser1.TimKiemKichCo(timkiem);

                if (result == null || !result.Any())
                {
                    MessageBox.Show("No data found.");
                }
                else
                {
                    LoadDataGrid3(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching KichCo: {ex.Message}");
            }
        }
    }
}
