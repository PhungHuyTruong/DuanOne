using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDonChiTiet
{
    public int IdChiTiet { get; set; }

    public int IdHoaDon { get; set; }

    public int IdSanPham { get; set; }

    public string TenSanPham { get; set; } = null!;

    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public decimal? ThanhTien { get; set; }

    public decimal? GiamGia { get; set; }

    public virtual HoaDon IdHoaDonNavigation { get; set; } = null!;

    public virtual SanPham IdSanPhamNavigation { get; set; } = null!;
}
