
namespace QLNHANSU
{
    partial class frmHopDongLaoDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDongLaoDong));
            this.gvDanhSachHD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SOHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYBATDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYKETTHUC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THOIHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HESOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LANKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDanhSachHD = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThemNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuuNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuyNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrintNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnDongNV = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayKY = new System.Windows.Forms.DateTimePicker();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.spLanKy = new DevExpress.XtraEditors.SpinEdit();
            this.spHeSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDanhSachHD
            // 
            this.gvDanhSachHD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SOHD,
            this.NGAYBATDAU,
            this.NGAYKETTHUC,
            this.THOIHAN,
            this.HESOLUONG,
            this.LANKY,
            this.MANV,
            this.HOTEN});
            this.gvDanhSachHD.GridControl = this.gcDanhSachHD;
            this.gvDanhSachHD.Name = "gvDanhSachHD";
            // 
            // SOHD
            // 
            this.SOHD.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.SOHD.AppearanceHeader.Options.UseFont = true;
            this.SOHD.Caption = "Số hợp đồng";
            this.SOHD.FieldName = "SOHD";
            this.SOHD.MaxWidth = 200;
            this.SOHD.MinWidth = 30;
            this.SOHD.Name = "SOHD";
            this.SOHD.Visible = true;
            this.SOHD.VisibleIndex = 0;
            this.SOHD.Width = 161;
            // 
            // NGAYBATDAU
            // 
            this.NGAYBATDAU.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NGAYBATDAU.AppearanceHeader.Options.UseFont = true;
            this.NGAYBATDAU.Caption = "Ngày bắt đầu";
            this.NGAYBATDAU.FieldName = "NGAYBATDAU";
            this.NGAYBATDAU.MaxWidth = 200;
            this.NGAYBATDAU.MinWidth = 150;
            this.NGAYBATDAU.Name = "NGAYBATDAU";
            this.NGAYBATDAU.Visible = true;
            this.NGAYBATDAU.VisibleIndex = 1;
            this.NGAYBATDAU.Width = 200;
            // 
            // NGAYKETTHUC
            // 
            this.NGAYKETTHUC.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.NGAYKETTHUC.AppearanceHeader.Options.UseFont = true;
            this.NGAYKETTHUC.Caption = "Ngày kết thúc";
            this.NGAYKETTHUC.FieldName = "NGAYKETTHUC";
            this.NGAYKETTHUC.MaxWidth = 200;
            this.NGAYKETTHUC.MinWidth = 120;
            this.NGAYKETTHUC.Name = "NGAYKETTHUC";
            this.NGAYKETTHUC.Visible = true;
            this.NGAYKETTHUC.VisibleIndex = 2;
            this.NGAYKETTHUC.Width = 200;
            // 
            // THOIHAN
            // 
            this.THOIHAN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.THOIHAN.AppearanceHeader.Options.UseFont = true;
            this.THOIHAN.Caption = "Thời hạn";
            this.THOIHAN.FieldName = "THOIHAN";
            this.THOIHAN.MaxWidth = 200;
            this.THOIHAN.MinWidth = 80;
            this.THOIHAN.Name = "THOIHAN";
            this.THOIHAN.Visible = true;
            this.THOIHAN.VisibleIndex = 3;
            this.THOIHAN.Width = 200;
            // 
            // HESOLUONG
            // 
            this.HESOLUONG.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.HESOLUONG.AppearanceHeader.Options.UseFont = true;
            this.HESOLUONG.Caption = "Hệ số lương";
            this.HESOLUONG.FieldName = "HESOLUONG";
            this.HESOLUONG.MaxWidth = 120;
            this.HESOLUONG.MinWidth = 120;
            this.HESOLUONG.Name = "HESOLUONG";
            this.HESOLUONG.Visible = true;
            this.HESOLUONG.VisibleIndex = 4;
            this.HESOLUONG.Width = 120;
            // 
            // LANKY
            // 
            this.LANKY.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.LANKY.AppearanceHeader.Options.UseFont = true;
            this.LANKY.Caption = "Lần ký";
            this.LANKY.FieldName = "LANKY";
            this.LANKY.MaxWidth = 100;
            this.LANKY.MinWidth = 120;
            this.LANKY.Name = "LANKY";
            this.LANKY.Visible = true;
            this.LANKY.VisibleIndex = 5;
            this.LANKY.Width = 120;
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
            this.HOTEN.VisibleIndex = 6;
            this.HOTEN.Width = 150;
            // 
            // gcDanhSachHD
            // 
            this.gcDanhSachHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSachHD.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSachHD.MainView = this.gvDanhSachHD;
            this.gcDanhSachHD.MenuManager = this.barManager1;
            this.gcDanhSachHD.Name = "gcDanhSachHD";
            this.gcDanhSachHD.Size = new System.Drawing.Size(1181, 430);
            this.gcDanhSachHD.TabIndex = 0;
            this.gcDanhSachHD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachHD});
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
            this.btnThemNV,
            this.btnSuaNV,
            this.btnXoaNV,
            this.btnLuuNV,
            this.btnHuyNV,
            this.btnDongNV,
            this.btnPrintNV});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuuNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuyNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrintNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDongNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Caption = "Thêm";
            this.btnThemNV.Id = 0;
            this.btnThemNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNV.ImageOptions.Image")));
            this.btnThemNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemNV.ImageOptions.LargeImage")));
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemNV_ItemClick);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Caption = "Sửa";
            this.btnSuaNV.Id = 1;
            this.btnSuaNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNV.ImageOptions.Image")));
            this.btnSuaNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaNV.ImageOptions.LargeImage")));
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaNV_ItemClick);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Caption = "Xóa";
            this.btnXoaNV.Id = 2;
            this.btnXoaNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNV.ImageOptions.Image")));
            this.btnXoaNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoaNV.ImageOptions.LargeImage")));
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaNV_ItemClick);
            // 
            // btnLuuNV
            // 
            this.btnLuuNV.Caption = "Lưu";
            this.btnLuuNV.Id = 3;
            this.btnLuuNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuNV.ImageOptions.Image")));
            this.btnLuuNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuuNV.ImageOptions.LargeImage")));
            this.btnLuuNV.Name = "btnLuuNV";
            this.btnLuuNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuuNV_ItemClick);
            // 
            // btnHuyNV
            // 
            this.btnHuyNV.Caption = "Hủy";
            this.btnHuyNV.Id = 4;
            this.btnHuyNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyNV.ImageOptions.Image")));
            this.btnHuyNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuyNV.ImageOptions.LargeImage")));
            this.btnHuyNV.Name = "btnHuyNV";
            this.btnHuyNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuyNV_ItemClick);
            // 
            // btnPrintNV
            // 
            this.btnPrintNV.Caption = "In";
            this.btnPrintNV.Id = 6;
            this.btnPrintNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintNV.ImageOptions.Image")));
            this.btnPrintNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPrintNV.ImageOptions.LargeImage")));
            this.btnPrintNV.Name = "btnPrintNV";
            this.btnPrintNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrintNV_ItemClick);
            // 
            // btnDongNV
            // 
            this.btnDongNV.Caption = "Đóng";
            this.btnDongNV.Id = 5;
            this.btnDongNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongNV.ImageOptions.Image")));
            this.btnDongNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDongNV.ImageOptions.LargeImage")));
            this.btnDongNV.Name = "btnDongNV";
            this.btnDongNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDongNV_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1181, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 762);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1181, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 732);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1181, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 732);
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
            this.splitContainer1.Panel1.Controls.Add(this.searchLookUpEdit1);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.spHeSoLuong);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.spLanKy);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKY);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayKetThuc);
            this.splitContainer1.Panel1.Controls.Add(this.txtSDT);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.dtNgayBatDau);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcDanhSachHD);
            this.splitContainer1.Size = new System.Drawing.Size(1181, 732);
            this.splitContainer1.SplitterDistance = 298;
            this.splitContainer1.TabIndex = 7;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(137, 32);
            this.txtSDT.MenuManager = this.barManager1;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(204, 22);
            this.txtSDT.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(27, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 18);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Số HĐ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Ngày bắt đầu";
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.CustomFormat = "dd/MM/yyyy";
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayBatDau.Location = new System.Drawing.Point(137, 71);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(204, 23);
            this.dtNgayBatDau.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 116);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 18);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Ngày kết thúc";
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(137, 116);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(204, 23);
            this.dtNgayKetThuc.TabIndex = 8;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(27, 163);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 18);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Ngày ký";
            // 
            // dtNgayKY
            // 
            this.dtNgayKY.CustomFormat = "dd/MM/yyyy";
            this.dtNgayKY.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayKY.Location = new System.Drawing.Point(137, 163);
            this.dtNgayKY.Name = "dtNgayKY";
            this.dtNgayKY.Size = new System.Drawing.Size(204, 23);
            this.dtNgayKY.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(434, 33);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 18);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Số lần ký";
            // 
            // spLanKy
            // 
            this.spLanKy.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spLanKy.Location = new System.Drawing.Point(521, 30);
            this.spLanKy.MenuManager = this.barManager1;
            this.spLanKy.Name = "spLanKy";
            this.spLanKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spLanKy.Properties.IsFloatValue = false;
            this.spLanKy.Properties.Mask.EditMask = "N00";
            this.spLanKy.Size = new System.Drawing.Size(108, 24);
            this.spLanKy.TabIndex = 13;
            // 
            // spHeSoLuong
            // 
            this.spHeSoLuong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spHeSoLuong.Location = new System.Drawing.Point(521, 72);
            this.spHeSoLuong.MenuManager = this.barManager1;
            this.spHeSoLuong.Name = "spHeSoLuong";
            this.spHeSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spHeSoLuong.Size = new System.Drawing.Size(108, 24);
            this.spHeSoLuong.TabIndex = 15;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(434, 75);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 18);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Hệ số lương";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(434, 116);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(73, 18);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Nhân nhiên";
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(521, 118);
            this.searchLookUpEdit1.MenuManager = this.barManager1;
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(249, 22);
            this.searchLookUpEdit1.TabIndex = 17;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // frmHopDongLaoDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 782);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmHopDongLaoDong";
            this.Text = "Hợp đồng";
            this.Load += new System.EventHandler(this.frmHopDongLaoDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLanKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spHeSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachHD;
        private DevExpress.XtraGrid.Columns.GridColumn SOHD;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYBATDAU;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYKETTHUC;
        private DevExpress.XtraGrid.Columns.GridColumn THOIHAN;
        private DevExpress.XtraGrid.Columns.GridColumn HESOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn LANKY;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.GridControl gcDanhSachHD;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThemNV;
        private DevExpress.XtraBars.BarButtonItem btnSuaNV;
        private DevExpress.XtraBars.BarButtonItem btnXoaNV;
        private DevExpress.XtraBars.BarButtonItem btnLuuNV;
        private DevExpress.XtraBars.BarButtonItem btnHuyNV;
        private DevExpress.XtraBars.BarButtonItem btnPrintNV;
        private DevExpress.XtraBars.BarButtonItem btnDongNV;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;
        private DevExpress.XtraEditors.SpinEdit spHeSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SpinEdit spLanKy;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DateTimePicker dtNgayKY;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}