using QUANLYLINHKIEN.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYLINHKIEN
{
    public partial class frmStaffManager : Form
    {
        public frmStaffManager()
        {
            InitializeComponent();
        }
        QLLKDB Context = new QLLKDB();
        private void LoadStaff()
        {
            try
            {
                dgv_Staff.DataSource = Context.NHANVIENs
                    .Join
                    (
                        Context.CHUCVUs,
                        NV => NV.MACV,
                        CV => CV.MACV,
                        (NV, CV) => new { NV, CV }
                    )
                    .Select
                    (
                        p => new
                        {
                            MANV = p.NV.MANV,
                            TENNV = p.NV.TENNV,
                            NAMSINH = p.NV.NAMSINH,
                            DIACHI = p.NV.DIACHI,
                            DIENTHOAI = p.NV.DIENTHOAI,
                            BANGCAP = p.NV.BANGCAP,
                            VITRI = p.CV.TENCV,
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
            cboPos.DataSource = Context.CHUCVUs.ToList();
            cboPos.DisplayMember = "TENCV";
            cboPos.ValueMember = "MACV";
        }
        private void Clear()
        {
            txtID.Enabled = true;
            txtID.Clear();
            txtDegree.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAdd.Clear();
            cboPos.SelectedIndex = 0;
            dtpYoB.Value = DateTime.Now;
        }
        private void CreateColumns(DataGridView dgview)
        {
            dgv_Staff.Columns.Add("MANV", "Mã NV");
            dgv_Staff.Columns.Add("TENNV", "Tên NV");
            dgv_Staff.Columns.Add("NAMSINH", "Năm sinh");
            dgv_Staff.Columns.Add("DIACHI", "Địa chỉ");
            dgv_Staff.Columns.Add("DIENTHOAI", "ĐT");
            dgv_Staff.Columns.Add("BANGCAP", "Bằng cấp");
            dgv_Staff.Columns.Add("VITRI", "Chức vụ");

            dgv_Staff.Columns["MANV"].DataPropertyName = "MANV";
            dgv_Staff.Columns["TENNV"].DataPropertyName = "TENNV";
            dgv_Staff.Columns["NAMSINH"].DataPropertyName = "NAMSINH";
            dgv_Staff.Columns["DIACHI"].DataPropertyName = "DIACHI";
            dgv_Staff.Columns["DIENTHOAI"].DataPropertyName = "DIENTHOAI";
            dgv_Staff.Columns["BANGCAP"].DataPropertyName = "BANGCAP";
            dgv_Staff.Columns["VITRI"].DataPropertyName = "VITRI";
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            CreateColumns(dgview);
            dgview.DefaultCellStyle.Font = new Font("Tahoma", 13);
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgview.Columns["MANV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Sort(dgview.Columns["MANV"], System.ComponentModel.ListSortDirection.Ascending);
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

        private void frmStaffManager_Load(object sender, EventArgs e)
        {
            SetGridViewStyle(dgv_Staff);
            LoadStaff();
            loadCbo();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadStaff();
                var list = Context.NHANVIENs
                    .Join
                    (
                        Context.CHUCVUs,
                        NV => NV.MACV,
                        CV => CV.MACV,
                        (NV, CV) => new { NV, CV }
                    )
                    .Where(p => p.NV.MANV.Contains(txtFind.Text) || p.NV.TENNV.Contains(txtFind.Text) || p.NV.BANGCAP.Contains(txtFind.Text) || p.CV.TENCV.Contains(txtFind.Text))
                    .Select
                    (
                        p => new
                        {
                            MANV = p.NV.MANV,
                            TENNV = p.NV.TENNV,
                            NAMSINH = p.NV.NAMSINH,
                            DIACHI = p.NV.DIACHI,
                            DIENTHOAI = p.NV.DIENTHOAI,
                            BANGCAP = p.NV.BANGCAP,
                            VITRI = p.CV.TENCV,
                        }
                    )
                    .ToList();
                if (list != null)
                {
                    dgv_Staff.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void icoBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtDegree.Text == "" || txtAdd.Text == "" || txtPhone.Text == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                if (txtID.Text.Length > 4)
                    throw new Exception("Mã nhân viên phải ít hơn hoặc bằng 4 ký tự");
                if (txtPhone.Text.Length != 10)
                    throw new Exception("Số điện thoại phải có 10 số");
                NHANVIEN temp = Context.NHANVIENs.Where(p => p.MANV.Equals(txtID.Text)).FirstOrDefault();
                if (temp != null)
                    throw new Exception("Mã nhân viên đã tồn tại");
                NHANVIEN NV = new NHANVIEN();
                NV.MANV = txtID.Text;
                NV.TENNV = txtName.Text;
                NV.DIACHI = txtAdd.Text;
                NV.DIENTHOAI = txtPhone.Text;
                NV.BANGCAP = txtDegree.Text;
                NV.NAMSINH = dtpYoB.Value;
                NV.MACV = cboPos.SelectedValue.ToString();
                Context.NHANVIENs.Add(NV);
                Context.SaveChanges();
                MessageBox.Show("Thêm thành công");
                LoadStaff();
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
                if (txtName.Text == "" || txtDegree.Text == "" || txtAdd.Text == "" || txtPhone.Text == "")
                    throw new Exception("Vui lòng điền đủ thông tin");
                if (txtPhone.Text.Length != 10)
                    throw new Exception("Số điện thoại phải có 10 số");
                NHANVIEN NV = Context.NHANVIENs.Where(p => p.MANV.Equals(txtID.Text)).FirstOrDefault();
                if (NV == null)
                    throw new Exception("Không tìm thấy !");
                NV.TENNV = txtName.Text;
                NV.DIACHI = txtAdd.Text;
                NV.DIENTHOAI = txtPhone.Text;
                NV.BANGCAP = txtDegree.Text;
                NV.NAMSINH = dtpYoB.Value;
                NV.MACV = cboPos.SelectedValue.ToString();
                Context.Entry(NV).State = System.Data.Entity.EntityState.Modified;
                Context.SaveChanges();
                MessageBox.Show("Sửa thành công");
                LoadStaff();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmStaffManager_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void DeleteHD(string MANV)
        {
            for (int i = 0; i < Context.HOADONs.ToList().Count; i++)
            {
                HOADON hd = Context.HOADONs.Where(p => p.MANV.Equals(MANV)).FirstOrDefault();
                if(hd!=null)
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
                NHANVIEN nv = Context.NHANVIENs.Where(p => p.MANV.Equals(txtID.Text)).FirstOrDefault();
                if (MessageBox.Show("Thao tác này sẽ xoá tất cả hoá đơn từ nhân viên "
                                    + txtName.Text + Environment.NewLine + "Bạn có muốn tiếp tục", "Cảnh báo"
                                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteHD(txtID.Text);
                    Context.NHANVIENs.Remove(nv);
                    Context.SaveChanges();
                    MessageBox.Show("Xoá thành công");
                    LoadStaff();
                    Clear();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_Staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtID.Enabled = false;
            if (index >= 0 && index < dgv_Staff.Rows.Count)
            {
                txtID.Text = dgv_Staff.Rows[index].Cells["MANV"].Value.ToString();
                txtName.Text = dgv_Staff.Rows[index].Cells["TENNV"].Value.ToString();
                txtAdd.Text = dgv_Staff.Rows[index].Cells["DIACHI"].Value.ToString();
                txtDegree.Text = dgv_Staff.Rows[index].Cells["BANGCAP"].Value.ToString();
                txtPhone.Text = dgv_Staff.Rows[index].Cells["DIENTHOAI"].Value.ToString();
                dtpYoB.Value = Convert.ToDateTime(dgv_Staff.Rows[index].Cells["NAMSINH"].Value);
                string temp = dgv_Staff.Rows[index].Cells["VITRI"].Value.ToString();
                cboPos.SelectedValue = Context.CHUCVUs.Where(p => p.TENCV.Equals(temp)).Select(p => p.MACV).FirstOrDefault().ToString();
            }
        }
    }
}
