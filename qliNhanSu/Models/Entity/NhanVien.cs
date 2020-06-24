namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            BaoHiems = new HashSet<BaoHiem>();
            HopDongs = new HashSet<HopDong>();
        }

        [Key]
        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaysinh { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(20)]
        public string DanToc { get; set; }

        [StringLength(50)]
        public string QueQuan { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }

        [StringLength(10)]
        public string MaPB { get; set; }

        [StringLength(10)]
        public string MaCV { get; set; }

        [StringLength(10)]
        public string MaLuong { get; set; }

        [StringLength(10)]
        public string MaTD { get; set; }

        public bool? active { get; set; }

        public int? isdelete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoHiem> BaoHiems { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HopDong> HopDongs { get; set; }

        public virtual Luong Luong { get; set; }

        public virtual PhongBan PhongBan { get; set; }

        public virtual TrinhDoHV TrinhDoHV { get; set; }
    }
}
