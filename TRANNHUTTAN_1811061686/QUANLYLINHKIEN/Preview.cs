using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QUANLYLINHKIEN.Report;
using QUANLYLINHKIEN.Model;

namespace QUANLYLINHKIEN
{
    public partial class Preview : DevExpress.XtraEditors.XtraForm
    {
        Frmreport rpt;
        frmStatisProduct statisProduct;
        frmStatisBill statisBill;
        public Preview(Frmreport rp)
        {
            rpt = rp;
            InitializeComponent();
        }
        public Preview(frmStatisProduct frmStatisProduct)
        {
            statisProduct = frmStatisProduct;
            InitializeComponent();
        }
        public Preview(frmStatisBill frmStatisBill)
        {
            statisBill = frmStatisBill;
            InitializeComponent();
        }
        private void Preview_Load(object sender, EventArgs e)
        {
            if (rpt != null)
            {
                rpt.CreateDocument();
                dcv_Preview.DocumentSource = rpt;
            }
            else if(statisProduct!=null)
            {
                statisProduct.CreateDocument();
                dcv_Preview.DocumentSource = statisProduct;
            }  
            else if(statisBill!=null)
            {
                statisBill.CreateDocument();
                dcv_Preview.DocumentSource = statisBill;
            }    
        }
    }
}