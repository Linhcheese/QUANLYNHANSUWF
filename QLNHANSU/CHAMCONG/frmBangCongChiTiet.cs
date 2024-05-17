﻿using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraSplashScreen;
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
	public partial class frmBangCongChiTiet : DevExpress.XtraEditors.XtraForm
	{
		public frmBangCongChiTiet()
		{
			InitializeComponent();
			cboThang.SelectedIndexChanged += CboThangNam_SelectedIndexChanged;
			cboNam.SelectedIndexChanged += CboThangNam_SelectedIndexChanged;
		}
		NHANVIEN _nhanvien;
		KYCONG _kycong;
		KYCONGCHITIET _kcct;
		BANGCONG_NV_CT _bangcongCT;
		public int _makycong;
		public int _macty;
		public int _thang;
		public int _nam;
		private void frmBangCongChiTiet_Load(object sender, EventArgs e)
		{
			_kycong = new KYCONG();
			_kcct = new KYCONGCHITIET();
			_nhanvien = new NHANVIEN();
			_bangcongCT = new BANGCONG_NV_CT();
			gcBangCongChiTiet.DataSource = _kcct.getList(_makycong);
			gvBangCongChiTiet.OptionsBehavior.Editable = false;
			CustomView(_thang, _nam);
			cboThang.Text = _thang.ToString();
			cboNam.Text = _nam.ToString();
		}
		private void CboThangNam_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (int.TryParse(cboThang.Text, out int thang))
			{
				_thang = thang;
			}
			if (int.TryParse(cboNam.Text, out int nam))
			{
				_nam = nam;
			}

			// Cập nhật bất kỳ thứ gì khác nếu cần thiết
		}
		public void loadBangCong()
		{
			_kcct = new KYCONGCHITIET();
			gcBangCongChiTiet.DataSource = _kcct.getList(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
			CustomView(int.Parse(cboThang.Text), int.Parse(cboNam.Text));
			gvBangCongChiTiet.OptionsBehavior.Editable = false;
		}
		private void btnPhatSinhKyCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			SplashScreenManager.ShowForm(typeof(frmWaiting), true, true);
			if (_kycong.KiemTraPhatSinhKyCong(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text)))
			{
				MessageBox.Show("Kỳ công đã phát sinh", "Thông báo");
				SplashScreenManager.CloseForm();
				return;
			}
			List<TB_NHANVIEN> lstNhanVien = _nhanvien.getList();
			_kcct.phatSinhKyCongChiTiet(_macty, int.Parse(cboThang.Text), int.Parse(cboNam.Text));
			foreach (var item in lstNhanVien)
			{
				for (int i = 1; i <= GetDayNumber(int.Parse(cboThang.Text), int.Parse(cboNam.Text)); i++)
				{
					TB_BANGCONG_NHANVIEN_CHITIET bcct = new TB_BANGCONG_NHANVIEN_CHITIET();
					bcct.MANV = item.MANV;
					bcct.IDCT = item.IDCT;
					bcct.HOTEN = item.HOTEN;
					bcct.GIOVAO = "8:00";
					bcct.GIORA = "17:00";

					bcct.NGAY = DateTime.Parse(cboNam.Text + "-" + cboThang.Text + "-" + i.ToString());
					bcct.THU = Functions.layThuTrongTuan(int.Parse(cboNam.Text), int.Parse(cboThang.Text), i);
					
					bcct.NGAYPHEP = 0;
					bcct.CONGNGAYLE = 0;
					bcct.CONGCHUNHAT = 0;
					if (bcct.THU == "Chủ nhật")
                    {
						bcct.KYHIEU = "CN";
						bcct.NGAYCONG = 0;
					}
						
					else
                    {
						bcct.KYHIEU = "X";
						bcct.NGAYCONG = 1;
					}
						
					bcct.MAKYCONG = _makycong;
					bcct.CREATED_DATE = DateTime.Now;
					bcct.CREATED_BY = 1;
					_bangcongCT.Add(bcct);
				}
			}
			var kc = _kycong.GetItem(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
			kc.TRANGTHAI = true;
			_kycong.Update(kc);
			SplashScreenManager.CloseForm();
			loadBangCong();
		}


		private void btnXemBangCong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			loadBangCong();
		}
		private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			loadBangCong();
		}
		private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}

		private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			this.Close();
		}

		private void CustomView(int thang, int nam)
		{
			gvBangCongChiTiet.RestoreLayoutFromXml(Application.StartupPath + @"\BangCong_Layout.xml");
			int i;
			foreach (GridColumn gridColumn in gvBangCongChiTiet.Columns)
			{

				if (gridColumn.FieldName == "HOTEN") continue;

				RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
				textEdit.Mask.MaskType = MaskType.RegEx;
				textEdit.Mask.EditMask = @"\p{Lu}+";
				gridColumn.ColumnEdit = textEdit;
			}

			for (i = 1; i <= GetDayNumber(_thang, _nam); i++)
			{
				DateTime newDate = new DateTime(_nam, _thang, i);

				GridColumn column = new GridColumn();
				column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
				string fieldName = "D" + i;
				switch (newDate.DayOfWeek.ToString())
				{
					case "Monday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "T.Hai " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = true;
						column.AppearanceHeader.ForeColor = Color.Blue;
						column.AppearanceHeader.BackColor = Color.Transparent;
						column.AppearanceHeader.BackColor2 = Color.Transparent;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Transparent;
						column.OptionsColumn.AllowFocus = true;
						//column.Width = 30;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						break;

					case "Tuesday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "T.Ba " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = true;
						column.AppearanceHeader.ForeColor = Color.Blue;
						column.AppearanceHeader.BackColor = Color.Transparent;
						column.AppearanceHeader.BackColor2 = Color.Transparent;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Transparent;
						column.OptionsColumn.AllowFocus = true;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						//column.Width = 30;
						break;

					case "Wednesday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "T.Tư " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = true;
						column.AppearanceHeader.ForeColor = Color.Blue;
						column.AppearanceHeader.BackColor = Color.Transparent;
						column.AppearanceHeader.BackColor2 = Color.Transparent;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Transparent;
						column.OptionsColumn.AllowFocus = true;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						//column.Width = 30;
						break;
					case "Thursday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "T.Năm " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = true;
						column.AppearanceHeader.ForeColor = Color.Blue;
						column.AppearanceHeader.BackColor = Color.Transparent;
						column.AppearanceHeader.BackColor2 = Color.Transparent;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Transparent;
						column.OptionsColumn.AllowFocus = true;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						//column.Width = 30;
						break;
					case "Friday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "T.Sáu " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = true;
						column.AppearanceHeader.ForeColor = Color.Blue;
						column.AppearanceHeader.BackColor = Color.Transparent;
						column.AppearanceHeader.BackColor2 = Color.Transparent;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Transparent;
						column.OptionsColumn.AllowFocus = true;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						//column.Width = 30;
						break;
					case "Saturday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "T.Bảy " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = true;
						column.AppearanceHeader.ForeColor = Color.Blue;
						column.AppearanceHeader.BackColor = Color.DeepPink;
						column.AppearanceHeader.BackColor2 = Color.DeepPink;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Transparent;
						column.OptionsColumn.AllowFocus = true;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						//column.Width = 30;
						break;
					case "Sunday":
						column = gvBangCongChiTiet.Columns[fieldName];
						column.Caption = "CN " + Environment.NewLine + i;
						column.OptionsColumn.AllowEdit = false;
						column.AppearanceHeader.ForeColor = Color.Red;
						column.AppearanceHeader.BackColor = Color.GreenYellow;
						column.AppearanceHeader.BackColor2 = Color.GreenYellow;
						column.AppearanceCell.ForeColor = Color.Black;
						column.AppearanceCell.BackColor = Color.Orange;
						//column.AppearanceHeader.Font = new Font("Tahoma", 8, FontStyle.Regular);
						//column.Width = 30;
						//column.OptionsColumn.AllowFocus = false;
						break;
				}
			}

			while (i <= 31)
			{
				gvBangCongChiTiet.Columns[i + 1].Visible = false;
				i++;
			}

		}
		private int GetDayNumber(int thang, int nam)
		{
			int dayNumber = 0;
			switch (thang)
			{
				case 2:
					dayNumber = DateTime.IsLeapYear(nam) ? 29 : 28;
					break;

				case 4:
				case 6:
				case 9:
				case 11:
					dayNumber = 30;
					break;

				case 1:
				case 3:
				case 5:
				case 7:
				case 8:
				case 10:
				case 12:
					dayNumber = 31;
					break;
			}

			return dayNumber;
		}
		private void mnCapNhatNgayCong_Click(object sender, EventArgs e)
		{
			frmCapNhatNgayCong frm = new frmCapNhatNgayCong();
			frm._makycong = _makycong;
			frm._manv = int.Parse(gvBangCongChiTiet.GetFocusedRowCellValue("MANV").ToString());
			frm._hoten = gvBangCongChiTiet.GetFocusedRowCellValue("HOTEN").ToString();
			frm._ngay = gvBangCongChiTiet.FocusedColumn.FieldName.ToString();
			frm.ShowDialog();
		}

		private void gvBangCongChiTiet_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
		{
			if (e.CellValue == null)
			{

			}
			else
			{
				if (e.CellValue.ToString() == "CT")
				{
					e.Appearance.BackColor = Color.DeepSkyBlue;
					e.Appearance.ForeColor = Color.White;
				}
				if (e.CellValue.ToString() == "Vcn")
				{
					e.Appearance.BackColor = Color.DarkGreen;
					e.Appearance.ForeColor = Color.White;
				}
				if (e.CellValue.ToString() == "P")
				{
					e.Appearance.BackColor = Color.LightBlue;

				}
				if (e.CellValue.ToString() == "V")
				{
					e.Appearance.BackColor = Color.IndianRed;
					e.Appearance.ForeColor = Color.White;
				}
			}

		}
    }
}