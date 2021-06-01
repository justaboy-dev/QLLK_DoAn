using DevExpress.DataProcessing;
using FontAwesome.Sharp;
using QUANLYLINHKIEN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using MessageBox = System.Windows.Forms.MessageBox;
using Size = System.Drawing.Size;

namespace QUANLYLINHKIEN
{
    public partial class frmMain : Form
    {
        private IconButton currentBtn;
        private Panel leftPan;
        private Form currentChildForm;
        string tittle = string.Empty;
        string username = string.Empty;

        public frmMain()
        {
            InitializeComponent();
            leftPan = new Panel();
            leftPan.Size = new Size(12,40);
            panelMainMenu.Controls.Add(leftPan);
            this.DoubleBuffered = true;
            timer1.Start();
        }
        public frmMain(string username)
        {
            InitializeComponent();
            leftPan = new Panel();
            leftPan.Size = new Size(12, 40);
            panelMainMenu.Controls.Add(leftPan);
            this.DoubleBuffered = true;
            timer1.Start();
            this.username = username;
            lblUsername.Text = username;
            setPermission(username);
        }
        private void setPermission(string username)
        {
            string CV = context.ACCOUNTs.Where(p => p.USERNAME.Equals(username)).Select(p => p.MACV).FirstOrDefault();
            if(CV.Equals("BH"))
            {
                panelProduct.Visible = false;
                icoBtnProduct.Visible = false;
                panelStaff.Visible = false;
                icoBtnStaffManager.Visible = false;
                icoBtnAccount.Visible = false;
            }    
            else if(CV.Equals("NS"))
            {
                panelProduct.Visible = false;
                icoBtnProduct.Visible = false;
                panelSell.Visible = false;
                iconBtnSeller.Visible = false;
                icoBtnAccount.Visible = false;
            }    
            else if(CV.Equals("QK"))
            {
                panelStaff.Visible = false;
                icoBtnStaffManager.Visible = false;
                panelSell.Visible = false;
                iconBtnSeller.Visible = false;
                icoBtnAccount.Visible = false;
            }
        }
        QLLKDB context = new QLLKDB();
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(0, 255, 255);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(152, 251, 152);
            public static Color color4 = Color.FromArgb(173, 255, 47);
            public static Color color5 = Color.FromArgb(64, 224, 208);
            public static Color color6 = Color.FromArgb(75, 0, 130);
            public static Color color7 = Color.FromArgb(61, 163, 141);
        }
        private void ActiveBtn(object sender, Color color)
        {
            if (sender != null)
            {
                SetButton(sender, color);
                leftPan.BackColor = color;
                leftPan.Location = new System.Drawing.Point(currentBtn.Location.X, currentBtn.Location.Y);
                leftPan.Visible = true;
                leftPan.BringToFront();
                SetTittle(color);
            }
        }
        private void ActiveSubBtn(object sender, Color color)
        {
            //leftPan.Visible = false;
            SetButton(sender, color);
            SetTittle(color);
        }
        private void SetButton(object sender,Color color)
        {
            DisableBtn();
            currentBtn = (IconButton)sender;
            currentBtn.BackColor = Color.FromArgb(37, 36, 81);
            currentBtn.ForeColor = color;
            //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.IconColor = color;
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            //currentBtn.ImageAlign = ContentAlignment.MiddleRight;

        }
        private void SetTittle(Color color)
        {
            iconCurrentChildForm.IconChar = currentBtn.IconChar;
            iconCurrentChildForm.IconColor = color;
            lblTittle.Text = currentBtn.Text;
        }
        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(52, 130, 198);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                //currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            //SizeF sf = new SizeF(1386, 788);
            //childForm.Scale(sf);
            childForm.WindowState = FormWindowState.Maximized;
            childForm.AutoSize = true;
            childForm.AutoScaleMode = AutoScaleMode.Inherit;
            childForm.Show();
        }

        private void customizeDesing()
        {
            panelSell.Visible = false;
            panelStaff.Visible = false;
            panelProduct.Visible = false;
            pnlUserSetting.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSell.Visible == true)
                panelSell.Visible = false;
            if (panelStaff.Visible == true)
                panelStaff.Visible = false;
            if (panelProduct.Visible == true)
                panelProduct.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void icoBtnHome_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColor.color1);
            hideSubMenu();
            if(currentChildForm!=null)
            {
                currentChildForm.Close();
            }
            openChildForm(new frmHomePage());
        }

        private void icoBtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void icoBtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconBtnSeller_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSell);
            ActiveBtn(sender, RGBColor.color2);
        }

        private void icoBtnStaffManager_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStaff);
            ActiveBtn(sender, RGBColor.color3);
        }

        private void icoBtnProduct_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProduct);
            ActiveBtn(sender, RGBColor.color4);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            customizeDesing();
            hideSubMenu();
            ActiveBtn(icoBtnHome, RGBColor.color1);
            openChildForm(new frmHomePage());
        }

        private void icoBtnAccount_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColor.color5);
            openChildForm(new frmAccountManager());

        }

        private void icoBtnLogout_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColor.color6);
            frmLogin flogin = new frmLogin();
            flogin.Show();
            this.Hide();
        }
        private void icoBtnSell_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color2);
            openChildForm(new frmSell());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color4);
            openChildForm(new frmCountry());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsl_time.Text = System.DateTime.Now.ToString();
        }

        private void iconBtnType_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color4);
            openChildForm(new frmTypeProduct());
        }

        private void icoBtnProvider_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color4);
            openChildForm(new frmProvider());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color4);
            openChildForm(new frmProductManager());
        }

        private void icoBtnBill_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color2);
            openChildForm(new frmBillManager());
        }

        private void icoBtnStaff_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color3);
            openChildForm(new frmStaffManager());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveSubBtn(sender, RGBColor.color3);
            openChildForm(new frmCustomer());
        }

        private void icoBtnStatis_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, RGBColor.color7);
            openChildForm(new frmStatis());
        }
        private void settingpanel()
        {
            pnlUserSetting.Visible = !pnlUserSetting.Visible;
            if (pnlUserSetting.Visible)
            {
                icoBtnSetting.Flip = FlipOrientation.Horizontal;
            }
            else
            {
                icoBtnSetting.Flip = FlipOrientation.Normal;
            }
        }
        private void icoBtnSetting_Click(object sender, EventArgs e)
        {
            settingpanel();
        }

        private void icoBtnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePass frm = new frmChangePass(username);
            frm.ShowDialog();
            settingpanel();
        }
    }
}
