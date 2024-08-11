using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public class ValidateText
    {
        public enum Vali
        {
            ChinhXac,
            KoDcDeTrong,
            KoDuThongTin,
            KoDungDuLieuNhap,
            KoDungEmail,
            KoDungDomain,
            KoPhaiSo,
            KoChinhXac,
            KoDcGhiKyTuDacBiet,
            ItTien

        }
        public static Vali CheckTen(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Vali.KoDcDeTrong;
            }
            if(text.Length <= 6)
            {
                return Vali.KoDuThongTin;
            }
            return Vali.ChinhXac;
        }
        public static Vali CheckMayCaiNgan(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Vali.KoDcDeTrong;
            }
            if (text.Length <= 2)
            {
                return Vali.KoDuThongTin;
            }
            return Vali.ChinhXac;
        }
        public static Vali CheckSo(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Vali.KoDcDeTrong;
            }
            if(!int.TryParse(text,out int result))
            {
                return Vali.KoPhaiSo;
            }
            return Vali.ChinhXac;
        }
        public static Vali CheckSDT(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Vali.KoDcDeTrong;
            }
            if (!int.TryParse(text, out int result))
            {
                return Vali.KoPhaiSo;
            }
            if (text.Length != 10)
            {
                return Vali.KoDuThongTin;
            }
            return Vali.ChinhXac;
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
        public static Vali CheckEmail(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Vali.KoDcDeTrong;
            }
            if (!ValidEmail(text))
            {
                return Vali.KoDungEmail;
            }
            if (!ValidDomain(text))
            {
                return Vali.KoDungDomain;
            }
            return Vali.ChinhXac;
        }
        public static Vali CheckMayCaiDaiDong(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Vali.KoDcDeTrong;
            }
            if (text.Length <= 10)
            {
                return Vali.KoDuThongTin;
            }
            return Vali.ChinhXac;
        }
        private  static bool CheckKyTuDacBiet(string input)
        {
            string pattern = @"[!@#$%^&*()_+{}\[\]:;""'<>,.?/\\|`~]";
            return Regex.IsMatch(input, pattern);
        }
        public static Vali CheckBarcode(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Vali.KoDcDeTrong;
            }
            if (text.Trim().Length != 8)
            {
                return Vali.KoDuThongTin;
            }
            if (CheckKyTuDacBiet(text))
            {
                return Vali.KoDcGhiKyTuDacBiet;
            }
            return Vali.ChinhXac;
        }
        public static Vali CheckGiaTien(string text)
        {

            if (string.IsNullOrEmpty(text))
            {
                return Vali.KoDcDeTrong;
            }
            if (!int.TryParse(text, out int result))
            {
                return Vali.KoPhaiSo;
            }
            if(result < 10000)
            {
                return Vali.ItTien;
            }
            return Vali.ChinhXac;
        }
    }
}
