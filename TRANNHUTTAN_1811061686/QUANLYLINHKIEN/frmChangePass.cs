using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYLINHKIEN.Model;

namespace QUANLYLINHKIEN
{
    public partial class frmChangePass : Form
    {
        QLLKDB context = new QLLKDB();
        string username = "";
        public frmChangePass()
        {
            InitializeComponent();
        }
        public frmChangePass(string username)
        {
            InitializeComponent();
            this.username = username;
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
        private void icoBtnChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOldPass.Text == "" || txtNewPass.Text == "" || txtRepeatNewPass.Text == "")
                    throw new Exception("Vui lòng nhập đủ thông tin");
                ACCOUNT acc = context.ACCOUNTs.Where(p => p.USERNAME.Equals(username)).FirstOrDefault();
                if(acc!=null)
                {
                    string user = acc.USERNAME + txtOldPass.Text;
                    if (!(Hashing(user).Equals(acc.HASHVALUE)))
                        throw new Exception("Sai mật khẩu cũ");
                    if(!txtNewPass.Text.Equals(txtRepeatNewPass.Text))
                        throw new Exception("Sai mật mật khẩu mới không giống nhau");
                    if(txtOldPass.Text.Equals(txtNewPass.Text))
                        throw new Exception("Mật khẩu mới không được giống mật khẩu cũ");
                    acc.HASHVALUE = Hashing(acc.USERNAME + txtNewPass.Text);
                    context.Entry(acc).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show("Đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void icoBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
