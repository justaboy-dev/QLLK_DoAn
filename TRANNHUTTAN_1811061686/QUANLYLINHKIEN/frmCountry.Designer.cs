namespace QUANLYLINHKIEN
{
    partial class frmCountry
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
            this.dgvCountry = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.icoBtnDelete = new FontAwesome.Sharp.IconButton();
            this.icoBtnEdit = new FontAwesome.Sharp.IconButton();
            this.icoBtnAdd = new FontAwesome.Sharp.IconButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCountry
            // 
            this.dgvCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountry.Location = new System.Drawing.Point(21, 103);
            this.dgvCountry.Margin = new System.Windows.Forms.Padding(5);
            this.dgvCountry.Name = "dgvCountry";
            this.dgvCountry.Size = new System.Drawing.Size(602, 317);
            this.dgvCountry.TabIndex = 0;
            this.dgvCountry.TabStop = false;
            this.dgvCountry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCountry_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.icoBtnDelete);
            this.groupBox1.Controls.Add(this.icoBtnEdit);
            this.groupBox1.Controls.Add(this.icoBtnAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(633, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(390, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NHẬP THÔNG TIN NƯỚC SẢN XUẤT";
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
            this.icoBtnDelete.Location = new System.Drawing.Point(275, 226);
            this.icoBtnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.icoBtnDelete.Name = "icoBtnDelete";
            this.icoBtnDelete.Rotation = 0D;
            this.icoBtnDelete.Size = new System.Drawing.Size(97, 67);
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
            this.icoBtnEdit.Location = new System.Drawing.Point(149, 226);
            this.icoBtnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.icoBtnEdit.Name = "icoBtnEdit";
            this.icoBtnEdit.Rotation = 0D;
            this.icoBtnEdit.Size = new System.Drawing.Size(97, 67);
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
            this.icoBtnAdd.Location = new System.Drawing.Point(13, 226);
            this.icoBtnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.icoBtnAdd.Name = "icoBtnAdd";
            this.icoBtnAdd.Rotation = 0D;
            this.icoBtnAdd.Size = new System.Drawing.Size(112, 67);
            this.icoBtnAdd.TabIndex = 3;
            this.icoBtnAdd.Text = "Thêm";
            this.icoBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnAdd.UseVisualStyleBackColor = true;
            this.icoBtnAdd.Click += new System.EventHandler(this.icoBtnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.Location = new System.Drawing.Point(11, 169);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 33);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.Location = new System.Drawing.Point(15, 89);
            this.txtID.Margin = new System.Windows.Forms.Padding(5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(357, 33);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(0, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nước";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nước";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH NƯỚC SẢN XUẤT";
            // 
            // txtFindValue
            // 
            this.txtFindValue.Location = new System.Drawing.Point(118, 65);
            this.txtFindValue.Name = "txtFindValue";
            this.txtFindValue.Size = new System.Drawing.Size(283, 30);
            this.txtFindValue.TabIndex = 3;
            this.txtFindValue.TextChanged += new System.EventHandler(this.txtFindValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tìm kiếm";
            // 
            // frmCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 434);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFindValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCountry);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmCountry";
            this.Text = "frmCountry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.frmCountry_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCountry;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton icoBtnDelete;
        private FontAwesome.Sharp.IconButton icoBtnEdit;
        private FontAwesome.Sharp.IconButton icoBtnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFindValue;
        private System.Windows.Forms.Label label4;
    }
}