using BusinessLayer;
using DataLayer;
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

namespace QLNHANSU
{
    public partial class frmUngLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmUngLuong()
        {
            InitializeComponent();
        }
        NHANVIEN _nhanvien;
        UNGLUONG _ungluong;
        bool _isAdding;
        int _id;
        private void frmUngLuong_Load(object sender, EventArgs e)
        {
            _isAdding = false;
            _ungluong = new UNGLUONG();
            _nhanvien = new NHANVIEN();
            ShowHideControls(true);
            LoadData();
            loadNhanVien();
        }
        void LoadData()
        {
            gcDanhSach.DataSource = _ungluong.getListFull();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        void loadNhanVien()
        {
            lkNhanVien.Properties.DataSource = _nhanvien.getListFull();
            lkNhanVien.Properties.DisplayMember = "HOTEN";
            lkNhanVien.Properties.ValueMember = "MANV";
        }
        
        private void ShowHideControls(bool isEditing)
        {
            btnLuuCV.Enabled = !isEditing;
            btnHuyCV.Enabled = !isEditing;
            btnPrintCV.Enabled = isEditing;
            btnSuaCV.Enabled = isEditing;
            btnThemCV.Enabled = isEditing;
            btnXoaCV.Enabled = isEditing;
            btnDongCV.Enabled = isEditing;
            txtNoiDung.Enabled = !isEditing;
            sotien.Enabled = !isEditing;
            lkNhanVien.Enabled = !isEditing;
        }
        private void btnThemCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtNoiDung.Text = string.Empty;
            spSoTien.EditValue = 0;
            lkNhanVien.EditValue = 0;
            _isAdding = true;
            ShowHideControls(false);
        }

        private void btnSuaCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _isAdding = false;
            ShowHideControls(false);
        }

        private void btnXoaCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ungluong.Delete(_id, 1); // User ID here
                LoadData();
            }
        }

        private void btnLuuCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            LoadData();
            _isAdding = false;
            ShowHideControls(true);
        }

        private void btnHuyCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _isAdding = false;
            ShowHideControls(true);
            txtNoiDung.Text = string.Empty;
            spSoTien.EditValue = 0;
        }

        private void btnPrintCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDongCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SaveData()
        {
            if (_isAdding)
            {
                TB_UNGLUONG tc = new TB_UNGLUONG();
                tc.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                tc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                tc.GHICHU = txtNoiDung.Text;
                tc.NGAY = DateTime.Now.Day;
                tc.THANG = DateTime.Now.Month;
                tc.NAM = DateTime.Now.Year;
                tc.CREATED_BY = 1; // User ID here
                tc.CREATED_DATE = DateTime.Now;
                _ungluong.Add(tc);
            }
            else
            {
                var tc = _ungluong.getItem(_id);
                tc.SOTIEN = double.Parse(spSoTien.EditValue.ToString());
                tc.MANV = int.Parse(lkNhanVien.EditValue.ToString());
                tc.GHICHU = txtNoiDung.Text;
                tc.NGAY = DateTime.Now.Day;
                tc.THANG = DateTime.Now.Month;
                tc.NAM = DateTime.Now.Year;
                tc.CREATED_BY = 1; // User ID here
                tc.CREATED_DATE = DateTime.Now;
                tc.UPDATED_BY = 1; // User ID here
                tc.UPDATED_DATE = DateTime.Now;
                _ungluong.Update(tc);
            }
        }

        private void gcDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
                txtNoiDung.Text = gvDanhSach.GetFocusedRowCellValue("GHICHU").ToString();
                spSoTien.EditValue = gvDanhSach.GetFocusedRowCellValue("SOTIEN");
                lkNhanVien.EditValue = gvDanhSach.GetFocusedRowCellValue("MANV");
            }
        }

        private void gvDanhSach_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.b2_2;
                Image resizedImg = new Bitmap(img, new Size(30, 30));
                e.Graphics.DrawImage(resizedImg, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }
    }
}