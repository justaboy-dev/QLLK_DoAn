using QUANLYLINHKIEN.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYLINHKIEN
{
    public partial class frmCountry : Form
    {
        QLLKDB Context = new QLLKDB();
        public frmCountry()
        {
            InitializeComponent();
            SetGridViewStyle(dgvCountry);
            LoadCountry();
        }
        private void LoadCountry()
        {
            try
            {
                dgvCountry.DataSource = Context.NUOCSXes.Select(p => new { p.MANUOC, p.TENNUOC }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void CreateColumns(DataGridView dgview)
        {
            dgvCountry.Columns.Add("MANUOC", "Mã nước");
            dgvCountry.Columns.Add("TENNUOC", "Tên nước");
            dgvCountry.Columns["MANUOC"].DataPropertyName = "MANUOC";
            dgvCountry.Columns["TENNUOC"].DataPropertyName = "TENNUOC";
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            CreateColumns(dgview);
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        private void icoBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                if (txtID.Text.Length > 2)
                    throw new Exception("Mã nước phải ít hơn hoặc bằng 2 ký tự");
                NUOCSX ns = Context.NUOCSXes.Where(p => p.MANUOC == txtID.Text).FirstOrDefault();
                if (ns != null)
                    throw new Exception("Mã nước đã tồn tại trong cơ sở dữ liệu");
                NUOCSX temp = new NUOCSX();
                temp.MANUOC = txtID.Text;
                temp.TENNUOC = txtName.Text;
                Context.NUOCSXes.Add(temp);
                Context.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadCountry();
                Clear();
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
        }
        private void dgvCountry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dgvCountry.Rows.Count)
            {
                txtID.Enabled = false;
                txtID.Text = dgvCountry.Rows[index].Cells["MANUOC"].Value.ToString();
                txtName.Text = dgvCountry.Rows[index].Cells["TENNUOC"].Value.ToString();
            }

        }

        private void frmCountry_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            Clear();
        }

        private void icoBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "")
                    throw new Exception("Vui lòng chọn nước cần sửa");
                NUOCSX ns = Context.NUOCSXes.Where(p => p.MANUOC == txtID.Text).FirstOrDefault();
                ns.TENNUOC = txtName.Text;
                Context.Entry(ns).State = EntityState.Modified;
                Context.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadCountry();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void DeleteChild(string MALOAI)
        {
            for (int i = 0; i < Context.LINHKIENs.ToList().Count; i++)
            {
                LINHKIEN lk = Context.LINHKIENs.Where(p => p.MANUOC == MALOAI).FirstOrDefault();
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
                    throw new Exception("Vui lòng chọn nước cần xoá!");
                NUOCSX ns = Context.NUOCSXes.Where(p => p.MANUOC == txtID.Text).FirstOrDefault();
                if (MessageBox.Show("Thao tác này sẽ xoá tất cả linh kiện có nước sản xuất là "
                                    + txtID.Text + Environment.NewLine + "Bạn có muốn tiếp tục", "Cảnh báo"
                                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteChild(txtID.Text);
                    Context.NUOCSXes.Remove(ns);
                    Context.SaveChanges();
                    MessageBox.Show("Xoá thành công", "Thông báo");
                }
                LoadCountry();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void txtFindValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadCountry();
                var lst = Context.NUOCSXes
                                    .Where(p => p.MANUOC.Contains(txtFindValue.Text) || p.TENNUOC.Contains(txtFindValue.Text))
                                    .Select(p => new { p.MANUOC, p.TENNUOC })
                                    .ToList();
                if (lst != null)
                {
                    dgvCountry.DataSource = lst;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
