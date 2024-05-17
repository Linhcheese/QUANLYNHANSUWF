using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using QLNHANSU.Reports;
using DevExpress.XtraReports.UI;
using BusinessLayer.DTO;

namespace QLNHANSU
{
    public partial class frmHopDongLaoDong : DevExpress.XtraEditors.XtraForm
    {


        HOPDONGLAODONG _hdld;
        NHANVIEN _nhanvien;
        bool _them;
        string _sohd;
      
        List<HOPDONG_DTO> _lst_hd_dto;

        public frmHopDongLaoDong()
        {
            InitializeComponent();
            _hdld = new HOPDONGLAODONG();
            _nhanvien = new NHANVIEN();


        }

        private void frmHopDongLaoDong_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            loadData();
            LoadNhanVien();
            splitContainer1.Panel1Collapsed = true;
          

        }

        private void btnThemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reset();
            _them = true;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSuaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            _them = false;
            _showHide(false);
            gcDanhSachHD.Enabled = true;
        }

        private void btnXoaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                _hdld.Delete(_sohd,1);
                loadData();
            }
        }
        public void LoadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        private void btnLuuNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
            reset();
        }

        private void btnHuyNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            reset();

            splitContainer1.Panel1Collapsed = true;
        }

        private void btnPrintNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _lst_hd_dto = _hdld.getItemFull(_sohd);
            rptHopDongLaoDong rpt = new rptHopDongLaoDong(_lst_hd_dto);
            rpt.ShowPreviewDialog();

        }

        private void btnDongNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

      
        private void loadData()
        {
            // Load dữ liệu từ BusinessLayer.CHUCVU và hiển thị lên gridControl hoặc gridView
            gcDanhSachHD.DataSource = _hdld.getListFull();
            gvDanhSachHD.OptionsBehavior.Editable = false;
           
        }

        private void _showHide(bool kt)
        {
            btnLuuNV.Enabled = !kt;
            btnHuyNV.Enabled = !kt;
            btnPrintNV.Enabled = kt;
            btnSuaNV.Enabled = kt;
            btnThemNV.Enabled = kt;
            btnXoaNV.Enabled = kt;
            btnDongNV.Enabled = kt;
            gcDanhSachHD.Enabled = kt;
            dtNgayBatDau.Enabled = !kt;
            dtNgayKetThuc.Enabled = !kt;
            dtNgayKY.Enabled = !kt;
            spHeSoLuong.Enabled = !kt;
            spLanKy.Enabled = !kt;
            slkNhanVien.Enabled = !kt;
            txtHD.Enabled = !kt;

        }

        void reset()
        {
            txtHD.Text = string.Empty;
            dtNgayBatDau.Value = DateTime.Now;
            dtNgayBatDau.Value = dtNgayBatDau.Value.AddMonths(6);
            dtNgayKY.Value = DateTime.Now;
            spLanKy.Text = "1";
            spHeSoLuong.Text = "1";
          
        }
        private void SaveData()
        {
            if (_them)
            {
                var maxSoHD = _hdld.MaxSoHopDong();
                int so = int.Parse(maxSoHD.Substring(0, 5)) + 1;
                TB_HOPDONG hd = new TB_HOPDONG();
                hd.SOHD = so.ToString("00000") + @"/"+DateTime.Now.Year.ToString()+@"/HĐLĐ";
                hd.NGAYBATDAU = dtNgayBatDau.Value;
                hd.NGAYKETTHUC = dtNgayKetThuc.Value;
                hd.NGAYKY = dtNgayKY.Value;
                hd.THOIHAN = cboThoiHan.Text;
                hd.HESOLUONG = double.Parse(spHeSoLuong.EditValue.ToString());
                hd.LUONGCOBAN = int.Parse(spLuongCoBan.EditValue.ToString());
                hd.LANKY = int.Parse(spLanKy.EditValue.ToString());
                hd.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                hd.NOIDUNG = txtNoiDung.RtfText;
                hd.MACT = 3;
                hd.CREATED_BY = 1;
                hd.CREATED_DATE = DateTime.Now;
                _hdld.Add(hd);
            }
            else
            {
                var hd = _hdld.getItem(_sohd);
              
                hd.NGAYBATDAU = dtNgayBatDau.Value;
                hd.NGAYKETTHUC = dtNgayKetThuc.Value;
                hd.NGAYKY = dtNgayKY.Value;
                hd.THOIHAN = cboThoiHan.Text;
                hd.HESOLUONG = double.Parse(spHeSoLuong.EditValue.ToString());
                hd.LUONGCOBAN = int.Parse(spLuongCoBan.EditValue.ToString());
                hd.LANKY = int.Parse(spLanKy.EditValue.ToString());
                hd.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                hd.NOIDUNG = txtNoiDung.RtfText;
                hd.MACT = 3;
                hd.UPDATED_BY = 1;
                hd.UPDATED_DATE = DateTime.Now;
                _hdld.Update(hd);
            }
        }


        private void gvDanhSachHD_Click(object sender, EventArgs e)
        {
            if (gvDanhSachHD.RowCount > 0)
            {

                _sohd = gvDanhSachHD.GetFocusedRowCellValue("SOHD").ToString();
                var hd = _hdld.getItem(_sohd);
                txtHD.Text = _sohd;
                dtNgayBatDau.Value=hd.NGAYBATDAU.Value;
                dtNgayKetThuc.Value=hd.NGAYBATDAU.Value;
               dtNgayKY.Value=hd.NGAYKY.Value;
                cboThoiHan.Text=hd.THOIHAN;
               spHeSoLuong.EditValue=hd.HESOLUONG;
                spLuongCoBan.EditValue = hd.LUONGCOBAN;
               spLanKy.Text=hd.LANKY.ToString();
              slkNhanVien.EditValue=hd.MANV;
                txtNoiDung.RtfText=hd.NOIDUNG;
                _lst_hd_dto = _hdld.getItemFull(_sohd);

            }
        }

        private void gvDanhSachHD_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.b2_2;
                // Tạo một bản sao của hình ảnh với kích thước mới
                Image resizedImg = new Bitmap(img, new Size(30, 30));
                // Vẽ hình ảnh đã thay đổi kích thước lên ô
                e.Graphics.DrawImage(resizedImg, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
        //load Combo


    }
}