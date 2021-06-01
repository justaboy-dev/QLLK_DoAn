namespace QUANLYLINHKIEN
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.icoUsername = new FontAwesome.Sharp.IconPictureBox();
            this.iconUserpassword = new FontAwesome.Sharp.IconPictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.icoBtnLogin = new FontAwesome.Sharp.IconButton();
            this.iconTittle = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.icoBtnLogout = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.icoUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTittle)).BeginInit();
            this.SuspendLayout();
            // 
            // icoUsername
            // 
            this.icoUsername.BackColor = System.Drawing.Color.Transparent;
            this.icoUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.icoUsername.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.icoUsername.IconColor = System.Drawing.Color.Gainsboro;
            this.icoUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoUsername.IconSize = 36;
            this.icoUsername.Location = new System.Drawing.Point(65, 78);
            this.icoUsername.Name = "icoUsername";
            this.icoUsername.Size = new System.Drawing.Size(46, 36);
            this.icoUsername.TabIndex = 0;
            this.icoUsername.TabStop = false;
            // 
            // iconUserpassword
            // 
            this.iconUserpassword.BackColor = System.Drawing.Color.Transparent;
            this.iconUserpassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconUserpassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconUserpassword.IconColor = System.Drawing.Color.Gainsboro;
            this.iconUserpassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUserpassword.IconSize = 36;
            this.iconUserpassword.Location = new System.Drawing.Point(65, 137);
            this.iconUserpassword.Name = "iconUserpassword";
            this.iconUserpassword.Size = new System.Drawing.Size(46, 36);
            this.iconUserpassword.TabIndex = 1;
            this.iconUserpassword.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsername.Location = new System.Drawing.Point(127, 78);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(354, 36);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword.Location = new System.Drawing.Point(127, 137);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(354, 36);
            this.txtPassword.TabIndex = 2;
            // 
            // icoBtnLogin
            // 
            this.icoBtnLogin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icoBtnLogin.ForeColor = System.Drawing.Color.Gainsboro;
            this.icoBtnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.icoBtnLogin.IconColor = System.Drawing.Color.Gainsboro;
            this.icoBtnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnLogin.IconSize = 48;
            this.icoBtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnLogin.Location = new System.Drawing.Point(127, 206);
            this.icoBtnLogin.Name = "icoBtnLogin";
            this.icoBtnLogin.Rotation = 0D;
            this.icoBtnLogin.Size = new System.Drawing.Size(161, 50);
            this.icoBtnLogin.TabIndex = 3;
            this.icoBtnLogin.Text = "ĐĂNG NHẬP";
            this.icoBtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnLogin.UseVisualStyleBackColor = false;
            this.icoBtnLogin.Click += new System.EventHandler(this.icoBtnLogin_Click);
            // 
            // iconTittle
            // 
            this.iconTittle.BackColor = System.Drawing.Color.Transparent;
            this.iconTittle.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconTittle.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.iconTittle.IconColor = System.Drawing.Color.Gainsboro;
            this.iconTittle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTittle.IconSize = 54;
            this.iconTittle.Location = new System.Drawing.Point(127, 12);
            this.iconTittle.Name = "iconTittle";
            this.iconTittle.Size = new System.Drawing.Size(56, 54);
            this.iconTittle.TabIndex = 4;
            this.iconTittle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(189, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // icoBtnLogout
            // 
            this.icoBtnLogout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnLogout.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icoBtnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.icoBtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.icoBtnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.icoBtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnLogout.IconSize = 48;
            this.icoBtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnLogout.Location = new System.Drawing.Point(345, 206);
            this.icoBtnLogout.Name = "icoBtnLogout";
            this.icoBtnLogout.Rotation = 0D;
            this.icoBtnLogout.Size = new System.Drawing.Size(136, 50);
            this.icoBtnLogout.TabIndex = 4;
            this.icoBtnLogout.Text = "THOÁT";
            this.icoBtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnLogout.UseVisualStyleBackColor = false;
            this.icoBtnLogout.Click += new System.EventHandler(this.icoBtnLogout_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.icoBtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(587, 285);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconTittle);
            this.Controls.Add(this.icoBtnLogout);
            this.Controls.Add(this.icoBtnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.iconUserpassword);
            this.Controls.Add(this.icoUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            ((System.ComponentModel.ISupportInitialize)(this.icoUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUserpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconTittle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox icoUsername;
        private FontAwesome.Sharp.IconPictureBox iconUserpassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private FontAwesome.Sharp.IconButton icoBtnLogin;
        private FontAwesome.Sharp.IconPictureBox iconTittle;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton icoBtnLogout;
    }
}