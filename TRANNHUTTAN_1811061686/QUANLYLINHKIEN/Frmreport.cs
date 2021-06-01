using QUANLYLINHKIEN.Report;
using System;
using System.Collections.Generic;
using QUANLYLINHKIEN.Model;
using System.Linq;

namespace QUANLYLINHKIEN
{
    public partial class Frmreport : DevExpress.XtraReports.UI.XtraReport
    {
        QLLKDB context = new QLLKDB();
        string MAHDs;
        string MAKHs;
        public Frmreport()
        {
            InitializeComponent();
        }
        public Frmreport(string MAHD, string MAKH)
        {
            InitializeComponent();
            MAHDs = MAHD;
            MAKHs = MAKH;
            InitData(MAHDs, MAKHs);
        }
        private void InitData(string MAHD, string MAKH)
        {
            BillCustomer obj = context.KHACHHANGs.Join(
                                                            context.HOADONs,
                                                            kh => kh.MAKH,
                                                            hd => hd.MAKH,
                                                            (kh, hd) => new { kh, hd }
                                                      )
                                                 .Join(
                                                            context.NHANVIENs,
                                                            khhd => khhd.hd.MANV,
                                                            nv => nv.MANV,
                                                            (khhd, nv) => new { khhd, nv }
                                                      )
                                                 .Where(p => p.khhd.hd.MAKH == MAKHs && p.khhd.hd.MAHD == MAHDs)
                                                 .Select(p => new BillCustomer
                                                 {
                                                     MAHD = p.khhd.hd.MAHD,
                                                     TENKH = p.khhd.kh.TENKH,
                                                     DIACHI = p.khhd.kh.DIACHI,
                                                     DIENTHOAI = p.khhd.kh.DIENTHOAI,
                                                     NGAYLAP = p.khhd.hd.NGAYLAP.Value,
                                                     NHANVIEN = p.nv.TENNV
                                                 }
                                                 ).FirstOrDefault();
            if (obj != null)
            {
                List<BillDetails> listDetails = context.CHITIETHDs.Join
                                        (
                                            context.LINHKIENs,
                                            ct => ct.MALK,
                                            lk => lk.MALK,
                                            (ct, lk) => new { ct, lk }
                                        ).Where(p => p.ct.MAHD == MAHDs).Select(p => new BillDetails
                                        {
                                            MALK = p.ct.MALK,
                                            TENLK = p.lk.TENLK,
                                            SL = p.ct.SOLUONG.Value,
                                            DONGIA = p.ct.DONGIA.Value,
                                            THANHTIEN = p.ct.THANHTIEN.Value,
                                        }
                                        )
                                        .ToList();
                //Frmreport rp = new Frmreport();
                foreach (DevExpress.XtraReports.Parameters.Parameter p in this.Parameters)
                    p.Visible = false;
                pMaHD.Value = obj.MAHD;
                pCustomer.Value = obj.TENKH;
                pAdd.Value = obj.DIACHI;
                pPhone.Value = obj.DIENTHOAI;
                pNhanVien.Value = obj.NHANVIEN;
                pNgayLap.Value = obj.NGAYLAP;

                //this.DataSource = listDetails;
                Report.DataSource = listDetails;
            }
        }
    }
}
