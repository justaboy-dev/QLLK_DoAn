namespace QUANLYLINHKIEN
{
    partial class frmBillManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.icoBtmDelete = new FontAwesome.Sharp.IconButton();
            this.icoBtnPrint = new FontAwesome.Sharp.IconButton();
            this.icoBtnEdit = new FontAwesome.Sharp.IconButton();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cboStaff = new System.Windows.Forms.ComboBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_bill = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.icoBtmDelete);
            this.groupBox1.Controls.Add(this.icoBtnPrint);
            this.groupBox1.Controls.Add(this.icoBtnEdit);
            this.groupBox1.Controls.Add(this.dtpTime);
            this.groupBox1.Controls.Add(this.cboStaff);
            this.groupBox1.Controls.Add(this.cboCustomer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(818, 157);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(346, 525);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN HOÁ ĐƠN";
            // 
            // icoBtmDelete
            // 
            this.icoBtmDelete.FlatAppearance.BorderSize = 0;
            this.icoBtmDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtmDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtmDelete.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtmDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.icoBtmDelete.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.icoBtmDelete.IconColor = System.Drawing.Color.DarkRed;
            this.icoBtmDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtmDelete.IconSize = 35;
            this.icoBtmDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtmDelete.Location = new System.Drawing.Point(130, 433);
            this.icoBtmDelete.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtmDelete.Name = "icoBtmDelete";
            this.icoBtmDelete.Rotation = 0D;
            this.icoBtmDelete.Size = new System.Drawing.Size(80, 57);
            this.icoBtmDelete.TabIndex = 5;
            this.icoBtmDelete.Text = "Xoá";
            this.icoBtmDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtmDelete.UseVisualStyleBackColor = true;
            this.icoBtmDelete.Click += new System.EventHandler(this.icoBtmDelete_Click);
            // 
            // icoBtnPrint
            // 
            this.icoBtnPrint.FlatAppearance.BorderSize = 0;
            this.icoBtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnPrint.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnPrint.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnPrint.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.icoBtnPrint.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnPrint.IconSize = 35;
            this.icoBtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnPrint.Location = new System.Drawing.Point(218, 433);
            this.icoBtnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnPrint.Name = "icoBtnPrint";
            this.icoBtnPrint.Rotation = 0D;
            this.icoBtnPrint.Size = new System.Drawing.Size(113, 57);
            this.icoBtnPrint.TabIndex = 6;
            this.icoBtnPrint.Text = "Xuất HD";
            this.icoBtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnPrint.UseVisualStyleBackColor = true;
            this.icoBtnPrint.Click += new System.EventHandler(this.icoBtnPrint_Click);
            // 
            // icoBtnEdit
            // 
            this.icoBtnEdit.FlatAppearance.BorderSize = 0;
            this.icoBtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnEdit.ForeColor = System.Drawing.Color.DarkBlue;
            this.icoBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.icoBtnEdit.IconColor = System.Drawing.Color.DarkBlue;
            this.icoBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnEdit.IconSize = 35;
            this.icoBtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnEdit.Location = new System.Drawing.Point(24, 433);
            this.icoBtnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnEdit.Name = "icoBtnEdit";
            this.icoBtnEdit.Rotation = 0D;
            this.icoBtnEdit.Size = new System.Drawing.Size(83, 57);
            this.icoBtnEdit.TabIndex = 4;
            this.icoBtnEdit.Text = "Sửa";
            this.icoBtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnEdit.UseVisualStyleBackColor = true;
            this.icoBtnEdit.Click += new System.EventHandler(this.icoBtnEdit_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(24, 267);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(307, 26);
            this.dtpTime.TabIndex = 2;
            // 
            // cboStaff
            // 
            this.cboStaff.FormattingEnabled = true;
            this.cboStaff.Location = new System.Drawing.Point(24, 361);
            this.cboStaff.Margin = new System.Windows.Forms.Padding(4);
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.Size = new System.Drawing.Size(307, 26);
            this.cboStaff.TabIndex = 3;
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(24, 179);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(307, 26);
            this.cboCustomer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 332);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhân viên lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng";
            // 
            // txtID
            // 
            this.txtID.AcceptsTab = true;
            this.txtID.Location = new System.Drawing.Point(24, 93);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(309, 26);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 42);
            this.label5.TabIndex = 1;
            this.label5.Text = "DANH SÁCH HOÁ ĐƠN";
            // 
            // dgv_bill
            // 
            this.dgv_bill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bill.Location = new System.Drawing.Point(28, 162);
            this.dgv_bill.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_bill.Name = "dgv_bill";
            this.dgv_bill.Size = new System.Drawing.Size(771, 515);
            this.dgv_bill.TabIndex = 2;
            this.dgv_bill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bill_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tìm kiếm";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(123, 118);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(300, 26);
            this.txtFind.TabIndex = 7;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // frmBillManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 695);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_bill);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBillManager";
            this.Text = "frmBillManager";
            this.Load += new System.EventHandler(this.frmBillManager_Load);
            this.Click += new System.EventHandler(this.frmBillManager_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ComboBox cboStaff;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton icoBtnEdit;
        private FontAwesome.Sharp.IconButton icoBtmDelete;
        private FontAwesome.Sharp.IconButton icoBtnPrint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_bill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFind;
    }
}