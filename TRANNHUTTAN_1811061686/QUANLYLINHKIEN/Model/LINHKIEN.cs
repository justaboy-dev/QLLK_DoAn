namespace QUANLYLINHKIEN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LINHKIEN")]
    public partial class LINHKIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LINHKIEN()
        {
            CHITIETHD = new HashSet<CHITIETHD>();
        }

        [Key]
        [StringLength(5)]
        public string MALK { get; set; }

        [StringLength(100)]
        public string TENLK { get; set; }

        [StringLength(3)]
        public string MALOAI { get; set; }

        [StringLength(2)]
        public string MANUOC { get; set; }

        [StringLength(4)]
        public string NAMSX { get; set; }

        [StringLength(3)]
        public string MANCC { get; set; }

        public long? DONGIA { get; set; }

        [Column(TypeName = "image")]
        public byte[] HINHANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHD> CHITIETHD { get; set; }

        public virtual LOAILK LOAILK { get; set; }

        public virtual NUOCSX NUOCSX { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
