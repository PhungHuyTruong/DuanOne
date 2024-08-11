using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HoaDon
{
    public int IdHoaDon { get; set; }

    public int UserId { get; set; }

    public decimal TongTien { get; set; }

    public bool TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public int? IdKhachHang { get; set; }

    public bool Huy { get; set; }

    public bool HoanTra { get; set; }

    public bool VanChuyen { get; set; }

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>();

    public virtual KhachHang? IdKhachHangNavigation { get; set; }

    public virtual NhanVien User { get; set; } = null!;
}
