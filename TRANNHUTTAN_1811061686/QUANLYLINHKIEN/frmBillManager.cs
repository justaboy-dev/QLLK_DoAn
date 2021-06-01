using QUANLYLINHKIEN.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYLINHKIEN
{
    public partial class frmBillManager : Form
    {
        public frmBillManager()
        {
            InitializeComponent();
        }
        QLLKDB Context = new QLLKDB();
        private void LoadBill()
        {
            try
            {
                dgv_bill.DataSource = Context.KHACHHANGs.Join
                    (
                        Context.HOADONs,
                        KH => KH.MAKH,
                        HD => HD.MAKH,
                        (KH, HD) => new { KH, HD }
                    )
                    .Join
                    (
                        Context.NHANVIENs,
                        KHHD => KHHD.HD.MANV,
                        NV => NV.MANV,
                        (KHHD, NV) => new { KHHD, NV }
                    )
                    .Select
                    (
                        p => new
                        {
                            MAHD = p.KHHD.HD.MAHD,
                            TENKH = p.KHHD.KH.TENKH,
                            NGAYLAP = p.KHHD.HD.NGAYLAP,
                            TENNV = p.NV.TENNV
                        }
                    )
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void loadCbo()
        {
            cboStaff.DataSource = Context.NHANVIENs.ToList();
            cboStaff.DisplayMember = "TENNV";
            cboStaff.ValueMember = "MANV";

            cboCustomer.DataSource = Context.KHACHHANGs.Select(p => new { p.MAKH, p.TENKH }).ToList();
            cboCustomer.DisplayMember = "TENKH";
            cboCustomer.ValueMember = "MAKH";
        }
        private void Clear()
        {
            txtID.Clear();
            txtID.Enabled = true;
            cboCustomer.SelectedIndex = 0;
            cboCustomer.SelectedIndex = 0;
            dtpTime.Value = DateTime.Now;
        }
        private void CreateColumns(DataGridView dgview)
        {
            dgv_bill.Columns.Add("MAHD", "Mã hoá đơn");
            dgv_bill.Columns.Add("TENKH", "Tên khách hàng");
            dgv_bill.Columns.Add("NGAYLAP", "Ngày lập");
            dgv_bill.Columns.Add("TENNV", "Nhân viên lập");
            dgv_bill.Columns["MAHD"].DataPropertyName = "MAHD";
            dgv_bill.Columns["TENKH"].DataPropertyName = "TENKH";
            dgv_bill.Columns["NGAYLAP"].DataPropertyName = "NGAYLAP";
            dgv_bill.Columns["TENNV"].DataPropertyName = "TENNV";
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            CreateColumns(dgview);
            dgview.DefaultCellStyle.Font = new Font("Tahoma", 13);
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgview.Columns["MAHD"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Sort(dgview.Columns["MAHD"], System.ComponentModel.ListSortDirection.Ascending);
            dgview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgview.ScrollBars = ScrollBars.Both;
            dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgview.BackgroundColor = Color.White;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToResizeColumns = false;
            dgview.AllowUserToResizeRows = false;
            dgview.AllowUserToDeleteRows = false;
            dgview.AllowUserToAddRows = false;
            dgview.AllowUserToOrderColumns = true;
            dgview.MultiSelect = true;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void frmBillManager_Load(object sender, EventArgs e)
        {
            SetGridViewStyle(dgv_bill);
            LoadBill();
            loadCbo();
        }

        private void dgv_bill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtID.Enabled = false;
            if (index >= 0 && index < dgv_bill.Rows.Count)
            {
                txtID.Text = dgv_bill.Rows[index].Cells["MAHD"].Value.ToString();

                string temp = dgv_bill.Rows[index].Cells["TENKH"].Value.ToString();
                cboCustomer.SelectedValue = Context.KHACHHANGs
                    .Join
                    (
                        Context.HOADONs,
                        KH => KH.MAKH,
                        HD => HD.MAKH,
                        (KH, HD) => new { KH, HD }
                    )
                    .Where(p => p.KH.TENKH.Equals(temp) && p.HD.MAHD.Equals(txtID.Text)).Select(p => p.KH.MAKH).FirstOrDefault().ToString();

                temp = dgv_bill.Rows[index].Cells["TENNV"].Value.ToString();
                cboStaff.SelectedValue =
                    Context.HOADONs
                    .Join
                    (
                        Context.NHANVIENs,
                        HD => HD.MANV,
                        NV => NV.MANV,
                        (HD, NV) => new { HD, NV }
                    )
                    .Where(p => p.NV.TENNV.Equals(temp) && p.HD.MAHD.Equals(txtID.Text)).Select(p => p.NV.MANV).FirstOrDefault().ToString();
                dtpTime.Value = Convert.ToDateTime(dgv_bill.Rows[index].Cells["NGAYLAP"].Value);
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadBill();
                var list = Context.KHACHHANGs.Join
                    (
                        Context.HOADONs,
                        KH => KH.MAKH,
                        HD => HD.MAKH,
                        (KH, HD) => new { KH, HD }
                    )
                    .Join
                    (
                        Context.NHANVIENs,
                        KHHD => KHHD.HD.MANV,
                        NV => NV.MANV,
                        (KHHD, NV) => new { KHHD, NV }
                    )
                    .Where(p => p.KHHD.HD.MAHD.Contains(txtFind.Text) || p.KHHD.KH.TENKH.Contains(txtFind.Text) || p.NV.TENNV.Contains(txtFind.Text))
                    .Select
                    (
                        p => new
                        {
                            MAHD = p.KHHD.HD.MAHD,
                            TENKH = p.KHHD.KH.TENKH,
                            NGAYLAP = p.KHHD.HD.NGAYLAP,
                            TENNV = p.NV.TENNV
                        }
                    )
                    .ToList();
                if (list != null)
                {
                    dgv_bill.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void icoBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                    throw new Exception("Vui lòng chọn hoá đơn");
                HOADON hd = Context.HOADONs.Where(p => p.MAHD.Equals(txtID.Text)).FirstOrDefault();
                hd.MAKH = cboCustomer.SelectedValue.ToString();
                hd.MANV = cboStaff.SelectedValue.ToString();
                hd.NGAYLAP = dtpTime.Value;
                Context.Entry(hd).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                MessageBox.Show("Sửa thành công");
                LoadBill();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteCTHD(string MAHD)
        {
            for (int i = 0; i < Context.CHITIETHDs.ToList().Count; i++)
            {
                CHITIETHD ct = Context.CHITIETHDs.Where(p => p.MAHD.Equals(MAHD)).FirstOrDefault();
                if (ct != null)
                {
                    Context.CHITIETHDs.Remove(ct);
                    Context.SaveChanges();
                }
            }
        }
        private void icoBtmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                    throw new Exception("Vui lòng chọn hoá đơn");
                HOADON hd = Context.HOADONs.Where(p => p.MAHD.Equals(txtID.Text)).FirstOrDefault();
                DeleteCTHD(txtID.Text);
                Context.HOADONs.Remove(hd);
                Context.SaveChanges();
                MessageBox.Show("Xoá thành công");
                LoadBill();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void icoBtnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                    throw new Exception("Vui lòng chọn hoá đơn");
                HOADON hd = Context.HOADONs.Where(p => p.MAHD.Equals(txtID.Text)).FirstOrDefault();
                Frmreport rp = new Frmreport(hd.MAHD, hd.MAKH);
                Preview pv = new Preview(rp);
                pv.ShowDialog();
                LoadBill();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBillManager_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
