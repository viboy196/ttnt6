namespace QLKhachSan.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ConnectQLKS : DbContext
    {
        public ConnectQLKS()
            : base("name=ConnectQLKS")
        {
        }

        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<DATPHONG> DATPHONGs { get; set; }
        public virtual DbSet<DICHVU> DICHVUs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<THUEPHONG> THUEPHONGs { get; set; }
        public virtual DbSet<THIETBI> THIETBIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.CHUCVU)
                .HasForeignKey(e => e.idChucVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.THUEPHONGs)
                .WithMany(e => e.DICHVUs)
                .Map(m => m.ToTable("SUDUNGDICHVU").MapLeftKey("idDichVu").MapRightKey("MaThue"));

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SoDT)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.CMT)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.DATPHONGs)
                .WithRequired(e => e.KHACHHANG)
                .HasForeignKey(e => e.idKhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.THUEPHONGs)
                .WithRequired(e => e.KHACHHANG)
                .HasForeignKey(e => e.idKhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.PHONGs)
                .WithRequired(e => e.LOAIPHONG)
                .HasForeignKey(e => e.idLoaiPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SoDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.CMT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.TinhTrang)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.DATPHONGs)
                .WithRequired(e => e.PHONG)
                .HasForeignKey(e => e.idPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.THIETBIs)
                .WithRequired(e => e.PHONG)
                .HasForeignKey(e => e.idPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.THUEPHONGs)
                .WithRequired(e => e.PHONG)
                .HasForeignKey(e => e.idPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THUEPHONG>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.THUEPHONG)
                .HasForeignKey(e => e.idThuePhong)
                .WillCascadeOnDelete(false);
        }
    }
}
