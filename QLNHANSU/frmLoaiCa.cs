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
    public partial class frmLoaiCa : DevExpress.XtraEditors.XtraForm
    {

        LOAICA _loaica;
        bool _them;
        int _id;

        public frmLoaiCa()
        {
            InitializeComponent();
            _loaica = new LOAICA 
            ();
        }

        private void frmLoaiCa_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            loadData();
        }

        private void loadData()
        {
            // Load dữ liệu từ BusinessLayer.CHUCVU và hiển thị lên gridControl hoặc gridView
            gcDanhSachCV.DataSource = _loaica.getList();
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
                _loaica.Delete(_id,1);
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

        }

        private void btnDongCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcDanhSachCV_Click(object sender, EventArgs e)
        {
            if (gvDanhSachCV.RowCount > 0)
            {
                _id = int.Parse(gvDanhSachCV.GetFocusedRowCellValue("IDLOAICA").ToString());
                txtTenCV.Text = gvDanhSachCV.GetFocusedRowCellValue("TENLOAICA").ToString();
                spHeSo.Text = gvDanhSachCV.GetFocusedRowCellValue("HESO").ToString();
            }
        }
        void SaveData()
        {
            if (_them)
            {
                TB_LOAICA cv = new TB_LOAICA();
                cv.TENLOAICA = txtTenCV.Text;
                cv.HESO = double.Parse(spHeSo.EditValue.ToString());
                cv.CREATED_BY = 1;
                cv.CREATED_DATE = DateTime.Now;
                _loaica.Add(cv);
            }
            else
            {
                var cv = _loaica.getItem(_id);
                cv.TENLOAICA = txtTenCV.Text;
                cv.HESO = double.Parse(spHeSo.EditValue.ToString());
                _loaica.Update(cv);
            }
        }

        private void gvDanhSachCV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
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

    }
}