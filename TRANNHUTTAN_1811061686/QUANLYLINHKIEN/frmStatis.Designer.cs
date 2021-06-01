namespace QUANLYLINHKIEN
{
    partial class frmStatis
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatis));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupMenu = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarKho = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarDT = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.navigationFrameMain = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.ngpKho = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.charControlsBill = new DevExpress.XtraCharts.ChartControl();
            this.ngpBill = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.charControlsProduct = new DevExpress.XtraCharts.ChartControl();
            this.chkFilter = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.icoBtnView = new FontAwesome.Sharp.IconButton();
            this.icoBtnPrint = new FontAwesome.Sharp.IconButton();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.filteringUIContext1 = new DevExpress.Utils.Filtering.FilteringUIContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrameMain)).BeginInit();
            this.navigationFrameMain.SuspendLayout();
            this.ngpKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charControlsBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.ngpBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.charControlsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFilter)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupMenu);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.MaxId = 3;
            this.tileBar.Name = "tileBar";
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar.SelectionColor = System.Drawing.Color.Red;
            this.tileBar.Size = new System.Drawing.Size(784, 98);
            this.tileBar.TabIndex = 0;
            this.tileBar.Text = "tileBar1";
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupMenu
            // 
            this.tileBarGroupMenu.Items.Add(this.tileBarKho);
            this.tileBarGroupMenu.Items.Add(this.tileBarDT);
            this.tileBarGroupMenu.Name = "tileBarGroupMenu";
            // 
            // tileBarKho
            // 
            this.tileBarKho.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.tileBarKho.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarKho.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tileBarKho.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarKho.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarKho.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileBarKho.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Red;
            this.tileBarKho.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarKho.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileBarKho.AppearanceItem.Selected.Options.UseFont = true;
            this.tileBarKho.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            tileItemElement1.Text = "TỒN KHO";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarKho.Elements.Add(tileItemElement1);
            this.tileBarKho.Id = 1;
            this.tileBarKho.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarKho.Name = "tileBarKho";
            // 
            // tileBarDT
            // 
            this.tileBarDT.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tileBarDT.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarDT.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tileBarDT.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarDT.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBarDT.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileBarDT.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Red;
            this.tileBarDT.AppearanceItem.Selected.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBarDT.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileBarDT.AppearanceItem.Selected.Options.UseFont = true;
            this.tileBarDT.DropDownOptions.BeakColor = System.Drawing.Color.Red;
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage1")));
            tileItemElement2.Text = "DOANH THU";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBarDT.Elements.Add(tileItemElement2);
            this.tileBarDT.Id = 2;
            this.tileBarDT.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarDT.Name = "tileBarDT";
            // 
            // navigationFrameMain
            // 
            this.navigationFrameMain.Controls.Add(this.ngpKho);
            this.navigationFrameMain.Controls.Add(this.ngpBill);
            this.navigationFrameMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrameMain.Location = new System.Drawing.Point(0, 98);
            this.navigationFrameMain.Name = "navigationFrameMain";
            this.navigationFrameMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.ngpBill,
            this.ngpKho});
            this.navigationFrameMain.SelectedPage = this.ngpKho;
            this.navigationFrameMain.Size = new System.Drawing.Size(784, 391);
            this.navigationFrameMain.TabIndex = 1;
            this.navigationFrameMain.Text = "navigationFrame1";
            // 
            // ngpKho
            // 
            this.ngpKho.Caption = "ngpKho";
            this.ngpKho.Controls.Add(this.charControlsBill);
            this.ngpKho.Name = "ngpKho";
            this.ngpKho.Size = new System.Drawing.Size(784, 391);
            // 
            // charControlsBill
            // 
            this.charControlsBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charControlsBill.Legend.Name = "Default Legend";
            this.charControlsBill.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.charControlsBill.Location = new System.Drawing.Point(0, 0);
            this.charControlsBill.Name = "charControlsBill";
            series1.Name = "SrCharBill";
            series1.View = pieSeriesView1;
            this.charControlsBill.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.charControlsBill.Size = new System.Drawing.Size(784, 391);
            this.charControlsBill.TabIndex = 0;
            chartTitle1.Text = "THỐNG KÊ DOANH THU";
            this.charControlsBill.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // ngpBill
            // 
            this.ngpBill.Caption = "ngpBill";
            this.ngpBill.Controls.Add(this.charControlsProduct);
            this.ngpBill.Controls.Add(this.chkFilter);
            this.ngpBill.Name = "ngpBill";
            this.ngpBill.Size = new System.Drawing.Size(784, 391);
            // 
            // charControlsProduct
            // 
            this.charControlsProduct.BorderOptions.Color = System.Drawing.Color.Transparent;
            this.charControlsProduct.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.charControlsProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charControlsProduct.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Empty;
            this.charControlsProduct.Legend.Name = "Default Legend";
            this.charControlsProduct.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.charControlsProduct.Location = new System.Drawing.Point(0, 0);
            this.charControlsProduct.Name = "charControlsProduct";
            pieSeriesLabel1.TextPattern = "{V}";
            series2.Label = pieSeriesLabel1;
            series2.LegendName = "Default Legend";
            series2.Name = "SrProduct";
            series2.View = pieSeriesView2;
            this.charControlsProduct.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.charControlsProduct.Size = new System.Drawing.Size(651, 391);
            this.charControlsProduct.TabIndex = 0;
            chartTitle2.Text = "THỐNG KÊ TỒN KHO SẢN PHẨM";
            this.charControlsProduct.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // chkFilter
            // 
            this.chkFilter.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFilter.Appearance.Options.UseFont = true;
            this.chkFilter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.chkFilter.CheckOnClick = true;
            this.chkFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkFilter.Location = new System.Drawing.Point(651, 0);
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.chkFilter.Size = new System.Drawing.Size(133, 391);
            this.chkFilter.TabIndex = 4;
            this.chkFilter.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.chkFilter_ItemCheck);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.icoBtnView);
            this.panel1.Controls.Add(this.icoBtnPrint);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 72);
            this.panel1.TabIndex = 2;
            // 
            // icoBtnView
            // 
            this.icoBtnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnView.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnView.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnView.ForeColor = System.Drawing.Color.DarkBlue;
            this.icoBtnView.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.icoBtnView.IconColor = System.Drawing.Color.DarkBlue;
            this.icoBtnView.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnView.IconSize = 30;
            this.icoBtnView.Location = new System.Drawing.Point(515, 14);
            this.icoBtnView.Name = "icoBtnView";
            this.icoBtnView.Rotation = 0D;
            this.icoBtnView.Size = new System.Drawing.Size(88, 33);
            this.icoBtnView.TabIndex = 2;
            this.icoBtnView.Text = "Xem";
            this.icoBtnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnView.UseVisualStyleBackColor = true;
            this.icoBtnView.Click += new System.EventHandler(this.icoBtnView_Click);
            // 
            // icoBtnPrint
            // 
            this.icoBtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoBtnPrint.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icoBtnPrint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icoBtnPrint.ForeColor = System.Drawing.Color.DarkGreen;
            this.icoBtnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.icoBtnPrint.IconColor = System.Drawing.Color.DarkGreen;
            this.icoBtnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoBtnPrint.IconSize = 30;
            this.icoBtnPrint.Location = new System.Drawing.Point(634, 14);
            this.icoBtnPrint.Name = "icoBtnPrint";
            this.icoBtnPrint.Rotation = 0D;
            this.icoBtnPrint.Size = new System.Drawing.Size(120, 33);
            this.icoBtnPrint.TabIndex = 2;
            this.icoBtnPrint.Text = "Xuất file";
            this.icoBtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icoBtnPrint.UseVisualStyleBackColor = true;
            this.icoBtnPrint.Click += new System.EventHandler(this.icoBtnPrint_Click);
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.AutoSize = true;
            this.lblTo.BackColor = System.Drawing.Color.Transparent;
            this.lblTo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.Black;
            this.lblTo.Location = new System.Drawing.Point(244, 22);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(71, 18);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "Đến ngày";
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.Transparent;
            this.lblFrom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.Black;
            this.lblFrom.Location = new System.Drawing.Point(12, 23);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(64, 18);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "Từ ngày";
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.Location = new System.Drawing.Point(321, 20);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(156, 21);
            this.dtpTo.TabIndex = 0;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.Location = new System.Drawing.Point(82, 20);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(156, 21);
            this.dtpFrom.TabIndex = 0;
            // 
            // filteringUIContext1
            // 
            this.filteringUIContext1.Client = this.charControlsProduct;
            // 
            // frmStatis
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.navigationFrameMain);
            this.Controls.Add(this.tileBar);
            this.Controls.Add(this.panel1);
            this.Name = "frmStatis";
            this.Load += new System.EventHandler(this.frmStatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrameMain)).EndInit();
            this.navigationFrameMain.ResumeLayout(false);
            this.ngpKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charControlsBill)).EndInit();
            this.ngpBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charControlsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFilter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupMenu;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarKho;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarDT;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrameMain;
        private DevExpress.XtraBars.Navigation.NavigationPage ngpKho;
        private DevExpress.XtraBars.Navigation.NavigationPage ngpBill;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton icoBtnView;
        private FontAwesome.Sharp.IconButton icoBtnPrint;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private DevExpress.XtraCharts.ChartControl charControlsBill;
        private DevExpress.XtraCharts.ChartControl charControlsProduct;
        private DevExpress.Utils.Filtering.FilteringUIContext filteringUIContext1;
        private DevExpress.XtraEditors.CheckedListBoxControl chkFilter;
    }
}