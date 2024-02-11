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
    public partial class frmTonGiao : DevExpress.XtraEditors.XtraForm
    {
        public frmTonGiao()
        {
            InitializeComponent();
        }
        bool _them;
        int _id;
        TONGIAO _tongiao;
        private void frmTonGiao_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            _tongiao = new TONGIAO();
            loadData();
        }
        public void loadData()
        {
            gcDanhSachTG.DataSource = _tongiao.getList();
            gvDanhSachTG.OptionsBehavior.Editable = false;
        }
        //
        void _showHide(bool kt)
        {
            btnLuuTG.Enabled = !kt;
            btnHuyTG.Enabled = !kt;
            btnPrintTG.Enabled = kt;
            btnSuaTG.Enabled = kt;
            btnThemTG.Enabled = kt;
            btnXoaTG.Enabled = kt;
            btnDongTG.Enabled = kt;
            txtTenTG.Enabled = !kt;
        }

        private void btnThemTG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenTG.Text = string.Empty;
            _them = true;
            _showHide(false);
        }

        private void btnSuaTG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoaTG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _tongiao.Delete(_id);
                loadData();
            }
        }

        private void btnLuuTG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
        }

        private void btnHuyTG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            txtTenTG.Text = string.Empty;
        }

        private void btnPrintTG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDongTG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }



        void SaveData()
        {
            if (_them)
            {
                TB_TONGIAO dt = new TB_TONGIAO();
                dt.TENTG = txtTenTG.Text;
                _tongiao.Add(dt);
            }
            else
            {
                var dt = _tongiao.getItem(_id);
                dt.TENTG = txtTenTG.Text;
                _tongiao.Update(dt);
            }
        }

        private void gvDanhSachTG_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSachTG.GetFocusedRowCellValue("ID").ToString());
            txtTenTG.Text = gvDanhSachTG.GetFocusedRowCellValue("TENTG").ToString();
        }
    }
}