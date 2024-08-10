using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class ShopSanPhamContext : DbContext
{
    public ShopSanPhamContext()
    {
    }

    public ShopSanPhamContext(DbContextOptions<ShopSanPhamContext> options)
        : base(options)
    {
    }

    public virtual DbSet<GiamGium> GiamGia { get; set; }

    public virtual DbSet<GioHang> GioHangs { get; set; }

    public virtual DbSet<GioHangChiTiet> GioHangChiTiets { get; set; }

    public virtual DbSet<GioiTinh> GioiTinhs { get; set; }

    public virtual DbSet<HangSanPham> HangSanPhams { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KichCo> KichCos { get; set; }

    public virtual DbSet<MauSac> MauSacs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=PHUNGHUYTRUONG\\SQLEXPRESS;Database=ShopSanPham;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GiamGium>(entity =>
        {
            entity.HasKey(e => e.IdGiamGia).HasName("PK__GiamGia__E0F7D8B64924AF1D");

            entity.ToTable(tb => tb.HasTrigger("trg_UpdateTrangThaiOnExpiry"));

            entity.HasIndex(e => e.LoaiGiamGia, "UQ__GiamGia__F08A19A75E1D56E8").IsUnique();

            entity.Property(e => e.LoaiGiamGia).HasMaxLength(50);
            entity.Property(e => e.MucGiamGia).HasColumnType("decimal(5, 0)");
            entity.Property(e => e.NgayBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
        });

        modelBuilder.Entity<GioHang>(entity =>
        {
            entity.HasKey(e => e.IdGioHang).HasName("PK__GioHang__CCE77A1FD94F6765");

            entity.ToTable("GioHang");

            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<GioHangChiTiet>(entity =>
        {
            entity.HasKey(e => e.IdGioHangChiTiet).HasName("PK__GioHangC__349C2035C0D9809D");

            entity.ToTable("GioHangChiTiet");

            entity.Property(e => e.DonGia).HasColumnType("decimal(12, 0)");
            entity.Property(e => e.GiamGia).HasColumnType("decimal(5, 0)");
            entity.Property(e => e.TenSanPham).HasMaxLength(250);
            entity.Property(e => e.ThanhTien).HasColumnType("decimal(14, 0)");

            entity.HasOne(d => d.IdGioHangNavigation).WithMany(p => p.GioHangChiTiets)
                .HasForeignKey(d => d.IdGioHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GioHangCh__IdGio__619B8048");

            entity.HasOne(d => d.IdSanPhamNavigation).WithMany(p => p.GioHangChiTiets)
                .HasForeignKey(d => d.IdSanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GioHangCh__IdSan__628FA481");
        });

        modelBuilder.Entity<GioiTinh>(entity =>
        {
            entity.HasKey(e => e.IdGioiTinh).HasName("PK__GioiTinh__D10DDED238DE139F");

            entity.ToTable("GioiTinh");

            entity.HasIndex(e => e.TenGioiTinh, "UQ__GioiTinh__C21601ECB5E141E3").IsUnique();

            entity.Property(e => e.TenGioiTinh).HasMaxLength(10);
        });

        modelBuilder.Entity<HangSanPham>(entity =>
        {
            entity.HasKey(e => e.IdHang).HasName("PK__HangSanP__520EAE7B5EA297BE");

            entity.ToTable("HangSanPham");

            entity.HasIndex(e => e.TenHang, "UQ__HangSanP__E6C9BFA8EE8DC22D").IsUnique();

            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.TenHang).HasMaxLength(100);
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.IdHoaDon).HasName("PK__HoaDon__4DD461C81D2122BA");

            entity.ToTable("HoaDon");

            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TongTien).HasColumnType("decimal(14, 0)");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.IdKhachHangNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdKhachHang)
                .HasConstraintName("FK__HoaDon__IdKhachH__6A30C649");

            entity.HasOne(d => d.User).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDon__UserID__693CA210");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.IdChiTiet).HasName("PK__HoaDonCh__4E91F45E1846BE82");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.DonGia).HasColumnType("decimal(12, 0)");
            entity.Property(e => e.GiamGia).HasColumnType("decimal(5, 0)");
            entity.Property(e => e.TenSanPham).HasMaxLength(250);
            entity.Property(e => e.ThanhTien).HasColumnType("decimal(14, 0)");

            entity.HasOne(d => d.IdHoaDonNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdHoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChi__IdHoa__6EF57B66");

            entity.HasOne(d => d.IdSanPhamNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdSanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChi__IdSan__6FE99F9F");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.IdKhachHang).HasName("PK__KhachHan__7CF5D83693305983");

            entity.ToTable("KhachHang");

            entity.HasIndex(e => e.SoDienThoai, "UQ__KhachHan__0389B7BD3AE8BD16").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__KhachHan__A9D105348AFAE870").IsUnique();

            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<KichCo>(entity =>
        {
            entity.HasKey(e => e.IdKichCo).HasName("PK__KichCo__830A25D8C10989C4");

            entity.ToTable("KichCo");

            entity.HasIndex(e => e.KichCo1, "UQ__KichCo__E377A044E8F87769").IsUnique();

            entity.Property(e => e.KichCo1).HasColumnName("KichCo");
        });

        modelBuilder.Entity<MauSac>(entity =>
        {
            entity.HasKey(e => e.IdMau).HasName("PK__MauSac__0D13B74505CA8E76");

            entity.ToTable("MauSac");

            entity.HasIndex(e => e.MauSac1, "UQ__MauSac__77B8168767FBBE0A").IsUnique();

            entity.Property(e => e.MauSac1)
                .HasMaxLength(50)
                .HasColumnName("MauSac");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__NhanVien__1788CCACDC1BB2DB");

            entity.ToTable("NhanVien", tb => tb.HasTrigger("TRG_Set_NhanVien_RoleID"));

            entity.HasIndex(e => e.PhoneNumber, "UQ__NhanVien__85FB4E38309970C4").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__NhanVien__A9D1053480372796").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Avatar).HasMaxLength(555);
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Gender).HasMaxLength(3);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Role)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RoleId)
                .HasMaxLength(10)
                .HasColumnName("RoleID");
            entity.Property(e => e.TrangThai).HasDefaultValue(true);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.IdSanPham).HasName("PK__SanPham__5FFA2D424F6C5572");

            entity.ToTable("SanPham");

            entity.HasIndex(e => e.Barcode, "UQ__SanPham__177800D3CE8CE6EA").IsUnique();

            entity.Property(e => e.Barcode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ChatLieu).HasMaxLength(50);
            entity.Property(e => e.Gia).HasColumnType("decimal(12, 0)");
            entity.Property(e => e.HinhAnh).HasMaxLength(555);
            entity.Property(e => e.KieuGiay).HasMaxLength(50);
            entity.Property(e => e.MoTa).HasMaxLength(1000);
            entity.Property(e => e.TenSanPham).HasMaxLength(250);

            entity.HasOne(d => d.IdGiamGiaNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdGiamGia)
                .HasConstraintName("FK__SanPham__IdGiamG__5812160E");

            entity.HasOne(d => d.IdGioiTinhNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdGioiTinh)
                .HasConstraintName("FK__SanPham__IdGioiT__571DF1D5");

            entity.HasOne(d => d.IdHangNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPham__IdHang__5629CD9C");

            entity.HasOne(d => d.KichCoNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.KichCo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPham__KichCo__59063A47");

            entity.HasOne(d => d.MauSacNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MauSac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPham__MauSac__59FA5E80");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
