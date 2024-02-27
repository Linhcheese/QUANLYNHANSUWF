
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class CHUCVU
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        // Lấy một mục theo ID
        public TB_CHUCVU getItem(int id)
        {
            return db.TB_CHUCVU.FirstOrDefault(x => x.IDCV == id);
        }

        // Thêm một mục
        public TB_CHUCVU Add(TB_CHUCVU cv)
        {
            try
            {
                db.TB_CHUCVU.Add(cv);
                db.SaveChanges();
                return cv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Lấy danh sách tất cả các mục
        public List<TB_CHUCVU> getList()
        {
            return db.TB_CHUCVU.ToList();
        }

        // Cập nhật một mục
        public TB_CHUCVU Update(TB_CHUCVU cv)
        {
            try
            {
                var _cv = db.TB_CHUCVU.FirstOrDefault(x => x.IDCV == cv.IDCV);
                if (_cv != null)
                {
                    _cv.TENCV = cv.TENCV;
                    // Cập nhật các trường khác tương tự nếu cần
                    db.SaveChanges();
                }
                return cv;
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
                var _cv = db.TB_CHUCVU.FirstOrDefault(x => x.IDCV == id);
                if (_cv != null)
                {
                    db.TB_CHUCVU.Remove(_cv);
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