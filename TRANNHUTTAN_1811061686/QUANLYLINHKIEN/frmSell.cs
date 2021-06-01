using QUANLYLINHKIEN.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYLINHKIEN
{
    public partial class frmSell : Form
    {
        public frmSell()
        {
            InitializeComponent();
        }
        QLLKDB contextDB = new QLLKDB();
        int index = -1;
        private void frmSell_Load(object sender, EventArgs e)
        {
            CreateColumns(dgv_Sell);
            loadform();
        }
        private void loadform()
        {
            try
            {
                SetGridViewStyle(dgv_Sell);
                List<NHANVIEN> listStaff = contextDB.NHANVIENs.Where(p => p.MACV == "BH").ToList();
                StaffComboboxFill(listStaff);
                loadLK();
                clearText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearText()
        {
            txtAdd.Clear();
            txtFind.Clear();
            txtID.Clear();
            txtName.Clear();
            txtPhone.Clear();
        }
        private void loadLK()
        {
            dgv_Sell.DataSource = contextDB.LINHKIENs
                .Join
                (contextDB.NHACUNGCAPs,
                    LK => LK.MANCC,
                    NCC => NCC.MANCC,
                    (LK, NCC) => new { LK, NCC }
                )
                .Join
                (
                    contextDB.LOAILKs,
                    LKNCC => LKNCC.LK.MALOAI,
                    LLK => LLK.MALOAI,
                    (LKNCC, LLK) => new { LKNCC, LLK }
                )
                .Join
                (
                    contextDB.NUOCSXes,
                    LKNCCLLK => LKNCCLLK.LKNCC.LK.MANUOC,
                    NSX => NSX.MANUOC,
                    (LKNCCLLK, NSX) => new { LKNCCLLK, NSX }
                )
                .Join
                (
                    contextDB.TONKHOs,
                    LKNCCLLKNSX => LKNCCLLKNSX.LKNCCLLK.LKNCC.LK.MALK,
                    TK => TK.MALK,
                    (LKNCCLLKNSX, TK) => new
                    {
                        MALK = LKNCCLLKNSX.LKNCCLLK.LKNCC.LK.MALK,
                        TENLK = LKNCCLLKNSX.LKNCCLLK.LKNCC.LK.TENLK,
                        LOAILK = LKNCCLLKNSX.LKNCCLLK.LLK.TENLOAI,
                        DONGIA = LKNCCLLKNSX.LKNCCLLK.LKNCC.LK.DONGIA,
                        TONKHO = TK.SOLUONG.Value
                    }
                ).ToList();
            pb_product.Image = null;
            foreach (DataGridViewRow dr in dgv_Sell.Rows)
            {
                dr.Cells["SELECTED"].Value = false;
            }
        }
        private void CreateColumns(DataGridView dgview)
        {
            DataGridViewCheckBoxColumn cb = new DataGridViewCheckBoxColumn();
            cb.HeaderText = "Chọn";
            cb.Name = "SELECTED";
            cb.DataPropertyName = "SELECTED";
            dgview.Columns.Add(cb);

            dgview.Columns.Add("MALK", "Mã LK");
            dgview.Columns.Add("TENLK", "Tên LK");
            dgview.Columns.Add("LOAILK", "Loại LK");
            dgview.Columns.Add("DONGIA", "Đơn giá");
            dgview.Columns.Add("TONKHO", "Tồn kho");

            DataGridViewComboBoxColumn cbo = new DataGridViewComboBoxColumn();
            cbo.HeaderText = "Số lượng";
            cbo.Name = "AMOUNT";
            cbo.DataPropertyName = "AMOUNT";
            for (int i = 0; i <= 50; i++)
            {
                cbo.Items.Add(i.ToString());
            }
            dgview.Columns.Add(cbo);

            dgview.Columns["MALK"].DataPropertyName = "MALK";
            dgview.Columns["TENLK"].DataPropertyName = "TENLK";
            dgview.Columns["LOAILK"].DataPropertyName = "LOAILK";
            dgview.Columns["DONGIA"].DataPropertyName = "DONGIA";
            dgview.Columns["TONKHO"].DataPropertyName = "TONKHO";
        }
        private void StaffComboboxFill(List<NHANVIEN> listStaff)
        {
            cboStaff.DataSource = listStaff;
            cboStaff.DisplayMember = "TENNV";
            cboStaff.ValueMember = "MANV";
            cboStaff.SelectedIndex = 0;
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.Columns["SELECTED"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Columns["MALK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Columns["TENLK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgview.Columns["LOAILK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Columns["DONGIA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Columns["TONKHO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Columns["AMOUNT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Columns["TONKHO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgview.Columns["AMOUNT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgview.Columns["AMOUNT"].DefaultCellStyle.NullValue = "0";

            dgview.Columns["DONGIA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgview.Columns["DONGIA"].DefaultCellStyle.Format = "C0";

            //dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgview.EditMode = DataGridViewEditMode.EditOnEnter;
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
        private void checkCell()
        {
            foreach (DataGridViewRow dr in dgv_Sell.Rows)
            {
                if (dr.Cells["AMOUNT"].Value != null)
                    if (dr.Cells["AMOUNT"].Value != (object)"0")
                        dr.Cells[0].Value = true;
            }
        }
        private Image ByteToImage(byte[] bytedata)
        {
            using (MemoryStream ms = new MemoryStream(bytedata))
            {
                return Image.FromStream(ms);
            }
        }
        private void dgv_sell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0 && index < dgv_Sell.Rows.Count && dgv_Sell.Columns["AMOUNT"].Index != e.ColumnIndex)
            {
                bool isSelected = Convert.ToBoolean(dgv_Sell.Rows[index].Cells[0].Value);
                if (isSelected)
                {
                    dgv_Sell.Rows[index].Cells[0].Value = false;
                    dgv_Sell.Rows[index].Cells["AMOUNT"].Value = null;
                }
                else
                {
                    dgv_Sell.Rows[index].Cells[0].Value = true;
                    dgv_Sell.Rows[index].Cells["AMOUNT"].Value = "1";
                }
                string ID = dgv_Sell.Rows[index].Cells["MALK"].Value.ToString();
                byte[] data = (contextDB.LINHKIENs.Where(p => p.MALK.Equals(ID)).Select(p => p.HINHANH).First()).ToArray();
                if (data != null)
                {
                    SetPictureBox();
                    pb_product.Image = ByteToImage(data);
                }
            }
            checkCell();
        }
        private void SetPictureBox()
        {
            pb_product.SizeMode = PictureBoxSizeMode.Zoom;
            pb_product.BorderStyle = BorderStyle.Fixed3D;
            pb_product.BackColor = Color.White;
        }
        private bool CheckSelectedItem(DataGridViewRow dr)
        {
            return (Convert.ToBoolean(dr.Cells[0].Value) && dr.Cells["AMOUNT"] != null);
        }
        private bool CheckSelected()
        {
            foreach (DataGridViewRow item in dgv_Sell.Rows)
            {
                if (CheckSelectedItem(item))
                {
                    return true;
                }
            }
            return false;
        }
        HOADON hd;
        KHACHHANG KH = new KHACHHANG();
        private void AddToDB()
        {
            try
            {
                hd = new HOADON();
                hd.MAHD = "HD" + (contextDB.HOADONs.Count() + 1);
                hd.MAKH = txtID.Text;
                hd.MANV = cboStaff.SelectedValue.ToString();
                hd.NGAYLAP = Convert.ToDateTime(System.DateTime.Now);
                KHACHHANG check = contextDB.KHACHHANGs.Where(p => p.MAKH == txtID.Text).FirstOrDefault();
                if (check == null)
                {
                    KH.MAKH = txtID.Text;
                    KH.TENKH = txtName.Text;
                    KH.DIACHI = txtAdd.Text;
                    KH.DIENTHOAI = txtPhone.Text;
                    KH.NGAYDANGKY = Convert.ToDateTime(System.DateTime.Now);
                    contextDB.KHACHHANGs.Add(KH);
                    contextDB.SaveChanges();
                }
                long Price = 0;
                long temp = 0;
                HOADON hdon = contextDB.HOADONs.Where(p => p.MAHD == hd.MAHD).FirstOrDefault();
                if (hdon == null)
                {
                    foreach (DataGridViewRow r in dgv_Sell.Rows)
                    {
                        if (Convert.ToBoolean(r.Cells[0].Value))
                        {
                            temp =
                                (long.Parse(r.Cells["DONGIA"].Value.ToString())
                                * long.Parse(r.Cells["AMOUNT"].Value.ToString()));
                            Price += temp;
                            string malk = r.Cells["MALK"].Value.ToString();
                            TONKHO t = contextDB.TONKHOs.Where(p => p.MALK.Equals(malk)).FirstOrDefault();
                            int slmua = int.Parse(r.Cells["AMOUNT"].Value.ToString());
                            t.SOLUONG = t.SOLUONG - slmua;
                            contextDB.Entry(t).State = System.Data.Entity.EntityState.Modified;
                            contextDB.SaveChanges();
                        }
                    }
                    hd.GIATRI = Price;
                    contextDB.HOADONs.Add(hd);
                    contextDB.SaveChanges();
                }
                foreach (DataGridViewRow r in dgv_Sell.Rows)
                {
                    if (Convert.ToBoolean(r.Cells[0].Value))
                    {
                        CHITIETHD ct = new CHITIETHD();
                        ct.MAHD = hd.MAHD;
                        temp =
                            (long.Parse(r.Cells["DONGIA"].Value.ToString())
                            * long.Parse(r.Cells["AMOUNT"].Value.ToString()));
                        ct.SOLUONG = int.Parse(r.Cells["AMOUNT"].Value.ToString());
                        ct.DONGIA = int.Parse(r.Cells["DONGIA"].Value.ToString());
                        ct.THANHTIEN = temp;
                        string tenLK = r.Cells["TENLK"].Value.ToString();
                        ct.MALK = contextDB.LINHKIENs
                                    .Where(p => p.TENLK == tenLK)
                                    .Select(p => p.MALK)
                                    .FirstOrDefault().ToString();
                        contextDB.CHITIETHDs.Add(ct);
                        contextDB.SaveChanges();
                    }
                }
                contextDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void icoBtnCreateBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtAdd.Text == "" || txtName.Text == "" || txtPhone.Text == "")
                    throw new Exception("Vui lòng điền đầy đủ thông tin!");
                if (txtID.Text.Length > 5)
                    throw new Exception("Mã khách hàng phải ít hơn hoặc bằng 5 ký tự");
                if (txtPhone.Text.Length != 10)
                    throw new Exception("Số điện thoại phải có đủ 10 chữ số!");
                if (!CheckSelected())
                    throw new Exception("Vui lòng chọn sản phẩm và số lượng sản phẩm");
                AddToDB();
                Frmreport rp = new Frmreport(hd.MAHD, hd.MAKH);
                Preview pv = new Preview(rp);
                pv.ShowDialog();
                loadform();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private string RowstoString(DataGridViewRow dr)
        {
            string Str = "";
            for (int i = 2; i < dgv_Sell.Columns.Count; i++)
            {
                Str += dr.Cells[i].Value.ToString();
            }
            return Str;
        }
        private void DeSelectAll()
        {
            foreach (DataGridViewRow dr in dgv_Sell.Rows)
            {
                dr.Selected = false;
            }
        }
        private void icoBtnFind_Click(object sender, EventArgs e)
        {
            bool flag = false;
            DeSelectAll();
            try
            {
                if (txtFind.Text == "")
                    throw new Exception("Nhập giá trị tìm kiếm !");
                foreach (DataGridViewRow dr in dgv_Sell.Rows)
                {
                    string str = RowstoString(dr);
                    if (str.ToUpper().Contains(txtFind.Text.ToUpper()))
                    {
                        dr.Selected = true;
                        dgv_Sell.FirstDisplayedScrollingRowIndex = dr.Index;
                        flag = true;
                    }
                }
                if (flag != true)
                    throw new Exception("Không tìm thấy sản phẩm");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void dgv_Sell_Leave(object sender, EventArgs e)
        {
            dgv_Sell.EndEdit(DataGridViewDataErrorContexts.Commit);
            checkCell();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            KHACHHANG kh = contextDB.KHACHHANGs.Where(p => p.MAKH == txtID.Text).FirstOrDefault();
            if (kh != null)
            {
                txtName.Text = kh.TENKH;
                txtAdd.Text = kh.DIACHI;
                txtPhone.Text = kh.DIENTHOAI;
            }
            else
            {
                txtName.Clear();
                txtAdd.Clear();
                txtPhone.Clear();
            }
        }
    }
}

