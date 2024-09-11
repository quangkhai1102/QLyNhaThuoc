using medicine_store.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyNhaThuoc
{
    public partial class DangNhap : Form
    {
        // Tạo một tooltip để hiển thị hướng dẫn khi di chuột qua các nút
        ToolTip tt = new ToolTip();

        public DangNhap()
        {
            InitializeComponent();

            // Thiết lập hướng dẫn tooltip cho các nút
            tt.SetToolTip(this.btDangKy, "Đăng ký");
            tt.SetToolTip(this.btDangNhap, "Đăng nhập");
            tt.SetToolTip(this.btThoat, "Thoát");
            tt.SetToolTip(this.btQuenMk, "Quên mật khẩu");

            // Thêm sự kiện Form.Shown để xử lý khi form được hiển thị
            this.Shown += new EventHandler(DangNhap_Shown);
        }

        // Xử lý khi form được hiển thị
        void DangNhap_Shown(object sender, EventArgs e)
        {
            // Đặt focus vào một control khác, ví dụ như một button
            this.pictureBox1.Focus();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        // Xử lý khi nút "Thoát" được click
        private void btThoat_Click(object sender, EventArgs e)
        {
            // Thoát ứng dụng
            Application.Exit();
        }

        // Xử lý khi nút "Đăng ký" được click
        private void btDangKy_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện mới của form DangKy
            DangKy dangKyForm = new DangKy();

            // Hiển thị form DangKy và ẩn form hiện tại
            dangKyForm.Show();
            this.Hide();
        }

        // Tạo đối tượng Modify để thực hiện các thao tác với cơ sở dữ liệu
        Modify modify = new Modify();

        // Xử lý khi nút "Đăng nhập" được click
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string tenTk = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            // Kiểm tra nếu các trường thông tin trống
            if (tenTk.Trim() == "" || matKhau.Trim() == "" || tenTk.Trim() == ("Tài khoản") || matKhau.Trim() == "Mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Tạo câu truy vấn SQL để kiểm tra tài khoản và mật khẩu
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tenTk + "' and MatKhau = '" + matKhau + "'";
                // Kiểm tra xem có tài khoản nào tương ứng với thông tin đã nhập không
                if (modify.TaiKhoans(query).Count() != 0)
                {
                    this.Hide();
                    Main_Form main_Form = new Main_Form();
                    main_Form.ShowDialog();
                }
                else
                {
                    // Thông báo lỗi nếu tài khoản hoặc mật khẩu không đúng
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Xử lý khi nút "Quên mật khẩu" được click
        private void btQuenMk_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện mới của form QuenMk
            QuenMk quenMkForm = new QuenMk();

            // Hiển thị form QuenMk và ẩn form hiện tại
            quenMkForm.Show();
            this.Hide();
        }

        // Xử lý khi textbox nhập tài khoản được focus
        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            // Nếu textbox hiện đang có nội dung là " Tài khoản", xóa nội dung đó
            if (txtTaiKhoan.Text == " Tài khoản")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black; // Thay đổi màu chữ thành màu xanh
            }
        }

        // Xử lý khi textbox nhập tài khoản không còn focus
        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            // Nếu textbox trống, hiển thị " Tài khoản" màu xám
            if (txtTaiKhoan.Text == "")
            {
                txtTaiKhoan.Text = " Tài khoản";
                txtTaiKhoan.ForeColor = Color.Black; // Thay đổi màu chữ thành màu xám
            }
        }

        // Xử lý khi textbox nhập mật khẩu được focus
        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            // Nếu textbox hiện đang có nội dung là " Mật khẩu", xóa nội dung đó và đặt PasswordChar
            if (txtMatKhau.Text == " Mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black; // Thay đổi màu chữ thành màu xanh
                txtMatKhau.PasswordChar = '*'; // Đặt PasswordChar khi nhập
            }
        }

        // Xử lý khi textbox nhập mật khẩu không còn focus
        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            // Nếu textbox trống, hiển thị " Mật khẩu" màu xám và loại bỏ PasswordChar
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = " Mật khẩu";
                txtMatKhau.ForeColor = Color.Black; // Thay đổi màu chữ thành màu xám
                txtMatKhau.PasswordChar = '\0'; // Đặt lại PasswordChar khi rời khỏi
            }
        }
    }
}
