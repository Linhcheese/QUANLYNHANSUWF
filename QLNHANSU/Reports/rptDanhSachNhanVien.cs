using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using BusinessLayer.DTO;

namespace QLNHANSU.Reports
{
    public partial class rptDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    { 
        public rptDanhSachNhanVien()
        {
            InitializeComponent();
        }
        List<NHANVIEN_DTO> _lstNV;
        public rptDanhSachNhanVien(List<NHANVIEN_DTO> lstNV)
        {
            InitializeComponent();
            this._lstNV = lstNV;
            this.DataSource = _lstNV;
            loadData();
        }
        void loadData()
        {
            lbMaNV.DataBindings.Add("Text", _lstNV, "MANV");
            lbHoTen.DataBindings.Add("Text", _lstNV, "HOTEN");
            lbGioiTinh.DataBindings.Add("Text", _lstNV, "GIOITINH");
            lbNgaySinh.DataBindings.Add("Text", _lstNV, "NGAYSINH");
            lbCCCD.DataBindings.Add("Text", _lstNV, "CCCD");
            lbDienThoai.DataBindings.Add("Text", _lstNV, "DIENTHOAI");
            lbEmail.DataBindings.Add("Text", _lstNV, "EMAIL");
            lbDiaChi.DataBindings.Add("Text", _lstNV, "DIACHI");
            lbPhongBan.DataBindings.Add("Text", _lstNV, "TENPB");
            lbChucVu.DataBindings.Add("Text", _lstNV, "TENCV");
            lbTrinhDo.DataBindings.Add("Text", _lstNV, "TENTD");
            lbDanToc.DataBindings.Add("Text", _lstNV, "TENDT");
            lbTonGiao.DataBindings.Add("Text", _lstNV, "TENTG");
            lbBoPhan.DataBindings.Add("Text", _lstNV, "TENBP");
            lbCongTy.DataBindings.Add("Text", _lstNV, "TENCT");
        }

    }
}
