namespace QLNS.Models.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopDong")]
    public partial class HopDong
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [StringLength(50)]
        public string LoaiHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TuNgay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DenNgay { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        public bool? active { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
