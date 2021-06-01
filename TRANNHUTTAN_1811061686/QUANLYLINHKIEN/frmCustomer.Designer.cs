namespace QUANLYLINHKIEN
{
    partial class frmCustomer
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
            this.icoBtmDelete = new FontAwesome.Sharp.IconButton();
            this.icoBtnAdd = new FontAwesome.Sharp.IconButton();
            this.icoBtnEdit = new FontAwesome.Sharp.IconButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.icoBtmDelete.Location = new System.Drawing.Point(219, 342);
            this.icoBtmDelete.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtmDelete.Name = "icoBtmDelete";
            this.icoBtmDelete.Rotation = 0D;
            this.icoBtmDelete.Size = new System.Drawing.Size(84, 45);
            this.icoBtmDelete.TabIndex = 10;
            this.icoBtmDelete.Text = "Xoá";
            this.icoBtmDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtmDelete.UseVisualStyleBackColor = true;
            this.icoBtmDelete.Click += new System.EventHandler(this.icoBtmDelete_Click);
            // 
            // icoBtnAdd
            // 
            this.icoBtnAdd.FlatAppearance.BorderSize = 0;
            this.icoBtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.icoBtnAdd.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnAdd.IconSize = 35;
            this.icoBtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnAdd.Location = new System.Drawing.Point(20, 342);
            this.icoBtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnAdd.Name = "icoBtnAdd";
            this.icoBtnAdd.Rotation = 0D;
            this.icoBtnAdd.Size = new System.Drawing.Size(91, 45);
            this.icoBtnAdd.TabIndex = 8;
            this.icoBtnAdd.Text = "Thêm";
            this.icoBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnAdd.UseVisualStyleBackColor = true;
            this.icoBtnAdd.Click += new System.EventHandler(this.icoBtnAdd_Click);
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
            this.icoBtnEdit.Location = new System.Drawing.Point(129, 342);
            this.icoBtnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnEdit.Name = "icoBtnEdit";
            this.icoBtnEdit.Rotation = 0D;
            this.icoBtnEdit.Size = new System.Drawing.Size(82, 45);
            this.icoBtnEdit.TabIndex = 9;
            this.icoBtnEdit.Text = "Sửa";
            this.icoBtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnEdit.UseVisualStyleBackColor = true;
            this.icoBtnEdit.Click += new System.EventHandler(this.icoBtnEdit_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.AcceptsTab = true;
            this.txtPhone.Location = new System.Drawing.Point(21, 290);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(282, 26);
            this.txtPhone.TabIndex = 5;
            // 
            // txtAdd
            // 
            this.txtAdd.AcceptsTab = true;
            this.txtAdd.Location = new System.Drawing.Point(23, 186);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(282, 54);
            this.txtAdd.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Điện thoại";
            // 
            // txtName
            // 
            this.txtName.AcceptsTab = true;
            this.txtName.Location = new System.Drawing.Point(23, 120);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(282, 26);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên khách hàng";
            // 
            // txtID
            // 
            this.txtID.AcceptsTab = true;
            this.txtID.Location = new System.Drawing.Point(23, 57);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(282, 26);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(123, 107);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(300, 26);
            this.txtFind.TabIndex = 16;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tìm kiếm";
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Location = new System.Drawing.Point(28, 151);
            this.dgv_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.Size = new System.Drawing.Size(561, 409);
            this.dgv_Customer.TabIndex = 14;
            this.dgv_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customer_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(478, 42);
            this.label5.TabIndex = 13;
            this.label5.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.icoBtmDelete);
            this.groupBox1.Controls.Add(this.icoBtnAdd);
            this.groupBox1.Controls.Add(this.icoBtnEdit);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtAdd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(611, 151);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(325, 409);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 576);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_Customer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.Click += new System.EventHandler(this.frmCustomer_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton icoBtmDelete;
        private FontAwesome.Sharp.IconButton icoBtnAdd;
        private FontAwesome.Sharp.IconButton icoBtnEdit;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_Customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}