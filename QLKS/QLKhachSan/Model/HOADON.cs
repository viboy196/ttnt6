namespace QLKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        public int idThuePhong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDen { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDi { get; set; }

        public double TongTien { get; set; }

        public virtual THUEPHONG THUEPHONG { get; set; }
    }
}
