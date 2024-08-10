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
    public class QuanLyKhoHang : IQuanLyKhoHang
    {
        private readonly ShopSanPhamContext _context;
        public QuanLyKhoHang(ShopSanPhamContext context) { _context = context; }

        public bool Create(SanPham sanpham)
        {
            try
            {
                _context.SanPhams.Add(sanpham);
                int rowsAffected = _context.SaveChanges();
                return rowsAffected > 0;
            }
            catch (Exception)
            {
                return false;
            }
          
        }
        public SanPham GetByID(int id)
        {
            return _context.SanPhams.Find(id);
        }

        public bool Update(SanPham sanpham)
        {
            try
            {
                _context.SanPhams.Update(sanpham);
                int rowsAffected = _context.SaveChanges();
                return rowsAffected > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<SanPham> Find(Func<SanPham, bool> predicate)
        {
            return _context.SanPhams.Include(gg => gg.IdGiamGiaNavigation)
                                    .Include(h => h.IdHangNavigation)
                                    .Include(gt => gt.IdGioiTinhNavigation)
                                    .Include(kc => kc.KichCoNavigation)
                                    .Include(ms => ms.MauSacNavigation)
                                    .Where(predicate)
                                    .ToList();
        }

        public IEnumerable<SanPham> GetAll()
        {
            return _context.SanPhams.Include(gg => gg.IdGiamGiaNavigation)
                                    .Include(h => h.IdHangNavigation)
                                    .Include(gt => gt.IdGioiTinhNavigation)
                                    .Include(kc => kc.KichCoNavigation)
                                    .Include(ms => ms.MauSacNavigation)
                                    .ToList();
        }

        public IEnumerable<GiamGium> GetAllGiamGia()
        {
           return _context.GiamGia.ToList();
        }

        public IEnumerable<GioiTinh> GetAllGioiTinh()
        {
            return _context.GioiTinhs.ToList();
        }

        public IEnumerable<HangSanPham> GetAllHangSP()
        {
            return _context.HangSanPhams.ToList();
        }

        public IEnumerable<KichCo> GetAllKichCo()
        {
            return _context.KichCos.ToList();
        }

        public IEnumerable<MauSac> GetAllMauSac()
        {
            return _context.MauSacs.ToList();
        }

 
    }
}
