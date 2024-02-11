using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class DANTOC
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        //get item
        public TB_DANTOC getItem(int id)
        {
            return db.TB_DANTOC.FirstOrDefault(x => x.ID == id);
        }
        //add
        public TB_DANTOC Add(TB_DANTOC dt)
        {
            try
            {
                db.TB_DANTOC.Add(dt);
                db.SaveChanges();
                return dt;

            }catch(Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }


        //get list
        public List<TB_DANTOC> getList()
        {
            return db.TB_DANTOC.ToList();
        }

        //update
        public TB_DANTOC Update(TB_DANTOC dt)
        {
            try
            {
                var _DT=db.TB_DANTOC.FirstOrDefault(x => x.ID == dt.ID);
                _DT.TENDT = dt.TENDT;
                db.SaveChanges();
                return dt;

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
                var _DT = db.TB_DANTOC.FirstOrDefault(x => x.ID == id);
                db.TB_DANTOC.Remove(_DT);
                db.SaveChanges();
               

            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }
    }
}
