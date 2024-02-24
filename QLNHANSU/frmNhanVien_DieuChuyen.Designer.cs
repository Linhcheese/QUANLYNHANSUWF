
namespace QLNHANSU
{
    partial class frmNhanVien_DieuChuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien_DieuChuyen));
            this.coMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemKT = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaKT = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaKT = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuKT = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyKT = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintKT = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongKT = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLyDo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.slkNhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtQD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gcDanhSachDC = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachDC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SOQUYETDINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LYDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAPB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPB2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAPB2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachDC)).BeginInit();
            this.SuspendLayout();
            // 
            // coMANV
            // 
            this.coMANV.Caption = "Mã nv";
            this.coMANV.FieldName = "MANV";
            this.coMANV.MaxWidth = 100;
            this.coMANV.Name = "coMANV";
            this.coMANV.Visible = true;
            this.coMANV.VisibleIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgay);
            this.splitContainer1.Panel1.Controls.Add(this.cboPhongBan);
            this.splitContainer1.Panel1.Controls.Add(this.txtGhiChu);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.txtLyDo);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.slkNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.txtQD);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSachDC);
            this.splitContainer1.Size = new System.Drawing.Size(1488, 786);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(59, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 18);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Ngày ";
            // 
            // dtNgay
            // 
            this.dtNgay.CustomFormat = "dd/MM/yyyy";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay.Location = new System.Drawing.Point(137, 86);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(204, 23);
            this.dtNgay.TabIndex = 25;
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(470, 85);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(249, 24);
            this.cboPhongBan.TabIndex = 24;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(137, 168);
            this.txtGhiChu.MenuManager = this.barManager1;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(919, 22);
            this.txtGhiChu.TabIndex = 23;
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
            this.btnThemKT,
            this.btnSuaKT,
            this.btnXoaKT,
            this.btnLuuKT,
            this.btnHuyKT,
            this.btnDongKT,
            this.btnPrintKT});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemKT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaKT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaKT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuKT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyKT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrintKT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDongKT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemKT
            // 
            this.btnThemKT.Caption = "Thêm";
            this.btnThemKT.Id = 0;
            this.btnThemKT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKT.ImageOptions.Image")));
            this.btnThemKT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemKT.ImageOptions.LargeImage")));
            this.btnThemKT.Name = "btnThemKT";
            this.btnThemKT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemKT_ItemClick);
            // 
            // btnSuaKT
            // 
            this.btnSuaKT.Caption = "Sửa";
            this.btnSuaKT.Id = 1;
            this.btnSuaKT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKT.ImageOptions.Image")));
            this.btnSuaKT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaKT.ImageOptions.LargeImage")));
            this.btnSuaKT.Name = "btnSuaKT";
            this.btnSuaKT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaKT_ItemClick);
            // 
            // btnXoaKT
            // 
            this.btnXoaKT.Caption = "Xóa";
            this.btnXoaKT.Id = 2;
            this.btnXoaKT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKT.ImageOptions.Image")));
            this.btnXoaKT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaKT.ImageOptions.LargeImage")));
            this.btnXoaKT.Name = "btnXoaKT";
            this.btnXoaKT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaKT_ItemClick);
            // 
            // btnLuuKT
            // 
            this.btnLuuKT.Caption = "Lưu";
            this.btnLuuKT.Id = 3;
            this.btnLuuKT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuKT.ImageOptions.Image")));
            this.btnLuuKT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuuKT.ImageOptions.LargeImage")));
            this.btnLuuKT.Name = "btnLuuKT";
            this.btnLuuKT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuKT_ItemClick);
            // 
            // btnHuyKT
            // 
            this.btnHuyKT.Caption = "Hủy";
            this.btnHuyKT.Id = 4;
            this.btnHuyKT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyKT.ImageOptions.Image")));
            this.btnHuyKT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuyKT.ImageOptions.LargeImage")));
            this.btnHuyKT.Name = "btnHuyKT";
            this.btnHuyKT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyKT_ItemClick);
            // 
            // btnPrintKT
            // 
            this.btnPrintKT.Caption = "In";
            this.btnPrintKT.Id = 6;
            this.btnPrintKT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintKT.ImageOptions.Image")));
            this.btnPrintKT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrintKT.ImageOptions.LargeImage")));
            this.btnPrintKT.Name = "btnPrintKT";
            this.btnPrintKT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintKT_ItemClick);
            // 
            // btnDongKT
            // 
            this.btnDongKT.Caption = "Đóng";
            this.btnDongKT.Id = 5;
            this.btnDongKT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongKT.ImageOptions.Image")));
            this.btnDongKT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDongKT.ImageOptions.LargeImage")));
            this.btnDongKT.Name = "btnDongKT";
            this.btnDongKT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDongKT_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1488, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 816);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1488, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 786);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1488, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 786);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(371, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 18);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Chuyển đến";
            // 
            // txtLyDo
            // 
            this.txtLyDo.Location = new System.Drawing.Point(137, 125);
            this.txtLyDo.MenuManager = this.barManager1;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(919, 22);
            this.txtLyDo.TabIndex = 20;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(62, 169);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 18);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Ghi chú";
            // 
            // slkNhanVien
            // 
            this.slkNhanVien.Location = new System.Drawing.Point(470, 41);
            this.slkNhanVien.MenuManager = this.barManager1;
            this.slkNhanVien.Name = "slkNhanVien";
            this.slkNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkNhanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkNhanVien.Size = new System.Drawing.Size(249, 22);
            this.slkNhanVien.TabIndex = 17;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coMANV,
            this.coHOTEN});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // coHOTEN
            // 
            this.coHOTEN.Caption = "Họ tên";
            this.coHOTEN.FieldName = "HOTEN";
            this.coHOTEN.MaxWidth = 150;
            this.coHOTEN.Name = "coHOTEN";
            this.coHOTEN.Visible = true;
            this.coHOTEN.VisibleIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(375, 45);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 18);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Nhân nhiên";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(62, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 18);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Lý do";
            // 
            // txtQD
            // 
            this.txtQD.Location = new System.Drawing.Point(137, 41);
            this.txtQD.MenuManager = this.barManager1;
            this.txtQD.Name = "txtQD";
            this.txtQD.Properties.ReadOnly = true;
            this.txtQD.Size = new System.Drawing.Size(204, 22);
            this.txtQD.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(62, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Số QĐ";
            // 
            // gcDanhSachDC
            // 
            this.gcDanhSachDC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSachDC.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSachDC.MainView = this.gvDanhSachDC;
            this.gcDanhSachDC.MenuManager = this.barManager1;
            this.gcDanhSachDC.Name = "gcDanhSachDC";
            this.gcDanhSachDC.Size = new System.Drawing.Size(1488, 509);
            this.gcDanhSachDC.TabIndex = 0;
            this.gcDanhSachDC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachDC});
            // 
            // gvDanhSachDC
            // 
            this.gvDanhSachDC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SOQUYETDINH,
            this.NGAY,
            this.LYDO,
            this.IDNV,
            this.HOTEN,
            this.MAPB,
            this.TENPB,
            this.MAPB2,
            this.TENPB2,
            this.NOIDUNG});
            this.gvDanhSachDC.GridControl = this.gcDanhSachDC;
            this.gvDanhSachDC.Name = "gvDanhSachDC";
            this.gvDanhSachDC.Click += new System.EventHandler(this.gvDanhSachDC_Click);
            // 
            // SOQUYETDINH
            // 
            this.SOQUYETDINH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SOQUYETDINH.AppearanceHeader.Options.UseFont = true;
            this.SOQUYETDINH.Caption = "Số quyết định";
            this.SOQUYETDINH.FieldName = "SOQD";
            this.SOQUYETDINH.MaxWidth = 200;
            this.SOQUYETDINH.MinWidth = 30;
            this.SOQUYETDINH.Name = "SOQUYETDINH";
            this.SOQUYETDINH.Visible = true;
            this.SOQUYETDINH.VisibleIndex = 0;
            this.SOQUYETDINH.Width = 161;
            // 
            // LYDO
            // 
            this.LYDO.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.LYDO.AppearanceHeader.Options.UseFont = true;
            this.LYDO.Caption = "Lý do";
            this.LYDO.FieldName = "LYDO";
            this.LYDO.MinWidth = 25;
            this.LYDO.Name = "LYDO";
            this.LYDO.Visible = true;
            this.LYDO.VisibleIndex = 1;
            this.LYDO.Width = 94;
            // 
            // NGAY
            // 
            this.NGAY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NGAY.AppearanceHeader.Options.UseFont = true;
            this.NGAY.Caption = "Ngày ";
            this.NGAY.FieldName = "NGAY";
            this.NGAY.MaxWidth = 200;
            this.NGAY.MinWidth = 150;
            this.NGAY.Name = "NGAY";
            this.NGAY.Visible = true;
            this.NGAY.VisibleIndex = 2;
            this.NGAY.Width = 200;
            // 
            // IDNV
            // 
            this.IDNV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.IDNV.AppearanceHeader.Options.UseFont = true;
            this.IDNV.Caption = "MANV";
            this.IDNV.FieldName = "IDNV";
            this.IDNV.MaxWidth = 150;
            this.IDNV.MinWidth = 150;
            this.IDNV.Name = "IDNV";
            this.IDNV.Width = 150;
            // 
            // HOTEN
            // 
            this.HOTEN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HOTEN.AppearanceHeader.Options.UseFont = true;
            this.HOTEN.Caption = "Nhân viên";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 150;
            this.HOTEN.MinWidth = 150;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 3;
            this.HOTEN.Width = 150;
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NOIDUNG.AppearanceHeader.Options.UseFont = true;
            this.NOIDUNG.Caption = "Ghi chú";
            this.NOIDUNG.FieldName = "GHICHU";
            this.NOIDUNG.MinWidth = 25;
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.Visible = true;
            this.NOIDUNG.VisibleIndex = 4;
            this.NOIDUNG.Width = 94;
            // 
            // TENPB
            // 
            this.TENPB.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TENPB.AppearanceHeader.Options.UseFont = true;
            this.TENPB.Caption = "Đơn vị hiện tại";
            this.TENPB.FieldName = "TENPB";
            this.TENPB.MinWidth = 25;
            this.TENPB.Name = "TENPB";
            this.TENPB.Visible = true;
            this.TENPB.VisibleIndex = 5;
            this.TENPB.Width = 94;
            // 
            // MAPB
            // 
            this.MAPB.FieldName = "MAPB";
            this.MAPB.MinWidth = 25;
            this.MAPB.Name = "MAPB";
            this.MAPB.Width = 94;
            // 
            // TENPB2
            // 
            this.TENPB2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.TENPB2.AppearanceHeader.Options.UseFont = true;
            this.TENPB2.Caption = "Đơn vị đến";
            this.TENPB2.FieldName = "TENPB2";
            this.TENPB2.MinWidth = 25;
            this.TENPB2.Name = "TENPB2";
            this.TENPB2.Visible = true;
            this.TENPB2.VisibleIndex = 6;
            this.TENPB2.Width = 94;
            // 
            // MAPB2
            // 
            this.MAPB2.FieldName = "MAPB2";
            this.MAPB2.MinWidth = 25;
            this.MAPB2.Name = "MAPB2";
            this.MAPB2.Width = 94;
            // 
            // frmNhanVien_DieuChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 836);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmNhanVien_DieuChuyen";
            this.Text = "Điều chuyển";
            this.Load += new System.EventHandler(this.frmNhanVien_DieuChuyen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLyDo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachDC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn coMANV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemKT;
        private DevExpress.XtraBars.BarButtonItem btnSuaKT;
        private DevExpress.XtraBars.BarButtonItem btnXoaKT;
        private DevExpress.XtraBars.BarButtonItem btnLuuKT;
        private DevExpress.XtraBars.BarButtonItem btnHuyKT;
        private DevExpress.XtraBars.BarButtonItem btnPrintKT;
        private DevExpress.XtraBars.BarButtonItem btnDongKT;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtLyDo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SearchLookUpEdit slkNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coHOTEN;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtQD;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gcDanhSachDC;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachDC;
        private DevExpress.XtraGrid.Columns.GridColumn SOQUYETDINH;
        private DevExpress.XtraGrid.Columns.GridColumn LYDO;
        private DevExpress.XtraGrid.Columns.GridColumn NGAY;
        private DevExpress.XtraGrid.Columns.GridColumn IDNV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn NOIDUNG;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private DevExpress.XtraGrid.Columns.GridColumn MAPB;
        private DevExpress.XtraGrid.Columns.GridColumn TENPB;
        private DevExpress.XtraGrid.Columns.GridColumn MAPB2;
        private DevExpress.XtraGrid.Columns.GridColumn TENPB2;
    }
}