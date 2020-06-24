namespace QLKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DATPHONG")]
    public partial class DATPHONG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPhieuDat { get; set; }

        public int idPhong { get; set; }

        public int idKhachHang { get; set; }

        public int SoNguoi { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDen { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDi { get; set; }

        public double TienCoc { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual PHONG PHONG { get; set; }
    }
}
