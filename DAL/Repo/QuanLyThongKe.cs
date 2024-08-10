using DAL.IRepo;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class QuanLyThongKe : IQuanLyThongKe
    {
        private readonly ShopSanPhamContext _context;
        public QuanLyThongKe(ShopSanPhamContext context)
        {
            _context = context;
        }

        public void Add(HoaDon entity)
        {
            _context.HoaDons.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<HoaDon> Find(Expression<Func<HoaDon, bool>> predicate)
        {
            return _context.HoaDons.Where(predicate).ToList();
        }

        public HoaDon Get(int id)
        {
            return _context.HoaDons.Find(id);
        }

        public void Remove(HoaDon entity)
        {
            _context.HoaDons.Remove(entity);
            _context.SaveChanges();
        }
        public List<HoaDon> LayHoaDonsTheoNgay(DateTime startDate, DateTime endDate) // Thay đổi tên
        {
            return _context.HoaDons
                           .Include(hd => hd.HoaDonChiTiets)
                           .ThenInclude(ct => ct.IdSanPhamNavigation)
                           .Where(hd => hd.NgayTao >= startDate && hd.NgayTao <= endDate)
                           .ToList();
        }

        public decimal LayTongTienTheoNgay(DateTime startDate, DateTime endDate) // Thay đổi tên
        {
            return _context.HoaDons
                           .Where(hd => hd.NgayTao >= startDate && hd.NgayTao <= endDate)
                           .Sum(hd => hd.TongTien);
        }
    }
}
