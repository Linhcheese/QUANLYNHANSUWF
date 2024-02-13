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
    public partial class frmChucVu : DevExpress.XtraEditors.XtraForm
    {
        CHUCVU _chucVu;
        bool _them;
        int _id;

        public frmChucVu()
        {
            InitializeComponent();
            _chucVu = new CHUCVU(); // Khởi tạo đối tượng từ lớp BusinessLayer.CHUCVU
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            loadData();
        }

        private void loadData()
        {
            // Load dữ liệu từ BusinessLayer.CHUCVU và hiển thị lên gridControl hoặc gridView
            gcDanhSachCV.DataSource = _chucVu.getList();
            gvDanhSachCV.OptionsBehavior.Editable = false;
        }

        private void _showHide(bool kt)
        {
            btnLuuCV.Enabled = !kt;
            btnHuyCV.Enabled = !kt;
            btnPrintCV.Enabled = kt;
            btnSuaCV.Enabled = kt;
            btnThemCV.Enabled = kt;
            btnXoaCV.Enabled = kt;
            btnDongCV.Enabled = kt;
            txtTenCV.Enabled = !kt;
        }

        private void btnThemCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenCV.Text = string.Empty;
            _them = true;
            _showHide(false);
        }

        private void btnSuaCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoaCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _chucVu.Delete(_id);
                loadData();
            }
        }

        private void btnLuuCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
        }

        private void btnHuyCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            txtTenCV.Text = string.Empty;
        }

        private void btnPrintCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Xử lý sự kiện in
        }

        private void btnDongCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void SaveData()
        {
            if (_them)
            {
                TB_CHUCVU cv = new TB_CHUCVU();
                cv.TENCV = txtTenCV.Text;
                _chucVu.Add(cv);
            }
            else
            {
                var cv = _chucVu.getItem(_id);
                cv.TENCV = txtTenCV.Text;
                _chucVu.Update(cv);
            }
        }

        private void gvDanhSachCV_Click(object sender, EventArgs e)
        {
            if (gvDanhSachCV.RowCount > 0)
            {
                _id = int.Parse(gvDanhSachCV.GetFocusedRowCellValue("IDCV").ToString());
                txtTenCV.Text = gvDanhSachCV.GetFocusedRowCellValue("TENCV").ToString();
            }
        }

    }
}
