using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;
namespace BusinessLayer
{
    public class NHANVIEN_THOIVIEC
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        // Lấy một nhân viên theo ID
        public TB_NHANVIEN_THOIVIEC getItem(string id)
        {
            return db.TB_NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == id);
        }

        public List<TB_NHANVIEN_THOIVIEC> getList()
        {
            return db.TB_NHANVIEN_THOIVIEC.ToList();
        }
        public List<NHANVIEN_THOIVIEC_DTO> getListFull()
        {
            var lstNV = db.TB_NHANVIEN_THOIVIEC.ToList();
            List<NHANVIEN_THOIVIEC_DTO> lstNVDTO = new List<NHANVIEN_THOIVIEC_DTO>();
            NHANVIEN_THOIVIEC_DTO nvDTO;
            foreach (var item in lstNV)
            {
                nvDTO = new NHANVIEN_THOIVIEC_DTO();
                nvDTO.SOQD = item.SOQD;
                nvDTO.MANV = item.MANV;
              
                nvDTO.NGAYNGHI = item.NGAYNGHI;
                nvDTO.NGAYNOPDON = item.NGAYNOPDON;
                nvDTO.LYDO = item.LYDO;
                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                nvDTO.HOTEN = nv.HOTEN;


                nvDTO.GHICHU = item.GHICHU;
                nvDTO.CREATED_BY = item.CREATED_BY;
                nvDTO.CREATED_DATE = item.CREATED_DATE;
                nvDTO.DELETED_BY = item.DELETED_BY;
                nvDTO.DELETED_DATE = item.DELETED_DATE;
                nvDTO.UPDATED_BY = item.UPDATED_BY;
                nvDTO.UPDATED_DATE = item.UPDATED_DATE;


                lstNVDTO.Add(nvDTO);

            }
            return lstNVDTO;

        }


        // Thêm một nhân viên
        public TB_NHANVIEN_THOIVIEC Add(TB_NHANVIEN_THOIVIEC tv)
        {
            try
            {
                db.TB_NHANVIEN_THOIVIEC.Add(tv);
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

     

        // Cập nhật thông tin của nhân viên
        public TB_NHANVIEN_THOIVIEC Update(TB_NHANVIEN_THOIVIEC tv)
        {
            try
            {
                var _tv = db.TB_NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == tv.SOQD);
                if (_tv != null)
                {
                    _tv.NGAYNGHI = tv.NGAYNGHI;
                    _tv.NGAYNOPDON = tv.NGAYNOPDON;
                    _tv.LYDO = tv.LYDO;
                    _tv.GHICHU = tv.GHICHU;
                    _tv.MANV = tv.MANV;
                    _tv.UPDATED_BY = tv.UPDATED_BY;
                    _tv.UPDATED_DATE = tv.UPDATED_DATE;
                 
                    db.SaveChanges();
                }
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Xóa một nhân viên
        public void Delete(string id,int user)
        {
            try
            {
                var _tv = db.TB_NHANVIEN_THOIVIEC.FirstOrDefault(x => x.SOQD == id);
                if (_tv != null)
                {
                    _tv.DELETED_BY = user;
                    _tv.DELETED_DATE = DateTime.Now;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSOQD()
        {
            var _kt = db.TB_NHANVIEN_THOIVIEC.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_kt != null)
            {
                return _kt.SOQD;
            }
            else
                return "00000";
        }
    }
}
