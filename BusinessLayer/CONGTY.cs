using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CONGTY
    {

        QLNHANSUEntities db = new QLNHANSUEntities();

        //get item
        public TB_CONGTY getItem(int id)
        {
            return db.TB_CONGTY.FirstOrDefault(x => x.IDCT == id);
        }
        //add
        public TB_CONGTY Add(TB_CONGTY ct)
        {
            try
            {
                db.TB_CONGTY.Add(ct);
                db.SaveChanges();
                return ct;

            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }


        //get list
        public List<TB_CONGTY> getList()
        {
            return db.TB_CONGTY.ToList();
        }

        //update
        public TB_CONGTY Update(TB_CONGTY ct)
        {
            try
            {
                var _CT = db.TB_CONGTY.FirstOrDefault(x => x.IDCT == ct.IDCT);
                _CT.TENCT = ct.TENCT;
                _CT.DIENTHOAI = ct.DIENTHOAI;
                _CT.EMAIL = ct.EMAIL;
                _CT.DIACHI = ct.DIACHI;
                db.SaveChanges();
                return ct;

            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }
        //Delete
        public void Delete(int id)
        {
            try
            {
                var _CT = db.TB_CONGTY.FirstOrDefault(x => x.IDCT == id);
                db.TB_CONGTY.Remove(_CT);
                db.SaveChanges();


            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }
    }
}

