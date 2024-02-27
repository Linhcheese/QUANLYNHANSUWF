
namespace QLNHANSU
{
    partial class frmTangLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTangLuong));
            this.coHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtQD = new DevExpress.XtraEditors.TextEdit();
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.gvDanhSachTV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DELETED_BY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOQD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYLENLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HSLCu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HSLMOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSachTV = new DevExpress.XtraGrid.GridControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.spHSLMoi = new DevExpress.XtraEditors.SpinEdit();
            this.spHSLCu = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayLenLuong = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayKy = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.slkHopDong = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coSOHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coHSL = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtQD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spHSLMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHSLCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkHopDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // coHOTEN
            // 
            this.coHOTEN.Caption = "Họ tên";
            this.coHOTEN.FieldName = "HOTEN";
            this.coHOTEN.MaxWidth = 150;
            this.coHOTEN.Name = "coHOTEN";
            this.coHOTEN.Visible = true;
            this.coHOTEN.VisibleIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(367, 172);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 18);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Nhân viên";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1460, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 913);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1460, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 883);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1460, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 883);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(42, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Số QĐ";
            // 
            // gvDanhSachTV
            // 
            this.gvDanhSachTV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DELETED_BY,
            this.SOQD,
            this.SOHD,
            this.NGAYKY,
            this.NGAYLENLUONG,
            this.HSLCu,
            this.HSLMOI,
            this.MANV,
            this.HOTEN,
            this.NOIDUNG});
            this.gvDanhSachTV.GridControl = this.gcDanhSachTV;
            this.gvDanhSachTV.Name = "gvDanhSachTV";
            this.gvDanhSachTV.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gvDanhSachTV_CustomDrawCell);
            // 
            // DELETED_BY
            // 
            this.DELETED_BY.FieldName = "DELETED_BY";
            this.DELETED_BY.MaxWidth = 10;
            this.DELETED_BY.MinWidth = 25;
            this.DELETED_BY.Name = "DELETED_BY";
            this.DELETED_BY.Visible = true;
            this.DELETED_BY.VisibleIndex = 0;
            this.DELETED_BY.Width = 25;
            // 
            // SOQD
            // 
            this.SOQD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SOQD.AppearanceHeader.Options.UseFont = true;
            this.SOQD.Caption = "Số quyết định";
            this.SOQD.FieldName = "SOQD";
            this.SOQD.MaxWidth = 200;
            this.SOQD.MinWidth = 30;
            this.SOQD.Name = "SOQD";
            this.SOQD.Visible = true;
            this.SOQD.VisibleIndex = 1;
            this.SOQD.Width = 200;
            // 
            // SOHD
            // 
            this.SOHD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SOHD.AppearanceHeader.Options.UseFont = true;
            this.SOHD.Caption = "Số hợp đồng";
            this.SOHD.FieldName = "SOHD";
            this.SOHD.MinWidth = 25;
            this.SOHD.Name = "SOHD";
            this.SOHD.Visible = true;
            this.SOHD.VisibleIndex = 2;
            this.SOHD.Width = 94;
            // 
            // NGAYKY
            // 
            this.NGAYKY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NGAYKY.AppearanceHeader.Options.UseFont = true;
            this.NGAYKY.Caption = "Ngày ký";
            this.NGAYKY.FieldName = "NGAYKY";
            this.NGAYKY.MaxWidth = 200;
            this.NGAYKY.MinWidth = 150;
            this.NGAYKY.Name = "NGAYKY";
            this.NGAYKY.Visible = true;
            this.NGAYKY.VisibleIndex = 4;
            this.NGAYKY.Width = 200;
            // 
            // NGAYLENLUONG
            // 
            this.NGAYLENLUONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NGAYLENLUONG.AppearanceHeader.Options.UseFont = true;
            this.NGAYLENLUONG.Caption = "Ngày lên lương";
            this.NGAYLENLUONG.FieldName = "NGAYLENLUONG";
            this.NGAYLENLUONG.MinWidth = 25;
            this.NGAYLENLUONG.Name = "NGAYLENLUONG";
            this.NGAYLENLUONG.Visible = true;
            this.NGAYLENLUONG.VisibleIndex = 3;
            this.NGAYLENLUONG.Width = 129;
            // 
            // HSLCu
            // 
            this.HSLCu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HSLCu.AppearanceHeader.Options.UseFont = true;
            this.HSLCu.Caption = "HSL Cũ";
            this.HSLCu.FieldName = "HESOLUONGHIENTAI";
            this.HSLCu.MinWidth = 25;
            this.HSLCu.Name = "HSLCu";
            this.HSLCu.Visible = true;
            this.HSLCu.VisibleIndex = 5;
            this.HSLCu.Width = 94;
            // 
            // HSLMOI
            // 
            this.HSLMOI.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HSLMOI.AppearanceHeader.Options.UseFont = true;
            this.HSLMOI.Caption = "HSL Mới";
            this.HSLMOI.FieldName = "HESOLUONGHIENTAI";
            this.HSLMOI.MinWidth = 25;
            this.HSLMOI.Name = "HSLMOI";
            this.HSLMOI.Visible = true;
            this.HSLMOI.VisibleIndex = 6;
            this.HSLMOI.Width = 94;
            // 
            // MANV
            // 
            this.MANV.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.MANV.AppearanceHeader.Options.UseFont = true;
            this.MANV.Caption = "MANV";
            this.MANV.FieldName = "MANV";
            this.MANV.MaxWidth = 150;
            this.MANV.MinWidth = 150;
            this.MANV.Name = "MANV";
            this.MANV.Width = 150;
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
            this.HOTEN.VisibleIndex = 7;
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
            this.NOIDUNG.VisibleIndex = 8;
            this.NOIDUNG.Width = 129;
            // 
            // gcDanhSachTV
            // 
            this.gcDanhSachTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSachTV.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSachTV.MainView = this.gvDanhSachTV;
            this.gcDanhSachTV.MenuManager = this.barManager1;
            this.gcDanhSachTV.Name = "gcDanhSachTV";
            this.gcDanhSachTV.Size = new System.Drawing.Size(1460, 574);
            this.gcDanhSachTV.TabIndex = 0;
            this.gcDanhSachTV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachTV});
            this.gcDanhSachTV.Click += new System.EventHandler(this.gcDanhSachTV_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(42, 89);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 18);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Hợp đồng";
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
            this.splitContainer1.Panel1.Controls.Add(this.spHSLMoi);
            this.splitContainer1.Panel1.Controls.Add(this.spHSLCu);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayLenLuong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKy);
            this.splitContainer1.Panel1.Controls.Add(this.txtGhiChu);
            this.splitContainer1.Panel1.Controls.Add(this.txtNhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainer1.Panel1.Controls.Add(this.slkHopDong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.txtQD);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSachTV);
            this.splitContainer1.Size = new System.Drawing.Size(1460, 883);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 11;
            // 
            // spHSLMoi
            // 
            this.spHSLMoi.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spHSLMoi.Location = new System.Drawing.Point(137, 182);
            this.spHSLMoi.MenuManager = this.barManager1;
            this.spHSLMoi.Name = "spHSLMoi";
            this.spHSLMoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHSLMoi.Size = new System.Drawing.Size(162, 24);
            this.spHSLMoi.TabIndex = 32;
            // 
            // spHSLCu
            // 
            this.spHSLCu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spHSLCu.Location = new System.Drawing.Point(137, 130);
            this.spHSLCu.MenuManager = this.barManager1;
            this.spHSLCu.Name = "spHSLCu";
            this.spHSLCu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHSLCu.Properties.ReadOnly = true;
            this.spHSLCu.Size = new System.Drawing.Size(162, 24);
            this.spHSLCu.TabIndex = 31;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(42, 175);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 18);
            this.labelControl6.TabIndex = 30;
            this.labelControl6.Text = "HSL mới";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(42, 132);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(76, 18);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "HSL hiện tại";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(365, 128);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 18);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Ngày lên lương";
            // 
            // dtNgayLenLuong
            // 
            this.dtNgayLenLuong.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLenLuong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLenLuong.Location = new System.Drawing.Point(487, 127);
            this.dtNgayLenLuong.Name = "dtNgayLenLuong";
            this.dtNgayLenLuong.Size = new System.Drawing.Size(204, 23);
            this.dtNgayLenLuong.TabIndex = 27;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(365, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 18);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Ngày ký";
            // 
            // dtNgayKy
            // 
            this.dtNgayKy.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKy.Location = new System.Drawing.Point(487, 89);
            this.dtNgayKy.Name = "dtNgayKy";
            this.dtNgayKy.Size = new System.Drawing.Size(204, 23);
            this.dtNgayKy.TabIndex = 25;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(137, 232);
            this.txtGhiChu.MenuManager = this.barManager1;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(610, 22);
            this.txtGhiChu.TabIndex = 23;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(487, 171);
            this.txtNhanVien.MenuManager = this.barManager1;
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(204, 22);
            this.txtNhanVien.TabIndex = 20;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(42, 233);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 18);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Ghi chú";
            // 
            // slkHopDong
            // 
            this.slkHopDong.Location = new System.Drawing.Point(137, 85);
            this.slkHopDong.MenuManager = this.barManager1;
            this.slkHopDong.Name = "slkHopDong";
            this.slkHopDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkHopDong.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkHopDong.Size = new System.Drawing.Size(204, 22);
            this.slkHopDong.TabIndex = 17;
            this.slkHopDong.EditValueChanged += new System.EventHandler(this.slkHopDong_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coSOHD,
            this.coMANV,
            this.coHOTEN,
            this.coHSL});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // coSOHD
            // 
            this.coSOHD.Caption = "Số hợp đồng";
            this.coSOHD.FieldName = "SOHD";
            this.coSOHD.MaxWidth = 100;
            this.coSOHD.Name = "coSOHD";
            this.coSOHD.Visible = true;
            this.coSOHD.VisibleIndex = 0;
            // 
            // coMANV
            // 
            this.coMANV.Caption = "Max nv";
            this.coMANV.FieldName = "MANV";
            this.coMANV.Name = "coMANV";
            this.coMANV.Visible = true;
            this.coMANV.VisibleIndex = 3;
            // 
            // coHSL
            // 
            this.coHSL.Caption = "Hệ số lương";
            this.coHSL.FieldName = "HESOLUONG";
            this.coHSL.Name = "coHSL";
            this.coHSL.Visible = true;
            this.coHSL.VisibleIndex = 1;
            // 
            // frmTangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 933);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmTangLuong";
            this.Text = "Quản lý lương";
            this.Load += new System.EventHandler(this.frmTangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachTV)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spHSLMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHSLCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkHopDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn coHOTEN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtQD;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dtNgayLenLuong;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtNgayKy;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.TextEdit txtNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SearchLookUpEdit slkHopDong;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coSOHD;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gcDanhSachTV;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachTV;
        private DevExpress.XtraGrid.Columns.GridColumn DELETED_BY;
        private DevExpress.XtraGrid.Columns.GridColumn SOQD;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKY;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYLENLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn NOIDUNG;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit spHSLMoi;
        private DevExpress.XtraEditors.SpinEdit spHSLCu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.Columns.GridColumn HSLCu;
        private DevExpress.XtraGrid.Columns.GridColumn HSLMOI;
        private DevExpress.XtraGrid.Columns.GridColumn coMANV;
        private DevExpress.XtraGrid.Columns.GridColumn coHSL;
        private DevExpress.XtraGrid.Columns.GridColumn SOHD;
    }
}