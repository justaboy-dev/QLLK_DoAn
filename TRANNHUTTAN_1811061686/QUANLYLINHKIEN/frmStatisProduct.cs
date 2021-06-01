using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QUANLYLINHKIEN.Report;
using System.Collections.Generic;
using System.Linq;

namespace QUANLYLINHKIEN
{
    public partial class frmStatisProduct : DevExpress.XtraReports.UI.XtraReport
    {
        public frmStatisProduct()
        {
            InitializeComponent();
        }
        public frmStatisProduct(List<StatisProduct> List, string selected)
        {
            InitializeComponent();
            InitData(List, selected); ;
        }
        public void InitData(List<StatisProduct> List,string selected)
        {
            Report.DataSource = List.Where(p=>p.LOAILK.Contains(selected));
        }

    }
}
