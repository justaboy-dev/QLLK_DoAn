using DevExpress.DataAccess.Native.Sql.ConnectionProviders;
using QUANLYLINHKIEN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYLINHKIEN
{
    public partial class frmAccountManager : Form
    {
        QLLKDB context = new QLLKDB();
        public frmAccountManager()
        {
            InitializeComponent();
        }
        private void frmAccountManager_Load(object sender, EventArgs e)
        {
            SetGridViewStyle(dgv_Account);
            LoadCbo(cboCV);
            loadAccount();
        }
        private void loadAccount()
        {
               dgv_Account.DataSource = context.ACCOUNTs
                                        .Join
                                        (
                                            context.CHUCVUs,
                                            AC => AC.MACV,
                                            CV => CV.MACV,
                                            (AC, CV) => new
                                            {
                                                USERNAME = AC.USERNAME,
                                                HASHVALUE = AC.HASHVALUE,
                                                TENCV = CV.TENCV,
                                            }
                                        )
                                        .ToList();
        }
        private void Clear()
        {
            txtUsername.Clear();
            txtPasswork.Clear();
            cboCV.SelectedIndex = 0;
            txtUsername.Enabled = true;
        }
        private void LoadCbo(ComboBox cbo)
        {
            cbo.DataSource = context.CHUCVUs.Select(p => new { p.MACV, p.TENCV }).ToList();
            cbo.DisplayMember = "TENCV";
            cbo.ValueMember = "MACV";
        }
        private void CreateColumns(DataGridView dgview)
        {
            dgview.Columns.Add("USERNAME", "Tên tài khoản");
            dgview.Columns.Add("HASHVALUE", "Hashing");
            dgview.Columns.Add("TENCV", "Chức vụ");
            dgview.Columns["USERNAME"].DataPropertyName = "USERNAME";
            dgview.Columns["HASHVALUE"].DataPropertyName = "HASHVALUE";
            dgview.Columns["TENCV"].DataPropertyName = "TENCV";
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            CreateColumns(dgview);

            dgview.Columns["USERNAME"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Columns["TENCV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
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
        private string Hashing(string inputString)
        {
            string valueHash = "";
            MD5 md = MD5.Create();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(inputString);
            byte[] Hash = md.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Hash.Length; i++)
            {
                sb.Append(Hash[i].ToString("X2"));
            }
            valueHash = sb.ToString();
            return valueHash;
        }

        private void icoBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPasswork.Text == "")
                    throw new Exception("Vui lòng nhập đủ thông tin");
                ACCOUNT acc = context.ACCOUNTs.Where(p => p.USERNAME.Equals(txtUsername.Text)).FirstOrDefault();
                if(acc!=null)
                    throw new Exception("Tên tài khoản đã tồn tại");
                ACCOUNT ac = new ACCOUNT();
                ac.USERNAME = txtUsername.Text;
                ac.HASHVALUE = Hashing(txtUsername.Text + txtPasswork.Text);
                ac.MACV = cboCV.SelectedValue.ToString();
                context.ACCOUNTs.Add(ac);
                context.SaveChanges();
                loadAccount();
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void icoBtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "")
                    throw new Exception("Vui lòng chọn tài khoản cần sửa");
                ACCOUNT acc = context.ACCOUNTs.Where(p => p.USERNAME.Equals(txtUsername.Text)).FirstOrDefault();
                if (acc == null)
                    throw new Exception("Không tìm thấy tài khoản");
                if (txtUsername.Text == "" || txtPasswork.Text == "")
                    throw new Exception("Vui lòng nhập đủ thông tin");
                acc.HASHVALUE = Hashing(txtUsername.Text + txtPasswork.Text);
                acc.MACV = cboCV.SelectedValue.ToString();
                context.Entry(acc).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                loadAccount();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void icoBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "")
                    throw new Exception("Vui lòng chọn tài khoản cần xoá");
                ACCOUNT acc = context.ACCOUNTs.Where(p => p.USERNAME.Equals(txtUsername.Text)).FirstOrDefault();
                if (acc == null)
                    throw new Exception("Không tìm thấy tài khoản");
                if (MessageBox.Show("Bạn có chắc chắn xoá tài khoản "
                    + acc.USERNAME + Environment.NewLine
                    + "Sau khi xoá tài khoản sẽ không thể truy cập phần mềm", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    context.ACCOUNTs.Remove(acc);
                    context.SaveChanges();
                    loadAccount();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void dgv_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >=0 && index < dgv_Account.Rows.Count)
            {
                txtUsername.Enabled = false;
                txtUsername.Text = dgv_Account.Rows[index].Cells["USERNAME"].Value.ToString();
                String temp = dgv_Account.Rows[index].Cells["TENCV"].Value.ToString();
                cboCV.SelectedValue = context.CHUCVUs.Where(p => p.TENCV.Equals(temp)).Select(p => p.MACV).FirstOrDefault().ToString();
            }    
        }

        private void frmAccountManager_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtFindValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadAccount();
                dgv_Account.DataSource = context.ACCOUNTs
                                        .Join
                                        (
                                            context.CHUCVUs,
                                            AC => AC.MACV,
                                            CV => CV.MACV,
                                            (AC, CV) => new
                                            {
                                                USERNAME = AC.USERNAME,
                                                HASHVALUE = AC.HASHVALUE,
                                                TENCV = CV.TENCV,
                                            }
                                        )
                                        .Where(p => p.USERNAME.Contains(txtFindValue.Text) || p.TENCV.Contains(txtFindValue.Text))
                                        .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
