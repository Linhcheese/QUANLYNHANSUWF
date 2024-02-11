
namespace QLNHANSU
{
    partial class frmTrinhDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrinhDo));
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.TENTD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvDanhSachTD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDTD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSachTD = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemTD = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaTD = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaTD = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuTD = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyTD = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintTD = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongTD = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTenTD = new DevExpress.XtraEditors.TextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTD.Properties)).BeginInit();
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
            // TENTD
            // 
            this.TENTD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TENTD.AppearanceHeader.Options.UseFont = true;
            this.TENTD.Caption = "TENTD";
            this.TENTD.FieldName = "TENTD";
            this.TENTD.MaxWidth = 400;
            this.TENTD.MinWidth = 300;
            this.TENTD.Name = "TENTD";
            this.TENTD.Visible = true;
            this.TENTD.VisibleIndex = 1;
            this.TENTD.Width = 300;
            // 
            // gvDanhSachTD
            // 
            this.gvDanhSachTD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDTD,
            this.TENTD});
            this.gvDanhSachTD.GridControl = this.gcDanhSachTD;
            this.gvDanhSachTD.Name = "gvDanhSachTD";
            this.gvDanhSachTD.Click += new System.EventHandler(this.gvDanhSachTD_Click);
            // 
            // IDTD
            // 
            this.IDTD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IDTD.AppearanceHeader.Options.UseFont = true;
            this.IDTD.Caption = "IDTD";
            this.IDTD.FieldName = "IDTD";
            this.IDTD.MaxWidth = 200;
            this.IDTD.MinWidth = 30;
            this.IDTD.Name = "IDTD";
            this.IDTD.Visible = true;
            this.IDTD.VisibleIndex = 0;
            this.IDTD.Width = 94;
            // 
            // gcDanhSachTD
            // 
            this.gcDanhSachTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSachTD.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSachTD.MainView = this.gvDanhSachTD;
            this.gcDanhSachTD.MenuManager = this.barManager1;
            this.gcDanhSachTD.Name = "gcDanhSachTD";
            this.gcDanhSachTD.Size = new System.Drawing.Size(1193, 380);
            this.gcDanhSachTD.TabIndex = 0;
            this.gcDanhSachTD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachTD});
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
            this.btnThemTD,
            this.btnSuaTD,
            this.btnXoaTD,
            this.btnLuuTD,
            this.btnHuyTD,
            this.btnDongTD,
            this.btnPrintTD});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemTD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaTD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaTD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuTD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyTD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrintTD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDongTD, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemTD
            // 
            this.btnThemTD.Caption = "Thêm";
            this.btnThemTD.Id = 0;
            this.btnThemTD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTD.ImageOptions.Image")));
            this.btnThemTD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemTD.ImageOptions.LargeImage")));
            this.btnThemTD.Name = "btnThemTD";
            this.btnThemTD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemTD_ItemClick);
            // 
            // btnSuaTD
            // 
            this.btnSuaTD.Caption = "Sửa";
            this.btnSuaTD.Id = 1;
            this.btnSuaTD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaTD.ImageOptions.Image")));
            this.btnSuaTD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaTD.ImageOptions.LargeImage")));
            this.btnSuaTD.Name = "btnSuaTD";
            this.btnSuaTD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaTD_ItemClick);
            // 
            // btnXoaTD
            // 
            this.btnXoaTD.Caption = "Xóa";
            this.btnXoaTD.Id = 2;
            this.btnXoaTD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTD.ImageOptions.Image")));
            this.btnXoaTD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaTD.ImageOptions.LargeImage")));
            this.btnXoaTD.Name = "btnXoaTD";
            this.btnXoaTD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaTD_ItemClick);
            // 
            // btnLuuTD
            // 
            this.btnLuuTD.Caption = "Lưu";
            this.btnLuuTD.Id = 3;
            this.btnLuuTD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuTD.ImageOptions.Image")));
            this.btnLuuTD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuuTD.ImageOptions.LargeImage")));
            this.btnLuuTD.Name = "btnLuuTD";
            this.btnLuuTD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuTD_ItemClick);
            // 
            // btnHuyTD
            // 
            this.btnHuyTD.Caption = "Hủy";
            this.btnHuyTD.Id = 4;
            this.btnHuyTD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyTD.ImageOptions.Image")));
            this.btnHuyTD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuyTD.ImageOptions.LargeImage")));
            this.btnHuyTD.Name = "btnHuyTD";
            this.btnHuyTD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyTD_ItemClick);
            // 
            // btnPrintTD
            // 
            this.btnPrintTD.Caption = "In";
            this.btnPrintTD.Id = 6;
            this.btnPrintTD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintTD.ImageOptions.Image")));
            this.btnPrintTD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrintTD.ImageOptions.LargeImage")));
            this.btnPrintTD.Name = "btnPrintTD";
            this.btnPrintTD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintTD_ItemClick);
            // 
            // btnDongTD
            // 
            this.btnDongTD.Caption = "Đóng";
            this.btnDongTD.Id = 5;
            this.btnDongTD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongTD.ImageOptions.Image")));
            this.btnDongTD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDongTD.ImageOptions.LargeImage")));
            this.btnDongTD.Name = "btnDongTD";
            this.btnDongTD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDongTD_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1193, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 541);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1193, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 511);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1193, 30);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(0, 511);
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
            this.splitContainer1.Panel1.Controls.Add(this.txtTenTD);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSachTD);
            this.splitContainer1.Size = new System.Drawing.Size(1193, 511);
            this.splitContainer1.SplitterDistance = 127;
            this.splitContainer1.TabIndex = 17;
            // 
            // txtTenTD
            // 
            this.txtTenTD.Location = new System.Drawing.Point(59, 20);
            this.txtTenTD.MenuManager = this.barManager1;
            this.txtTenTD.Name = "txtTenTD";
            this.txtTenTD.Size = new System.Drawing.Size(157, 22);
            this.txtTenTD.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(28, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên";
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1193, 30);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 511);
            // 
            // barDockControl5
            // 
            this.barDockControl5.CausesValidation = false;
            this.barDockControl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl5.Location = new System.Drawing.Point(1193, 30);
            this.barDockControl5.Manager = null;
            this.barDockControl5.Size = new System.Drawing.Size(0, 511);
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
            this.gcDanhSach.Size = new System.Drawing.Size(1193, 511);
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
            // frmTrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.gcDanhSach);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl5);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTrinhDo";
            this.Text = "Trình độ";
            this.Load += new System.EventHandler(this.frmTrinhDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraGrid.Columns.GridColumn TENTD;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachTD;
        private DevExpress.XtraGrid.Columns.GridColumn IDTD;
        private DevExpress.XtraGrid.GridControl gcDanhSachTD;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemTD;
        private DevExpress.XtraBars.BarButtonItem btnSuaTD;
        private DevExpress.XtraBars.BarButtonItem btnXoaTD;
        private DevExpress.XtraBars.BarButtonItem btnLuuTD;
        private DevExpress.XtraBars.BarButtonItem btnHuyTD;
        private DevExpress.XtraBars.BarButtonItem btnPrintTD;
        private DevExpress.XtraBars.BarButtonItem btnDongTD;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit txtTenTD;
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
    }
}