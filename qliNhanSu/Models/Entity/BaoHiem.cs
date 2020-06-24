namespace Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoHiem")]
    public partial class BaoHiem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBH { get; set; }

        [StringLength(50)]
        public string LoaiBH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaycap { get; set; }

        [StringLength(50)]
        public string Noicap { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual BaoHiem BaoHiem1 { get; set; }

        public virtual BaoHiem BaoHiem2 { get; set; }
    }
}
