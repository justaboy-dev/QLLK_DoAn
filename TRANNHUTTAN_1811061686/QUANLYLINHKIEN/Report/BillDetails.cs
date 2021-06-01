using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYLINHKIEN.Report
{
    public class BillDetails
    {
        [Display(Name = "Mã LK")]
        public string MALK { get; set; }
        [Display(Name ="Tên sản phẩm")]
        public string TENLK { get; set; }
        [Display(Name = "Số lượng")]
        public int SL { get; set; }
        [Display(Name = "Đơn giá")]
        public long DONGIA { get; set; }
        [Display(Name = "Thành tiền")]
        public long THANHTIEN { get; set; }
        [Display(Name = "Tổng tiền")]
        public decimal GIATRI { get; set; }

    }
}
