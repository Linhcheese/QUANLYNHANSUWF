using BusinessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QLNHANSU
{
    public partial class frmDangKy : DevExpress.XtraEditors.XtraForm
    {
        // Tạo một instance của AccountManager để quản lý việc đăng ký tài khoản
        DANGKY checkDangky;

        public frmDangKy()
        {
            InitializeComponent();

            // Khởi tạo AccountManager
            checkDangky = new DANGKY();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kiểm tra xem đã nhập đầy đủ thông tin chưa
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!");
                return;
            }

            // Thực hiện đăng ký tài khoản
            bool registered = checkDangky.Register(username, password);
            if (registered)
            {
                // Hiển thị thông báo đăng ký thành công
                MessageBox.Show("Đăng ký thành công!");
                // Sau khi đăng ký thành công, bạn có thể thực hiện các hành động khác như đóng form này hoặc chuyển đến form khác
                // Ví dụ: this.Close();
            }
            else
            {
                // Hiển thị thông báo lỗi nếu đăng ký không thành công
                MessageBox.Show("Tên người dùng đã tồn tại. Vui lòng chọn tên khác.");
            }

        }

        private void btnReCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
    }
}
