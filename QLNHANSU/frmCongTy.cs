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
using DataLayer;
using BusinessLayer;

namespace QLNHANSU
{
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        CONGTY _congTy;
        bool _them;
        int _id;

        public frmCongTy()
        {
            InitializeComponent();
            _congTy = new CONGTY(); // Khởi tạo đối tượng từ lớp BusinessLayer.CONGTY
        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            loadData();
        }

        private void loadData()
        {
            // Load dữ liệu từ BusinessLayer.CONGTY và hiển thị lên gridControl hoặc gridView
            gcDanhSachCT.DataSource = _congTy.getList();
            gvDanhSachCT.OptionsBehavior.Editable = false;
        }

        private void _showHide(bool kt)
        {
            btnLuuCT.Enabled = !kt;
            btnHuyCT.Enabled = !kt;
            btnPrintCT.Enabled = kt;
            btnSuaCT.Enabled = kt;
            btnThemCT.Enabled = kt;
            btnXoaCT.Enabled = kt;
            btnDongCT.Enabled = kt;
            txtTenCT.Enabled = !kt;
            txtSDTCT.Enabled = !kt;
            txtEmailCT.Enabled = !kt;
            txtDiaChiCT.Enabled = !kt;
        }

        private void btnThemCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearTxt();
            _them = true;
            _showHide(false);
        }

        private void btnSuaCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoaCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _congTy.Delete(_id);
                loadData();
                ClearTxt();
            }
        }

        private void btnLuuCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
        }

        private void btnHuyCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            ClearTxt();
        }
        private void ClearTxt()
        {
            txtTenCT.Text = string.Empty;
            txtSDTCT.Text = string.Empty;
            txtEmailCT.Text = string.Empty;
            txtDiaChiCT.Text = string.Empty;
        }


        private void btnPrintCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Xử lý sự kiện in
        }

        private void btnDongCT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void SaveData()
        {
            if (_them)
            {
                TB_CONGTY ct = new TB_CONGTY();
                ct.TENCT = txtTenCT.Text;
                ct.DIENTHOAI = txtSDTCT.Text;
                ct.EMAIL = txtEmailCT.Text;
                ct.DIACHI = txtDiaChiCT.Text;
                _congTy.Add(ct);
            }
            else
            {
                var ct = _congTy.getItem(_id);
                ct.TENCT = txtTenCT.Text;
                ct.DIENTHOAI = txtSDTCT.Text;
                ct.EMAIL = txtEmailCT.Text;
                ct.DIACHI = txtDiaChiCT.Text;
                _congTy.Update(ct);
            }
        }

        private void gvDanhSachCT_Click(object sender, EventArgs e)
        {
            if (gvDanhSachCT.FocusedRowHandle >= 0) // Kiểm tra xem có dòng được chọn không
            {
                _id = int.Parse(gvDanhSachCT.GetFocusedRowCellValue("IDCT").ToString());
                txtTenCT.Text = gvDanhSachCT.GetFocusedRowCellValue("TENCT").ToString();
                txtSDTCT.Text = gvDanhSachCT.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtEmailCT.Text = gvDanhSachCT.GetFocusedRowCellValue("EMAIL").ToString();
                txtDiaChiCT.Text = gvDanhSachCT.GetFocusedRowCellValue("DIACHI").ToString();
            }
        }

    }
}
