using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{
    public interface IChucNangThuocTinh
    {
        IEnumerable<HangSanPham> TimKiemHang(string timkiemhang);
        IEnumerable<MauSac> TimKiemMau(string timkiemmau);
        IEnumerable<KichCo> TimKiemKichCo(string timkiemkichco);
        IEnumerable<GioiTinh> TimKiemGioiTinh(string timkiemgioitinh);
        IEnumerable<GiamGium> TimKiemGiamGia(string timkiemgiamgia);


        bool CreateGiamGiaSP(string loaigiamgia, decimal mucgiam, DateTime ngaybatdau, DateTime ngayketthuc, bool trangthai);
        bool UpdateGiamGiaSP(int idgiamgia, string loaigiamgia, decimal mucgiam, DateTime ngaybatdau, DateTime ngayketthuc, bool trangthai);

        GiamGium GetGiamGiaByID(int id);
        IEnumerable<GiamGium> GetAllGiamGia();

        bool CreateHangSP(string tenhang, string diachi);
        bool UpdateHangSP(int idhangsp, string tenhang, string diachi);

        HangSanPham GetHangByID(int id);
        IEnumerable<HangSanPham> GetAllHang();

        bool CreateMauSacSP(string tenmau);
        bool UpdateMauSacSP(int idmau, string tenmau);

        MauSac GetMauSacByID(int id);
        IEnumerable<MauSac> GetAllMauSac();

        bool CreateKichCoSP(int kichco);
        bool UpdateKichCoSP(int idkichco, int kichco);

        KichCo GetKichCoByID(int id);
        IEnumerable<KichCo> GetAllKichCo();

        bool CreateGioiTinhSP(string tengioitinh);
        bool UpdateGioiTinhSP(int idgioitinh, string tengioitinh);

        GioiTinh GetGioiTinhByID(int id);
        IEnumerable<GioiTinh> GetAllGioiTinh();

    }
}
