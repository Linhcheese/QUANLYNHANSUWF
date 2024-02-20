using BusinessLayer.DTO;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLNHANSU.Reports
{
    public partial class rptHopDongLaoDong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHopDongLaoDong()
        {
            InitializeComponent();
        }
        List<HOPDONG_DTO> _hd;
        public rptHopDongLaoDong(List<HOPDONG_DTO> hd)
        {
            InitializeComponent();
            this._hd = hd;
            this.DataSource = _hd;
            LoadData();
        }
        void LoadData()
        {
            lbSoHD.DataBindings.Add("Text", _hd, "SOHD");
        }
    }
}
