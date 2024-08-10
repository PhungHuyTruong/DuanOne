using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IChucNangKhoHang
    {
        bool CreateSanPham(string ten,int idhang,int soluong,string mota,string chatlieu,string kieugiay,int idgioitih,int idkichco,int idmausac,string barcode,decimal gia,string hinhanh);
        bool UpdateSanPham(int idsanpham, string ten, int idhang, int soluong, string mota, string chatlieu, string kieugiay, int idgioitih, int idkichco, int idmausac, string barcode, decimal gia, bool trangthai, string hinhanh);
        bool UpdateTrangThai(int idsanpham, bool trangthai);
        SanPham GetSanPhamByID(int id);   
        IEnumerable<SanPham> GetAllSanPham();
        IEnumerable<SanPham> SearchSanPham(string timkiem);
        IEnumerable<HangSanPham> GetAllHangSP();
        IEnumerable<GioiTinh> GetAllGioiTinh();
        IEnumerable<KichCo> GetAllKichCo();
        IEnumerable<MauSac> GetAllMauSac();


        //tab2
        IEnumerable<GiamGium> GetAllGiamGia();
        bool UpdateKhuyenMai(int idsanpham, int khuyenmai);
        bool DeleteKhuyenMai(int idsanpham);
        bool ThemNhieuKhuyenMai(List<int> idsanpham, int idgiamgia);
        bool HuyNhieuKhuyenMai(List<int> idsanpham);
    }   
}
