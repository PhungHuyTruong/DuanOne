using DAL.IRepo;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class QuanLyKhachHang : IQuanLyKhachHang
    {
        private readonly ShopSanPhamContext _context;
        public QuanLyKhachHang(ShopSanPhamContext context)
        {
            _context = context;
        }

        public bool AddKhachHang(KhachHang kh)
        {
            if (ChecKThongTinTrung(kh.Email, kh.SoDienThoai))
            {
                _context.KhachHangs.Add(kh);
                int change = _context.SaveChanges();
                return change > 0;
            }
            else 
            {
                return false;
            }
           
        }

        public async Task<IEnumerable<KhachHang>> GetAllKHachHang()
        {
            return await _context.KhachHangs.ToListAsync();
        }

        public KhachHang GetKhachHang(string sdt)
        {
            return _context.KhachHangs.FirstOrDefault(kh => kh.SoDienThoai == sdt);
        }

        public bool UpdateKhachHang(KhachHang kh)
        {
            if (ChecKThongTinTrung(kh.Email, kh.SoDienThoai)) 
            {
                var khach = _context.KhachHangs.Find(kh.IdKhachHang);
                khach.Ten = kh.Ten;
                khach.SoDienThoai = kh.SoDienThoai;
                khach.DiaChi = kh.DiaChi;
                khach.Email = kh.Email;

                _context.KhachHangs.Update(khach);
                int change = _context.SaveChanges();
                return change > 0;
            }
            else
            {
                return false;
            }
        
        }
        private bool ChecKThongTinTrung(string email,string sdt)
        {
            var khach = _context.KhachHangs.ToList();
            foreach (var item    in khach)
            {
                if (item.Email == email || item.SoDienThoai == sdt)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
