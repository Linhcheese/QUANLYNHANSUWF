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
    public partial class frmbophan : DevExpress.XtraEditors.XtraForm
    {
        BOPHAN _boPhan;
        bool _them;
        int _id;

        public frmbophan()
        {
            InitializeComponent();
            _boPhan = new BOPHAN(); // Khởi tạo đối tượng từ lớp BusinessLayer.BOPHAN
        }

        private void frmbophan_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            loadData();
        }

        private void loadData()
        {
            // Load dữ liệu từ BusinessLayer.BOPHAN và hiển thị lên gridControl hoặc gridView
            gcDanhSachBP.DataSource = _boPhan.getList();
            gvDanhSachBP.OptionsBehavior.Editable = false;
        }

        private void _showHide(bool kt)
        {
            btnLuuBP.Enabled = !kt;
            btnHuyBP.Enabled = !kt;
            btnPrintBP.Enabled = kt;
            btnSuaBP.Enabled = kt;
            btnThemBP.Enabled = kt;
            btnXoaBP.Enabled = kt;
            btnDongBP.Enabled = kt;
            txtTenBP.Enabled = !kt;
        }

        private void btnThemBP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenBP.Text = string.Empty;
            _them = true;
            _showHide(false);
        }

        private void btnSuaBP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoaBP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _boPhan.Delete(_id);
                loadData();
            }
        }

        private void btnLuuBP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
        }

        private void btnHuyBP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            txtTenBP.Text = string.Empty;
        }

        private void btnPrintBP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Xử lý sự kiện in
        }

        private void btnDongBP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void SaveData()
        {
            if (_them)
            {
                TB_BOPHAN bp = new TB_BOPHAN();
                bp.TENBP = txtTenBP.Text;
                _boPhan.Add(bp);
            }
            else
            {
                var bp = _boPhan.getItem(_id);
                bp.TENBP = txtTenBP.Text;
                _boPhan.Update(bp);
            }
        }

        private void gvDanhSachBP_Click(object sender, EventArgs e)
        {
            if (gvDanhSachBP.RowCount > 0) // Kiểm tra xem có dòng được chọn không
            {
                _id = int.Parse(gvDanhSachBP.GetFocusedRowCellValue("IDBP").ToString());
                txtTenBP.Text = gvDanhSachBP.GetFocusedRowCellValue("TENBP").ToString();
            }
        }
    }
}
