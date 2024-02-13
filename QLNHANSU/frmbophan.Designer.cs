
namespace QLNHANSU
{
    partial class frmbophan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbophan));
            this.TENBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvDanhSachBP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDBP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSachBP = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemBP = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaBP = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaBP = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuBP = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyBP = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintBP = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongBP = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtTenBP = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TENBP
            // 
            this.TENBP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TENBP.AppearanceHeader.Options.UseFont = true;
            this.TENBP.Caption = "Tên bộ phận";
            this.TENBP.FieldName = "TENBP";
            this.TENBP.MaxWidth = 400;
            this.TENBP.MinWidth = 300;
            this.TENBP.Name = "TENBP";
            this.TENBP.Visible = true;
            this.TENBP.VisibleIndex = 1;
            this.TENBP.Width = 300;
            // 
            // gvDanhSachBP
            // 
            this.gvDanhSachBP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDBP,
            this.TENBP});
            this.gvDanhSachBP.GridControl = this.gcDanhSachBP;
            this.gvDanhSachBP.Name = "gvDanhSachBP";
            this.gvDanhSachBP.Click += new System.EventHandler(this.gvDanhSachBP_Click);
            // 
            // IDBP
            // 
            this.IDBP.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IDBP.AppearanceHeader.Options.UseFont = true;
            this.IDBP.Caption = "ID";
            this.IDBP.FieldName = "IDBP";
            this.IDBP.MaxWidth = 200;
            this.IDBP.MinWidth = 30;
            this.IDBP.Name = "IDBP";
            this.IDBP.Visible = true;
            this.IDBP.VisibleIndex = 0;
            this.IDBP.Width = 94;
            // 
            // gcDanhSachBP
            // 
            this.gcDanhSachBP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSachBP.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSachBP.MainView = this.gvDanhSachBP;
            this.gcDanhSachBP.MenuManager = this.barManager1;
            this.gcDanhSachBP.Name = "gcDanhSachBP";
            this.gcDanhSachBP.Size = new System.Drawing.Size(797, 408);
            this.gcDanhSachBP.TabIndex = 0;
            this.gcDanhSachBP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachBP});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemBP,
            this.btnSuaBP,
            this.btnXoaBP,
            this.btnLuuBP,
            this.btnHuyBP,
            this.btnDongBP,
            this.btnPrintBP});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemBP, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaBP, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaBP, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuBP, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyBP, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrintBP, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDongBP, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemBP
            // 
            this.btnThemBP.Caption = "Thêm";
            this.btnThemBP.Id = 0;
            this.btnThemBP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemBP.ImageOptions.Image")));
            this.btnThemBP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemBP.ImageOptions.LargeImage")));
            this.btnThemBP.Name = "btnThemBP";
            this.btnThemBP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemBP_ItemClick);
            // 
            // btnSuaBP
            // 
            this.btnSuaBP.Caption = "Sửa";
            this.btnSuaBP.Id = 1;
            this.btnSuaBP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaBP.ImageOptions.Image")));
            this.btnSuaBP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaBP.ImageOptions.LargeImage")));
            this.btnSuaBP.Name = "btnSuaBP";
            this.btnSuaBP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaBP_ItemClick);
            // 
            // btnXoaBP
            // 
            this.btnXoaBP.Caption = "Xóa";
            this.btnXoaBP.Id = 2;
            this.btnXoaBP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaBP.ImageOptions.Image")));
            this.btnXoaBP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaBP.ImageOptions.LargeImage")));
            this.btnXoaBP.Name = "btnXoaBP";
            this.btnXoaBP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaBP_ItemClick);
            // 
            // btnLuuBP
            // 
            this.btnLuuBP.Caption = "Lưu";
            this.btnLuuBP.Id = 3;
            this.btnLuuBP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuBP.ImageOptions.Image")));
            this.btnLuuBP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuuBP.ImageOptions.LargeImage")));
            this.btnLuuBP.Name = "btnLuuBP";
            this.btnLuuBP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuBP_ItemClick);
            // 
            // btnHuyBP
            // 
            this.btnHuyBP.Caption = "Hủy";
            this.btnHuyBP.Id = 4;
            this.btnHuyBP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBP.ImageOptions.Image")));
            this.btnHuyBP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuyBP.ImageOptions.LargeImage")));
            this.btnHuyBP.Name = "btnHuyBP";
            this.btnHuyBP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyBP_ItemClick);
            // 
            // btnPrintBP
            // 
            this.btnPrintBP.Caption = "In";
            this.btnPrintBP.Id = 6;
            this.btnPrintBP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBP.ImageOptions.Image")));
            this.btnPrintBP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrintBP.ImageOptions.LargeImage")));
            this.btnPrintBP.Name = "btnPrintBP";
            this.btnPrintBP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintBP_ItemClick);
            // 
            // btnDongBP
            // 
            this.btnDongBP.Caption = "Đóng";
            this.btnDongBP.Id = 5;
            this.btnDongBP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongBP.ImageOptions.Image")));
            this.btnDongBP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDongBP.ImageOptions.LargeImage")));
            this.btnDongBP.Name = "btnDongBP";
            this.btnDongBP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDongBP_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(797, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 572);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(797, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 542);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(797, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 542);
            // 
            // txtTenBP
            // 
            this.txtTenBP.Location = new System.Drawing.Point(132, 20);
            this.txtTenBP.MenuManager = this.barManager1;
            this.txtTenBP.Name = "txtTenBP";
            this.txtTenBP.Size = new System.Drawing.Size(157, 22);
            this.txtTenBP.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên bộ phận";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTenBP);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSachBP);
            this.splitContainer1.Size = new System.Drawing.Size(797, 542);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 5;
            // 
            // frmbophan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 592);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmbophan";
            this.Text = "frmbophan";
            this.Load += new System.EventHandler(this.frmbophan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBP.Properties)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn TENBP;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachBP;
        private DevExpress.XtraGrid.Columns.GridColumn IDBP;
        private DevExpress.XtraGrid.GridControl gcDanhSachBP;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemBP;
        private DevExpress.XtraBars.BarButtonItem btnSuaBP;
        private DevExpress.XtraBars.BarButtonItem btnXoaBP;
        private DevExpress.XtraBars.BarButtonItem btnLuuBP;
        private DevExpress.XtraBars.BarButtonItem btnHuyBP;
        private DevExpress.XtraBars.BarButtonItem btnPrintBP;
        private DevExpress.XtraBars.BarButtonItem btnDongBP;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit txtTenBP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}