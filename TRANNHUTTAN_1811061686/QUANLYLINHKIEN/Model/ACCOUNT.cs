namespace QUANLYLINHKIEN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Key]
        [StringLength(20)]
        public string USERNAME { get; set; }

        [StringLength(33)]
        public string HASHVALUE { get; set; }

        [StringLength(2)]
        public string MACV { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }
    }
}
