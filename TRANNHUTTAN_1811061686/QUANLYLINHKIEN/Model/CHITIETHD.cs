namespace QUANLYLINHKIEN.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHD")]
    public partial class CHITIETHD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string MAHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string MALK { get; set; }

        public int? SOLUONG { get; set; }

        public long? DONGIA { get; set; }

        public long? THANHTIEN { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual LINHKIEN LINHKIEN { get; set; }
    }
}
