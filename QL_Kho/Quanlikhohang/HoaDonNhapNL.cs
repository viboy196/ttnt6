//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quanlikhohang
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDonNhapNL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDonNhapNL()
        {
            this.ChiTietHDNs = new HashSet<ChiTietHDN>();
        }
    
        public int MaHDN { get; set; }
        public Nullable<int> MaPDNL { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public Nullable<int> MaNV { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHDN> ChiTietHDNs { get; set; }
        public virtual PhieuDatNL PhieuDatNL { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
