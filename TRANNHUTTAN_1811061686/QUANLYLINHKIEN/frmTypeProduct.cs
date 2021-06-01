using QUANLYLINHKIEN.Model;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYLINHKIEN
{
    public partial class frmTypeProduct : Form
    {
        QLLKDB Context = new QLLKDB();
        public frmTypeProduct()
        {
            InitializeComponent();
            SetGridViewStyle(dgv_ProducType);
            LoadProductType();
        }
        private void Clear()
        {
            txtID.Clear();
            txtName.Clear();
        }
        private void LoadProductType()
        {
            try
            {
                dgv_ProducType.DataSource = Context.LOAILKs.Select(p => new { p.MALOAI, p.TENLOAI }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void CreateColumns(DataGridView dgview)
        {
            dgv_ProducType.Columns.Add("MALOAI", "Mã loại linh kiện");
            dgv_ProducType.Columns.Add("TENLOAI", "Tên loại linh kiện");
            dgv_ProducType.Columns["MALOAI"].DataPropertyName = "MALOAI";
            dgv_ProducType.Columns["TENLOAI"].DataPropertyName = "TENLOAI";
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
        private void dgv_ProducType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dgv_ProducType.Rows.Count)
            {
                txtID.Enabled = false;
                txtID.Text = dgv_ProducType.Rows[index].Cells["MALOAI"].Value.ToString();
                txtName.Text = dgv_ProducType.Rows[index].Cells["TENLOAI"].Value.ToString();
            }
        }

        private void frmTypeProduct_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            Clear();
        }

        private void icoBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                if (txtID.Text.Length > 3)
                    throw new Exception("Mã loại linh kiện phải ít hơn hoặc bằng 3 ký tự");
                LOAILK lk = Context.LOAILKs.Where(p => p.MALOAI == txtID.Text).FirstOrDefault();
                if (lk != null)
                    throw new Exception("Mã loại linh kiện đã tồn tại trong cơ sở dữ liệu");
                LOAILK temp = new LOAILK();
                temp.MALOAI = txtID.Text;
                temp.TENLOAI = txtName.Text;
                Context.LOAILKs.Add(temp);
                Context.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadProductType();
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
                    throw new Exception("Vui lòng chọn loại linh kiện cần sửa");
                LOAILK lk = Context.LOAILKs.Where(p => p.MALOAI == txtID.Text).FirstOrDefault();
                lk.TENLOAI = txtName.Text;
                Context.Entry(lk).State = EntityState.Modified;
                Context.SaveChanges();
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadProductType();
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
                LINHKIEN lk = Context.LINHKIENs.Where(p => p.MALOAI == MALOAI).FirstOrDefault();
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
                    throw new Exception("Vui lòng chọn loại linh kiện cần xoá!");
                LOAILK lk = Context.LOAILKs.Where(p => p.MALOAI == txtID.Text).FirstOrDefault();
                if (MessageBox.Show("Thao tác này sẽ xoá tất cả linh kiện có mã loại là "
                                    + txtName.Text + Environment.NewLine + "Bạn có muốn tiếp tục", "Cảnh báo"
                                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteChild(txtID.Text);
                    Context.LOAILKs.Remove(lk);
                    Context.SaveChanges();
                    MessageBox.Show("Xoá thành công", "Thông báo");
                }
                LoadProductType();
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
                LoadProductType();
                var lst = Context.LOAILKs
                                    .Where(p => p.MALOAI.Contains(txtFindValue.Text) || p.TENLOAI.Contains(txtFindValue.Text))
                                    .Select(p => new { p.MALOAI, p.TENLOAI })
                                    .ToList();
                if (lst != null)
                {
                    dgv_ProducType.DataSource = lst;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
