using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TONGIAO
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        //get item
        public TB_TONGIAO getItem(int id)
        {
            return db.TB_TONGIAO.FirstOrDefault(x => x.ID == id);
        }
        //add
        public TB_TONGIAO Add(TB_TONGIAO tg)
        {
            try
            {
                db.TB_TONGIAO.Add(tg);
                db.SaveChanges();
                return tg;

            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }


        //get list
        public List<TB_TONGIAO> getList()
        {
            return db.TB_TONGIAO.ToList();
        }

        //update
        public TB_TONGIAO Update(TB_TONGIAO tg)
        {
            try
            {
                var _TG = db.TB_TONGIAO.FirstOrDefault(x => x.ID == tg.ID);
                _TG.TENTG = tg.TENTG;
                db.SaveChanges();
                return tg;

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
                var _TG = db.TB_TONGIAO.FirstOrDefault(x => x.ID == id);
                db.TB_TONGIAO.Remove(_TG);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }
    }
}