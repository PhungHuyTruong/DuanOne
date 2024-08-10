using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IChucNangThongKe
    {
        IEnumerable<HoaDon> GetHoaDonsByDateRange(DateTime startDate, DateTime endDate);
        decimal GetTongTienByDateRange(DateTime startDate, DateTime endDate);
        int GetTotalProductsSoldByDateRange(DateTime startDate, DateTime endDate);
        List<HoaDon> LayHoaDonsTheoNgay(DateTime startDate, DateTime endDate); // Thay đổi tên
        decimal LayTongTienTheoNgay(DateTime startDate, DateTime endDate); // Thay đổi tên
        List<HoaDonChiTiet> LayThongKeSanPhamTheoNgay(DateTime startDate, DateTime endDate); // Thay đổi tên

    }
}
