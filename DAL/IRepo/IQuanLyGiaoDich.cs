using DAL.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepo
{
    public interface IQuanLyGiaoDich
    {
          GioHang AddGioHang();
          Task UpdateGioHang(int giohang,bool trangthai);
          Task<List<GioHangChiTiet>> AllChiTietTrongXe(int idgiohang);
          Task<CheckResult> AddChiTietGioHang(int idgiohang, int idsanpham);
          Task<CheckResult>  UpdateChiTiet(int chitiet, int idsp, int soluong);
          Task<bool> DeleteChiTiet(int chitiet);


          Task TruSoLuong(HoaDon hoaDon);
          Task<(CheckResult, HoaDon)> TaoHoaDon(GioHang gioHang, int userid, bool phuongthuc, decimal tongtien, int idkhachhang, bool vanchuyen);
          Task<CheckResult> ThanhToan(int idgiohang, int userid, decimal tien, bool phuongthuc, int idkhachhang, bool vanchuyen);

          Task XoaGioHang(int idgiohang);
          




        //PHu
          Task<IEnumerable<SanPham>> AllSanPham();
          Task<IEnumerable<GioHang>> AllGioHangCho();



        // tab2
        Task<IEnumerable<HoaDon>> AllHoaDonVanChuyen();
        Task<IEnumerable<HoaDon>> AllHoaDonDaThanhToan();
        Task<IEnumerable<HoaDon>> AllHoaDonDieuKien(Expression<Func<HoaDon, bool>> predicate);
        Task<IEnumerable<HoaDonChiTiet>> AllChiTietHoaDon(int id);
        Task XacThucHoaDon(int hoadon);
        Task HUyHoaDon(int hoadon);
        Task HoanTraHoaDon(int hoadon);
        Task CheckHoaDon(int id);


    }
}
