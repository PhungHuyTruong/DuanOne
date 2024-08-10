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
    public class QuanLyNhanVien : IQuanLyNhanVien
    {
        private readonly ShopSanPhamContext _context;
        public QuanLyNhanVien(ShopSanPhamContext context)
        {
            _context = context;
        }

        public void Create(NhanVien nhanVien)
        {
             _context.NhanViens.Add(nhanVien);
                _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var nhanvienxoa = _context.NhanViens.Find(id);
            _context.NhanViens.Remove(nhanvienxoa);
            _context.SaveChanges();
        }

        public IEnumerable<NhanVien> Find(Func<NhanVien, bool> predicate)
        {
            return _context.NhanViens.Where(predicate);
        }

        public IEnumerable<NhanVien> GetAll()
        {
             return _context.NhanViens.AsNoTracking().ToList();
        }

        public NhanVien GetById(int id)
        {
            return _context.NhanViens.Find(id);
        }

        public void Update(NhanVien nhanVien)
        {
            var nhanviensua = _context.NhanViens.Find(nhanVien.UserId);
            _context.NhanViens.Update(nhanviensua);
            _context.SaveChanges();
        }
    }
}
