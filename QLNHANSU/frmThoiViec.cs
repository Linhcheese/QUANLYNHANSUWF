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
    public partial class frmThoiViec : DevExpress.XtraEditors.XtraForm
    {

        NHANVIEN_THOIVIEC _thoiviec;
        bool _them;
        string _soqd;
        NHANVIEN _nhanvien;

        public frmThoiViec()
        {
            InitializeComponent();
            _thoiviec = new NHANVIEN_THOIVIEC();
            _nhanvien = new NHANVIEN();
        
        }

  
        private void frmThoiViec_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            loadData();
            LoadNhanVien();
         
            splitContainer1.Panel1Collapsed = true;
        }
        public void LoadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
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
            gcDanhSachTV.Enabled = true;
        }

        private void btnXoaKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                _thoiviec.Delete(_soqd, 1);
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


        private void loadData()
        {
            // Load dữ liệu từ BusinessLayer.CHUCVU và hiển thị lên gridControl hoặc gridView
            gcDanhSachTV.DataSource = _thoiviec.getListFull();
            gvDanhSachTV.OptionsBehavior.Editable = false;

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
            gcDanhSachTV.Enabled = kt;
            dtNgayNghi.Enabled = !kt;
            dtNgayNopDon.Enabled = !kt;
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
            TB_NHANVIEN_THOIVIEC dc;
            if (_them)
            {
                var maxSoQD = _thoiviec.MaxSOQD();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                 dc = new TB_NHANVIEN_THOIVIEC();


                dc.SOQD = so.ToString("00000") + @"/2024/QĐTV";

                dc.LYDO = txtLyDo.Text;
                dc.NGAYNOPDON = dtNgayNopDon.Value;
                dc.NGAYNGHI = dtNgayNghi.Value;
                dc.GHICHU = txtGhiChu.Text;
                dc.MANV = int.Parse(slkNhanVien.EditValue.ToString());
              

                dc.CREATED_BY = 1;
                dc.CREATED_DATE = DateTime.Now;
                _thoiviec.Add(dc);
                /*   MessageBox.Show("Dữ liệu đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
            else
            {
                 dc = _thoiviec.getItem(_soqd);

                dc.LYDO = txtLyDo.Text;
                dc.NGAYNOPDON = dtNgayNopDon.Value;
                dc.NGAYNGHI = dtNgayNghi.Value;
                dc.GHICHU = txtGhiChu.Text;
                dc.UPDATED_BY = 1;
                dc.UPDATED_DATE = DateTime.Now;
                _thoiviec.Update(dc);
            }
            var nv = _nhanvien.getItem(dc.MANV.Value);
            nv.DATHOIVIEC = true;
            _nhanvien.Update(nv);
        }

        private void gcDanhSachTV_Click(object sender, EventArgs e)
        {
            if (gvDanhSachTV.RowCount > 0)
            {


                _soqd = gvDanhSachTV.GetFocusedRowCellValue("SOQD").ToString();
                var kt = _thoiviec.getItem(_soqd);
                txtQD.Text = _soqd;
                txtLyDo.Text = kt.LYDO;
                dtNgayNghi.Value = kt.NGAYNGHI.Value;
                dtNgayNopDon.Value = kt.NGAYNOPDON.Value;
                slkNhanVien.EditValue = kt.MANV;
                txtGhiChu.Text = kt.GHICHU;



            }
        }

        private void dtNgayNopDon_ValueChanged(object sender, EventArgs e)
        {
            dtNgayNghi.Value = dtNgayNopDon.Value.AddDays(45);
        }
    }
}