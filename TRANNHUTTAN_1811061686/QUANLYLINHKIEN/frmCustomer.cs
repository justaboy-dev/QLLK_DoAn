using QUANLYLINHKIEN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYLINHKIEN
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        QLLKDB Context = new QLLKDB();
        private void LoadCustomer()
        {
            try
            {
                dgv_Customer.DataSource = Context.KHACHHANGs
                    .Select
                    (
                        p=> new
                        {
                            p.MAKH,
                            p.TENKH,
                            p.DIACHI,
                            p.DIENTHOAI,
                            p.NGAYDANGKY,
                        }
                    )
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void Clear()
        {
            txtID.Enabled = true;
            txtID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAdd.Clear();
        }
        private void CreateColumns(DataGridView dgview)
        {
            dgv_Customer.Columns.Add("MAKH", "Mã KH");
            dgv_Customer.Columns.Add("TENKH", "Tên KH");
            dgv_Customer.Columns.Add("DIACHI", "Địa chỉ");
            dgv_Customer.Columns.Add("DIENTHOAI", "ĐT");
            dgv_Customer.Columns.Add("NGAYDANGKY", "Ngày đăng ký");

            dgv_Customer.Columns["MAKH"].DataPropertyName = "MAKH";
            dgv_Customer.Columns["TENKH"].DataPropertyName = "TENKH";
            dgv_Customer.Columns["DIACHI"].DataPropertyName = "DIACHI";
            dgv_Customer.Columns["DIENTHOAI"].DataPropertyName = "DIENTHOAI";
            dgv_Customer.Columns["NGAYDANGKY"].DataPropertyName = "NGAYDANGKY";
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            CreateColumns(dgview);
            dgview.DefaultCellStyle.Font = new Font("Tahoma", 13);
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgview.Columns["MAKH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Sort(dgview.Columns["MAKH"], System.ComponentModel.ListSortDirection.Ascending);
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

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            SetGridViewStyle(dgv_Customer);
            LoadCustomer();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadCustomer();
                var list = Context.KHACHHANGs
                    .Where(p=>p.MAKH.Contains(txtFind.Text)||p.TENKH.Contains(txtFind.Text) || p.DIENTHOAI.Contains(txtFind.Text)||p.DIACHI.Contains(txtFind.Text))
                    .Select
                    (
                        p => new
                        {
                            p.MAKH,
                            p.TENKH,
                            p.DIACHI,
                            p.DIENTHOAI,
                            p.NGAYDANGKY,
                        }
                    )
                    .ToList();
                if(list != null)
                {
                    dgv_Customer.DataSource = list;
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void dgv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtID.Enabled = false;
            if (index >= 0 && index < dgv_Customer.Rows.Count)
            {
                txtID.Text = dgv_Customer.Rows[index].Cells["MAKH"].Value.ToString();
                txtName.Text = dgv_Customer.Rows[index].Cells["TENKH"].Value.ToString();
                txtAdd.Text = dgv_Customer.Rows[index].Cells["DIACHI"].Value.ToString();
                txtPhone.Text = dgv_Customer.Rows[index].Cells["DIENTHOAI"].Value.ToString();
            }
        }

        private void frmCustomer_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void icoBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtAdd.Text == "" || txtPhone.Text == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                if (txtID.Text.Length > 5)
                    throw new Exception("Mã nhân viên phải ít hơn hoặc bằng 5 ký tự");
                if (txtPhone.Text.Length != 10)
                    throw new Exception("Số điện thoại phải có 10 số");
                KHACHHANG temp = Context.KHACHHANGs.Where(p => p.MAKH.Equals(txtID.Text)).FirstOrDefault();
                if (temp != null)
                    throw new Exception("Mã khách hàng đã tồn tại");
                KHACHHANG KH = new KHACHHANG();
                KH.MAKH = txtID.Text;
                KH.TENKH = txtName.Text;
                KH.DIACHI = txtAdd.Text;
                KH.DIENTHOAI = txtPhone.Text;
                KH.NGAYDANGKY = System.DateTime.Now;
                Context.KHACHHANGs.Add(KH);
                Context.SaveChanges();
                MessageBox.Show("Thêm thành công");
                LoadCustomer();
                Clear();
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
                if (txtName.Text == "" || txtAdd.Text == "" || txtPhone.Text == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                if (txtPhone.Text.Length != 10)
                    throw new Exception("Số điện thoại phải có 10 số");
                KHACHHANG temp = Context.KHACHHANGs.Where(p => p.MAKH.Equals(txtID.Text)).FirstOrDefault();
                if (temp == null)
                    throw new Exception("Không tìm thấy khách hàng");
                temp.TENKH = txtName.Text;
                temp.DIACHI = txtAdd.Text;
                temp.DIENTHOAI = txtPhone.Text;
                Context.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                MessageBox.Show("Sửa thành công");
                LoadCustomer();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteHD(string MAKH)
        {
            for (int i = 0; i < Context.HOADONs.ToList().Count; i++)
            {
                HOADON hd = Context.HOADONs.Where(p => p.MAKH.Equals(MAKH)).FirstOrDefault();
                if (hd != null)
                {
                    for (int j = 0; j < Context.CHITIETHDs.ToList().Count; j++)
                    {
                        CHITIETHD ct = Context.CHITIETHDs.Where(p => p.MAHD.Equals(hd.MAHD)).FirstOrDefault();
                        if (ct != null)
                        {
                            Context.CHITIETHDs.Remove(ct);
                            Context.SaveChanges();
                        }
                    }
                    Context.HOADONs.Remove(hd);
                    Context.SaveChanges();
                }
            }
        }
        private void icoBtmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == null)
                    throw new Exception("Vui lòng chọn nhân viên");
                KHACHHANG KH = Context.KHACHHANGs.Where(p => p.MAKH.Equals(txtID.Text)).FirstOrDefault();
                if (MessageBox.Show("Thao tác này sẽ xoá tất cả hoá đơn của khách hàng "
                                    + txtName.Text + Environment.NewLine + "Bạn có muốn tiếp tục", "Cảnh báo"
                                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteHD(txtID.Text);
                    Context.KHACHHANGs.Remove(KH);
                    Context.SaveChanges();
                    MessageBox.Show("Xoá thành công");
                    LoadCustomer();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
