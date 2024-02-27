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
    public partial class frmTangLuong : DevExpress.XtraEditors.XtraForm
    {

        NHANVIEN_TANGLUONG _nvtl;
        bool _them;
        string _soqd;
        HOPDONGLAODONG _hopdong;
        NHANVIEN _nv;
        public frmTangLuong()
        {
            InitializeComponent();
            _nvtl = new NHANVIEN_TANGLUONG();
            _hopdong = new HOPDONGLAODONG();
            _nv = new NHANVIEN();
        }

        private void frmTangLuong_Load(object sender, EventArgs e)
        {
            _them = false;
            _showHide(true);
            loadData();
            loadHopDong();

            splitContainer1.Panel1Collapsed = true;
        }
        public void loadHopDong()
        {
            slkHopDong.Properties.DataSource = _hopdong.getListFull();
            slkHopDong.Properties.ValueMember = "SOHD";
            slkHopDong.Properties.DisplayMember = "SOHD";
        }
        private void btnThemKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reset();
            _them = true;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSuaKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;
            _them = false;
            _showHide(false);
            gcDanhSachTV.Enabled = true;
        }

        private void btnXoaKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                _nvtl.Delete(_soqd, 1);
                var hd = _hopdong.getItem(slkHopDong.EditValue.ToString());
                hd.HESOLUONG = double.Parse(spHSLCu.EditValue.ToString()); ;
                _hopdong.Update(hd);
                loadData();
            }
        }

        private void btnLuuKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveData();
            loadData();
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
            reset();
        }

        private void btnHuyKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            reset();

            splitContainer1.Panel1Collapsed = true;
        }

        private void btnPrintKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDongKT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gcDanhSachTV_Click(object sender, EventArgs e)
        {
            if (gvDanhSachTV.RowCount > 0)
            {


                _soqd = gvDanhSachTV.GetFocusedRowCellValue("SOQD").ToString();
                var tl = _nvtl.getItem(_soqd);
                txtQD.Text = _soqd;
                spHSLCu.EditValue = tl.HESOLUONGHIENTAI;
                spHSLMoi.EditValue = tl.HESOLUONGMOI;
                    
                dtNgayLenLuong.Value = tl.NGAYLENLUONG.Value;
                dtNgayKy.Value = tl.NGAYKY.Value;
                slkHopDong.EditValue = tl.MANV;
                txtGhiChu.Text = tl.GHICHU;



            }
        }
        private void loadData()
        {
            // Load dữ liệu từ BusinessLayer.CHUCVU và hiển thị lên gridControl hoặc gridView
            gcDanhSachTV.DataSource = _nvtl.getListFull();
            gvDanhSachTV.OptionsBehavior.Editable = false;

        }

        private void _showHide(bool kt)
        {
            btnLuuKT.Enabled = !kt;
            btnHuyKT.Enabled = !kt;
            btnPrintKT.Enabled = kt;
            btnSuaKT.Enabled = kt;
            btnThemKT.Enabled = kt;
            btnXoaKT.Enabled = kt;
            btnDongKT.Enabled = kt;
            gcDanhSachTV.Enabled = kt;
            dtNgayLenLuong.Enabled = !kt;
            dtNgayKy.Enabled = !kt;
            spHSLCu.Enabled = !kt;
            spHSLMoi.Enabled = !kt;

            slkHopDong.Enabled = !kt;
            txtQD.Enabled = !kt;
            txtNhanVien.Enabled = !kt;
            txtGhiChu.Enabled = !kt;

        }

        void reset()
        {
            txtQD.Text = string.Empty;
            txtNhanVien.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
      


        }
        void SaveData()
        {
            TB_NHANVIEN_TANGLUONG tl;
            if (_them)
            {
                var maxSoQD = _nvtl.MaxSOQD();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;
                tl = new TB_NHANVIEN_TANGLUONG();

                tl.SOQD = so.ToString("00000") + @"/"+DateTime.Now.Year.ToString()+"/QĐTL";
                tl.SOHD = _hopdong.getItem(slkHopDong.EditValue.ToString()).SOHD;
                tl.HESOLUONGHIENTAI = _hopdong.getItem(slkHopDong.EditValue.ToString()).HESOLUONG;
                tl.HESOLUONGMOI = double.Parse(spHSLMoi.EditValue.ToString());

                tl.NGAYKY = dtNgayKy.Value;
                tl.NGAYLENLUONG = dtNgayLenLuong.Value;
                tl.GHICHU = txtGhiChu.Text;
                tl.MANV = _hopdong.getItem( slkHopDong.EditValue.ToString()).MANV;

                tl.CREADTED_BY = 1;
                tl.CRREATED_DATE = DateTime.Now;
                _nvtl.Add(tl);
                 /*   MessageBox.Show("Dữ liệu đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
            else
            {
                tl = _nvtl.getItem(_soqd);


                tl.HESOLUONGHIENTAI = _hopdong.getItem(slkHopDong.EditValue.ToString()).HESOLUONG;
                tl.HESOLUONGMOI = double.Parse(spHSLMoi.EditValue.ToString());
                tl.SOHD = _hopdong.getItem(slkHopDong.EditValue.ToString()).SOHD;
                tl.NGAYKY = dtNgayKy.Value;
                tl.NGAYLENLUONG = dtNgayLenLuong.Value;
                tl.GHICHU = txtGhiChu.Text;
                tl.MANV = _hopdong.getItem(slkHopDong.EditValue.ToString()).MANV;
                tl.UPDATED_BY = 1;
                tl.UPDATED_DATE = DateTime.Now;
                _nvtl.Update(tl);
            }
            var hd = _hopdong.getItem(slkHopDong.EditValue.ToString());
            hd.HESOLUONG = double.Parse(spHSLMoi.EditValue.ToString()); ;
            _hopdong.Update(hd);
        }

        private void slkHopDong_EditValueChanged(object sender, EventArgs e)
        {
            if (slkHopDong.EditValue != null)
            {
                var selectedValue = slkHopDong.EditValue.ToString();
                var hd = _hopdong.getItemFull(selectedValue);
                if (hd != null && hd.Count > 0)
                {
                    var firstItem = hd[0]; // Lấy phần tử đầu tiên
                    txtNhanVien.Text = firstItem.MANV + " - " + firstItem.HOTEN;
                    spHSLCu.EditValue = firstItem.HESOLUONG;
                }
                else
                {
                    // Xử lý trường hợp không tìm thấy dữ liệu
                    // Ví dụ: Xóa nội dung của các điều khiển khác để xóa thông tin cũ
                    txtNhanVien.Text = string.Empty;
                    spHSLCu.EditValue = null;
                }
            }
        }


        private void gvDanhSachTV_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
          
        }
    }
}