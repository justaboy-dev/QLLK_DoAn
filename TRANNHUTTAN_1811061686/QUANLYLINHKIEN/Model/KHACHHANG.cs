namespace QUANLYLINHKIEN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            HOADON = new HashSet<HOADON>();
        }

        [Key]
        [StringLength(5)]
        public string MAKH { get; set; }

        [StringLength(50)]
        public string TENKH { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(11)]
        public string DIENTHOAI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYDANGKY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADON { get; set; }
    }
}
