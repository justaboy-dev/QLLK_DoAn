namespace QUANLYLINHKIEN
{
    partial class frmProvider
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.icoBtnDelete = new FontAwesome.Sharp.IconButton();
            this.icoBtnEdit = new FontAwesome.Sharp.IconButton();
            this.icoBtnAdd = new FontAwesome.Sharp.IconButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_Provider = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Provider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtFindValue
            // 
            this.txtFindValue.Location = new System.Drawing.Point(110, 90);
            this.txtFindValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFindValue.Name = "txtFindValue";
            this.txtFindValue.Size = new System.Drawing.Size(255, 27);
            this.txtFindValue.TabIndex = 11;
            this.txtFindValue.TextChanged += new System.EventHandler(this.txtFindValue_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(509, 42);
            this.label6.TabIndex = 10;
            this.label6.Text = "DANH SÁCH NHÀ CUNG CẤP";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.icoBtnDelete);
            this.groupBox2.Controls.Add(this.icoBtnEdit);
            this.groupBox2.Controls.Add(this.icoBtnAdd);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtAdd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(673, 131);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(318, 439);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NHẬP THÔNG TIN NHÀ CUNG CẤP";
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
            this.icoBtnDelete.Location = new System.Drawing.Point(216, 384);
            this.icoBtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnDelete.Name = "icoBtnDelete";
            this.icoBtnDelete.Rotation = 0D;
            this.icoBtnDelete.Size = new System.Drawing.Size(94, 38);
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
            this.icoBtnEdit.Location = new System.Drawing.Point(121, 384);
            this.icoBtnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnEdit.Name = "icoBtnEdit";
            this.icoBtnEdit.Rotation = 0D;
            this.icoBtnEdit.Size = new System.Drawing.Size(87, 38);
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
            this.icoBtnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.icoBtnAdd.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnAdd.IconSize = 35;
            this.icoBtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnAdd.Location = new System.Drawing.Point(14, 384);
            this.icoBtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.icoBtnAdd.Name = "icoBtnAdd";
            this.icoBtnAdd.Rotation = 0D;
            this.icoBtnAdd.Size = new System.Drawing.Size(99, 38);
            this.icoBtnAdd.TabIndex = 3;
            this.icoBtnAdd.Text = "Thêm";
            this.icoBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnAdd.UseVisualStyleBackColor = true;
            this.icoBtnAdd.Click += new System.EventHandler(this.icoBtnAdd_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhone.Location = new System.Drawing.Point(31, 331);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(265, 27);
            this.txtPhone.TabIndex = 2;
            // 
            // txtAdd
            // 
            this.txtAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtAdd.Location = new System.Drawing.Point(31, 225);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(265, 62);
            this.txtAdd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(27, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại cung cấp";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.Location = new System.Drawing.Point(31, 144);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 27);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(27, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ nhà cung cấp";
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.Location = new System.Drawing.Point(31, 69);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(265, 27);
            this.txtID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(27, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(27, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã nhà cung cấp";
            // 
            // dgv_Provider
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Provider.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Provider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Provider.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Provider.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Provider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Provider.Location = new System.Drawing.Point(20, 131);
            this.dgv_Provider.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Provider.Name = "dgv_Provider";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Provider.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Provider.Size = new System.Drawing.Size(645, 434);
            this.dgv_Provider.TabIndex = 8;
            this.dgv_Provider.TabStop = false;
            this.dgv_Provider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Provider_CellClick);
            // 
            // frmProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFindValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_Provider);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProvider";
            this.Text = "frmProvider";
            this.Click += new System.EventHandler(this.frmProvider_Click);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Provider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFindValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton icoBtnDelete;
        private FontAwesome.Sharp.IconButton icoBtnEdit;
        private FontAwesome.Sharp.IconButton icoBtnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Provider;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}