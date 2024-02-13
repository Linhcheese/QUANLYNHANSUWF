using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class NHANVIEN
    {
        QLNHANSUEntities db = new QLNHANSUEntities();

        // Lấy một nhân viên theo ID
        public TB_NHANVIEN getItem(int id)
        {
            return db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == id);
        }

        // Thêm một nhân viên
        public TB_NHANVIEN Add(TB_NHANVIEN employee)
        {
            try
            {
                db.TB_NHANVIEN.Add(employee);
                db.SaveChanges();
                return employee;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Lấy danh sách tất cả các nhân viên
        public List<TB_NHANVIEN> getList()
        {
            return db.TB_NHANVIEN.ToList();
        }

        // Cập nhật thông tin của nhân viên
        public TB_NHANVIEN Update(TB_NHANVIEN employee)
        {
            try
            {
                var emp = db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == employee.MANV);
                if (emp != null)
                {
                    emp.HOTEN = employee.HOTEN;
                    emp.GIOITINH = employee.GIOITINH;
                    emp.NGAYSINH = employee.NGAYSINH;
                    emp.CCCD = employee.CCCD;
                    emp.DIENTHOAI = employee.DIENTHOAI;
                    emp.HINHANH = employee.HINHANH;
                    emp.EMAIL = employee.EMAIL;
                    emp.DIACHI = employee.DIACHI;
                    emp.IDBP = employee.IDBP;
                    emp.IDCV = employee.IDCV;
                    emp.IDPB = employee.IDPB;
                    emp.IDTD = employee.IDTD;
                    emp.IDDT = employee.IDDT;
                    emp.IDTG = employee.IDTG;

                    emp.IDCT = employee.IDCT;
                    db.SaveChanges();
                }
                return employee;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        // Xóa một nhân viên
        public void Delete(int id)
        {
            try
            {
                var emp = db.TB_NHANVIEN.FirstOrDefault(x => x.MANV == id);
                if (emp != null)
                {
                    db.TB_NHANVIEN.Remove(emp);
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
