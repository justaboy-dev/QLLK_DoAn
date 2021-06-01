namespace QUANLYLINHKIEN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            HOADON = new HashSet<HOADON>();
        }

        [Key]
        [StringLength(4)]
        public string MANV { get; set; }

        [StringLength(50)]
        public string TENNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NAMSINH { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(11)]
        public string DIENTHOAI { get; set; }

        [StringLength(50)]
        public string BANGCAP { get; set; }

        [StringLength(2)]
        public string MACV { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADON { get; set; }
    }
}
