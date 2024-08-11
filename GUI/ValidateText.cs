using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public class ValidateText
    {
        public enum Validate
        {
            ChinhXac,
            KoDcDeTrong,
            KoDuThongTin,
            KoDungDuLieuNhap,
            KoDungEmail,
            KoDungDomain,
            KoPhaiSo,

        }
        static Validate CheckTen(TextBox text)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                return Validate.KoDcDeTrong;
            }
            if(text.Text.Length <= 6)
            {
                return Validate.KoDuThongTin;
            }
            return Validate.ChinhXac;
        }
        static Validate CheckSo(TextBox text)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                return Validate.KoDcDeTrong;
            }
            if(!int.TryParse(text.Text,out int result))
            {
                return Validate.KoPhaiSo;
            }
            if(text.Text.Length < 1)
            {
                return Validate.KoDuThongTin;
            }
            return Validate.ChinhXac;
        }
        static Validate CheckSDT(TextBox text)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                return Validate.KoDcDeTrong;
            }
            if (!int.TryParse(text.Text, out int result))
            {
                return Validate.KoPhaiSo;
            }
            if (text.Text.Length != 10)
            {
                return Validate.KoDuThongTin;
            }
            return Validate.ChinhXac;
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
        static Validate CheckEmail(TextBox text)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                return Validate.KoDcDeTrong;
            }
            if (!ValidEmail(text.Text))
            {
                return Validate.KoDungEmail;
            }
            if (!ValidDomain(text.Text))
            {
                return Validate.KoDungDomain;
            }
            return Validate.ChinhXac;
        }
        static Validate CheckMayCaiDaiDong(TextBox text)
        {
            if (string.IsNullOrEmpty(text.Text))
            {
                return Validate.KoDcDeTrong;
            }
            if (text.Text.Length <= 10)
            {
                return Validate.KoDuThongTin;
            }
            return Validate.ChinhXac;
        }
    }
}
