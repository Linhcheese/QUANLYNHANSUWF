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
    public partial class frmPhongBan : DevExpress.XtraEditors.XtraForm
    {
        PHONGBAN _phongBan;
        bool _them;
        int _id;

        public frmPhongBan()
        {
            InitializeComponent();
            _phongBan = new PHONGBAN(); // Khởi tạo đối tượng từ lớp BusinessLayer.PhongBan
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            loadData();
        }

        private void loadData()
        {
            // Load dữ liệu từ BusinessLayer.PhongBan và hiển thị lên gridControl hoặc gridView
            gcDanhSachPB.DataSource = _phongBan.getList();
            gvDanhSachPB.OptionsBehavior.Editable = false;
        }

        private void _showHide(bool kt)
        {
            btnLuuPB.Enabled = !kt;
            btnHuyPB.Enabled = !kt;
            btnPrintPB.Enabled = kt;
            btnSuaPB.Enabled = kt;
            btnThemPB.Enabled = kt;
            btnXoaPB.Enabled = kt;
            btnDongPB.Enabled = kt;
            txtTenPB.Enabled = !kt;
        }

        private void btnThemPB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenPB.Text = string.Empty;
            _them = true;
            _showHide(false);
        }

        private void btnSuaPB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoaPB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _phongBan.Delete(_id);
                loadData();
            }
        }

        private void btnLuuPB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
        }

        private void btnHuyPB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            txtTenPB.Text = string.Empty;
        }

        private void btnPrintPB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Xử lý sự kiện in
        }

        private void btnDongPB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void SaveData()
        {
            if (_them)
            {
                TB_PHONGBAN pb = new TB_PHONGBAN();
                pb.TENPB = txtTenPB.Text;
                _phongBan.Add(pb);
            }
            else
            {
                var pb = _phongBan.getItem(_id);
                pb.TENPB = txtTenPB.Text;
                _phongBan.Update(pb);
            }
        }

        private void gvDanhSachPB_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSachPB.GetFocusedRowCellValue("IDPB").ToString());
            txtTenPB.Text = gvDanhSachPB.GetFocusedRowCellValue("TENPB").ToString();
        }
    }
}
