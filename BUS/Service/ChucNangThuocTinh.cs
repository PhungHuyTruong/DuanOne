using BUS.IService;
using BUS.Remove;
using DAL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class ChucNangThuocTinh : IChucNangThuocTinh
    {
        private readonly IQuanLyThuocTinh repos;
        public ChucNangThuocTinh(IQuanLyThuocTinh repo)
        {
            repos = repo;
        }



        public bool CreateGiamGiaSP(string loaigiamgia, decimal mucgiam, DateTime ngaybatdau, DateTime ngayketthuc, bool trangthai)
        {
            try
            {
                var giamgia = new GiamGium()
                {
                    LoaiGiamGia = loaigiamgia,
                    MucGiamGia = mucgiam,
                    NgayBatDau = ngaybatdau,
                    NgayKetThuc = ngayketthuc,
                    TrangThai = trangthai,
                };
                repos.CreateGiamGia(giamgia);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateGioiTinhSP(string tengioitinh)
        {
            try
            {
                var gioitinh = new GioiTinh()
                {
                    TenGioiTinh = tengioitinh,
                };
                repos.CreateGioiTinh(gioitinh);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateHangSP(string tenhang, string diachi)
        {
            try
            {
                var hang = new HangSanPham()
                {
                    TenHang = tenhang,
                    DiaChi = diachi,
                };
                repos.CreateHang(hang);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateKichCoSP(int kichco)
        {
            try
            {
                var kichco1 = new KichCo()
                {
                    KichCo1 = kichco,
                };
                repos.CreateKichCo(kichco1);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CreateMauSacSP(string tenmau)
        {
            try
            {
                var mausac = new MauSac()
                {
                    MauSac1 = tenmau,
                };
                repos.CreateMauSac(mausac);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<GiamGium> GetAllGiamGia()
        {
            return repos.GetAllGiamGia();
        }

        public IEnumerable<GioiTinh> GetAllGioiTinh()
        {
            return repos.GetAllGioiTinh();
        }

        public IEnumerable<HangSanPham> GetAllHang()
        {
            return repos.GetAllHang();
        }

        public IEnumerable<KichCo> GetAllKichCo()
        {
            return repos.GetAllKichCo();
        }

        public IEnumerable<MauSac> GetAllMauSac()
        {
            return repos.GetAllMauSac();
        }

        public GiamGium GetGiamGiaByID(int id)
        {
            var giamgia1 = repos.GetGiamGiaByID(id);
            return giamgia1;
        }

        public GioiTinh GetGioiTinhByID(int id)
        {
            var gioitinh1 = repos.GetGioiTinhByID(id);
            return gioitinh1;
        }

        public HangSanPham GetHangByID(int id)
        {
            var hangsp1 = repos.GetHangByID(id);
            return hangsp1;
        }

        public KichCo GetKichCoByID(int id)
        {
            var kichco1 = repos.GetKichCoByID(id);
            return kichco1;
        }

        public MauSac GetMauSacByID(int id)
        {
            var mausac1 = repos.GetMauSacByID(id);
            return mausac1;
        }

        public bool UpdateGiamGiaSP(int idgiamgia, string loaigiamgia, decimal mucgiam, DateTime ngaybatdau, DateTime ngayketthuc, bool trangthai)
        {
            try
            {
                var giamgiasua = repos.GetGiamGiaByID(idgiamgia);
                if (giamgiasua != null)
                {
                    giamgiasua.LoaiGiamGia = loaigiamgia;
                    giamgiasua.MucGiamGia = mucgiam;
                    giamgiasua.NgayBatDau = ngaybatdau;
                    giamgiasua.NgayKetThuc = ngayketthuc;
                    giamgiasua.TrangThai = trangthai;

                    if (!trangthai)
                    {
                        var sanPhams = repos.GetAllSanPhamsByGiamGiaId(idgiamgia);
                        foreach (var sanPham in sanPhams)
                        {
                            sanPham.IdGiamGia = null;
                            repos.UpdateSanPham(sanPham);
                        }
                    }

                    repos.UpdateGiamGia(giamgiasua);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool UpdateGioiTinhSP(int idgioitinh, string tengioitinh)
        {
            try
            {
                var gioitinhsua = repos.GetGioiTinhByID(idgioitinh);
                if (gioitinhsua != null)
                {
                    gioitinhsua.TenGioiTinh = tengioitinh;

                    repos.UpdateGioiTinh(gioitinhsua);
                    return true;
                }
                return false;
            }
            catch (Exception) { return false; }
        }

        public bool UpdateHangSP(int idhang, string tenhang, string diachi)
        {
            try
            {
                var hangsua = repos.GetHangByID(idhang);
                if (hangsua != null)
                {
                    hangsua.TenHang = tenhang;
                    hangsua.DiaChi = diachi;

                    repos.UpdateHang(hangsua);
                    return true;
                }
                return false;
            }
            catch (Exception) { return false; }
        }

        public bool UpdateKichCoSP(int idkichco, int kichco)
        {
            try
            {
                var kichcosua = repos.GetKichCoByID(idkichco);
                if (kichcosua != null)
                {
                    kichcosua.KichCo1 = kichco;

                    repos.UpdateKichCo(kichcosua);
                    return true;
                }
                return false;
            }
            catch (Exception) { return false; }
        }

        public bool UpdateMauSacSP(int idmau, string tenmau)
        {
            try
            {
                var mausacsua = repos.GetMauSacByID(idmau);
                if (mausacsua != null)
                {
                    mausacsua.MauSac1 = tenmau;

                    repos.UpdateMauSac(mausacsua);
                    return true;
                }
                return false;
            }
            catch (Exception) { return false; }
        }

        public IEnumerable<HangSanPham> TimKiemHang(string timkiemhang)
        {
            return repos.Find(hsp => hsp.TenHang.StartsWith(timkiemhang, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<MauSac> TimKiemMau(string timkiemmau)
        {
            return repos.Find(mc => mc.MauSac1.StartsWith(timkiemmau, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<KichCo> TimKiemKichCo(string timkiemkichco)
        {
            if (string.IsNullOrEmpty(timkiemkichco))
            {
                return repos.GetAllKichCo();
            }

            var timkiemLower = timkiemkichco.Trim().ToLower();

            return repos.Find(kc =>
                kc.KichCo1.ToString().ToLower().Contains(timkiemLower));

        }

        public IEnumerable<GioiTinh> TimKiemGioiTinh(string timkiemgioitinh)
        {
            return repos.Find(gt => gt.TenGioiTinh.StartsWith(timkiemgioitinh, StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<GiamGium> TimKiemGiamGia(string timkiemgiamgia)
        {
            if (string.IsNullOrEmpty(timkiemgiamgia))
            {
                return repos.GetAllGiamGia();
            }

            string timkiemNormalized = RemoveDiacritics.RemoveDiacritics1(timkiemgiamgia.Trim().ToLowerInvariant());

            bool ContainsNormalized(string source, string toCheck)
            {
                string normalizedSource = RemoveDiacritics.RemoveDiacritics1(source.ToLowerInvariant());
                return normalizedSource.Contains(toCheck);
            }

            return repos.Find(gg =>
                ContainsNormalized(gg.LoaiGiamGia, timkiemNormalized) ||
                gg.MucGiamGia.ToString().Contains(timkiemNormalized)
            );
        }
        public bool UpdateSanPham(SanPham sanPham)
        {
            return repos.UpdateSanPham(sanPham);
        }

        public IEnumerable<SanPham> GetAllSanPhamsByGiamGiaId(int idGiamGia)
        {
            return repos.GetAllSanPhamsByGiamGiaId(idGiamGia);
        }
    }
}
