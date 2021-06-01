namespace QUANLYLINHKIEN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NUOCSX")]
    public partial class NUOCSX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NUOCSX()
        {
            LINHKIEN = new HashSet<LINHKIEN>();
        }

        [Key]
        [StringLength(2)]
        public string MANUOC { get; set; }

        [StringLength(50)]
        public string TENNUOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LINHKIEN> LINHKIEN { get; set; }
    }
}
