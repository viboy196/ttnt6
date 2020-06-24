namespace Quanlikhohang.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KhoHangContext : DbContext
    {
        public KhoHangContext()
            : base("name=KhoHangModel")
        {
        }

        public virtual DbSet<BienBanThanhLy> BienBanThanhLies { get; set; }
        public virtual DbSet<ChiTietBBTL> ChiTietBBTLs { get; set; }
        public virtual DbSet<ChiTietHDN> ChiTietHDNs { get; set; }
        public virtual DbSet<ChiTietPDNL> ChiTietPDNLs { get; set; }
        public virtual DbSet<ChiTietPTK> ChiTietPTKs { get; set; }
        public virtual DbSet<HoaDonNhapNL> HoaDonNhapNLs { get; set; }
        public virtual DbSet<NguyenLieu> NguyenLieux { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuDatNL> PhieuDatNLs { get; set; }
        public virtual DbSet<PhieuThongKe> PhieuThongKes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BienBanThanhLy>()
                .HasMany(e => e.ChiTietBBTLs)
                .WithRequired(e => e.BienBanThanhLy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDonNhapNL>()
                .HasMany(e => e.ChiTietHDNs)
                .WithRequired(e => e.HoaDonNhapNL)
                .HasForeignKey(e => e.MaHD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguyenLieu>()
                .HasMany(e => e.ChiTietBBTLs)
                .WithRequired(e => e.NguyenLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguyenLieu>()
                .HasMany(e => e.ChiTietHDNs)
                .WithRequired(e => e.NguyenLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguyenLieu>()
                .HasMany(e => e.ChiTietPDNLs)
                .WithRequired(e => e.NguyenLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NguyenLieu>()
                .HasMany(e => e.ChiTietPTKs)
                .WithRequired(e => e.NguyenLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatNL>()
                .HasMany(e => e.ChiTietPDNLs)
                .WithRequired(e => e.PhieuDatNL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuThongKe>()
                .HasMany(e => e.ChiTietPTKs)
                .WithRequired(e => e.PhieuThongKe)
                .WillCascadeOnDelete(false);
        }
    }
}
