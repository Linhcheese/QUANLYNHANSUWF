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
            string rePassword = txtRePassAgain.Text;

            // Kiểm tra xem đã nhập đầy đủ thông tin chưa
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(rePassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản!");
                return;
            }

            // Kiểm tra độ dài của tên đăng nhập
            if (username.Length < 10 || username.Length > 12)
            {
                MessageBox.Show("Tên đăng nhập phải từ 10 đến 12 ký tự!");
                return;
            }

            // Kiểm tra độ dài của mật khẩu
            if (password.Length < 6 || password.Length > 12)
            {
                MessageBox.Show("Mật khẩu phải từ 6 đến 12 ký tự!");
                return;
            }

            // Kiểm tra xem mật khẩu và mật khẩu nhập lại có khớp nhau không
            if (!password.Equals(rePassword))
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng kiểm tra lại!");
                return;
            }

            // Thực hiện đăng ký tài khoản
            bool registered = checkDangky.Register(username, password);
            if (registered)
            {
                // Đóng form hiện tại trước khi mở form đăng nhập mới
                this.Hide(); // Ẩn form hiện tại trước khi mở form mới
                frmDangNhap frmDangNhap = new frmDangNhap();
                frmDangNhap.ShowDialog();
                this.Close(); // Sau khi form đăng nhập mới được đóng, đóng luôn form hiện tại
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

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }
    }
}
