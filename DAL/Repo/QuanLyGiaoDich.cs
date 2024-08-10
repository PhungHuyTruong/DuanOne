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
    public enum CheckResult
    {
        ThanhCong,
        KoThanhCong,
        KoDuSoLuong,
        ThieuTien,
        KoTimThaySP,
        KoTimThayGH,
        KoTimThayUser,
        KoTimThayChiTiet,
    }
    public class QuanLyGiaoDich : IQuanLyGiaoDich
    {
        private readonly ShopSanPhamContext _context;
        public QuanLyGiaoDich(ShopSanPhamContext context)
        {
            _context = context;
        }

        public async Task<CheckResult> AddChiTietGioHang(int idgiohang, int idsanpham)
        {
            try
            {
                var giohang = await _context.GioHangs
                    .Include(gh => gh.GioHangChiTiets)
                    .FirstOrDefaultAsync(gh => gh.IdGioHang == idgiohang);
                var sanpham = await _context.SanPhams
                    .Include(sp => sp.IdGiamGiaNavigation)
                    .FirstOrDefaultAsync(sp => sp.IdSanPham == idsanpham);
                var existingItem = giohang.GioHangChiTiets
                    .FirstOrDefault(item => item.IdSanPham == idsanpham);

                if (existingItem != null)
                {
                    if (CheckSoLuong(existingItem.SoLuong + 1, sanpham.IdSanPham))
                    {
                        existingItem.SoLuong++;
                        existingItem.ThanhTien = TinhThanhTien(existingItem.DonGia, existingItem.SoLuong, sanpham.IdGiamGiaNavigation?.MucGiamGia);
                    }
                    else
                    {
                        return CheckResult.KoDuSoLuong;
                    }
                }
                else
                {
                    if (CheckSoLuong(1, sanpham.IdSanPham))
                    {
                        var newItem = new GioHangChiTiet
                        {
                            IdGioHang = giohang.IdGioHang,
                            IdSanPham = sanpham.IdSanPham,
                            TenSanPham = sanpham.TenSanPham,
                            SoLuong = 1,
                            DonGia = sanpham.Gia,
                            GiamGia = sanpham.IdGiamGiaNavigation?.MucGiamGia,
                            ThanhTien = TinhThanhTien(sanpham.Gia, 1, sanpham.IdGiamGiaNavigation?.MucGiamGia)
                        };
                        _context.GioHangChiTiets.Add(newItem);
                    }
                    else
                    {
                        return CheckResult.KoDuSoLuong;
                    }
                }

                int affectedRows = await _context.SaveChangesAsync();
                return affectedRows > 0 ? CheckResult.ThanhCong : CheckResult.KoThanhCong;
            }
            catch (Exception ex)
            {
                return CheckResult.KoThanhCong;
            }
        }
        private bool CheckSoLuong(int soluong, int idsp)
        {
            var sp = _context.SanPhams.FirstOrDefault(sp => sp.IdSanPham == idsp);
            if (soluong > sp.SoLuong)
            {
                return false;
            }
            return true;
        }
        private decimal TinhThanhTien(decimal price, int quantity, decimal? discount)
        {
            if (discount.HasValue)
            {
                price *= (1 - discount.Value / 100);
            }
            return price * quantity;
        }

        public GioHang AddGioHang()
        {
            using (var context = new ShopSanPhamContext())
            {
                GioHang gh = new GioHang()
                {
                    TrangThai = true
                };
                context.GioHangs.Add(gh);
                context.SaveChanges();
                return gh;
            }
        }

        public async Task<List<GioHangChiTiet>> AllChiTietTrongXe(int idgiohang)
        {
            //var giohang = await _context.GioHangs
            //    .Include(g => g.GioHangChiTiets)
            //    .FirstOrDefaultAsync(g =>g.IdGioHang == idgiohang);
            //if(giohang == null)
            //{
            //    return new List<GioHangChiTiet>();
            //}
            //return giohang.GioHangChiTiets.ToList();
            return await _context.GioHangChiTiets.Where(ct => ct.IdGioHang == idgiohang).Select(ct => new GioHangChiTiet
            {
                IdGioHangChiTiet = ct.IdGioHangChiTiet,
                IdGioHang = ct.IdGioHang,
                IdSanPham = ct.IdSanPham,
                TenSanPham = ct.TenSanPham,
                SoLuong = ct.SoLuong,
                DonGia = ct.DonGia,
                GiamGia = ct.GiamGia,
                ThanhTien = ct.ThanhTien
            })
             .ToListAsync();
        }

        public async Task<IEnumerable<GioHang>> AllGioHangCho()
        {
            var list = await _context.GioHangs.Where(gh => gh.TrangThai == false).ToListAsync();
            return list;
        }

        public async Task<IEnumerable<SanPham>> AllSanPham()
        {
            var list = await _context.SanPhams.Where(sp => sp.TrangThai == true && (sp.SoLuong > 0)).ToListAsync();
            return list;
        }

        public async Task<bool> DeleteChiTiet(int chitiet)
        {
            var giohangchitiet = await _context.GioHangChiTiets.FindAsync(chitiet);

            if (giohangchitiet == null)
            {
                return false;
            }
            try
            {
                _context.GioHangChiTiets.Remove(giohangchitiet);
                int rowsAffected = await _context.SaveChangesAsync();
                return rowsAffected > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<CheckResult> ThanhToan(int idgiohang, int userid, decimal tien, bool phuongthuc, int idkhachhang)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var giohang = await _context.GioHangs
                    .Include(g => g.GioHangChiTiets)
                    .FirstOrDefaultAsync(gh => gh.IdGioHang == idgiohang);

                if (giohang == null)
                    return CheckResult.KoTimThayGH;

                var tongtien = giohang.GioHangChiTiets.Sum(ct => ct.ThanhTien);
                if (!TinhTien(tongtien, tien))
                    return CheckResult.ThieuTien;

                var (result, hoadon) = await TaoHoaDon(giohang, userid, phuongthuc, tongtien, idkhachhang);
                if (result == CheckResult.ThanhCong && hoadon != null)
                {
                    await TruSoLuong(hoadon);
                    await transaction.CommitAsync();
                    return CheckResult.ThanhCong;
                }

                await transaction.RollbackAsync();
                return result;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                return CheckResult.KoThanhCong;
            }
        }

        public async Task<(CheckResult, HoaDon)> TaoHoaDon(GioHang gioHang, int userid, bool phuongthuc, decimal tongtien, int idkhachhang)
        {
            HoaDon hoadon = new HoaDon
            {
                UserId = userid,
                TrangThai = phuongthuc,
                TongTien = tongtien,
                IdKhachHang = phuongthuc ? (int?)null : idkhachhang
            };

            List<HoaDonChiTiet> chiTietList = new List<HoaDonChiTiet>();

            foreach (var item in gioHang.GioHangChiTiets)
            {
                HoaDonChiTiet chitiet = new HoaDonChiTiet
                {
                    IdSanPham = item.IdSanPham,
                    TenSanPham = item.TenSanPham,
                    SoLuong = item.SoLuong,
                    DonGia = item.DonGia,
                    ThanhTien = item.ThanhTien,
                    GiamGia = item.GiamGia
                };
                chiTietList.Add(chitiet);
            }
            try
            {
                _context.HoaDons.Add(hoadon);
                await _context.SaveChangesAsync();
                foreach (var chitiet in chiTietList)
                {
                    chitiet.IdHoaDon = hoadon.IdHoaDon;
                    _context.HoaDonChiTiets.Add(chitiet);
                }

                int rowefft = await _context.SaveChangesAsync();

                return (CheckResult.ThanhCong, hoadon);
            }
            catch (Exception ex)
            {
                return (CheckResult.KoThanhCong, null);
            }
        }
        private bool TinhTien(decimal tongtien, decimal tien)
        {
            if (tien >= tongtien)
            {
                return true;
            }
            return false;
        }
        public async Task TruSoLuong(HoaDon hoaDon)
        {
            if (hoaDon.TrangThai)
            {
                var list = hoaDon.HoaDonChiTiets;
                foreach (var chitiet in list)
                {
                    var sp = await _context.SanPhams.FirstOrDefaultAsync(sp => sp.IdSanPham == chitiet.IdSanPham);
                    if (sp != null)
                    {
                        sp.SoLuong -= chitiet.SoLuong;
                    }
                }
                await _context.SaveChangesAsync();
            }
            return;

            //var productQuantities = hoaDon.HoaDonChiTiets
            //  .GroupBy(ct => ct.IdSanPham)
            //  .ToDictionary(g => g.Key, g => g.Sum(ct => ct.SoLuong));

            //var productIds = productQuantities.Keys.ToList();
            //var products = await _context.SanPhams
            //    .Where(sp => productIds.Contains(sp.IdSanPham))
            //    .ToListAsync();

            //foreach (var product in products)
            //{
            //    product.SoLuong -= productQuantities[product.IdSanPham];
            //}

            //await _context.SaveChangesAsync();
        }

        public async Task<CheckResult> UpdateChiTiet(int chitiet, int idsp, int soluong)
        {
            var giohangchitiet = await _context.GioHangChiTiets.FindAsync(chitiet);
            var sanpham = await _context.SanPhams.FindAsync(idsp);
            if (giohangchitiet == null)
            {
                return CheckResult.KoTimThayChiTiet;
            }
            if (sanpham == null)
            {
                return CheckResult.KoTimThaySP;
            }
            try
            {
                if (!CheckSoLuong(soluong, idsp))
                {
                    return CheckResult.KoDuSoLuong;
                }
                else
                {
                    giohangchitiet.SoLuong = soluong;
                    giohangchitiet.ThanhTien = TinhThanhTien(giohangchitiet.DonGia, giohangchitiet.SoLuong, sanpham.IdGiamGiaNavigation?.MucGiamGia);
                    _context.GioHangChiTiets.Update(giohangchitiet);
                    int rowAffected = await _context.SaveChangesAsync();
                    return rowAffected > 0 ? CheckResult.ThanhCong : CheckResult.KoThanhCong;
                }
            }
            catch (Exception)
            {
                return CheckResult.KoThanhCong;
            }
        }

        public async Task UpdateGioHang(int idgiohang, bool trangthai)
        {
            var giohang = await _context.GioHangs.FirstOrDefaultAsync(gh => gh.IdGioHang == idgiohang);
            giohang.TrangThai = trangthai;
            _context.GioHangs.Update(giohang);
            _context.SaveChangesAsync();

        }


        public async Task XoaGioHang(int idgiohang)
        {
            var giohang = await _context.GioHangs.FirstOrDefaultAsync(gh => gh.IdGioHang == idgiohang);
            var chitiet = await _context.GioHangChiTiets.Where(ct => ct.IdGioHang == giohang.IdGioHang).ToListAsync();
            _context.GioHangChiTiets.RemoveRange(chitiet);
            _context.GioHangs.Remove(giohang);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<HoaDon>> AllHoaDonVanChuyen()
        {
            var list = await _context.HoaDons.Include(id => id.IdKhachHangNavigation)
                                             .Where(hd => hd.TrangThai == false && hd.Huy == false)
                                             .ToListAsync();
            return list;
        }
        public async Task<IEnumerable<HoaDon>> AllHoaDonDaThanhToan()
        {
            var list = await _context.HoaDons.Include(id => id.IdKhachHangNavigation)
                                             .Where(hd => hd.TrangThai == true && hd.HoanTra == false)
                                             .ToListAsync();
            return list;
        }
        public async Task<IEnumerable<HoaDon>> AllHoaDonDieuKien(Expression<Func<HoaDon, bool>> predicate)
        {
            return await _context.HoaDons.Include(id => id.IdKhachHangNavigation).Where(predicate).ToListAsync();
        }
        public async Task<IEnumerable<HoaDonChiTiet>> AllChiTietHoaDon(int id)
        {
    
            
            
var list = await _context.HoaDonChiTiets.Where(ct => ct.IdHoaDon == id).Select(ct => new HoaDonChiTiet
            {
                IdChiTiet  = ct.IdChiTiet,
                IdHoaDon = id,
                IdSanPham = ct.IdSanPham,
                TenSanPham = ct.TenSanPham,
                SoLuong = ct.SoLuong,
                DonGia = ct.DonGia,
                ThanhTien = ct.ThanhTien,
                GiamGia = ct.GiamGia,
            })
            .ToListAsync();
            return list;    
        }
        public async Task XacThucHoaDon(int idhoadon)
        {
            var hoadon = await _context.HoaDons.FirstOrDefaultAsync(id => id.IdHoaDon == idhoadon);
            if (hoadon != null)
            {

                hoadon.TrangThai = true;
                await TruSoLuong(hoadon);
                await _context.SaveChangesAsync();
            }
        }

        public async Task HUyHoaDon(int idhoadon)
        {
            var hoadon = await _context.HoaDons.FirstOrDefaultAsync(id => id.IdHoaDon == idhoadon);
            if (hoadon != null)
            {
                hoadon.Huy = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task HoanTraHoaDon(int idhoadon)
        {
            var hoadon = await _context.HoaDons.FirstOrDefaultAsync(id => id.IdHoaDon == idhoadon);
            if (hoadon != null)
            {
                hoadon.HoanTra = true;
                await HoanTraSoluong(hoadon);
                await _context.SaveChangesAsync();
                
            }
        }

        private async Task HoanTraSoluong(HoaDon hoadon)
        {
            if (hoadon.HoanTra == true && hoadon.TrangThai == true)
            {
                var list = hoadon.HoaDonChiTiets;
                foreach (var chitiet in list)
                {
                    var sp = await _context.SanPhams.FirstOrDefaultAsync(sp => sp.IdSanPham == chitiet.IdSanPham);
                    if (sp != null)
                    {
                        sp.SoLuong += chitiet.SoLuong;
                    }
                }
                await _context.SaveChangesAsync();
            }
        }
        public async Task CheckHoaDon(int id)
        {
            await _context.HoaDons.FindAsync(id);
        }
    }
}
