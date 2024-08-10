using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepo
{
    public interface IQuanLyKhoHang
    {
        bool Create(SanPham sanpham);
        bool Update(SanPham sanpham);
        IEnumerable<SanPham> GetAll();
        SanPham GetByID(int id);
        IEnumerable<SanPham> Find(Func<SanPham, bool> predicate);
        IEnumerable<HangSanPham> GetAllHangSP();
        IEnumerable<GioiTinh> GetAllGioiTinh();
        IEnumerable<KichCo> GetAllKichCo();
        IEnumerable<MauSac> GetAllMauSac();
        IEnumerable<GiamGium> GetAllGiamGia();
        
    }
}
