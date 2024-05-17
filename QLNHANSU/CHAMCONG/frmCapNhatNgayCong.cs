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

namespace QLNHANSU.CHAMCONG
{
    public partial class frmCapNhatNgayCong : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatNgayCong()
        {
            InitializeComponent();
        }
        public int _manv;
        public string _hoten;
        public int _makycong;
        public string _ngay;
        public int _cNgay;
        KYCONGCHITIET _kcct;
        BANGCONG_NV_CT _bcct_nv;
        frmBangCongChiTiet frmBCCC = (frmBangCongChiTiet)Application.OpenForms["frmBangCongChiTiet"];
        private void frmCapNhatNgayCong_Load(object sender, EventArgs e)
        {
            _kcct = new KYCONGCHITIET();
            _bcct_nv = new BANGCONG_NV_CT();
            lblID.Text = _manv.ToString();
            lblHoTen.Text = _hoten.ToString();
            string nam = _makycong.ToString().Substring(0, 4);
            string thang  = _makycong.ToString().Substring(4);
            string ngay = _ngay.Substring(1);
            DateTime _d = DateTime.Parse(nam + "-" + thang + "-" + ngay);
            cldNgayCong.SetDate(_d);

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            string _valueChamCong = rdgChamCong.Properties.Items[rdgChamCong.SelectedIndex].Value.ToString();
            String _valueNgayNghi = rdgNgayNghi.Properties.Items[rdgNgayNghi.SelectedIndex].Value.ToString();
            string fieldName = "D" + _cNgay.ToString();
            var kcct = _kcct.getItem(_makycong, _manv);
            
            if(cldNgayCong.SelectionRange.Start.Year*100+cldNgayCong.SelectionRange.Start.Month!=+_makycong)
            {
                MessageBox.Show(" Thực hiện chấm công không đúng kỳ công. Vui lòng kiểm tra lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Functions.execQuery("UPDATE TB_KYCONGCHITIET SET " + fieldName+"='"+_valueChamCong+" ' WHERE MAKYCONG=" + _makycong+"AND MANV= "+_manv);
            TB_BANGCONG_NHANVIEN_CHITIET bcctnv = _bcct_nv.getItem(_makycong, _manv, cldNgayCong.SelectionStart.Day);

            if (cldNgayCong.SelectionStart.DayOfWeek == DayOfWeek.Sunday)
            {
                if (_valueNgayNghi == "CN")
                {
                    bcctnv.CONGCHUNHAT = 1;
                    bcctnv.NGAYCONG = 0;

                }
                else
                {
                    bcctnv.CONGCHUNHAT = 0.5;
                    bcctnv.NGAYCONG = 0;

                }
            }
            else
            {
                bcctnv.KYHIEU = _valueChamCong;
                switch (_valueChamCong)
                {
                    case "P":
                        if (_valueNgayNghi == "CN")
                        {
                            bcctnv.NGAYPHEP = 1;
                            bcctnv.NGAYCONG = 0;

                        }
                        else
                        {
                            bcctnv.NGAYPHEP = 0.5;
                            bcctnv.NGAYCONG = 0.5;

                        }
                        break;
                    case "CT":
                        if (_valueNgayNghi == "CN")
                        {

                            bcctnv.NGAYCONG = 1;
                        }
                        else
                        {
                            bcctnv.NGAYPHEP = 0.5;
                            bcctnv.NGAYCONG = 0.5;
                        }
                        break;
                    case "V":
                        if (_valueNgayNghi == "CN")
                        {
                            bcctnv.KHONGPHEP = 1;
                            bcctnv.NGAYCONG = 0;
                            
                        }
                        else
                        {
                            bcctnv.KHONGPHEP = 0.5;
                            bcctnv.NGAYCONG = 0.5;
                        }
                        break;
                    case "CL":
                        if (_valueNgayNghi == "CN")
                        {
                            bcctnv.CONGNGAYLE = 1;
                            

                        }
                        else
                        {
                            bcctnv.CONGNGAYLE = 0.5;
                            bcctnv.NGAYCONG = 0.5;
                        }
                        break;

                    default:
                        break;
                }
            }

            _bcct_nv.Update(bcctnv);
            double tongcongngayle = _bcct_nv.tongNgayCongLe(_makycong, _manv);
            double tongngaykhongphep = _bcct_nv.tongNgayKhongPhep(_makycong, _manv);
            double tongngayphep = _bcct_nv.tongNgayPhep(_makycong, _manv);
            double tongngaycong = _bcct_nv.tongNgayCong(_makycong, _manv);
            double congchunhat = _bcct_nv.tongNgayCongChuNhat(_makycong, _manv);
            kcct.CONGNGAYLE = tongcongngayle;
            kcct.NGHIKHONGPHEP = tongngaykhongphep;
            kcct.NGAYPHEP = tongngayphep ;
            kcct.TONGNGAYCONG = tongngaycong;
            kcct.CONGCHUNHAT = congchunhat;
            _kcct.Update(kcct);
            frmBCCC.loadBangCong();
            
           
            /*MessageBox.Show(_valueChamCong + "--" + _valueNgayNghi);*/
        }

        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cldNgayCong_DateSelected(object sender, DateRangeEventArgs e)
        {
            _cNgay = cldNgayCong.SelectionRange.Start.Day;
        }
    }
}