using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TRINHDO
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        // Lấy một mục theo ID
        public TB_TRINHDO getItem(int id)
        {
            return db.TB_TRINHDO.FirstOrDefault(x => x.IDTD == id);
        }

        // Thêm một mục
        public TB_TRINHDO Add(TB_TRINHDO trinhdo)
        {
            try
            {
                db.TB_TRINHDO.Add(trinhdo);
                db.SaveChanges();
                return trinhdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Lấy danh sách tất cả các mục
        public List<TB_TRINHDO> getList()
        {
            return db.TB_TRINHDO.ToList();
        }

        // Cập nhật một mục
        public TB_TRINHDO Update(TB_TRINHDO trinhdo)
        {
            try
            {
                var _trinhdo = db.TB_TRINHDO.FirstOrDefault(x => x.IDTD == trinhdo.IDTD);
                if (_trinhdo != null)
                {
                    _trinhdo.TENTD = trinhdo.TENTD;
                    // Cập nhật các trường khác tương tự nếu cần
                    db.SaveChanges();
                }
                return trinhdo;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Xóa một mục
        public void Delete(int id)
        {
            try
            {
                var _trinhdo = db.TB_TRINHDO.FirstOrDefault(x => x.IDTD == id);
                if (_trinhdo != null)
                {
                    db.TB_TRINHDO.Remove(_trinhdo);
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