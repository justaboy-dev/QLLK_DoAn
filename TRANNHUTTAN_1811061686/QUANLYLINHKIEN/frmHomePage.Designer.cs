namespace QUANLYLINHKIEN
{
    partial class frmHomePage
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
            this.imgSlider = new DevExpress.XtraEditors.Controls.ImageSlider();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // imgSlider
            // 
            this.imgSlider.AllowLooping = true;
            this.imgSlider.AutoSlide = DevExpress.XtraEditors.Controls.AutoSlide.Forward;
            this.imgSlider.AutoSlideInterval = 3000;
            this.imgSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgSlider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.imgSlider.Location = new System.Drawing.Point(0, 0);
            this.imgSlider.Name = "imgSlider";
            this.imgSlider.Size = new System.Drawing.Size(800, 450);
            this.imgSlider.TabIndex = 0;
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgSlider);
            this.Name = "frmHomePage";
            this.Text = "frmHomePage";
            ((System.ComponentModel.ISupportInitialize)(this.imgSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Controls.ImageSlider imgSlider;
    }
}