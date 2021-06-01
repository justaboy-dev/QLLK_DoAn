namespace QUANLYLINHKIEN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHACUNGCAP")]
    public partial class NHACUNGCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHACUNGCAP()
        {
            LINHKIEN = new HashSet<LINHKIEN>();
        }

        [Key]
        [StringLength(3)]
        public string MANCC { get; set; }

        [StringLength(50)]
        public string TENNCC { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(11)]
        public string DIENTHOAI { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYDANGKY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LINHKIEN> LINHKIEN { get; set; }
    }
}
