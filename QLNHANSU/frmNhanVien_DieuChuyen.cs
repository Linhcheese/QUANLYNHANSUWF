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
namespace QLNHANSU
{
    public partial class frmNhanVien_DieuChuyen : DevExpress.XtraEditors.XtraForm
    {

        NHANVIEN_DIEUCHUYEN _dieuchuyen;
        bool _them;
        string _soqd;
        NHANVIEN _nhanvien;
        PHONGBAN _phongban;
        public frmNhanVien_DieuChuyen()
        {
            InitializeComponent();
            _dieuchuyen = new NHANVIEN_DIEUCHUYEN();
            _nhanvien = new NHANVIEN();
            _phongban = new PHONGBAN();
        }

        private void frmNhanVien_DieuChuyen_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            loadData();
            LoadNhanVien();
            LoadDonViDen();
            splitContainer1.Panel1Collapsed = true;
        }
        public void LoadNhanVien()
        {   
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        public void LoadDonViDen()
        {
            cboPhongBan.DataSource = _phongban.getList();
            cboPhongBan.ValueMember = "IDPB";
            cboPhongBan.DisplayMember = "TENPB";
        }
        private void btnThemKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reset();
            _them = true;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSuaKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            _them = false;
            _showHide(false);
            gcDanhSachDC.Enabled = true;
        }

        private void btnXoaKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                _dieuchuyen.Delete(_soqd, 1);
                loadData();
            }
        }

        private void btnLuuKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
            reset();
        }

        private void btnHuyKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            reset();

            splitContainer1.Panel1Collapsed = true;
        }

        private void btnPrintKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDongKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhSachDC_Click(object sender, EventArgs e)
        {
            if (gvDanhSachDC.RowCount > 0)
            {


                _soqd = gvDanhSachDC.GetFocusedRowCellValue("SOQD").ToString();
                var kt = _dieuchuyen.getItem(_soqd);
                txtQD.Text = _soqd;
                txtLyDo.Text = kt.LYDO;
                dtNgay.Value = kt.NGAY.Value;
                slkNhanVien.EditValue = kt.IDNV;
                txtGhiChu.Text = kt.GHICHU;
                cboPhongBan.SelectedValue = kt.MAPB2;


            }
        }
        private void loadData()
        {
            // Load dữ liệu từ BusinessLayer.CHUCVU và hiển thị lên gridControl hoặc gridView
            gcDanhSachDC.DataSource = _dieuchuyen.getItemFull();
            gvDanhSachDC.OptionsBehavior.Editable = false;

        }

        private void _showHide(bool kt)
        {
            btnLuuKT.Enabled = !kt;
            btnHuyKT.Enabled = !kt;
            btnPrintKT.Enabled = kt;
            btnSuaKT.Enabled = kt;
            btnThemKT.Enabled = kt;
            btnXoaKT.Enabled = kt;
            btnDongKT.Enabled = kt;
            gcDanhSachDC.Enabled = kt;
            dtNgay.Enabled = !kt;
            // dtNgayKetThuc.Enabled = !kt;

            slkNhanVien.Enabled = !kt;
            txtQD.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            txtGhiChu.Enabled = !kt;

        }

        void reset()
        {
            txtQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            /* dtNgayBatDau.Value = DateTime.Now;
             dtNgayBatDau.Value = dtNgayBatDau.Value.AddMonths(6);*/


        }
        void SaveData()
        {
            if (_them)
            {
                var maxSoQD = _dieuchuyen.MaxSOQD();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                TB_NV_DIEUCHUYEN dc = new TB_NV_DIEUCHUYEN();


                dc.SOQD = so.ToString("00000") + @"/2024/QĐDC";
   
                dc.LYDO = txtLyDo.Text;
                dc.NGAY = dtNgay.Value;

                dc.GHICHU = txtGhiChu.Text;
                dc.IDNV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.MAPB = _nhanvien.getItem(int.Parse(slkNhanVien.EditValue.ToString())).IDBP;
                dc.MAPB2 = int.Parse(cboPhongBan.SelectedValue.ToString());




                dc.CREATED_BY = 1;
                dc.CREATED_DATE = DateTime.Now;
                _dieuchuyen.Add(dc);
                /*   MessageBox.Show("Dữ liệu đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
            else
            {
                TB_NV_DIEUCHUYEN dc = _dieuchuyen.getItem(_soqd);
               

                dc.LYDO = txtLyDo.Text;
                dc.NGAY = dtNgay.Value;

                dc.GHICHU = txtGhiChu.Text;
                dc.IDNV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.MAPB2 = int.Parse(cboPhongBan.SelectedValue.ToString());
                dc.UPDATED_BY = 1;
                dc.UPDATED_DATE = DateTime.Now;
                _dieuchuyen.Update(dc);
            }
        }
    }
}