
namespace QLNHANSU
{
    partial class frmCongTy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongTy));
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.TENCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvDanhSachCT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIENTHOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSachCT = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemCT = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaCT = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaCT = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuCT = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyCT = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintCT = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongCT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtEmailCT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiaChiCT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSDTCT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenCT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.TENDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSach = new DevExpress.XtraGrid.GridControl();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDTCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Đóng";
            this.barButtonItem14.Id = 5;
            this.barButtonItem14.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.ImageOptions.Image")));
            this.barButtonItem14.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem14.ImageOptions.LargeImage")));
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // TENCT
            // 
            this.TENCT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TENCT.AppearanceHeader.Options.UseFont = true;
            this.TENCT.Caption = "Tên công ty";
            this.TENCT.FieldName = "TENCT";
            this.TENCT.MaxWidth = 200;
            this.TENCT.MinWidth = 200;
            this.TENCT.Name = "TENCT";
            this.TENCT.Visible = true;
            this.TENCT.VisibleIndex = 1;
            this.TENCT.Width = 200;
            // 
            // gvDanhSachCT
            // 
            this.gvDanhSachCT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDCT,
            this.TENCT,
            this.DIENTHOAI,
            this.EMAIL,
            this.DIACHI});
            this.gvDanhSachCT.GridControl = this.gcDanhSachCT;
            this.gvDanhSachCT.Name = "gvDanhSachCT";
            this.gvDanhSachCT.Click += new System.EventHandler(this.gvDanhSachCT_Click);
            // 
            // IDCT
            // 
            this.IDCT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IDCT.AppearanceHeader.Options.UseFont = true;
            this.IDCT.Caption = "Mã công ty";
            this.IDCT.FieldName = "IDCT";
            this.IDCT.MaxWidth = 200;
            this.IDCT.MinWidth = 100;
            this.IDCT.Name = "IDCT";
            this.IDCT.Visible = true;
            this.IDCT.VisibleIndex = 0;
            this.IDCT.Width = 200;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.DIENTHOAI.AppearanceHeader.Options.UseFont = true;
            this.DIENTHOAI.Caption = "Điện thoại";
            this.DIENTHOAI.FieldName = "DIENTHOAI";
            this.DIENTHOAI.MaxWidth = 200;
            this.DIENTHOAI.MinWidth = 150;
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.Visible = true;
            this.DIENTHOAI.VisibleIndex = 2;
            this.DIENTHOAI.Width = 150;
            // 
            // EMAIL
            // 
            this.EMAIL.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.EMAIL.AppearanceHeader.Options.UseFont = true;
            this.EMAIL.Caption = "Email";
            this.EMAIL.FieldName = "EMAIL";
            this.EMAIL.MaxWidth = 200;
            this.EMAIL.MinWidth = 300;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Visible = true;
            this.EMAIL.VisibleIndex = 3;
            this.EMAIL.Width = 300;
            // 
            // DIACHI
            // 
            this.DIACHI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.DIACHI.AppearanceHeader.Options.UseFont = true;
            this.DIACHI.Caption = "Địa chỉ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.MaxWidth = 300;
            this.DIACHI.MinWidth = 500;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 4;
            this.DIACHI.Width = 500;
            // 
            // gcDanhSachCT
            // 
            this.gcDanhSachCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSachCT.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSachCT.MainView = this.gvDanhSachCT;
            this.gcDanhSachCT.MenuManager = this.barManager1;
            this.gcDanhSachCT.Name = "gcDanhSachCT";
            this.gcDanhSachCT.Size = new System.Drawing.Size(1161, 443);
            this.gcDanhSachCT.TabIndex = 0;
            this.gcDanhSachCT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachCT});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemCT,
            this.btnSuaCT,
            this.btnXoaCT,
            this.btnLuuCT,
            this.btnHuyCT,
            this.btnDongCT,
            this.btnPrintCT});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemCT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaCT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaCT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuCT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyCT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrintCT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDongCT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemCT
            // 
            this.btnThemCT.Caption = "Thêm";
            this.btnThemCT.Id = 0;
            this.btnThemCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.ImageOptions.Image")));
            this.btnThemCT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemCT.ImageOptions.LargeImage")));
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemCT_ItemClick);
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.Caption = "Sửa";
            this.btnSuaCT.Id = 1;
            this.btnSuaCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaCT.ImageOptions.Image")));
            this.btnSuaCT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaCT.ImageOptions.LargeImage")));
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaCT_ItemClick);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Caption = "Xóa";
            this.btnXoaCT.Id = 2;
            this.btnXoaCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCT.ImageOptions.Image")));
            this.btnXoaCT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaCT.ImageOptions.LargeImage")));
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaCT_ItemClick);
            // 
            // btnLuuCT
            // 
            this.btnLuuCT.Caption = "Lưu";
            this.btnLuuCT.Id = 3;
            this.btnLuuCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuCT.ImageOptions.Image")));
            this.btnLuuCT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuuCT.ImageOptions.LargeImage")));
            this.btnLuuCT.Name = "btnLuuCT";
            this.btnLuuCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuCT_ItemClick);
            // 
            // btnHuyCT
            // 
            this.btnHuyCT.Caption = "Hủy";
            this.btnHuyCT.Id = 4;
            this.btnHuyCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyCT.ImageOptions.Image")));
            this.btnHuyCT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuyCT.ImageOptions.LargeImage")));
            this.btnHuyCT.Name = "btnHuyCT";
            this.btnHuyCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyCT_ItemClick);
            // 
            // btnPrintCT
            // 
            this.btnPrintCT.Caption = "In";
            this.btnPrintCT.Id = 6;
            this.btnPrintCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintCT.ImageOptions.Image")));
            this.btnPrintCT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrintCT.ImageOptions.LargeImage")));
            this.btnPrintCT.Name = "btnPrintCT";
            this.btnPrintCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintCT_ItemClick);
            // 
            // btnDongCT
            // 
            this.btnDongCT.Caption = "Đóng";
            this.btnDongCT.Id = 5;
            this.btnDongCT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongCT.ImageOptions.Image")));
            this.btnDongCT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDongCT.ImageOptions.LargeImage")));
            this.btnDongCT.Name = "btnDongCT";
            this.btnDongCT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDongCT_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1161, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 633);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1161, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 603);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1161, 30);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 603);
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
            this.splitContainer1.Panel1.Controls.Add(this.txtEmailCT);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.txtDiaChiCT);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.txtSDTCT);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenCT);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSachCT);
            this.splitContainer1.Size = new System.Drawing.Size(1161, 603);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 17;
            // 
            // txtEmailCT
            // 
            this.txtEmailCT.Location = new System.Drawing.Point(127, 66);
            this.txtEmailCT.MenuManager = this.barManager1;
            this.txtEmailCT.Name = "txtEmailCT";
            this.txtEmailCT.Size = new System.Drawing.Size(157, 22);
            this.txtEmailCT.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(16, 63);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 21);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Email";
            // 
            // txtDiaChiCT
            // 
            this.txtDiaChiCT.Location = new System.Drawing.Point(437, 64);
            this.txtDiaChiCT.MenuManager = this.barManager1;
            this.txtDiaChiCT.Name = "txtDiaChiCT";
            this.txtDiaChiCT.Size = new System.Drawing.Size(157, 22);
            this.txtDiaChiCT.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(312, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 21);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Địa chỉ";
            // 
            // txtSDTCT
            // 
            this.txtSDTCT.Location = new System.Drawing.Point(437, 20);
            this.txtSDTCT.MenuManager = this.barManager1;
            this.txtSDTCT.Name = "txtSDTCT";
            this.txtSDTCT.Size = new System.Drawing.Size(157, 22);
            this.txtSDTCT.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(312, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Số điện thoại";
            // 
            // txtTenCT
            // 
            this.txtTenCT.Location = new System.Drawing.Point(127, 22);
            this.txtTenCT.MenuManager = this.barManager1;
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(157, 22);
            this.txtTenCT.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên công ty";
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1161, 30);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 603);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl5.Location = new System.Drawing.Point(1161, 30);
            this.barDockControl5.Manager = null;
            this.barDockControl5.Size = new System.Drawing.Size(0, 603);
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 1;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Id = 4;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In";
            this.btnPrint.Id = 6;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.LargeImage")));
            this.btnPrint.Name = "btnPrint";
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 5;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            this.btnDong.Name = "btnDong";
            // 
            // TENDT
            // 
            this.TENDT.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TENDT.AppearanceHeader.Options.UseFont = true;
            this.TENDT.Caption = "TENDT";
            this.TENDT.FieldName = "TENDT";
            this.TENDT.MaxWidth = 400;
            this.TENDT.MinWidth = 300;
            this.TENDT.Name = "TENDT";
            this.TENDT.Visible = true;
            this.TENDT.VisibleIndex = 1;
            this.TENDT.Width = 300;
            // 
            // gvDanhSach
            // 
            this.gvDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TENDT});
            this.gvDanhSach.GridControl = this.gcDanhSach;
            this.gvDanhSach.Name = "gvDanhSach";
            // 
            // ID
            // 
            this.ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.ID.AppearanceHeader.Options.UseFont = true;
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MaxWidth = 200;
            this.ID.MinWidth = 30;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 94;
            // 
            // gcDanhSach
            // 
            this.gcDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSach.Location = new System.Drawing.Point(0, 30);
            this.gcDanhSach.MainView = this.gvDanhSach;
            this.gcDanhSach.Name = "gcDanhSach";
            this.gcDanhSach.Size = new System.Drawing.Size(1161, 603);
            this.gcDanhSach.TabIndex = 16;
            this.gcDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSach});
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Thêm";
            this.barButtonItem8.Id = 0;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Sửa";
            this.barButtonItem9.Id = 1;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Xóa";
            this.barButtonItem10.Id = 2;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Lưu";
            this.barButtonItem11.Id = 3;
            this.barButtonItem11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.Image")));
            this.barButtonItem11.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.LargeImage")));
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "In";
            this.barButtonItem13.Id = 6;
            this.barButtonItem13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.Image")));
            this.barButtonItem13.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem13.ImageOptions.LargeImage")));
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Hủy";
            this.barButtonItem12.Id = 4;
            this.barButtonItem12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.ImageOptions.Image")));
            this.barButtonItem12.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.ImageOptions.LargeImage")));
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // frmCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 653);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCongTy";
            this.Text = "Công ty";
            this.Load += new System.EventHandler(this.frmCongTy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDTCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraGrid.Columns.GridColumn TENCT;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachCT;
        private DevExpress.XtraGrid.Columns.GridColumn IDCT;
        private DevExpress.XtraGrid.GridControl gcDanhSachCT;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemCT;
        private DevExpress.XtraBars.BarButtonItem btnSuaCT;
        private DevExpress.XtraBars.BarButtonItem btnXoaCT;
        private DevExpress.XtraBars.BarButtonItem btnLuuCT;
        private DevExpress.XtraBars.BarButtonItem btnHuyCT;
        private DevExpress.XtraBars.BarButtonItem btnPrintCT;
        private DevExpress.XtraBars.BarButtonItem btnDongCT;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit txtEmailCT;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDiaChiCT;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSDTCT;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTenCT;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TENDT;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraGrid.Columns.GridColumn DIENTHOAI;
        private DevExpress.XtraGrid.Columns.GridColumn EMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
    }
}