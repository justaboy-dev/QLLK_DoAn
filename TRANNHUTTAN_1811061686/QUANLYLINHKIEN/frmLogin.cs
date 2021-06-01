using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using QUANLYLINHKIEN.Model;

namespace QUANLYLINHKIEN
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        QLLKDB contextDB = new QLLKDB();
        private string Hashing(string inputString)
        {
            string valueHash = "";
            MD5 md = MD5.Create();
            byte[] bytes= System.Text.Encoding.UTF8.GetBytes(inputString);
            byte[] Hash = md.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for(int i=0;i<Hash.Length;i++)
            {
                sb.Append(Hash[i].ToString("X2"));
            }
            valueHash = sb.ToString();
            return valueHash;
        }
        private void icoBtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ tài khoản và mật khẩu");
                string login = txtUsername.Text + txtPassword.Text;
                string hashString = contextDB.ACCOUNTs.Where(p => p.USERNAME == txtUsername.Text).Select(p => p.HASHVALUE).FirstOrDefault();
                string hash = Hashing(login);
                if (Hashing(login)!= hashString)
                    throw new Exception("Sai tài khoản hoặc mật khẩu");
                Form fMain = new frmMain(txtUsername.Text);
                this.Hide();
                fMain.Show();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void icoBtnLogout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát","Thoát",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
