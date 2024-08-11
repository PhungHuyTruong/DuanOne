using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static GUI.ValidateText;

namespace GUI
{
    public class Validate1
    {
        public enum Vali1
        {
            ChinhXac,
            KoDcDeTrong,
            KoDuThongTin,
            KoDungDuLieuNhap,
            KoDungEmail,
            KoDungDomain,
            KoPhaiSo,
            KoChinhXac,
            KoDungSoDienThoai,
            NgaySinhKoHopLe,
            KoDungMatKhau,
            KoDungSoNhapVao,
            NgayBatDauLonHonNgayKetthuc

        }
        public static Vali1 CheckNgaySinh(DateOnly ngaySinh)
        {
            if (ngaySinh == default(DateOnly))
            {
                return Vali1.KoDcDeTrong;
            }

            if (ngaySinh > DateOnly.FromDateTime(DateTime.Now))
            {
                return Vali1.NgaySinhKoHopLe;
            }

            //int tuoi = DateTime.Now.Year - ngaySinh.Year;
            //if (tuoi < 18 || tuoi > 100)
            //{
            //    return Vali1.NgaySinhKoHopLe;
            //}

            return Vali1.ChinhXac;
        }
        public static Vali1 CheckNgay(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            if (ngayBatDau == default(DateTime))
            {
                return Vali1.KoDcDeTrong;
            }
            if (ngayKetThuc == default(DateTime))
            {
                return Vali1.KoDcDeTrong;
            }
            if (ngayBatDau == default(DateTime) || ngayKetThuc == default(DateTime))
            {
                return Vali1.KoDcDeTrong;
            }

            if (ngayBatDau >= ngayKetThuc)
            {
                return Vali1.NgayBatDauLonHonNgayKetthuc;
            }

            return Vali1.ChinhXac;
        }


        public static Vali1 CheckTen(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Vali1.KoDcDeTrong;
            }
            if (text.Length <= 6)
            {
                return Vali1.KoDuThongTin;
            }
            return Vali1.ChinhXac;
        }

        private static bool ValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\d{10,11}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }

        public static Vali1 CheckPhoneNumber(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Vali1.KoDcDeTrong;
            }
            if (!ValidPhoneNumber(text))
            {
                return Vali1.KoDungSoDienThoai;
            }
            return Vali1.ChinhXac;
        }

        private static bool ValidEmail(string email)
        {
            string patern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(patern);
            return regex.IsMatch(email);
        }
        private static bool ValidDomain(string email)
        {
            try
            {
                var address = new MailAddress(email);
                var domain = address.Host;

                var dns = Dns.GetHostEntry(domain);
                return dns.AddressList.Length > 0;
            }
            catch
            {
                return false;
            }
        }

        public static Vali1 CheckEmail(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Vali1.KoDcDeTrong;
            }
            if (!ValidEmail(text))
            {
                return Vali1.KoDungEmail;
            }
            if (!ValidDomain(text))
            {
                return Vali1.KoDungDomain;
            }
            return Vali1.ChinhXac;
        }
        public static Vali1 CheckDiaChi(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Vali1.KoDcDeTrong;
            }
            return Vali1.ChinhXac;
        }
        private static bool ValidPassword(string password)
        {
            string pattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password);
        }
        public static Vali1 CheckPassword(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Vali1.KoDcDeTrong;
            }
            if (!ValidPassword(text))
            {
                return Vali1.KoDungMatKhau;
            }
            return Vali1.ChinhXac;
        }

        public static Vali1 CheckRadioButtonSelected(params RadioButton[] radioButtons)
        {
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    return Vali1.ChinhXac;
                }
            }
            return Vali1.KoDcDeTrong; 
        }
        public static Vali1 CheckComboBoxSelected(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1 || string.IsNullOrEmpty(comboBox.SelectedItem?.ToString()))
            {
                return Vali1.KoDcDeTrong;
            }
            return Vali1.ChinhXac;
        }
        public static Vali1 CheckSo(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Vali1.KoDcDeTrong;
            }
            if (!int.TryParse(text, out int result))
            {
                return Vali1.KoPhaiSo;
            }
            if (result <= 0 || result >= 100)
            {
                return Vali1.KoDuThongTin;
            }
            if (result <= 0 || result >= 100)
            {
                return Vali1.KoDungSoNhapVao;
            }
            return Vali1.ChinhXac;
        }
    }
}
