namespace QUANLYLINHKIEN
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRepeatNewPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.icoBtnChangePass = new FontAwesome.Sharp.IconButton();
            this.icoBtnExit = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(126, 38);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(348, 27);
            this.txtOldPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(126, 96);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(348, 27);
            this.txtNewPass.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(18, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtRepeatNewPass
            // 
            this.txtRepeatNewPass.Location = new System.Drawing.Point(126, 158);
            this.txtRepeatNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepeatNewPass.Name = "txtRepeatNewPass";
            this.txtRepeatNewPass.PasswordChar = '*';
            this.txtRepeatNewPass.Size = new System.Drawing.Size(348, 27);
            this.txtRepeatNewPass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(18, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu mới";
            // 
            // icoBtnChangePass
            // 
            this.icoBtnChangePass.FlatAppearance.BorderSize = 0;
            this.icoBtnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnChangePass.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnChangePass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnChangePass.ForeColor = System.Drawing.Color.Gainsboro;
            this.icoBtnChangePass.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.icoBtnChangePass.IconColor = System.Drawing.Color.Gainsboro;
            this.icoBtnChangePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnChangePass.IconSize = 40;
            this.icoBtnChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnChangePass.Location = new System.Drawing.Point(118, 209);
            this.icoBtnChangePass.Name = "icoBtnChangePass";
            this.icoBtnChangePass.Rotation = 0D;
            this.icoBtnChangePass.Size = new System.Drawing.Size(177, 45);
            this.icoBtnChangePass.TabIndex = 4;
            this.icoBtnChangePass.Text = "Đổi mật khẩu";
            this.icoBtnChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnChangePass.UseVisualStyleBackColor = true;
            this.icoBtnChangePass.Click += new System.EventHandler(this.icoBtnChangePass_Click);
            // 
            // icoBtnExit
            // 
            this.icoBtnExit.FlatAppearance.BorderSize = 0;
            this.icoBtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.icoBtnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.icoBtnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.icoBtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnExit.IconSize = 48;
            this.icoBtnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnExit.Location = new System.Drawing.Point(329, 209);
            this.icoBtnExit.Name = "icoBtnExit";
            this.icoBtnExit.Rotation = 0D;
            this.icoBtnExit.Size = new System.Drawing.Size(137, 45);
            this.icoBtnExit.TabIndex = 5;
            this.icoBtnExit.Text = "Thoát";
            this.icoBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnExit.UseVisualStyleBackColor = true;
            this.icoBtnExit.Click += new System.EventHandler(this.icoBtnExit_Click);
            // 
            // frmChangePass
            // 
            this.AcceptButton = this.icoBtnChangePass;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(513, 281);
            this.Controls.Add(this.icoBtnExit);
            this.Controls.Add(this.icoBtnChangePass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRepeatNewPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRepeatNewPass;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton icoBtnChangePass;
        private FontAwesome.Sharp.IconButton icoBtnExit;
    }
}