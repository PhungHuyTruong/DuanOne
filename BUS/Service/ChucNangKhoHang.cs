using Azure.Core;
using BUS.IService;
using DAL.IRepo;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class ChucNangKhoHang : IChucNangKhoHang
    {
        private readonly IQuanLyKhoHang _repo;
        public ChucNangKhoHang(IQuanLyKhoHang repo)
        {
            _repo = repo;
        }

        public bool CreateSanPham(string ten, int idhang, int soluong, string mota, string chatlieu, string kieugiay, int idgioitih, int idkichco, int idmausac, string barcode, decimal gia, string hinhanh)
        {
            var sanpham = new SanPham()
            {
                TenSanPham = ten,
                IdHang = idhang,
                SoLuong = soluong,
                MoTa = mota,
                ChatLieu = chatlieu,
                KieuGiay = kieugiay,
                IdGioiTinh = idgioitih,
                KichCo = idkichco,
                MauSac = idmausac,
                Barcode = barcode,
                Gia = gia,
                TrangThai = true,
            };
            if (KiemTraThongTin(sanpham))
            {
                return _repo.Create(sanpham);
            }
            return false;    
        }
        public bool UpdateSanPham(int idsanpham,string ten, int idhang, int soluong, string mota, string chatlieu, string kieugiay, int idgioitih, int idkichco, int idmausac, string barcode, decimal gia,bool trangthai, string hinhanh)
        {
            var sanphamsua = _repo.GetByID(idsanpham);
            if (sanphamsua != null)
            {
                sanphamsua.TenSanPham = ten;
                sanphamsua.IdHang = idhang;
                sanphamsua.SoLuong = soluong;
                sanphamsua.MoTa = mota;
                sanphamsua.ChatLieu = chatlieu;
                sanphamsua.KieuGiay = kieugiay;
                sanphamsua.IdGioiTinh = idgioitih;
                sanphamsua.KichCo = idkichco;
                sanphamsua.MauSac = idmausac;
                sanphamsua.Barcode = barcode;
                sanphamsua.Gia = gia;
                sanphamsua.TrangThai = trangthai;
                sanphamsua.HinhAnh = hinhanh;
                if (KiemTraCapNhat(sanphamsua))
                {
                    return _repo.Update(sanphamsua);
                }
            }
            return false;
        }

        public bool UpdateTrangThai(int idsanpham, bool trangthai)
        {
            var sanphmasua = _repo.GetByID(idsanpham); 
           if (sanphmasua != null)
            {
                sanphmasua.TrangThai = trangthai;
                return true;
            } 
           return false;
        }

        public IEnumerable<SanPham> GetAllSanPham()
        {
            return _repo.GetAll(); 
        }

        public SanPham GetSanPhamByID(int id)
        {
            var sanpham  = _repo.GetByID(id);   
            return sanpham;
        }

        public IEnumerable<SanPham> SearchSanPham(string timkiem)
        {   
            return _repo.Find(sp => sp.TenSanPham.Contains(timkiem) || (sp.Barcode.Contains(timkiem)));
        }


        public IEnumerable<GioiTinh> GetAllGioiTinh()
        {
            return _repo.GetAllGioiTinh();
        }

        public IEnumerable<HangSanPham> GetAllHangSP()
        {
            return _repo.GetAllHangSP();    
        }

        public IEnumerable<KichCo> GetAllKichCo()
        {
            return _repo.GetAllKichCo();    
        }

        public IEnumerable<MauSac> GetAllMauSac()
        {
           return (_repo.GetAllMauSac());
        }

 
 
        private bool KiemTraThongTin(SanPham sanpham) 
        {
            var list = _repo.GetAll().Where(sp => sp.IdSanPham != sanpham.IdSanPham);
            if(sanpham.SoLuong <= 0 || sanpham.Gia <= 0)
            {
                return false;
            }
            foreach(var sp in list)
            {
                if ((sp.TenSanPham.Equals(sanpham.TenSanPham) && sp.IdHang.Equals(sanpham.IdHang)&&
                    sp.MoTa.Equals(sanpham.MoTa) && sp.ChatLieu.Equals(sanpham.ChatLieu) &&
                    sp.KieuGiay.Equals(sanpham.KieuGiay) && sp.MauSac.Equals(sanpham.MauSac) &&
                    sp.IdGioiTinh.Equals(sanpham.IdGioiTinh) && sp.KichCo.Equals(sanpham.KichCo)&&
                    sp.Gia.Equals(sanpham.Gia)) || (sp.Barcode.Equals(sanpham.Barcode)) )
                {
                    return false;
                }
            }
            return true;
        }
        private bool KiemTraCapNhat(SanPham sanpham)
        {
            var list = _repo.GetAll().Where(sp => sp.IdSanPham != sanpham.IdSanPham);
            if (sanpham.SoLuong <= 0 || sanpham.Gia <= 0)
            {
                return false;
            }
            foreach(var sp in list)
            {
                if ((sp.TenSanPham.Equals(sanpham.TenSanPham) && sp.IdHang.Equals(sanpham.IdHang) &&
                    sp.MoTa.Equals(sanpham.MoTa) && sp.ChatLieu.Equals(sanpham.ChatLieu) &&
                    sp.KieuGiay.Equals(sanpham.KieuGiay) && sp.MauSac.Equals(sanpham.MauSac) &&
                    sp.IdGioiTinh.Equals(sanpham.IdGioiTinh) && sp.KichCo.Equals(sanpham.KichCo) &&
                    sp.Gia.Equals(sanpham.Gia)) || (sp.Barcode.Equals(sanpham.Barcode)))
                {
                    return false;
                }
            }
            return true ;
        }


        //tab2
        public IEnumerable<GiamGium> GetAllGiamGia()
        {
            return _repo.GetAllGiamGia().Where(gg => gg.TrangThai == true);
        }

        public bool UpdateKhuyenMai(int idsanpham, int khuyenmai)
        {
            if (idsanpham == null || khuyenmai == null)
            {
                return false;
            }
            SanPham sanphamsua = _repo.GetByID(idsanpham);
            if(sanphamsua == null)
            {
                return false;
            }
            if(sanphamsua.IdGiamGia.Equals(khuyenmai))
            {
                return false;
            }
            else
            {
                sanphamsua.IdGiamGia = khuyenmai;
                return _repo.Update(sanphamsua);
            }
            
        }

        public bool DeleteKhuyenMai(int idsanpham)
        {
            if (idsanpham == null)
            {
                return false;
            }
            SanPham sanphamsua = _repo.GetByID(idsanpham);
            if (sanphamsua == null)
            {
                return false;
            }
            if (sanphamsua.IdGiamGia == null)
            {
                return false;
            }
            else
            {
                sanphamsua.IdGiamGia = null;
                return _repo.Update(sanphamsua);
            }
        }

        public bool ThemNhieuKhuyenMai(List<int> idsanpham, int idgiamgia)
        {   
            bool valid = false;
            if (idsanpham == null || idgiamgia == null)
            {return valid;

            }
            foreach (var item in idsanpham)
            {
                var sp = GetSanPhamByID(item);
                sp.IdGiamGia = idgiamgia;
                if (_repo.Update(sp))
                {
                    valid = true;
                }
            }
            return valid;
        }

        public bool HuyNhieuKhuyenMai(List<int> idsanpham)
        {
            bool valid = false;
            if (idsanpham == null)
            {
                return valid;

            }
            foreach (var item in idsanpham)
            {
                var sp = GetSanPhamByID(item);
                sp.IdGiamGia = null;
                if (_repo.Update(sp))
                {
                    valid = true;
                }
            }
            return valid;
        }
    }
}
