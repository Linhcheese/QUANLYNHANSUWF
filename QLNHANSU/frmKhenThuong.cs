﻿using DevExpress.XtraEditors;
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
    public partial class frmKhenThuong : DevExpress.XtraEditors.XtraForm
    {

        KHENTHUONG_KYLUAT _khenthuong;
        bool _them;
        string _soqd;
        NHANVIEN _nhanvien;
        public frmKhenThuong()
        {
            InitializeComponent();
            _khenthuong = new KHENTHUONG_KYLUAT();
            _nhanvien = new NHANVIEN();
        }

        private void frmKhenThuong_Load(object sender, EventArgs e)
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
        private void btnThemKt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            gcDanhSachKT.Enabled = true;
        }

        private void btnXoaKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                _khenthuong.Delete(_soqd,1);
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
         /*   _lst_hd_dto = _hdld.getItemFull(_sohd);
            rptHopDongLaoDong rpt = new rptHopDongLaoDong(_lst_hd_dto);
            rpt.ShowPreviewDialog();*/
        }

        private void btnDongKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvDanhSachKT_Click(object sender, EventArgs e)
        {
            if (gvDanhSachKT.RowCount > 0)
            {


                _soqd = gvDanhSachKT.GetFocusedRowCellValue("SOQUYETDINH").ToString();
                var kt = _khenthuong.getItem(_soqd);
                txtHD.Text = _soqd;
                txtLyDo.Text = kt.LYDO;
                dtNgay.Value = kt.NGAY.Value;
                slkNhanVien.EditValue = kt.MANV;
                txtNoiDung.Text = kt.NOIDUNG;
             

            }
        }


        private void loadData()
        {
            // Load dữ liệu từ BusinessLayer.CHUCVU và hiển thị lên gridControl hoặc gridView
            gcDanhSachKT.DataSource = _khenthuong.getItemFull(1);
            gvDanhSachKT.OptionsBehavior.Editable = false;

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
            gcDanhSachKT.Enabled = kt;
           dtNgay.Enabled = !kt;
           // dtNgayKetThuc.Enabled = !kt;
          
            slkNhanVien.Enabled = !kt;
            txtHD.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            txtNoiDung.Enabled = !kt;

        }

        void reset()
        {
            txtHD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            /* dtNgayBatDau.Value = DateTime.Now;
             dtNgayBatDau.Value = dtNgayBatDau.Value.AddMonths(6);*/


        }
        void SaveData()
        {
            if (_them)
            {
                var maxSoQD = _khenthuong.MaxSoQuyetDinh(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                TB_KHENTHUONG_KYLUAT kt = new TB_KHENTHUONG_KYLUAT();


                kt.SOQUYETDINH = so.ToString("00000") + @"/2024/QĐKT";
                /* hd.NGAYBATDAU = dtNgayBatDau.Value;
                 hd.NGAYKETTHUC = dtNgayKetThuc.Value;*/
                kt.LYDO = txtLyDo.Text;
                kt.NGAY = dtNgay.Value;

                kt.NOIDUNG = txtNoiDung.Text;
                kt.MANV = int.Parse(slkNhanVien.EditValue.ToString());
       
               
                kt.LOAI = 1;
                kt.CREATED_BY = 1;
                kt.CREATED_DATE = DateTime.Now;
                _khenthuong.Add(kt);
             /*   MessageBox.Show("Dữ liệu đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
            else
            {
                TB_KHENTHUONG_KYLUAT kt = _khenthuong.getItem(_soqd);

                /*  hd.NGAYBATDAU = dtNgayBatDau.Value;
                  hd.NGAYKETTHUC = dtNgayKetThuc.Value;*/
                kt.NGAY = dtNgay.Value;
                kt.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                kt.NOIDUNG = txtNoiDung.Text;
                kt.LYDO = txtLyDo.Text;
              
                kt.UPDATED_BY = 1;
                kt.UPDATED_DATE = DateTime.Now;
                _khenthuong.Update(kt);
            }
        }
    }
}