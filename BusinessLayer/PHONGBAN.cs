using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using DataLayer;


namespace BusinessLayer
{
    public class PHONGBAN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        // Lấy một mục theo ID
        public TB_PHONGBAN getItem(int id)
        {
            return db.TB_PHONGBAN.FirstOrDefault(x => x.IDPB == id);
        }

        // Thêm một mục
        public TB_PHONGBAN Add(TB_PHONGBAN phongban)
        {
            try
            {
                db.TB_PHONGBAN.Add(phongban);
                db.SaveChanges();
                return phongban;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Lấy danh sách tất cả các mục
        public List<TB_PHONGBAN> getList()
        {
            return db.TB_PHONGBAN.ToList();
        }

        // Cập nhật một mục
        public TB_PHONGBAN Update(TB_PHONGBAN phongban)
        {
            try
            {
                var _phongban = db.TB_PHONGBAN.FirstOrDefault(x => x.IDPB == phongban.IDPB);
                if (_phongban != null)
                {
                    _phongban.TENPB = phongban.TENPB;
                    // Cập nhật các trường khác tương tự nếu cần
                    db.SaveChanges();
                }
                return phongban;
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
                var _phongban = db.TB_PHONGBAN.FirstOrDefault(x => x.IDPB == id);
                if (_phongban != null)
                {
                    db.TB_PHONGBAN.Remove(_phongban);
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