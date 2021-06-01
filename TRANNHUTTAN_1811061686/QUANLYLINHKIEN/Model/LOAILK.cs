namespace QUANLYLINHKIEN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAILK")]
    public partial class LOAILK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAILK()
        {
            LINHKIEN = new HashSet<LINHKIEN>();
        }

        [Key]
        [StringLength(3)]
        public string MALOAI { get; set; }

        [StringLength(50)]
        public string TENLOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LINHKIEN> LINHKIEN { get; set; }
    }
}
