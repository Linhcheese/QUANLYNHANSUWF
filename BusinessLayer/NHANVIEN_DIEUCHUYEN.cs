using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.DTO;


namespace BusinessLayer
{
   public  class NHANVIEN_DIEUCHUYEN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        public TB_NV_DIEUCHUYEN getItem(string soqd)
        {
            return db.TB_NV_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == soqd);
        }

        public List<TB_NV_DIEUCHUYEN> getlist()
        {
            return db.TB_NV_DIEUCHUYEN.ToList();
        }
        public List<NHANVIEN_DIEUCHUYEN_DTO> getItemFull()
        {
            List<TB_NV_DIEUCHUYEN> lstKT = db.TB_NV_DIEUCHUYEN.ToList();
            List<NHANVIEN_DIEUCHUYEN_DTO> lstDTO = new List<NHANVIEN_DIEUCHUYEN_DTO>();
            NHANVIEN_DIEUCHUYEN_DTO nvDTO;
            foreach (var item in lstKT)
            {
                nvDTO = new NHANVIEN_DIEUCHUYEN_DTO();
                nvDTO.SOQD = item.SOQD;
                nvDTO.NGAY = item.NGAY.Value;
             
             
                nvDTO.LYDO = item.LYDO;
                nvDTO.GHICHU = item.GHICHU;
                nvDTO.IDNV = item.IDNV;

                var nv = db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == item.IDNV);
                nvDTO.HOTEN = nv.HOTEN;


                nvDTO.MAPB = item.MAPB;
                var pb=    db.TB_PHONGBAN.FirstOrDefault(x1 => x1.IDPB == item.MAPB);
                nvDTO.TENPB = pb.TENPB;

                nvDTO.MAPB2 = item.MAPB2;
                var pb2 = db.TB_PHONGBAN.FirstOrDefault(x2 => x2.IDPB == item.MAPB2);
                nvDTO.TENPB2 = pb2.TENPB;

                nvDTO.CREATED_BY = item.CREATED_BY;
                nvDTO.CREATED_DATE = item.CREATED_DATE;
                nvDTO.DELETED_BY = item.DELETED_BY;
                nvDTO.DELETED_DATE = item.DELETED_DATE;
                nvDTO.UPDATED_BY = item.UPDATED_BY;
                nvDTO.UPDATED_DATE = item.UPDATED_DATE;

                lstDTO.Add(nvDTO);

            }
            return lstDTO;
        }
        public TB_NV_DIEUCHUYEN Add(TB_NV_DIEUCHUYEN dc)
        {
            try
            {
                db.TB_NV_DIEUCHUYEN.Add(dc);
                db.SaveChanges();

                return dc;

            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }

        public TB_NV_DIEUCHUYEN Update(TB_NV_DIEUCHUYEN kt)
        {
            try
            {
                TB_NV_DIEUCHUYEN _dc = db.TB_NV_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == kt.SOQD);
                _dc.NGAY = kt.NGAY;
                _dc.MAPB2= kt.MAPB2;
             
                _dc.LYDO = kt.LYDO;
                _dc.GHICHU = kt.GHICHU;
               
                _dc.UPDATED_BY = kt.UPDATED_BY;
                _dc.UPDATED_DATE = kt.UPDATED_DATE;
                db.SaveChanges();
                return kt;

            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
            }
        }

        public void Delete(string soqd, int manv)
        {
            try
            {
                var _kt = db.TB_NV_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == soqd);
                _kt.DELETED_BY = manv;
                _kt.DELETED_DATE = DateTime.Now;


                db.SaveChanges();


            }
            catch (Exception ex)
            {
                throw new Exception("Loi : " + ex.Message);
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
