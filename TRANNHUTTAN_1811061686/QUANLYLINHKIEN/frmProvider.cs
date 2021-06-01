using QUANLYLINHKIEN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYLINHKIEN
{
    public partial class frmProvider : Form
    {
        public frmProvider()
        {
            InitializeComponent();
            SetGridViewStyle(dgv_Provider);
            LoadProvider();
        }
        QLLKDB Context = new QLLKDB();
        private void txtFindValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadProvider();
                var lst = Context.NHACUNGCAPs
                                    .Where(p => p.MANCC.Contains(txtFindValue.Text)
                                    || p.TENNCC.Contains(txtFindValue.Text)
                                    || p.DIACHI.Contains(txtFindValue.Text)
                                    || p.DIENTHOAI.Contains(txtFindValue.Text)
                                    )
                                    .Select(p => new { p.MANCC, p.TENNCC, p.DIACHI,p.DIENTHOAI, p.NGAYDANGKY.Value})
                                    .ToList();
                if (lst != null)
                {
                    dgv_Provider.DataSource = lst;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void LoadProvider()
        {
            try
            {
                dgv_Provider.DataSource = Context.NHACUNGCAPs
                                        .Select(p => new
                                        { 
                                            MANCC = p.MANCC,
                                            TENNCC = p.TENNCC,
                                            DIACHI = p.DIACHI,
                                            DIENTHOAI = p.DIENTHOAI,
                                            NGAYDANGKY = DbFunctions.TruncateTime(p.NGAYDANGKY.Value)
                                        })
                                        .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void Clear()
        {
            txtID.Clear();
            txtName.Clear();
            txtAdd.Clear();
            txtPhone.Clear();
        }
        private void CreateColumns(DataGridView dgview)
        {
            dgv_Provider.Columns.Add("MANCC", "Mã NCC");
            dgv_Provider.Columns.Add("TENNCC", "Tên NCC");
            dgv_Provider.Columns.Add("DIACHI", "Địa chỉ");
            dgv_Provider.Columns.Add("DIENTHOAI", "Số điện thoại");
            dgv_Provider.Columns.Add("NGAYDANGKY", "Ngày đăng ký");
            dgv_Provider.Columns["MANCC"].DataPropertyName = "MANCC";
            dgv_Provider.Columns["TENNCC"].DataPropertyName = "TENNCC";
            dgv_Provider.Columns["DIACHI"].DataPropertyName = "DIACHI";
            dgv_Provider.Columns["DIENTHOAI"].DataPropertyName = "DIENTHOAI";
            dgv_Provider.Columns["NGAYDANGKY"].DataPropertyName = "NGAYDANGKY";
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            CreateColumns(dgview);
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Provider.Columns["MANCC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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


        private void dgv_Provider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dgv_Provider.Rows.Count)
            {
                txtID.Enabled = false;
                txtID.Text = dgv_Provider.Rows[index].Cells["MANCC"].Value.ToString();
                txtName.Text = dgv_Provider.Rows[index].Cells["TENNCC"].Value.ToString();
                txtAdd.Text = dgv_Provider.Rows[index].Cells["DIACHI"].Value.ToString();
                txtPhone.Text = dgv_Provider.Rows[index].Cells["DIENTHOAI"].Value.ToString();
            }
        }

        private void frmProvider_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            Clear();
        }

        private void icoBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtAdd.Text == "" || txtPhone.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                if (txtID.Text.Length > 3)
                    throw new Exception("Mã nhà cung cấp phải ít hơn hoặc bằng 3 ký tự");
                if (txtPhone.Text.Length > 10)
                    throw new Exception("Số điện thoại phải đủ 10 ký tự");
                NHACUNGCAP ncc = Context.NHACUNGCAPs.Where(p => p.MANCC == txtID.Text).FirstOrDefault();
                if (ncc != null)
                    throw new Exception("Mã nhà cung cấp đã tồn tại trong cơ sở dữ liệu");
                NHACUNGCAP temp = new NHACUNGCAP();
                temp.MANCC = txtID.Text;
                temp.TENNCC = txtName.Text;
                temp.DIACHI = txtAdd.Text;
                temp.DIENTHOAI = txtPhone.Text;
                temp.NGAYDANGKY = System.DateTime.Now;
                Context.NHACUNGCAPs.Add(temp);
                Context.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadProvider();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void icoBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "")
                    throw new Exception("Vui lòng chọn nhà cung cấp cần sửa");
                NHACUNGCAP ncc = Context.NHACUNGCAPs.Where(p => p.MANCC == txtID.Text).FirstOrDefault();
                ncc.TENNCC = txtName.Text;
                ncc.DIACHI = txtAdd.Text;
                ncc.DIENTHOAI = txtPhone.Text;
                Context.Entry(ncc).State = EntityState.Modified;
                Context.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadProvider();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void DeleteChild(string MANCC)
        {
            for (int i = 0; i < Context.LINHKIENs.ToList().Count; i++)
            {
                LINHKIEN lk = Context.LINHKIENs.Where(p => p.MANCC == MANCC).FirstOrDefault();
                if (lk != null)
                {
                    Context.LINHKIENs.Remove(lk);
                    Context.SaveChanges();
                }
            }
        }
        private void icoBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                    throw new Exception("Vui lòng chọn nhà cung cấp cần xoá!");
                NHACUNGCAP ncc = Context.NHACUNGCAPs.Where(p => p.MANCC == txtID.Text).FirstOrDefault();
                if (MessageBox.Show("Thao tác này sẽ xoá tất cả linh kiện có nhà cung cấp là "
                                    + txtName.Text + Environment.NewLine + "Bạn có muốn tiếp tục", "Cảnh báo"
                                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteChild(txtID.Text);
                    Context.NHACUNGCAPs.Remove(ncc);
                    Context.SaveChanges();
                    MessageBox.Show("Xoá thành công", "Thông báo");
                }
                LoadProvider();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
