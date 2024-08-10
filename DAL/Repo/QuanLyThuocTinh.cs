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
    public class QuanLyThuocTinh : IQuanLyThuocTinh
    {
        private readonly ShopSanPhamContext _shopSanPhamContext;
        public QuanLyThuocTinh()
        {
            _shopSanPhamContext = new ShopSanPhamContext();
        }

        public IEnumerable<HangSanPham> Find(Func<HangSanPham, bool> predicate)
        {
            return _shopSanPhamContext.HangSanPhams
            .Include(hsp => hsp.SanPhams)
            .Where(predicate)
            .ToList();
        }

        public IEnumerable<SanPham> GetAllSanPhamsByGiamGiaId(int idGiamGia)
        {
            return _shopSanPhamContext.SanPhams.Where(sp => sp.IdGiamGia == idGiamGia).ToList();
        }

        public bool CreateGiamGia(GiamGium giamGia)
        {
            try
            {
                _shopSanPhamContext.GiamGia.Add(giamGia);
                int rowsAffected = _shopSanPhamContext.SaveChanges();
                return rowsAffected > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateGioiTinh(GioiTinh gioiTinh)
        {
            try
            {
                _shopSanPhamContext.GioiTinhs.Add(gioiTinh);
                int rowsAffected = _shopSanPhamContext.SaveChanges();
                return rowsAffected > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateHang(HangSanPham hang)
        {
            try
            {
                _shopSanPhamContext.HangSanPhams.Add(hang);
                int rowsAffected = _shopSanPhamContext.SaveChanges();
                return rowsAffected > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateKichCo(KichCo kichCo)
        {
            try
            {
                _shopSanPhamContext.KichCos.Add(kichCo);
                int rowsAffected = _shopSanPhamContext.SaveChanges();
                return rowsAffected > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateMauSac(MauSac mauSac)
        {
            try
            {
                _shopSanPhamContext.MauSacs.Add(mauSac);
                int rowsAffected = _shopSanPhamContext.SaveChanges();
                return rowsAffected > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<GiamGium> GetAllGiamGia()
        {
            try
            {
                var giamGias = _shopSanPhamContext.GiamGia.ToList();
                foreach (var gg in giamGias)
                {
                    Console.WriteLine($"GiamGia Id: {gg.IdGiamGia}, TrangThai: {gg.TrangThai}");
                }
                return giamGias;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<GiamGium>();
            }
        }

        public IEnumerable<GioiTinh> GetAllGioiTinh()
        {
            return _shopSanPhamContext.GioiTinhs.ToList();
        }

        public IEnumerable<HangSanPham> GetAllHang()
        {
            return _shopSanPhamContext.HangSanPhams.ToList();
        }

        public IEnumerable<KichCo> GetAllKichCo()
        {
            return _shopSanPhamContext.KichCos.ToList();
        }

        public IEnumerable<MauSac> GetAllMauSac()
        {
            return _shopSanPhamContext.MauSacs.ToList();
        }

        public GiamGium GetGiamGiaByID(int id)
        {
            return _shopSanPhamContext.GiamGia.Find(id);
        }

        public GioiTinh GetGioiTinhByID(int id)
        {
            return _shopSanPhamContext.GioiTinhs.Find(id);
        }

        public HangSanPham GetHangByID(int id)
        {
            return _shopSanPhamContext.HangSanPhams.Find(id);
        }

        public KichCo GetKichCoByID(int id)
        {
            return _shopSanPhamContext.KichCos.Find(id);
        }

        public MauSac GetMauSacByID(int id)
        {
            return _shopSanPhamContext.MauSacs.Find(id);
        }

        public bool UpdateGiamGia(GiamGium giamGia)
        {
            try
            {
                Console.WriteLine($"Updating GiamGia with TrangThai: {giamGia.TrangThai}");
                _shopSanPhamContext.GiamGia.Update(giamGia);
                int rowsAffected = _shopSanPhamContext.SaveChanges();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool UpdateSanPham(SanPham sanPham)
        {
            try
            {
                _shopSanPhamContext.SanPhams.Update(sanPham);
                int rowsAffected = _shopSanPhamContext.SaveChanges();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool UpdateGioiTinh(GioiTinh gioiTinh)
        {
                try
                {
                    _shopSanPhamContext.GioiTinhs.Update(gioiTinh);
                    int rowsAffected = _shopSanPhamContext.SaveChanges();
                    return rowsAffected > 0;
                }
                catch (Exception)
                {
                    return false;
                }
        }

        public bool UpdateHang(HangSanPham hang)
        {
                try
                {
                    _shopSanPhamContext.HangSanPhams.Update(hang);
                    int rowsAffected = _shopSanPhamContext.SaveChanges();
                    return rowsAffected > 0;
                }
                catch (Exception)
                {
                    return false;
                }
        }

        public bool UpdateKichCo(KichCo kichCo)
        {
                try
                {
                    _shopSanPhamContext.KichCos.Update(kichCo);
                    int rowsAffected = _shopSanPhamContext.SaveChanges();
                    return rowsAffected > 0;
                }
                catch (Exception)
                {
                    return false;
                }
        }

        public bool UpdateMauSac(MauSac mauSac)
        {
                try
                {
                    _shopSanPhamContext.MauSacs.Update(mauSac);
                    int rowsAffected = _shopSanPhamContext.SaveChanges();
                    return rowsAffected > 0;
                }
                catch (Exception)
                {
                    return false;
                }
        }

        public IEnumerable<KichCo> Find(Func<KichCo, bool> predicate)
        {
            return _shopSanPhamContext.KichCos
            .Include(kc => kc.SanPhams)
            .Where(predicate)
            .ToList();
        }

        public IEnumerable<MauSac> Find(Func<MauSac, bool> predicate)
        {
            return _shopSanPhamContext.MauSacs
            .Include(mc => mc.SanPhams)
            .Where(predicate)
            .ToList();
        }

        public IEnumerable<GiamGium> Find(Func<GiamGium, bool> predicate)
        {
            return _shopSanPhamContext.GiamGia
            .Include(gg => gg.SanPhams)
            .Where(predicate)
            .ToList();
        }

        public IEnumerable<GioiTinh> Find(Func<GioiTinh, bool> predicate)
        {
            return _shopSanPhamContext.GioiTinhs
            .Include(gt => gt.SanPhams)
            .Where(predicate)
            .ToList();
        }
    }
}
