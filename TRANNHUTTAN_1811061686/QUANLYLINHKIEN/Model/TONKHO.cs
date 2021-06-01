namespace QUANLYLINHKIEN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TONKHO")]
    public partial class TONKHO
    {
        [Key]
        [StringLength(5)]
        public string MALK { get; set; }

        public int? SOLUONG { get; set; }
    }
}
