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
    public partial class fmDanToc : DevExpress.XtraEditors.XtraForm
    {
        public fmDanToc()
        {
            InitializeComponent();
        }
        DANTOC _dantoc;
        bool _them;
        int _id;
        private void fmDanToc_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            _dantoc = new DANTOC();
            loadData();
        }
        public void loadData()
        {
            gcDanhSach.DataSource = _dantoc.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        //
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnPrint.Enabled = kt;
            btnSua.Enabled = kt;
            btnThem.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            txtTen.Enabled = !kt;
        }

        //them
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTen.Text = string.Empty;
            _them = true;
            _showHide(false);
        }
        //sua
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }
        // xoa
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn xóa không ?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _dantoc.Delete(_id);
                loadData();
            }
          
        }
        //Save
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
        }
        //Cancle
        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            txtTen.Text = string.Empty;
        }
        //Print
        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        //Close
        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        void SaveData()
        {
            if (_them)
            {
                TB_DANTOC dt = new TB_DANTOC();
                dt.TENDT = txtTen.Text;
                _dantoc.Add(dt);
            }
            else
            {
                var dt = _dantoc.getItem(_id);
                dt.TENDT = txtTen.Text;
                _dantoc.Update(dt);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("ID").ToString());
            txtTen.Text= gvDanhSach.GetFocusedRowCellValue("TENDT").ToString();
        }
    }
}