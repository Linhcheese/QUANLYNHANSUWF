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
using System.IO;
using QLNHANSU.Reports;
using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;
namespace QLNHANSU
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {

        NHANVIEN _nhanvien;
        BOPHAN _bophan;
        DANTOC _dantoc;
        TONGIAO _tongiao;
        TRINHDO _trinhdo;
        PHONGBAN _phongban;
        CHUCVU _chucvu; 
        bool _them;
        int _id;
        List<NHANVIEN_DTO> _lstDTOs;
        public frmNhanVien()
        {
            InitializeComponent();
            _nhanvien = new NHANVIEN();
            _bophan = new BOPHAN();
            _dantoc = new DANTOC();
            _tongiao = new TONGIAO();
            _trinhdo = new TRINHDO();
            _phongban = new PHONGBAN();
            _chucvu = new CHUCVU(); 
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            loadData();
            loadCombo();
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnThemCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reset();
            _them = true;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
        }


        private void btnSuaCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            _them = false;
            _showHide(false);
        }

        private void btnXoaCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nhanvien.Delete(_id);
                loadData();
            }
        }

        private void btnLuuCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
            reset();
        }

        private void btnHuyCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            reset();

            splitContainer1.Panel1Collapsed = true;

        }

        private void btnPrintCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptDanhSachNhanVien rpt= new rptDanhSachNhanVien(_lstDTOs);
            rpt.ShowRibbonPreview();
        }

        private void btnDongCV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private void gvDanhSachNV_Click(object sender, EventArgs e)
        {
            if (gvDanhSachNV.RowCount > 0)
            {
                _id = int.Parse(gvDanhSachNV.GetFocusedRowCellValue("MANV").ToString());
                var nv = _nhanvien.getItem(_id);
               chkGioiTinh.Checked=nv.GIOITINH.Value;
                dtNgaySinh.Value=nv.NGAYSINH.Value;
               txtSDT.Text=nv.DIENTHOAI;
                txtCCCD.Text=nv.CCCD;
               txtDiaChi.Text=nv.DIACHI;
                txtEmail.Text = nv.EMAIL;
                picHinhAnh.Image = Base64toImage(nv.HINHANH);
                cboBoPhan.SelectedValue=nv.IDBP;
               cboChucVu.SelectedValue=nv.IDCV;
               cboPhongBan.SelectedValue=nv.IDPB;
                cboDanToc.SelectedValue=nv.IDDT;
               cboTonGiao.SelectedValue=nv.IDTG;
               cboTrinhDo.SelectedValue=nv.IDTD;
             
                txtTenNV.Text = nv.HOTEN;
               
            }
        }
        //

        private void loadData()
        {
            // Load dữ liệu từ BusinessLayer.CHUCVU và hiển thị lên gridControl hoặc gridView
            gcDanhSachNV.DataSource = _nhanvien.getListFull();
            gvDanhSachNV.OptionsBehavior.Editable = false;
            _lstDTOs= _nhanvien.getListFull(); 
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
            txtTenNV.Enabled = !kt;
            chkGioiTinh.Enabled = !kt;
            dtNgaySinh.Enabled = !kt;
            txtSDT.Enabled = !kt;
            txtEmail.Enabled = !kt;
            txtCCCD.Enabled = !kt;
            txtDiaChi.Enabled = !kt;
            cboBoPhan.Enabled = !kt;
            cboChucVu.Enabled = !kt;
            cboPhongBan.Enabled = !kt;
            cboDanToc.Enabled = !kt;
            cboTonGiao.Enabled = !kt;
            cboTrinhDo.Enabled = !kt;
            cboTrinhDo.Enabled = !kt;
            btnTaiAnh.Enabled = !kt;
            cboCongTy.Enabled = !kt;
        }

        void reset()
            {
            txtTenNV.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSDT.Text = string.Empty;
            chkGioiTinh.Checked = false;
        }
        void SaveData()
        {
            if (_them)
            {
                TB_NHANVIEN nv = new TB_NHANVIEN();
                nv.HOTEN = txtTenNV.Text;
                nv.GIOITINH = chkGioiTinh.Checked;
                nv.NGAYSINH = dtNgaySinh.Value;
                nv.DIENTHOAI = txtSDT.Text;
                nv.EMAIL = txtEmail.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DIACHI = txtDiaChi.Text;
                nv.HINHANH = ImageToBase64(picHinhAnh.Image,picHinhAnh.Image.RawFormat);
                nv.IDBP = int.Parse(cboBoPhan.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboChucVu.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPhongBan.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDanToc.SelectedValue.ToString());
                nv.IDTG = int.Parse(cboTonGiao.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTrinhDo.SelectedValue.ToString());
                nv.IDCT = 3;
                _nhanvien.Add(nv);
            }
            else
            {
                var nv = _nhanvien.getItem(_id);
                nv.HOTEN = txtTenNV.Text;
                nv.GIOITINH = chkGioiTinh.Checked;
                nv.NGAYSINH = dtNgaySinh.Value;
                nv.DIENTHOAI = txtSDT.Text;
                nv.CCCD = txtCCCD.Text;
                nv.EMAIL = txtEmail.Text;
                nv.DIACHI = txtDiaChi.Text;
                nv.HINHANH = ImageToBase64(picHinhAnh.Image, picHinhAnh.Image.RawFormat);
                nv.IDBP = int.Parse(cboBoPhan.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboChucVu.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPhongBan.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDanToc.SelectedValue.ToString());
                nv.IDTG = int.Parse(cboTonGiao.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTrinhDo.SelectedValue.ToString());
                nv.IDCT = 3;
                _nhanvien.Update(nv);
            }
        }

        //load Combo
        void loadCombo()
        {
            // Load danh sách bộ phận vào ComboBox cboBoPhan
            cboBoPhan.DataSource = _bophan.getList();
            cboBoPhan.DisplayMember = "TENBP";
            cboBoPhan.ValueMember = "IDBP";

            // Load danh sách dân tộc vào ComboBox cboDanToc
            cboDanToc.DataSource = _dantoc.getList();
            cboDanToc.DisplayMember = "TenDT";
            cboDanToc.ValueMember = "ID";

            // Load danh sách tôn giáo vào ComboBox cboTonGiao
            cboTonGiao.DataSource = _tongiao.getList();
            cboTonGiao.DisplayMember = "TenTG";
            cboTonGiao.ValueMember = "ID";

            // Load danh sách trình độ vào ComboBox cboTrinhDo
            cboTrinhDo.DataSource = _trinhdo.getList();
            cboTrinhDo.DisplayMember = "TenTD";
            cboTrinhDo.ValueMember = "IDTD";

            // Load danh sách phòng ban vào ComboBox cboPhongBan
            cboPhongBan.DataSource = _phongban.getList();
            cboPhongBan.DisplayMember = "TenPB";
            cboPhongBan.ValueMember = "IDPB";

            // Load danh sách chức vụ vào ComboBox cboChucVu
            cboChucVu.DataSource = _chucvu.getList();
            cboChucVu.DisplayMember = "TenCV";
            cboChucVu.ValueMember = "IDCV";


        }



        public byte[] ImageToBase64(Image image,System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }
        public Image Base64toImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Picture file(.png, .jpg)|*.png;*.jpg";
            openFileDialog.Title = " Chọn hình ảnh";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFileDialog.FileName);
                picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}