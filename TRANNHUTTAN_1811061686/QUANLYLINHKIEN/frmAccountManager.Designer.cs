namespace QUANLYLINHKIEN
{
    partial class frmAccountManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Account = new System.Windows.Forms.DataGridView();
            this.cboCV = new System.Windows.Forms.ComboBox();
            this.icoBtnDelete = new FontAwesome.Sharp.IconButton();
            this.icoBtnEdit = new FontAwesome.Sharp.IconButton();
            this.icoBtnAdd = new FontAwesome.Sharp.IconButton();
            this.txtFindValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPasswork = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Account
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Account.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Account.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Account.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Account.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Account.Location = new System.Drawing.Point(19, 114);
            this.dgv_Account.Name = "dgv_Account";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Account.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Account.Size = new System.Drawing.Size(635, 317);
            this.dgv_Account.TabIndex = 18;
            this.dgv_Account.TabStop = false;
            this.dgv_Account.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Account_CellClick);
            // 
            // cboCV
            // 
            this.cboCV.FormattingEnabled = true;
            this.cboCV.Location = new System.Drawing.Point(23, 190);
            this.cboCV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cboCV.Name = "cboCV";
            this.cboCV.Size = new System.Drawing.Size(278, 27);
            this.cboCV.TabIndex = 6;
            // 
            // icoBtnDelete
            // 
            this.icoBtnDelete.FlatAppearance.BorderSize = 0;
            this.icoBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icoBtnDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.icoBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.icoBtnDelete.IconColor = System.Drawing.Color.DarkRed;
            this.icoBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnDelete.IconSize = 35;
            this.icoBtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnDelete.Location = new System.Drawing.Point(218, 254);
            this.icoBtnDelete.Name = "icoBtnDelete";
            this.icoBtnDelete.Rotation = 0D;
            this.icoBtnDelete.Size = new System.Drawing.Size(83, 32);
            this.icoBtnDelete.TabIndex = 5;
            this.icoBtnDelete.Text = "Xoá";
            this.icoBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnDelete.UseVisualStyleBackColor = true;
            this.icoBtnDelete.Click += new System.EventHandler(this.icoBtnDelete_Click);
            // 
            // icoBtnEdit
            // 
            this.icoBtnEdit.FlatAppearance.BorderSize = 0;
            this.icoBtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnEdit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icoBtnEdit.ForeColor = System.Drawing.Color.DarkBlue;
            this.icoBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.icoBtnEdit.IconColor = System.Drawing.Color.DarkBlue;
            this.icoBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnEdit.IconSize = 35;
            this.icoBtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnEdit.Location = new System.Drawing.Point(126, 254);
            this.icoBtnEdit.Name = "icoBtnEdit";
            this.icoBtnEdit.Rotation = 0D;
            this.icoBtnEdit.Size = new System.Drawing.Size(93, 32);
            this.icoBtnEdit.TabIndex = 4;
            this.icoBtnEdit.Text = "Sửa";
            this.icoBtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnEdit.UseVisualStyleBackColor = true;
            this.icoBtnEdit.Click += new System.EventHandler(this.icoBtnEdit_Click);
            // 
            // icoBtnAdd
            // 
            this.icoBtnAdd.FlatAppearance.BorderSize = 0;
            this.icoBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icoBtnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.icoBtnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.icoBtnAdd.IconColor = System.Drawing.Color.SeaGreen;
            this.icoBtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnAdd.IconSize = 35;
            this.icoBtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnAdd.Location = new System.Drawing.Point(21, 254);
            this.icoBtnAdd.Name = "icoBtnAdd";
            this.icoBtnAdd.Rotation = 0D;
            this.icoBtnAdd.Size = new System.Drawing.Size(99, 32);
            this.icoBtnAdd.TabIndex = 3;
            this.icoBtnAdd.Text = "Thêm";
            this.icoBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnAdd.UseVisualStyleBackColor = true;
            this.icoBtnAdd.Click += new System.EventHandler(this.icoBtnAdd_Click);
            // 
            // txtFindValue
            // 
            this.txtFindValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFindValue.Location = new System.Drawing.Point(116, 74);
            this.txtFindValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtFindValue.Name = "txtFindValue";
            this.txtFindValue.Size = new System.Drawing.Size(356, 27);
            this.txtFindValue.TabIndex = 21;
            this.txtFindValue.TextChanged += new System.EventHandler(this.txtFindValue_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(440, 42);
            this.label6.TabIndex = 20;
            this.label6.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // txtPasswork
            // 
            this.txtPasswork.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPasswork.Location = new System.Drawing.Point(24, 134);
            this.txtPasswork.Name = "txtPasswork";
            this.txtPasswork.Size = new System.Drawing.Size(278, 27);
            this.txtPasswork.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chức vụ";
            // 
            // txtUsername
            // 
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsername.Location = new System.Drawing.Point(24, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(278, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(21, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(21, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tìm kiếm";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cboCV);
            this.groupBox2.Controls.Add(this.icoBtnDelete);
            this.groupBox2.Controls.Add(this.icoBtnEdit);
            this.groupBox2.Controls.Add(this.icoBtnAdd);
            this.groupBox2.Controls.Add(this.txtPasswork);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(686, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 308);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NHẬP THÔNG TIN TÀI KHOẢN";
            // 
            // frmAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 443);
            this.Controls.Add(this.dgv_Account);
            this.Controls.Add(this.txtFindValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAccountManager";
            this.Text = "frmAccountManager";
            this.Load += new System.EventHandler(this.frmAccountManager_Load);
            this.Click += new System.EventHandler(this.frmAccountManager_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Account;
        private System.Windows.Forms.ComboBox cboCV;
        private FontAwesome.Sharp.IconButton icoBtnDelete;
        private FontAwesome.Sharp.IconButton icoBtnEdit;
        private FontAwesome.Sharp.IconButton icoBtnAdd;
        private System.Windows.Forms.TextBox txtFindValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPasswork;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}