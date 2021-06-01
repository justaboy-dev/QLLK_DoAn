using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using QUANLYLINHKIEN.Model;
using QUANLYLINHKIEN.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QUANLYLINHKIEN
{
    public partial class frmStatis : DevExpress.XtraEditors.XtraForm
    {
        public frmStatis()
        {
            InitializeComponent();
            dtpFrom.Value = Convert.ToDateTime("1/1/1995 12:00:00AM");
            dtpTo.Value = System.DateTime.Now;
        }
        List<StatisBill> statisBill = new List<StatisBill>();
        private void loadData()
        {
            statisProducts = Context.LINHKIENs.Join
                    (
                        Context.TONKHOs,
                        LK => LK.MALK,
                        TK => TK.MALK,
                        (LK, TK) => new { LK, TK }
                    )
                    .Select
                    (
                        p => new StatisProduct
                        {
                            MALK = p.LK.MALK,
                            LOAILK = p.LK.MALOAI,
                            TENLK = p.LK.TENLK,
                            SOLUONG = p.TK.SOLUONG
                        }
                    )
                    .ToList();
            statisBill = Context.HOADONs
                .Join
                (
                    Context.KHACHHANGs,
                    HD => HD.MAKH,
                    KH => KH.MAKH,
                    (HD,KH) => new {HD,KH}
                )
                .Join
                (
                    Context.NHANVIENs,
                    HDKH => HDKH.HD.MANV,
                    NV => NV.MANV,
                    (HDKH, NV) => new { HDKH, NV }
                )
                .Select
                (
                    p => new StatisBill
                    {
                        MAHD = p.HDKH.HD.MAHD,
                        NGAYLAP = p.HDKH.HD.NGAYLAP,
                        GIATRI = p.HDKH.HD.GIATRI,
                        TENKH = p.HDKH.KH.TENKH,
                        TENNV = p.NV.TENNV,
                    }
                ).ToList();
            chkFilter.DataSource = Context.LOAILKs.ToList();
            chkFilter.DisplayMember = "TENLOAI";
            chkFilter.ValueMember = "MALOAI";
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrameMain.SelectedPageIndex = tileBarGroupMenu.Items.IndexOf(e.Item);
            if (tileBarGroupMenu.Items.IndexOf(e.Item) == 1)
            {
                LoadCharBill(statisBill);
                show(true);
            }
            else
            {
                show(false);
            }
        }
        private void show(bool status)
        {
            icoBtnView.Visible = status;
            lblFrom.Visible = status;
            lblTo.Visible = status;
            dtpFrom.Visible = status;
            dtpTo.Visible = status;
        }
        QLLKDB Context = new QLLKDB();

        List<StatisProduct> statisProducts;
        private void LoadCharProduct(List<StatisProduct> list)
        {
            charControlsProduct.DataSource = list;
            charControlsProduct.Series["SrProduct"].ArgumentDataMember = "TENLK";
            charControlsProduct.Series["SrProduct"].ValueDataMembers.AddRange(new string[] { "SOLUONG" });

            charControlsProduct.Series["SrProduct"].LegendTextPattern = "{A}";
            charControlsProduct.Series["SrProduct"].Label.TextPattern = "{V:.##}SP";

            PieSeriesView myView = (PieSeriesView)charControlsProduct.Series["SrProduct"].View;
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1,
            DataFilterCondition.GreaterThanOrEqual, 9));
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
                DataFilterCondition.NotEqual, "Others"));
            myView.ExplodeMode = PieExplodeMode.UseFilters;
            myView.ExplodedDistancePercentage = 5;
            myView.RuntimeExploding = true;
        }
        private void LoadCharBill(List<StatisBill> list)
        {
            charControlsBill.DataSource = list;
            charControlsBill.Series["SrCharBill"].ArgumentDataMember = "MAHD";
            charControlsBill.Series["SrCharBill"].ValueDataMembers.AddRange(new string[] { "GIATRI" });

            charControlsBill.Series["SrCharBill"].LegendTextPattern = "{A}";
            charControlsBill.Series["SrCharBill"].Label.TextPattern = "{V:c0}";

            PieSeriesView myView = (PieSeriesView)charControlsBill.Series["SrCharBill"].View;
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1,
            DataFilterCondition.GreaterThanOrEqual, 9));
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
                DataFilterCondition.NotEqual, "Others"));
            myView.ExplodeMode = PieExplodeMode.UseFilters;
            myView.ExplodedDistancePercentage = 5;
            myView.RuntimeExploding = true;
        }

        private void icoBtnView_Click(object sender, EventArgs e)
        {
            if (icoBtnView.Visible == true)
            {
                var listFilter = statisBill.Where(p => p.NGAYLAP >= dtpFrom.Value && p.NGAYLAP.Value <= dtpTo.Value).ToList();
                LoadCharBill(listFilter);
            }
        }

        private void icoBtnPrint_Click(object sender, EventArgs e)
        {
            if (icoBtnView.Visible == false)
            {
                string selected = getSelected();
                frmStatisProduct rp = new frmStatisProduct(statisProducts, selected);
                Preview pv = new Preview(rp);
                pv.ShowDialog();
            }
            else
            {
                frmStatisBill rp = new frmStatisBill(statisBill, dtpFrom.Value, dtpTo.Value);
                Preview pv = new Preview(rp);
                pv.ShowDialog();
            }
        }
        private string getSelected()
        {
            string selected = "";
            for (int i = 0; i < chkFilter.CheckedItemsCount; i++)
            {
                selected += chkFilter.CheckedItems[i].ToString();
            }
            return selected;
        }
        private void chkFilter_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            string selected = getSelected();
            List<StatisProduct> listProduct = statisProducts.Where(p => selected.Contains(p.LOAILK)).ToList();
            LoadCharProduct(listProduct);
        }

        private void frmStatis_Load(object sender, EventArgs e)
        {
            navigationFrameMain.SelectedPageIndex = 0;
            show(false);
            loadData();
            //charControlsProduct.DataSource = statisProducts;
        }
    }
}