using BUS.IService;
using DAL.IRepo;
using DAL.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class ChucNangThongKe : IChucNangThongKe
    {
        private readonly IQuanLyThongKe quanLyThongKe;

        public ChucNangThongKe(IQuanLyThongKe hoaDonRepository)
        {
            quanLyThongKe = hoaDonRepository;
        }

        public IEnumerable<HoaDon> GetHoaDonsByDateRange(DateTime startDate, DateTime endDate)
        {
            return quanLyThongKe.Find(hd => hd.NgayTao >= startDate && hd.NgayTao <= endDate && hd.TrangThai);
        }

        public List<HoaDon> LayHoaDonsTheoNgay(DateTime startDate, DateTime endDate) // Thay đổi tên
        {
            return quanLyThongKe.LayHoaDonsTheoNgay(startDate, endDate);
        }

        public decimal LayTongTienTheoNgay(DateTime startDate, DateTime endDate) // Thay đổi tên
        {
            return quanLyThongKe.LayTongTienTheoNgay(startDate, endDate);
        }

        public List<HoaDonChiTiet> LayThongKeSanPhamTheoNgay(DateTime startDate, DateTime endDate) // Thay đổi tên
        {
            var hoaDons = quanLyThongKe.LayHoaDonsTheoNgay(startDate, endDate);
            return hoaDons.SelectMany(hd => hd.HoaDonChiTiets).ToList();
        }
        public decimal GetTongTienByDateRange(DateTime startDate, DateTime endDate)
        {
            return quanLyThongKe.Find(hd => hd.NgayTao >= startDate && hd.NgayTao <= endDate && hd.TrangThai)
                                    .Sum(hd => hd.TongTien);
        }

        public int GetTotalProductsSoldByDateRange(DateTime startDate, DateTime endDate)
        {
            var hoaDons = GetHoaDonsByDateRange(startDate, endDate);
            return hoaDons.Sum(hd => hd.HoaDonChiTiets.Sum(ct => ct.SoLuong));
        }

    }
}
