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
    public partial class frmHopDongLaoDong : DevExpress.XtraEditors.XtraForm
    {


        HOPDONGLAODONG _hdld;
        bool _them;
        string _sohd;
        
        public frmHopDongLaoDong()
        {
            InitializeComponent();
            _hdld = new HOPDONGLAODONG();
           
        }

        private void frmHopDongLaoDong_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            loadData();
          
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnThemNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reset();
            _them = true;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSuaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            _them = false;
            _showHide(false);
            gcDanhSachHD.Enabled = true;
        }

        private void btnXoaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                _hdld.Delete(_sohd,1);
                loadData();
            }
        }

        private void btnLuuNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
            reset();
        }

        private void btnHuyNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            reset();

            splitContainer1.Panel1Collapsed = true;
        }

        private void btnPrintNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
           // rpt.ShowRibbonPreview();
        }

        private void btnDongNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private void gvDanhSachHD_Click(object sender, EventArgs e)
        {
            if (gvDanhSachHD.RowCount > 0)
            {
                
                _sohd= gvDanhSachHD.GetFocusedRowCellValue("SOHD").ToString();
            

            }
        }
        private void loadData()
        {
            // Load dữ liệu từ BusinessLayer.CHUCVU và hiển thị lên gridControl hoặc gridView
            gcDanhSachHD.DataSource = _hdld.getList();
            gvDanhSachHD.OptionsBehavior.Editable = false;
           
        }

        private void _showHide(bool kt)
        {
            btnLuuNV.Enabled = !kt;
            btnHuyNV.Enabled = !kt;
            btnPrintNV.Enabled = kt;
            btnSuaNV.Enabled = kt;
            btnThemNV.Enabled = kt;
            btnXoaNV.Enabled = kt;
            btnDongNV.Enabled = kt;
            gcDanhSachHD.Enabled = !kt;
            dtNgayBatDau.Enabled = !kt;
            dtNgayKetThuc.Enabled = !kt;
            dtNgayKY.Enabled = !kt;
            spHeSoLuong.Enabled = !kt;
            spLanKy.Enabled = !kt;
            slkNhanVien.Enabled = !kt;
            txtHD.Enabled = !kt;

        }

        void reset()
        {
            txtHD.Text = string.Empty;
            dtNgayBatDau.Value = DateTime.Now;
            dtNgayBatDau.Value = dtNgayBatDau.Value.AddMonths(6);
            dtNgayKY.Value = DateTime.Now;
            spLanKy.Text = "1";
            spHeSoLuong.Text = "1";
          
        }
        void SaveData()
        {
            if (_them)
            {
              
            }
            else
            {
               
               // _hdld.Update(nv);
            }
        }

        //load Combo
        

    }
}