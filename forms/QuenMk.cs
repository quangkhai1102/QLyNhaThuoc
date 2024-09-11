using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyNhaThuoc
{
    public partial class QuenMk : Form
    {
        // Tạo một tooltip để hiển thị hướng dẫn khi di chuột qua các nút
        ToolTip tt = new ToolTip();

        public QuenMk()
        {
            InitializeComponent();

            // Khởi tạo các thành phần giao diện và sự kiện
            label2.Text = ""; // Không hiển thị gì trong label2 ban đầu
            pictureBox3.Visible = false; // Không hiển thị ảnh bên cạnh button ban đầu

            // Thiết lập hướng dẫn tooltip cho các nút
            tt.SetToolTip(this.btTim, "Tìm mật khẩu");
            tt.SetToolTip(this.btThoat, "Thoát");

            // Thêm sự kiện Form.Shown để xử lý khi form được hiển thị
            this.Shown += new EventHandler(QuenMk_Shown);
        }

        // Xử lý khi form được hiển thị
        void QuenMk_Shown(object sender, EventArgs e)
        {
            // Đặt focus vào hình ảnh (pictureBox1) khi form được hiển thị
            this.pictureBox1.Focus();
        }

        // Hàm kiểm tra định dạng email
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-z0-9]{3,30}@gmail.com$");
        }

        // Tạo đối tượng Modify để thực hiện các thao tác với cơ sở dữ liệu
        Modify modify = new Modify();

        // Xử lý khi nút "Tìm mật khẩu" được click
        private void btTim_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            // Kiểm tra nếu email trống
            if (Email.Trim() == "" || Email.Trim() == "Email")
            {
                MessageBox.Show("Vui lòng nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Kiểm tra định dạng email
            else if (!CheckEmail(Email))
            {
                MessageBox.Show("Vui lòng nhập email với định dạng username@gmail.com", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                // Tạo câu truy vấn SQL để tìm tài khoản với email được cung cấp
                string query = "Select * from TaiKhoan where Email = '" + Email + "' ";
                // Hiển thị hình loading
                pictureBox3.Visible = true;
                // Kiểm tra xem có tài khoản nào tương ứng với email không
                if (modify.TaiKhoans(query).Count() != 0)
                {
                    // Hiển thị mật khẩu tương ứng với email
                    label2.ForeColor = Color.Black;
                    label2.Text = modify.TaiKhoans(query)[0].MatKhau1;
                }
                else
                {
                    // Thông báo nếu email chưa được đăng ký
                    label2.ForeColor = Color.Black;
                    label2.Text = "Email chưa được đăng ký";
                }
            }
        }

        // Xử lý khi nút "Thoát" được click
        private void btThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị form đăng nhập và đóng form hiện tại
            DangNhap dangNhapForm = new DangNhap();
            dangNhapForm.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Xử lý khi textbox nhập email được focus
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            // Nếu textbox hiện đang có nội dung là " Email", xóa nội dung đó
            if (txtEmail.Text == " Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black; // Thay đổi màu chữ thành màu xanh
            }
        }

        // Xử lý khi textbox nhập email không còn focus
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            // Nếu textbox trống, hiển thị " Email" màu xám
            if (txtEmail.Text == "")
            {
                txtEmail.Text = " Email";
                txtEmail.ForeColor = Color.Black; // Thay đổi màu chữ thành màu xám
            }
        }
    }
}
