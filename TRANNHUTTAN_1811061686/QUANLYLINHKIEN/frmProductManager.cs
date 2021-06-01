using QUANLYLINHKIEN.Model;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYLINHKIEN
{
    public partial class frmProductManager : Form
    {
        QLLKDB Context = new QLLKDB();
        public frmProductManager()
        {
            InitializeComponent();
            dtpYear.Format = DateTimePickerFormat.Custom;
            dtpYear.CustomFormat = "yyyy";
            dtpYear.ShowUpDown = true;
        }
        private void frmProductManager_Load(object sender, EventArgs e)
        {
            SetGridViewStyle(dgv_Product);
            loadCbo();
            LoadProduct();
        }
        private void LoadProduct()
        {
            try
            {
                dgv_Product.DataSource = Context.LINHKIENs
                                        .Join
                                        (
                                            Context.NUOCSXes,
                                            L => L.MANUOC,
                                            N => N.MANUOC,
                                            (L, N) => new { L, N }
                                        )
                                        .Join
                                        (
                                            Context.LOAILKs,
                                            LN => LN.L.MALOAI,
                                            L => L.MALOAI,
                                            (LN, L) => new { LN, L }
                                        )
                                        .Join
                                        (
                                            Context.NHACUNGCAPs,
                                            LNL => LNL.LN.L.MANCC,
                                            NC => NC.MANCC,
                                            (LNL, NC) => new { LNL, NC }
                                        )
                                        .Join
                                        (
                                            Context.TONKHOs,
                                            LNLLC => LNLLC.LNL.LN.L.MALK,
                                            TK => TK.MALK,
                                            (LNLLC,TK) => new {LNLLC,TK}
                                        )
                                        .Select(p => new
                                        {
                                            MALK = p.LNLLC.LNL.LN.L.MALK,
                                            TENLK = p.LNLLC.LNL.LN.L.TENLK,
                                            TENLOAI = p.LNLLC.LNL.L.TENLOAI,
                                            TENNUOC = p.LNLLC.LNL.LN.N.TENNUOC,
                                            NAMSX = p.LNLLC.LNL.LN.L.NAMSX,
                                            TENNCC = p.LNLLC.NC.TENNCC,
                                            DONGIA = p.LNLLC.LNL.LN.L.DONGIA,
                                            SOLUONG = p.TK.SOLUONG,
                                        })
                                        .ToList();
                pb_product.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        private void loadCbo()
        {
            cboCountry.DataSource = Context.NUOCSXes.ToList();
            cboCountry.DisplayMember = "TENNUOC";
            cboCountry.ValueMember = "MANUOC";

            cboProvider.DataSource = Context.NHACUNGCAPs.Select(p => new { p.MANCC, p.TENNCC }).ToList();
            cboProvider.DisplayMember = "TENNCC";
            cboProvider.ValueMember = "MANCC";

            cboType.DataSource = Context.LOAILKs.ToList();
            cboType.DisplayMember = "TENLOAI";
            cboType.ValueMember = "MALOAI";
        }
        private void Clear()
        {
            txtID.Clear();
            txtID.Enabled = true;
            txtName.Clear();
            txtPrice.Clear();
            cboCountry.SelectedIndex = 0;
            cboProvider.SelectedIndex = 0;
            cboType.SelectedIndex = 0;
            dtpYear.Value = DateTime.Now;
        }
        private void CreateColumns(DataGridView dgview)
        {
            dgv_Product.Columns.Add("MALK", "Mã LK");
            dgv_Product.Columns.Add("TENLK", "Tên LK");
            dgv_Product.Columns.Add("TENLOAI", "Loại LK");
            dgv_Product.Columns.Add("TENNUOC", "Nước SX");
            dgv_Product.Columns.Add("NAMSX", "Năm SX");
            dgv_Product.Columns.Add("TENNCC", "Nhà CC");
            dgv_Product.Columns.Add("DONGIA", "Giá");
            dgv_Product.Columns.Add("SOLUONG", "Tồn kho");
            dgv_Product.Columns["MALK"].DataPropertyName = "MALK";
            dgv_Product.Columns["TENLK"].DataPropertyName = "TENLK";
            dgv_Product.Columns["TENLOAI"].DataPropertyName = "TENLOAI";
            dgv_Product.Columns["TENNUOC"].DataPropertyName = "TENNUOC";
            dgv_Product.Columns["NAMSX"].DataPropertyName = "NAMSX";
            dgv_Product.Columns["TENNCC"].DataPropertyName = "TENNCC";
            dgv_Product.Columns["DONGIA"].DataPropertyName = "DONGIA";
            dgv_Product.Columns["SOLUONG"].DataPropertyName = "SOLUONG";
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            CreateColumns(dgview);
            dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgview.Columns["MALK"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Columns["NAMSX"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Columns["SOLUONG"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgview.Columns["DONGIA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgview.Columns["DONGIA"].DefaultCellStyle.Format = "C0";
            dgview.Sort(dgview.Columns["MALK"], System.ComponentModel.ListSortDirection.Ascending);
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

        private void txtFindValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LoadProduct();
                var lst = Context.LINHKIENs
                                    .Join
                                        (
                                            Context.NUOCSXes,
                                            L => L.MANUOC,
                                            N => N.MANUOC,
                                            (L, N) => new { L, N }
                                        )
                                        .Join
                                        (
                                            Context.LOAILKs,
                                            LN => LN.L.MALOAI,
                                            L => L.MALOAI,
                                            (LN, L) => new { LN, L }
                                        )
                                        .Join
                                        (
                                            Context.NHACUNGCAPs,
                                            LNL => LNL.LN.L.MANCC,
                                            NC => NC.MANCC,
                                            (LNL, NC) => new { LNL, NC }
                                        )
                                        .Where(p => p.LNL.LN.L.MALK.Contains(txtFindValue.Text)
                                        || p.LNL.LN.L.TENLK.Contains(txtFindValue.Text)
                                        || p.LNL.L.TENLOAI.Contains(txtFindValue.Text)
                                        || p.NC.TENNCC.Contains(txtFindValue.Text)
                                        || p.LNL.LN.N.TENNUOC.Contains(txtFindValue.Text)
                                        )
                                        .Select(p => new
                                        {
                                            MALK = p.LNL.LN.L.MALK,
                                            TENLK = p.LNL.LN.L.TENLK,
                                            TENLOAI = p.LNL.L.TENLOAI,
                                            TENNUOC = p.LNL.LN.N.TENNUOC,
                                            NAMSX = p.LNL.LN.L.NAMSX,
                                            TENNCC = p.NC.TENNCC,
                                            DONGIA = p.LNL.LN.L.DONGIA,
                                        })
                                        .ToList();
                if (lst != null)
                {
                    dgv_Product.DataSource = lst;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void dgv_Product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pb_product.SizeMode = PictureBoxSizeMode.Zoom;
            pb_product.BackColor = Color.White;
            pb_product.BorderStyle = BorderStyle.Fixed3D;
            txtID.Enabled = false;
            int index = e.RowIndex;
            if (index >= 0 && index < dgv_Product.Rows.Count)
            {
                txtID.Enabled = false;
                txtID.Text = dgv_Product.Rows[index].Cells["MALK"].Value.ToString();
                txtName.Text = dgv_Product.Rows[index].Cells["TENLK"].Value.ToString();

                string temp = dgv_Product.Rows[index].Cells["TENNUOC"].Value.ToString().Trim();
                cboCountry.SelectedValue = (Context.NUOCSXes.Where(p => p.TENNUOC.Equals(temp)).Select(p => p.MANUOC).FirstOrDefault()).ToString();

                temp = dgv_Product.Rows[index].Cells["TENNCC"].Value.ToString().Trim();
                cboProvider.SelectedValue = (Context.NHACUNGCAPs.Where(p => p.TENNCC.Equals(temp)).Select(p => p.MANCC).FirstOrDefault()).ToString();

                temp = dgv_Product.Rows[index].Cells["TENLOAI"].Value.ToString().Trim();
                cboType.SelectedValue = (Context.LOAILKs.Where(p => p.TENLOAI.Equals(temp)).Select(p => p.MALOAI).FirstOrDefault()).ToString();

                CultureInfo provider = CultureInfo.InvariantCulture;
                dtpYear.Value = DateTime.ParseExact(dgv_Product.Rows[index].Cells["NAMSX"].Value.ToString(), "yyyy", provider);
                txtPrice.Text = dgv_Product.Rows[index].Cells["DONGIA"].Value.ToString();

                pb_product.Image = ByteToImage(Context.LINHKIENs.Where(p => p.MALK.Equals(txtID.Text)).Select(p => p.HINHANH).FirstOrDefault());

                txtAmount.Text = (Context.TONKHOs.Where(p => p.MALK.Equals(txtID.Text)).Select(p => p.SOLUONG).FirstOrDefault()).ToString();

            }
        }

        private void frmProductManager_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void icoBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtPrice.Text == "" || txtAmount.Text == "" || pb_product.Image == null)
                    throw new Exception("Vui lòng nhập đầy đủ thông tin và hình ảnh");
                if (txtID.Text.Length != 5)
                    throw new Exception("Mã linh kiện phải là 5 ký tự");
                if (!txtPrice.Text.All(Char.IsDigit))
                    throw new Exception("Giá phải là số nguyên");
                if (!txtAmount.Text.All(Char.IsDigit))
                    throw new Exception("Số lượng phải là số nguyên");
                LINHKIEN LK = Context.LINHKIENs.Where(p => p.MALK == txtID.Text).FirstOrDefault();
                if (LK != null)
                    throw new Exception("Linh kiện đã tồn tại trong cơ sở dữ liệu");
                LINHKIEN temp = new LINHKIEN();
                temp.MALK = txtID.Text;
                temp.TENLK = txtName.Text;
                temp.MALOAI = cboType.SelectedValue.ToString();
                temp.MANCC = cboProvider.SelectedValue.ToString();
                temp.MANUOC = cboCountry.SelectedValue.ToString();
                temp.NAMSX = dtpYear.Value.Year.ToString();
                temp.DONGIA = long.Parse(txtPrice.Text);
                temp.HINHANH = imageToByte(ofdSelectImage.FileName);
                Context.LINHKIENs.Add(temp);
                Context.SaveChanges();
                TONKHO tk = new TONKHO();
                tk.MALK = txtID.Text;
                tk.SOLUONG = int.Parse(txtAmount.Text);
                Context.TONKHOs.Add(tk);
                Context.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadProduct();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void DeleteChild(string MALK)
        {
            String[] maHD = { };
            int count = 0;
            for (int j = 0; j < Context.CHITIETHDs.ToList().Count; j++)
            {
                CHITIETHD ct = Context.CHITIETHDs.Where(p => p.MALK.Equals(MALK)).FirstOrDefault();
                if (ct != null)
                {
                    maHD[count] = ct.MAHD;
                    count++;
                    Context.CHITIETHDs.Remove(ct);
                    Context.SaveChanges();
                }
            }
            foreach (string st in maHD)
            {
                HOADON hd = Context.HOADONs.Where(p => p.MAHD.Equals(st)).FirstOrDefault();
                Context.HOADONs.Remove(hd);
                Context.SaveChanges();
            }
            TONKHO tk = Context.TONKHOs.Where(p => p.MALK.Equals(MALK)).FirstOrDefault();
            if(tk!=null)
            {
                Context.TONKHOs.Remove(tk);
                Context.SaveChanges();
            }    
        }
        private byte[] imageToByte(string location)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Image img = Image.FromFile(location);
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private Image ByteToImage(byte[] bytedata)
        {
            Image img = null;
            try
            {
                using (MemoryStream ms = new MemoryStream(bytedata))
                {
                    img = Image.FromStream(ms);
                }
                return img;
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi đọc ảnh");
            }
            return img;
        }
        private void icoBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || txtName.Text == "" || txtPrice.Text == "")
                    throw new Exception("Vui lòng chọn linh kiện cần xoá!");
                LINHKIEN lk = Context.LINHKIENs.Where(p => p.MALK == txtID.Text).FirstOrDefault();
                if (lk == null)
                    throw new Exception("Không tìm thấy linh kiện");
                if (MessageBox.Show("Thao tác này sẽ xoá tất cả hoá đơn có linh kiện"
                                    + txtName.Text + Environment.NewLine + "Bạn có muốn tiếp tục", "Cảnh báo"
                                    , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteChild(txtID.Text);
                    Context.LINHKIENs.Remove(lk);
                    Context.SaveChanges();
                    MessageBox.Show("Xoá thành công", "Thông báo");
                }
                LoadProduct();
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
                if (txtID.Text == "")
                    throw new Exception("Vui lòng chọn linh kiện cần sửa");
                LINHKIEN LK = Context.LINHKIENs.Where(p => p.MALK == txtID.Text).FirstOrDefault();
                if (LK == null)
                    throw new Exception("Không tìm thấy linh kiện");
                LK.TENLK = txtName.Text;
                LK.MALOAI = cboType.SelectedValue.ToString();
                LK.MANCC = cboProvider.SelectedValue.ToString();
                LK.MANUOC = cboCountry.SelectedValue.ToString();
                LK.NAMSX = dtpYear.Value.Year.ToString();
                LK.DONGIA = long.Parse(txtPrice.Text);
                LK.HINHANH = imageToByte(ofdSelectImage.FileName);
                Context.Entry(LK).State = EntityState.Modified;
                Context.SaveChanges();

                TONKHO tk = Context.TONKHOs.Where(p => p.MALK.Equals(txtID.Text)).FirstOrDefault();
                tk.SOLUONG = int.Parse(txtAmount.Text);
                Context.Entry(tk).State = EntityState.Modified;
                Context.SaveChanges();

                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadProduct();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void icoBtnImage_Click(object sender, EventArgs e)
        {
            try
            {
                ofdSelectImage = new OpenFileDialog();
                ofdSelectImage.Filter = "JPEP file|*.jpg|PNG file|*.png|All file|*.*";
                ofdSelectImage.ShowDialog();
                pb_product.ImageLocation = ofdSelectImage.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
