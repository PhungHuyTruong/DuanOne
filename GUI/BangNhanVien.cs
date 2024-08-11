
    using DAL.Models;
    using BUS.IService;
    using System.Diagnostics.Eventing.Reader;

    namespace GUI
    {
    public partial class BangNhanVien : Form
    {
        private string _currentAvatarPath;
        private int selectedid = -1;
        private readonly IChucNangNhanVien _chucNang;
        public BangNhanVien(IChucNangNhanVien chucNang)
        {
            _chucNang = chucNang;
            InitializeComponent();
            loaddatagrid(_chucNang.GetAllNhanVien());
        }
        public void loaddatagrid(IEnumerable<NhanVien> data)
        {
            dtg_nhanvien.Rows.Clear();
            dtg_nhanvien.ColumnCount = 13;
            dtg_nhanvien.Columns[0].Name = "ID";
            dtg_nhanvien.Columns[0].Visible = false;
            dtg_nhanvien.Columns[1].Name = "RoleID";
            dtg_nhanvien.Columns[2].Name = "Role";
            dtg_nhanvien.Columns[3].Name = "Name";
            dtg_nhanvien.Columns[4].Name = "DateOfBirth";
            dtg_nhanvien.Columns[5].Name = "Gender";
            dtg_nhanvien.Columns[6].Name = "Email";
            dtg_nhanvien.Columns[7].Name = "PhoneNumber";
            dtg_nhanvien.Columns[8].Name = "Address";
            dtg_nhanvien.Columns[9].Name = "RegistrationDate";
            dtg_nhanvien.Columns[10].Name = "Avatar";
            dtg_nhanvien.Columns[10].Visible = true;
            dtg_nhanvien.Columns[11].Name = "Pass";
            dtg_nhanvien.Columns[11].Visible = false;
            dtg_nhanvien.Columns[12].Name = "TrangThai";
            foreach (NhanVien nv in data)
            {
                dtg_nhanvien.Rows.Add(
                    nv.UserId,
                    nv.RoleId,
                    nv.Role,
                    nv.Name,
                    nv.DateOfBirth.ToString("yyyy-MM-dd"),
                    nv.Gender,
                    nv.Email,
                    nv.PhoneNumber,
                    nv.Address,
                    nv.RegistrationDate?.ToString("yyyy-MM-dd"),
                    nv.Avatar,
                    nv.Password,
                    nv.TrangThai
                );
            }
        }

        private void dtg_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var selecteduser = dtg_nhanvien.Rows[index];
            //Dictionary<string, object> cellvalue = new Dictionary<string, object>();
            //cellvalue.Add("cell0", selecteduser.Cells[0].Value);
            //cellvalue.Add("cell1", selecteduser.Cells[1].Value);
            //cellvalue.Add("cell2", selecteduser.Cells[2].Value);
            //cellvalue.Add("cell3", selecteduser.Cells[3].Value);
            //cellvalue.Add("cell4", selecteduser.Cells[4].Value);
            //cellvalue.Add("cell5", selecteduser.Cells[5].Value);
            //cellvalue.Add("cell6", selecteduser.Cells[6].Value);
            //cellvalue.Add("cell7", selecteduser.Cells[7].Value);
            //cellvalue.Add("cell8", selecteduser.Cells[8].Value);
            //cellvalue.Add("cell9", selecteduser.Cells[9].Value);
            //cellvalue.Add("cell10", selecteduser.Cells[10].Value);
            //cellvalue.Add("cell11", selecteduser.Cells[11].Value);
            //foreach (var cells in cellvalue)
            //{
            //    if (cells.Value is null)
            //    {
            //        cellvalue[cells.Key] = "null";
            //    }
            //}
            //
           



            var cellvalue = Enumerable.Range(0, selecteduser.Cells.Count)
            .ToDictionary(i => $"cell{i}", i => selecteduser.Cells[i].Value ?? "null");
            //

            if (index >= 0)
            {
                string imgpath = cellvalue["cell10"] != null ? cellvalue["cell10"].ToString() : string.Empty;
                pt_avater.Image = FileManager.PicManager.LoadAvatar(imgpath);
                _currentAvatarPath = imgpath;
                txt_ten.Text = cellvalue["cell3"].ToString();
                txt_roleid.Text = cellvalue["cell1"].ToString();
                cbb_role.SelectedItem = cellvalue["cell2"].ToString();
                if (cellvalue["cell5"].ToString() == "Nam") { rb_nam.Checked = true; }
                else { rb_nu.Checked = true; }
                txt_ngaysinh.Text = cellvalue["cell4"].ToString();
                txt_email.Text = cellvalue["cell6"].ToString();
                txt_sodienthoai.Text = cellvalue["cell7"].ToString();
                txt_diachi.Text = cellvalue["cell8"].ToString();
                txt_ngayvaolam.Text = cellvalue["cell9"].ToString();
                txt_password.Text = cellvalue["cell11"].ToString();
                selectedid = Convert.ToInt32(cellvalue["cell0"].ToString());
                if (Convert.ToBoolean(cellvalue["cell12"]) == false) {rb_thoilam.Checked = true;}
                else { rb_conlam.Checked = true;}
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var existingNhanVien = _chucNang.GetAllNhanVien().FirstOrDefault(nv => nv.Name.Equals(txt_ten.Text, StringComparison.OrdinalIgnoreCase) && nv.UserId != selectedid);
            if (existingNhanVien != null)
            {
                MessageBox.Show("Tên nhân viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingEmail = _chucNang.GetAllNhanVien().FirstOrDefault(nv => nv.Email.Equals(txt_email.Text, StringComparison.OrdinalIgnoreCase) && nv.UserId != selectedid);
            if (existingEmail != null)
            {
                MessageBox.Show("Email đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CheckText1())
            {
                var nhanvienthem = _chucNang.GetNhanVienByID(selectedid);
                nhanvienthem.Name = txt_ten.Text;
                nhanvienthem.DateOfBirth = DateOnly.Parse(txt_ngaysinh.Text);

                if (rb_nam.Checked == true) { nhanvienthem.Gender = "Nam"; }
                else if (rb_nu.Checked == true) { nhanvienthem.Gender = "Nữ"; }
                nhanvienthem.Email = txt_email.Text;
                nhanvienthem.PhoneNumber = txt_sodienthoai.Text;
                nhanvienthem.Address = txt_diachi.Text;
                nhanvienthem.Role = cbb_role.SelectedItem.ToString();
                if (_currentAvatarPath != null && _currentAvatarPath != nhanvienthem.Avatar)
                {
                    FileManager.PicManager.DeleteAvatar(nhanvienthem.Avatar); // Delete old avatar
                    nhanvienthem.Avatar = _currentAvatarPath;
                }
                nhanvienthem.Password = txt_password.Text;
                nhanvienthem.TrangThai = rb_conlam.Checked;

                _chucNang.UpdateNhanVien(nhanvienthem);
                loaddatagrid(_chucNang.GetAllNhanVien());
                _currentAvatarPath = null;
            }


        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            _currentAvatarPath = null;
            selectedid = -1;
            pt_avater.Image = null;
            txt_ten.Text = null;
            txt_roleid.Text = null;
            cbb_role.SelectedItem = null;
            rb_nam.Checked = false;
            rb_nu.Checked = false;
            txt_ngaysinh.Text = null;
            txt_sodienthoai.Text = null;
            txt_diachi.Text = null;
            txt_ngayvaolam.Text = null;
            txt_password.Text = null;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var existingNhanVien = _chucNang.GetAllNhanVien().FirstOrDefault(nv => nv.Name.Equals(txt_ten.Text, StringComparison.OrdinalIgnoreCase) && nv.UserId != selectedid);
            if (existingNhanVien != null)
            {
                MessageBox.Show("Tên nhân viên đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingEmail = _chucNang.GetAllNhanVien().FirstOrDefault(nv => nv.Email.Equals(txt_email.Text, StringComparison.OrdinalIgnoreCase) && nv.UserId != selectedid);
            if (existingEmail != null)
            {
                MessageBox.Show("Email đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CheckText1())
            {
                var nhanvienthem = new NhanVien
                {
                    Name = txt_ten.Text ?? "",
                    DateOfBirth = DateOnly.TryParse(txt_ngaysinh.Text, out var dob) ? dob : DateOnly.FromDateTime(DateTime.Now),
                    Gender = rb_nam.Checked ? "Nam" : (rb_nu.Checked ? "Nữ" : ""),
                    Email = txt_email.Text ?? "",
                    PhoneNumber = txt_sodienthoai.Text ?? "",
                    Address = txt_diachi.Text ?? "",
                    Role = cbb_role.SelectedItem?.ToString() ?? "",
                    RoleId = null,
                    RegistrationDate = DateOnly.FromDateTime(DateTime.Now),
                    Avatar = _currentAvatarPath,
                    Password = txt_password.Text ?? ""
                };
                if (_chucNang.KiemTraTrungData(nhanvienthem) is true)
                {
                    _chucNang.CreateNhanVien(nhanvienthem);
                    _currentAvatarPath = null;
                }
                else { MessageBox.Show("bi trung data"); }

                loaddatagrid(_chucNang.GetAllNhanVien());
            }

        }


        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txt_timkiem.Text;
            loaddatagrid(_chucNang.FindNhanVien(timkiem));
        }

        private void btn_uploadanh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Title = "Select an Avatar Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _currentAvatarPath = FileManager.PicManager.SaveAvatar(openFileDialog.FileName);
                    pt_avater.Image = FileManager.PicManager.LoadAvatar(_currentAvatarPath);
                }
            }
        }
        public bool CheckText1()
        {
            bool isValid = true;
            var ten = Validate1.CheckTen(txt_ten.Text);
            switch (ten)
            {
                case Validate1.Vali1.KoDuThongTin:
                    Ib_erhoten.Text = "Hãy Nhập Nhiều Hơn 6 Chữ";
                    isValid = false;
                    break;
                case Validate1.Vali1.KoDcDeTrong:
                    Ib_erhoten.Text = "Không Được Để Trống Thông Tin";
                    isValid = false;
                    break;
                case Validate1.Vali1.ChinhXac:
                    Ib_erhoten.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }
            var sdt = Validate1.CheckPhoneNumber(txt_sodienthoai.Text);
            switch (sdt)
            {
                case Validate1.Vali1.KoDungSoDienThoai:
                    Id_ersdt.Text = "Hãy Nhập Đúng Kiểu Số Điện Thoại";
                    isValid = false;
                    break;
                case Validate1.Vali1.KoDcDeTrong:
                    Id_ersdt.Text = "Không Được Để Trống Thông Tin";
                    isValid = false;
                    break;
                case Validate1.Vali1.ChinhXac:
                    Id_ersdt.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }

            if (DateTime.TryParse(txt_ngaysinh.Text, out DateTime ngaySinhDateTime))
            {
                var ngaySinh = Validate1.CheckNgaySinh(DateOnly.FromDateTime(ngaySinhDateTime));

                switch (ngaySinh)
                {
                    case Validate1.Vali1.KoDcDeTrong:
                        Id_erngaysinh.Text = "Không Được Để Trống Ngày Sinh";
                        isValid = false;
                        break;
                    case Validate1.Vali1.NgaySinhKoHopLe:
                        Id_erngaysinh.Text = "Ngày Sinh Không Hợp Lệ";
                        isValid = false;
                        break;
                    case Validate1.Vali1.ChinhXac:
                        Id_erngaysinh.Text = "";
                        break;
                    default:
                        isValid = false;
                        break;
                }
            }
            else
            {
                Id_erngaysinh.Text = "Định Dạng Ngày Sinh Không Hợp Lệ";
                isValid = false;
            }



            var email = Validate1.CheckEmail(txt_email.Text);
            switch (email)
            {
                case Validate1.Vali1.KoDungEmail:
                    Id_eremail.Text = "Hãy Nhập Đúng Email VD:abc@.gmail.com";
                    isValid = false;
                    break;
                case Validate1.Vali1.KoDcDeTrong:
                    Id_eremail.Text = "Không Được Để Trống Thông Tin";
                    isValid = false;
                    break;
                case Validate1.Vali1.KoDungDomain:
                    Id_eremail.Text = "Hãy Nhập Domain Thật VD:Email,Gmail,Yahoo,...";
                    isValid = false;
                    break;
                case Validate1.Vali1.ChinhXac:
                    Id_eremail.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }

            var diachi = Validate1.CheckDiaChi(txt_diachi.Text);
            switch (diachi)
            {
                case Validate1.Vali1.KoDcDeTrong:
                    Id_erdiachi.Text = "Không Được Để Trống Thông Tin";
                    isValid = false;
                    break;
                case Validate1.Vali1.ChinhXac:
                    Id_erdiachi.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }

            var matkhau = Validate1.CheckPassword(txt_password.Text);
            switch (matkhau)
            {
                case Validate1.Vali1.KoDcDeTrong:
                    lb_pass.Text = "Không Được Để Trống Thông Tin";
                    isValid = false;
                    break;
                case Validate1.Vali1.KoDungMatKhau:
                    lb_pass.Text = "Không đúng định dạng mật khẩu phải từ 6 kí tự trở lên và có ít nhất 1 số";
                    isValid = false;
                    break;
                case Validate1.Vali1.ChinhXac:
                    lb_pass.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }
            var gioitinh = Validate1.CheckRadioButtonSelected(rb_nam, rb_nu);
            switch (gioitinh)
            {
                case Validate1.Vali1.KoDcDeTrong:
                    lb_gioitinh.Text = "Bạn phải chọn ít nhất một tùy chọn";
                    isValid = false;
                    break;
                case Validate1.Vali1.ChinhXac:
                    lb_gioitinh.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }
            var lam = Validate1.CheckRadioButtonSelected(rb_conlam, rb_thoilam);
            switch (lam)
            {
                case Validate1.Vali1.KoDcDeTrong:
                    lb_lam.Text = "Bạn phải chọn ít nhất một tùy chọn";
                    isValid = false;
                    break;
                case Validate1.Vali1.ChinhXac:
                    lb_lam.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }
            var comboBox = Validate1.CheckComboBoxSelected(cbb_role);
            switch (comboBox)
            {
                case Validate1.Vali1.KoDcDeTrong:
                    lb_chucvu.Text = "Bạn phải chọn một mục trong danh sách";
                    isValid = false;
                    break;
                case Validate1.Vali1.ChinhXac:
                    lb_chucvu.Text = "";
                    break;
                default:
                    isValid = false;
                    break;
            }


            return isValid;

        }

    }
}
