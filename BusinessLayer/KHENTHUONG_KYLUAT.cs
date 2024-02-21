using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;

namespace BusinessLayer
{
   public class KHENTHUONG_KYLUAT
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        public TB_KHENTHUONG_KYLUAT getItem(string soqd)
        {
            return db.TB_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == soqd);
        }

        public List<TB_KHENTHUONG_KYLUAT> getlist(int loai)
        {
            return db.TB_KHENTHUONG_KYLUAT.Where(x=>x.LOAI==loai).ToList()                                          ;
        }
        public List<KHENTHUONG_KYLUAT_DTO> getItemFull(int loai)
        {
            List<TB_KHENTHUONG_KYLUAT> lstKT = db.TB_KHENTHUONG_KYLUAT.Where(x => x.LOAI == loai).ToList();
            List<KHENTHUONG_KYLUAT_DTO> lstDTO = new List<KHENTHUONG_KYLUAT_DTO>();
            KHENTHUONG_KYLUAT_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KHENTHUONG_KYLUAT_DTO();
                kt.SOQUYETDINH = item.SOQUYETDINH;
                kt.NGAY = item.NGAY.Value;
                kt.DENNGAY = item.DENNGAY.Value;
                kt.TUNGAY = item.TUNGAY;
                kt.LOAI = item.LOAI;
                kt.LYDO = item.LYDO;
                kt.NOIDUNG = item.NOIDUNG;
                kt.MANV = item.MANV;
             
                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                kt.HOTEN = nv.HOTEN;
             
                kt.CREATED_BY = item.CREATED_BY;
                kt.CREATED_DATE = item.CREATED_DATE;
                kt.DELETED_BY = item.DELETED_BY;
                kt.DELETED_DATE = item.DELETED_DATE;
                kt.UPDATED_BY = item.UPDATED_BY;
                kt.UPDATED_DATE = item.UPDATED_DATE;
              
                lstDTO.Add(kt);

            }
            return lstDTO;
        }
        public TB_KHENTHUONG_KYLUAT Add(TB_KHENTHUONG_KYLUAT kt)
        {
            try
            {
                db.TB_KHENTHUONG_KYLUAT.Add(kt);
                db.SaveChanges();
               
                return kt;

            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }

        public TB_KHENTHUONG_KYLUAT Update(TB_KHENTHUONG_KYLUAT kt)
        {
            try
            {
               TB_KHENTHUONG_KYLUAT _kt= db.TB_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == kt.SOQUYETDINH);
                _kt.NGAY = kt.NGAY;
                _kt.TUNGAY = kt.TUNGAY;
                _kt.DENNGAY = kt.DENNGAY;
                _kt.LYDO = kt.LYDO;
                _kt.NOIDUNG = kt.NOIDUNG;
                _kt.LOAI = kt.LOAI;
                _kt.MANV = kt.MANV;
                _kt.UPDATED_BY = kt.UPDATED_BY;
                _kt.UPDATED_DATE = kt.UPDATED_DATE;
                db.SaveChanges();
                return kt;

            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }

        public void Delete(string soqd,int manv) 
        {
            try
            {
                var _kt = db.TB_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == soqd);
                _kt.DELETED_BY = manv;
                _kt.DELETED_DATE = DateTime.Now;


                db.SaveChanges();


            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh(int loai)
        {
            var _kt = db.TB_KHENTHUONG_KYLUAT.Where(x=>x.LOAI==loai).OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_kt != null)
            {
                return _kt.SOQUYETDINH;
            }
            else
                return "00000";
        }
    }
}
