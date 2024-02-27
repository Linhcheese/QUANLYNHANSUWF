using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class LOAICONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        // Lấy một mục
        public TB_LOAICONG GetItem(int id)
        {
            return db.TB_LOAICONG.FirstOrDefault(x => x.IDLC == id);
        }

        // Thêm một mục mới
        public TB_LOAICONG Add(TB_LOAICONG dt)
        {
            try
            {
                db.TB_LOAICONG.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Lấy danh sách
        public List<TB_LOAICONG> GetList()
        {
            return db.TB_LOAICONG.ToList();
        }

        // Cập nhật một mục
        public TB_LOAICONG Update(TB_LOAICONG dt)
        {
            try
            {
                var _DT = db.TB_LOAICONG.FirstOrDefault(x => x.IDLC == dt.IDLC);
                if (_DT != null)
                {
                    _DT.TENLC = dt.TENLC;
                    _DT.HESO = dt.HESO;
                    _DT.UPDATED_BY = 1; // Giả sử cố định là 1, bạn có thể điều chỉnh theo yêu cầu của bạn
                    _DT.UPDATED_DATE = DateTime.Now;
                    db.SaveChanges();
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Xóa một mục
        public void Delete(int id, int user)
        {
            try
            {
                var _DT = db.TB_LOAICONG.FirstOrDefault(x => x.IDLC == id);
                if (_DT != null)
                {
                    _DT.DELETED_BY = user;
                    _DT.DELETED_DATE = DateTime.Now;
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
