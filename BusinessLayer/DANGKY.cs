using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DANGKY
    {
        QLNHANSUEntities db = new QLNHANSUEntities(); // Khởi tạo đối tượng để truy cập CSDL

        // Phương thức đăng ký tài khoản
        public bool Register(string username, string password)
        {
            try
            {
                // Kiểm tra xem tên người dùng đã tồn tại chưa
                var existingUser = db.TB_TAIKHOAN.FirstOrDefault(x => x.USERNAME == username);
                if (existingUser != null)
                {
                    Console.WriteLine("Tên người dùng đã tồn tại. Vui lòng chọn tên khác.");
                    return false;
                }

                // Tạo mới một đối tượng TAIKHOAN và thêm vào cơ sở dữ liệu
                var newAccount = new TB_TAIKHOAN()
                {
                    USERNAME = username,
                    PASSWORD = password
                };
                db.TB_TAIKHOAN.Add(newAccount);
                db.SaveChanges();

                Console.WriteLine("Đăng ký thành công!");
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }
    }
}
