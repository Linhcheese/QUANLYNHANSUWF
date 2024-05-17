﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
   public class BANGCONG_NV_CT
    {
        QLNHANSUEntities db = new QLNHANSUEntities();
        public TB_BANGCONG_NHANVIEN_CHITIET getItem(int makycong, int manv, int ngay)
        {
            return db.TB_BANGCONG_NHANVIEN_CHITIET.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV == manv && x.NGAY.Value.Day==ngay);
        }
        public TB_BANGCONG_NHANVIEN_CHITIET Add(TB_BANGCONG_NHANVIEN_CHITIET bcct)
        {
            try
            {
                db.TB_BANGCONG_NHANVIEN_CHITIET.Add(bcct);
                db.SaveChanges();
                return bcct;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public TB_BANGCONG_NHANVIEN_CHITIET Update(TB_BANGCONG_NHANVIEN_CHITIET bcct)
        {
            try
            {
                TB_BANGCONG_NHANVIEN_CHITIET bcnv = db.TB_BANGCONG_NHANVIEN_CHITIET.FirstOrDefault(x => x.MAKYCONG == bcct.MAKYCONG && x.MANV==bcct.MANV && x.NGAY==bcct.NGAY);
                bcnv.KYHIEU = bcnv.KYHIEU;
                bcnv.GIOVAO = bcct.GIOVAO;
                bcnv.GIORA = bcct.GIORA;
                bcnv.NGAYPHEP = bcct.NGAYPHEP;
                bcnv.GHICHU = bcct.GHICHU;
                bcnv.CONGCHUNHAT = bcct.CONGCHUNHAT;
                bcnv.CONGNGAYLE = bcct.CONGNGAYLE;
                bcnv.NGAYCONG = bcct.NGAYCONG;
                bcnv.UPDATED_BY = bcct.UPDATED_BY;
                bcnv.UPDATED_DATE = bcct.UPDATED_DATE;
                db.SaveChanges();
                return bcct;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public double tongNgayPhep( int makycong, int manv)
        {
            return db.TB_BANGCONG_NHANVIEN_CHITIET.Where(x => x.MAKYCONG == makycong && x.MANV == manv && x.NGAYPHEP!=null).ToList().Sum(p=>p.NGAYPHEP.Value);
        }
        public double tongNgayCongChuNhat(int makycong, int manv)
        {
            return db.TB_BANGCONG_NHANVIEN_CHITIET.Where(x => x.MAKYCONG == makycong && x.MANV == manv && x.CONGCHUNHAT != null).ToList().Sum(p => p.CONGCHUNHAT.Value);
        }
        public double tongNgayCong(int makycong, int manv)
        {
            return db.TB_BANGCONG_NHANVIEN_CHITIET.Where(x => x.MAKYCONG == makycong && x.MANV == manv && x.NGAYPHEP != null).ToList().Sum(p => p.NGAYCONG.Value);
        }
        public double tongNgayKhongPhep(int makycong, int manv)
        {
            return db.TB_BANGCONG_NHANVIEN_CHITIET.Where(x => x.MAKYCONG == makycong && x.MANV == manv && x.KHONGPHEP != null).ToList().Sum(p => p.KHONGPHEP.Value);
        }
        public double tongNgayCongLe(int makycong, int manv)
        {
            return db.TB_BANGCONG_NHANVIEN_CHITIET.Where(x => x.MAKYCONG == makycong && x.MANV == manv && x.CONGNGAYLE != null).ToList().Sum(p => p.CONGNGAYLE.Value);
        }
    }
}
