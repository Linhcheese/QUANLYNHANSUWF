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
    public partial class frmTrinhDo : DevExpress.XtraEditors.XtraForm
    {
        TRINHDO _trinhDo;
        bool _them;
        int _id;

        public frmTrinhDo()
        {
            InitializeComponent();
            _trinhDo = new TRINHDO(); // Khởi tạo đối tượng từ lớp BusinessLayer.TrinhDo
        }

        private void frmTrinhDo_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            loadData();
        }

        private void loadData()
        {
            // Load dữ liệu từ BusinessLayer.TrinhDo và hiển thị lên gridControl hoặc gridView
            gcDanhSachTD.DataSource = _trinhDo.getList();
            gvDanhSachTD.OptionsBehavior.Editable = false;
        }

        private void _showHide(bool kt)
        {
            btnLuuTD.Enabled = !kt;
            btnHuyTD.Enabled = !kt;
            btnPrintTD.Enabled = kt;
            btnSuaTD.Enabled = kt;
            btnThemTD.Enabled = kt;
            btnXoaTD.Enabled = kt;
            btnDongTD.Enabled = kt;
            txtTenTD.Enabled = !kt;
        }

        private void btnThemTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenTD.Text = string.Empty;
            _them = true;
            _showHide(false);
        }

        private void btnSuaTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoaTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _trinhDo.Delete(_id);
                loadData();
            }
        }

        private void btnLuuTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
        }

        private void btnHuyTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            txtTenTD.Text = string.Empty;
        }

        private void btnPrintTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Xử lý sự kiện in
        }

        private void btnDongTD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void SaveData()
        {
            if (_them)
            {
                TB_TRINHDO dt = new TB_TRINHDO();
                dt.TENTD = txtTenTD.Text;
                _trinhDo.Add(dt);
            }
            else
            {
                var dt = _trinhDo.getItem(_id);
                dt.TENTD = txtTenTD.Text;
                _trinhDo.Update(dt);
            }
        }

        private void gvDanhSachTD_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSachTD.GetFocusedRowCellValue("IDTD").ToString());
            txtTenTD.Text = gvDanhSachTD.GetFocusedRowCellValue("TENTD").ToString();
        }

      
    }
}
