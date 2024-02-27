using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;

namespace BusinessLayer
{
    public class NHANVIEN_TANGLUONG
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        // Lấy một nhân viên theo ID
        public TB_NHANVIEN_TANGLUONG getItem(string id)
        {
            return db.TB_NHANVIEN_TANGLUONG.FirstOrDefault(x => x.SOQD == id);
        }

        public List<TB_NHANVIEN_TANGLUONG> getList()
        {
            return db.TB_NHANVIEN_TANGLUONG.ToList();
        }
        public List<NHANVIEN_TANGLUONG_DTO> getListFull()
        {
            var lstNV = db.TB_NHANVIEN_TANGLUONG.ToList();
            List<NHANVIEN_TANGLUONG_DTO> lstNVDTO = new List<NHANVIEN_TANGLUONG_DTO>();
            NHANVIEN_TANGLUONG_DTO nvDTO;
            foreach (var item in lstNV)
            {
                nvDTO = new NHANVIEN_TANGLUONG_DTO();
                nvDTO.SOQD = item.SOQD;
                nvDTO.SOHD = item.SOHD;
                nvDTO.MANV = item.MANV;
                nvDTO.NGAYKY = item.NGAYKY;
                nvDTO.NGAYLENLUONG = item.NGAYLENLUONG;
                nvDTO.HESOLUONGHIENTAI = item.HESOLUONGHIENTAI;
                nvDTO.HESOLUONGMOI = item.HESOLUONGMOI;
              
                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == item.MANV);
                nvDTO.HOTEN = nv.HOTEN;


                nvDTO.GHICHU = item.GHICHU;
      
                nvDTO.DELETED_BY = item.DELETED_BY;
                nvDTO.DELETED_DATE = item.DELETED_DATE;
                nvDTO.UPDATED_BY = item.UPDATED_BY;
                nvDTO.UPDATED_DATE = item.UPDATED_DATE;


                lstNVDTO.Add(nvDTO);

            }
            return lstNVDTO;

        }


        // Thêm một nhân viên
        public TB_NHANVIEN_TANGLUONG Add(TB_NHANVIEN_TANGLUONG tv)
        {
            try
            {
                db.TB_NHANVIEN_TANGLUONG.Add(tv);
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }



        // Cập nhật thông tin của nhân viên
        public TB_NHANVIEN_TANGLUONG Update(TB_NHANVIEN_TANGLUONG tl)
        {
            try
            {
                var _tl = db.TB_NHANVIEN_TANGLUONG.FirstOrDefault(x => x.SOQD == tl.SOQD);
                if (_tl != null)
                {
                    _tl.SOHD = tl.SOHD;
                    _tl.NGAYKY = tl.NGAYKY;
                    _tl.NGAYLENLUONG = tl.NGAYLENLUONG;
                    _tl.HESOLUONGHIENTAI = tl.HESOLUONGHIENTAI;
                    _tl.HESOLUONGMOI = tl.HESOLUONGMOI;
                    _tl.GHICHU = tl.GHICHU;
                    _tl.MANV = tl.MANV;
                    _tl.UPDATED_BY = tl.UPDATED_BY;
                    _tl.UPDATED_DATE = tl.UPDATED_DATE;

                    db.SaveChanges();
                }
                return tl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Xóa một nhân viên
        public void Delete(string id, int user)
        {
            try
            {
                var _tv = db.TB_NHANVIEN_TANGLUONG.FirstOrDefault(x => x.SOQD == id);
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
            var _kt = db.TB_NHANVIEN_TANGLUONG.OrderByDescending(x => x.CRREATED_DATE).FirstOrDefault();
            if (_kt != null)
            {
                return _kt.SOQD;
            }
            else
                return "00000";
        }
    }
}
