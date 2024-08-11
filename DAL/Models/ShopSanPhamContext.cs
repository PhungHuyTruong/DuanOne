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
        => optionsBuilder.UseSqlServer("Server=ANHDUC;Database=ShopSanPham;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GiamGium>(entity =>
        {
            entity.HasKey(e => e.IdGiamGia).HasName("PK__GiamGia__E0F7D8B6A9CC47C1");

            entity.ToTable(tb => tb.HasTrigger("trg_UpdateTrangThaiOnExpiry"));

            entity.HasIndex(e => e.LoaiGiamGia, "UQ__GiamGia__F08A19A72DEFF21C").IsUnique();

            entity.Property(e => e.LoaiGiamGia).HasMaxLength(50);
            entity.Property(e => e.MucGiamGia).HasColumnType("decimal(5, 0)");
            entity.Property(e => e.NgayBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
        });

        modelBuilder.Entity<GioHang>(entity =>
        {
            entity.HasKey(e => e.IdGioHang).HasName("PK__GioHang__CCE77A1F61A1CF98");

            entity.ToTable("GioHang");

            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<GioHangChiTiet>(entity =>
        {
            entity.HasKey(e => e.IdGioHangChiTiet).HasName("PK__GioHangC__349C2035CD16E328");

            entity.ToTable("GioHangChiTiet");

            entity.Property(e => e.DonGia).HasColumnType("decimal(12, 0)");
            entity.Property(e => e.GiamGia).HasColumnType("decimal(5, 0)");
            entity.Property(e => e.TenSanPham).HasMaxLength(250);
            entity.Property(e => e.ThanhTien).HasColumnType("decimal(14, 0)");

            entity.HasOne(d => d.IdGioHangNavigation).WithMany(p => p.GioHangChiTiets)
                .HasForeignKey(d => d.IdGioHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GioHangCh__IdGio__69279377");

            entity.HasOne(d => d.IdSanPhamNavigation).WithMany(p => p.GioHangChiTiets)
                .HasForeignKey(d => d.IdSanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GioHangCh__IdSan__6A1BB7B0");
        });

        modelBuilder.Entity<GioiTinh>(entity =>
        {
            entity.HasKey(e => e.IdGioiTinh).HasName("PK__GioiTinh__D10DDED2778F9683");

            entity.ToTable("GioiTinh");

            entity.HasIndex(e => e.TenGioiTinh, "UQ__GioiTinh__C21601EC0A477CAF").IsUnique();

            entity.Property(e => e.TenGioiTinh).HasMaxLength(10);
        });

        modelBuilder.Entity<HangSanPham>(entity =>
        {
            entity.HasKey(e => e.IdHang).HasName("PK__HangSanP__520EAE7B1B557C23");

            entity.ToTable("HangSanPham");

            entity.HasIndex(e => e.TenHang, "UQ__HangSanP__E6C9BFA829E68917").IsUnique();

            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.TenHang).HasMaxLength(100);
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.IdHoaDon).HasName("PK__HoaDon__4DD461C80B2BEB00");

            entity.ToTable("HoaDon");

            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TongTien).HasColumnType("decimal(14, 0)");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.IdKhachHangNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdKhachHang)
                .HasConstraintName("FK__HoaDon__IdKhachH__6FD49106");

            entity.HasOne(d => d.User).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDon__UserID__6EE06CCD");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.IdChiTiet).HasName("PK__HoaDonCh__4E91F45EF94DF9FD");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.DonGia).HasColumnType("decimal(12, 0)");
            entity.Property(e => e.GiamGia).HasColumnType("decimal(5, 0)");
            entity.Property(e => e.TenSanPham).HasMaxLength(250);
            entity.Property(e => e.ThanhTien).HasColumnType("decimal(14, 0)");

            entity.HasOne(d => d.IdHoaDonNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdHoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChi__IdHoa__74994623");

            entity.HasOne(d => d.IdSanPhamNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdSanPham)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDonChi__IdSan__758D6A5C");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.IdKhachHang).HasName("PK__KhachHan__7CF5D8366C9863B8");

            entity.ToTable("KhachHang");

            entity.HasIndex(e => e.Email, "UQ_KhachHang_Email").IsUnique();

            entity.HasIndex(e => e.SoDienThoai, "UQ_KhachHang_SoDienThoai").IsUnique();

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
            entity.HasKey(e => e.IdKichCo).HasName("PK__KichCo__830A25D8055F6DA3");

            entity.ToTable("KichCo");

            entity.HasIndex(e => e.KichCo1, "UQ__KichCo__E377A0444D28A811").IsUnique();

            entity.Property(e => e.KichCo1).HasColumnName("KichCo");
        });

        modelBuilder.Entity<MauSac>(entity =>
        {
            entity.HasKey(e => e.IdMau).HasName("PK__MauSac__0D13B745C72FD448");

            entity.ToTable("MauSac");

            entity.HasIndex(e => e.MauSac1, "UQ__MauSac__77B816877AA69951").IsUnique();

            entity.Property(e => e.MauSac1)
                .HasMaxLength(50)
                .HasColumnName("MauSac");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__NhanVien__1788CCAC939B8018");

            entity.ToTable("NhanVien", tb => tb.HasTrigger("TRG_Set_NhanVien_RoleID"));

            entity.HasIndex(e => e.PhoneNumber, "UQ__NhanVien__85FB4E380E32D03D").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__NhanVien__A9D105346302C699").IsUnique();

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
            entity.HasKey(e => e.IdSanPham).HasName("PK__SanPham__5FFA2D42C9B37530");

            entity.ToTable("SanPham");

            entity.HasIndex(e => e.Barcode, "UQ__SanPham__177800D3E701B32C").IsUnique();

            entity.Property(e => e.Barcode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ChatLieu).HasMaxLength(50);
            entity.Property(e => e.Gia).HasColumnType("decimal(12, 0)");
            entity.Property(e => e.HinhAnh).HasMaxLength(555);
            entity.Property(e => e.KieuGiay).HasMaxLength(50);
            entity.Property(e => e.MoTa).HasMaxLength(1000);
            entity.Property(e => e.TenSanPham).HasMaxLength(250);
            entity.Property(e => e.TrangThai).HasDefaultValue(true);

            entity.HasOne(d => d.IdGiamGiaNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdGiamGia)
                .HasConstraintName("FK__SanPham__IdGiamG__60924D76");

            entity.HasOne(d => d.IdGioiTinhNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdGioiTinh)
                .HasConstraintName("FK__SanPham__IdGioiT__5F9E293D");

            entity.HasOne(d => d.IdHangNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.IdHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPham__IdHang__5EAA0504");

            entity.HasOne(d => d.KichCoNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.KichCo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPham__KichCo__618671AF");

            entity.HasOne(d => d.MauSacNavigation).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.MauSac)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SanPham__MauSac__627A95E8");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
