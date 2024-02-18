using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    public class HOPDONGLAODONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        // Lấy một nhân viên theo ID
        public TB_HOPDONG getItem(string sohd)
        {
            return db.TB_HOPDONG.FirstOrDefault(x => x.SOHD == sohd);
        }
        public List<TB_HOPDONG> getList()
        {
            return db.TB_HOPDONG.ToList();
        }

        public TB_HOPDONG Add(TB_HOPDONG hopdong)
        {
            try
            {
                db.TB_HOPDONG.Add(hopdong);
                db.SaveChanges();
                return hopdong;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public TB_HOPDONG Update(TB_HOPDONG hopdong)
        {
            try
            {
                var hd = db.TB_HOPDONG.FirstOrDefault(x => x.SOHD == hopdong.SOHD);
                if (hd != null)
                {
                    hd.NGAYBATDAU = hopdong.NGAYBATDAU;
                    hd.NGAYKETTHUC = hopdong.NGAYKETTHUC;
                    hd.NGAYKY = hopdong.NGAYKY;
                    hd.LANKY = hopdong.LANKY;
                    hd.HESOLUONG = hopdong.HESOLUONG;
                    hd.NOIDUNG = hopdong.NOIDUNG;
                    hd.THOIHAN = hopdong.THOIHAN;
                    hd.SOHD = hopdong.SOHD;

                  
                    hd.UPDATED_BY = hopdong.UPDATED_BY;
                    hd.UPDATED_DATE = hopdong.UPDATED_DATE;
                    hd.CREATED_BY = hopdong.CREATED_BY;
                    hd.CREATED_DATE = hopdong.CREATED_DATE;


                    hd.MACT = hopdong.MACT;
                    db.SaveChanges();
                }
                return hopdong;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Xóa một nhân viên
        public void Delete(string id,int manv)
        {
            try
            {
                var hd = db.TB_HOPDONG.FirstOrDefault(x => x.SOHD == id);
                if (hd != null)
                {
                    hd.DELETED_BY = manv;
                    hd.DELETED_DATE = DateTime.Now;
                 //   db.TB_HOPDONG.Remove(hd);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
