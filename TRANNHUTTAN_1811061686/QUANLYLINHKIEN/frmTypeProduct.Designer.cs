namespace QUANLYLINHKIEN
{
    partial class frmTypeProduct
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.icoBtnDelete = new FontAwesome.Sharp.IconButton();
            this.icoBtnEdit = new FontAwesome.Sharp.IconButton();
            this.icoBtnAdd = new FontAwesome.Sharp.IconButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_ProducType = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindValue = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProducType)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(525, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "DANH SÁCH LOẠI SẢN PHẨM";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.icoBtnDelete);
            this.groupBox2.Controls.Add(this.icoBtnEdit);
            this.groupBox2.Controls.Add(this.icoBtnAdd);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(568, 132);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(377, 265);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NHẬP THÔNG TIN LOẠI SẢN PHẨM";
            // 
            // icoBtnDelete
            // 
            this.icoBtnDelete.FlatAppearance.BorderSize = 0;
            this.icoBtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnDelete.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icoBtnDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.icoBtnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.icoBtnDelete.IconColor = System.Drawing.Color.DarkRed;
            this.icoBtnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnDelete.IconSize = 35;
            this.icoBtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnDelete.Location = new System.Drawing.Point(247, 188);
            this.icoBtnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.icoBtnDelete.Name = "icoBtnDelete";
            this.icoBtnDelete.Rotation = 0D;
            this.icoBtnDelete.Size = new System.Drawing.Size(91, 67);
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
            this.icoBtnEdit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icoBtnEdit.ForeColor = System.Drawing.Color.DarkBlue;
            this.icoBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.icoBtnEdit.IconColor = System.Drawing.Color.DarkBlue;
            this.icoBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnEdit.IconSize = 35;
            this.icoBtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnEdit.Location = new System.Drawing.Point(141, 188);
            this.icoBtnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.icoBtnEdit.Name = "icoBtnEdit";
            this.icoBtnEdit.Rotation = 0D;
            this.icoBtnEdit.Size = new System.Drawing.Size(91, 67);
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
            this.icoBtnAdd.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.icoBtnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.icoBtnAdd.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnAdd.IconSize = 35;
            this.icoBtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icoBtnAdd.Location = new System.Drawing.Point(8, 188);
            this.icoBtnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.icoBtnAdd.Name = "icoBtnAdd";
            this.icoBtnAdd.Rotation = 0D;
            this.icoBtnAdd.Size = new System.Drawing.Size(110, 67);
            this.icoBtnAdd.TabIndex = 3;
            this.icoBtnAdd.Text = "Thêm";
            this.icoBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnAdd.UseVisualStyleBackColor = true;
            this.icoBtnAdd.Click += new System.EventHandler(this.icoBtnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.Location = new System.Drawing.Point(10, 145);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(328, 33);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.Location = new System.Drawing.Point(10, 68);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(328, 33);
            this.txtID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(5, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên loại linh kiện";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(5, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã loại linh kiện";
            // 
            // dgv_ProducType
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ProducType.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ProducType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ProducType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ProducType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ProducType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProducType.Location = new System.Drawing.Point(21, 131);
            this.dgv_ProducType.Margin = new System.Windows.Forms.Padding(5);
            this.dgv_ProducType.Name = "dgv_ProducType";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_ProducType.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ProducType.Size = new System.Drawing.Size(536, 266);
            this.dgv_ProducType.TabIndex = 3;
            this.dgv_ProducType.TabStop = false;
            this.dgv_ProducType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ProducType_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtFindValue
            // 
            this.txtFindValue.Location = new System.Drawing.Point(112, 87);
            this.txtFindValue.Name = "txtFindValue";
            this.txtFindValue.Size = new System.Drawing.Size(283, 27);
            this.txtFindValue.TabIndex = 6;
            this.txtFindValue.TextChanged += new System.EventHandler(this.txtFindValue_TextChanged);
            // 
            // frmTypeProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(971, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFindValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_ProducType);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTypeProduct";
            this.Text = "frmTypeProduct";
            this.Click += new System.EventHandler(this.frmTypeProduct_Click);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProducType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton icoBtnDelete;
        private FontAwesome.Sharp.IconButton icoBtnEdit;
        private FontAwesome.Sharp.IconButton icoBtnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_ProducType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFindValue;
    }
}