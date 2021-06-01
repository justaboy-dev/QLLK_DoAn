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
    public partial class frmStatisBill : DevExpress.XtraReports.UI.XtraReport
    {
        public frmStatisBill()
        {
            InitializeComponent();
        }
        public frmStatisBill(List<StatisBill> List, DateTime from, DateTime To)
        {
            InitializeComponent();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in this.Parameters)
                p.Visible = false;
            pFrom.Value = from;
            pTo.Value = To;
            Report.DataSource = List.Where(p => p.NGAYLAP >= from && p.NGAYLAP.Value <= To).ToList();
        }

    }
}
