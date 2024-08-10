using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class SanPham
{
    public int IdSanPham { get; set; }

    public string TenSanPham { get; set; } = null!;

    public int IdHang { get; set; }

    public int SoLuong { get; set; }

    public string? MoTa { get; set; }

    public string ChatLieu { get; set; } = null!;

    public string KieuGiay { get; set; } = null!;

    public int? IdGioiTinh { get; set; }

    public int KichCo { get; set; }

    public int MauSac { get; set; }

    public string Barcode { get; set; } = null!;

    public decimal Gia { get; set; }

    public int? IdGiamGia { get; set; }

    public bool TrangThai { get; set; }

    public string? HinhAnh { get; set; }

    public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; } = new List<GioHangChiTiet>();

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual GiamGium? IdGiamGiaNavigation { get; set; }

    public virtual GioiTinh? IdGioiTinhNavigation { get; set; }

    public virtual HangSanPham IdHangNavigation { get; set; } = null!;

    public virtual KichCo KichCoNavigation { get; set; } = null!;

    public virtual MauSac MauSacNavigation { get; set; } = null!;
}
