using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLyNhaThuoc
{
    public partial class DangKy : Form
    {
        ToolTip tt = new ToolTip(); // Đối tượng để hiển thị gợi ý khi di chuột qua các điều khiển

        public DangKy()
        {
            InitializeComponent();

            tt.SetToolTip(this.btDangKy, "Đăng ký"); // Hiển thị gợi ý "Đăng ký" khi di chuột qua nút "btDangKy"
            tt.SetToolTip(this.btThoat, "Thoát"); // Hiển thị gợi ý "Thoát" khi di chuột qua nút "btThoat"

            // Thêm sự kiện Form.Shown
            this.Shown += new EventHandler(DangKy_Shown);
        }

        // Xử lý sự kiện khi form được hiển thị
        void DangKy_Shown(object sender, EventArgs e)
        {
            // Đặt focus vào một control khác để tránh việc tự động đặt focus vào textbox và hiển thị bàn phím ảo
            this.pictureBox1.Focus();
        }

        // Phương thức kiểm tra chuỗi có phải là tài khoản hợp lệ không
        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-z0-9]{4,16}$");
        }

        // Phương thức kiểm tra chuỗi có phải là email hợp lệ không
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-z0-9]{3,30}@gmail.com$");
        }

        // Xử lý sự kiện click vào nút "Thoát"
        private void btThoat_Click(object sender, EventArgs e)
        {
            // Hiển thị form đăng nhập và ẩn form đăng ký
            DangNhap dangNhapForm = new DangNhap();
            dangNhapForm.Show();
            this.Hide();
        }

        Modify modify = new Modify(); // Khởi tạo đối tượng Modify để thực hiện các thao tác trên cơ sở dữ liệu

        // Xử lý sự kiện click vào nút "Đăng ký"
        private void btDangKy_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các textbox
            string tenTk = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            string xacNhan = txtXacNhan.Text;
            string Email = txtEmail.Text;

            // Kiểm tra các trường thông tin có trống không
            if (tenTk.Trim() == "" || matKhau.Trim() == "" || xacNhan.Trim() == "" || Email.Trim() == "" || tenTk.Trim() == "Tài khoản" || matKhau.Trim() == "Mật khẩu" || xacNhan.Trim() == "Nhập lại mật khẩu" || Email.Trim() == "Email")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!CheckAccount(tenTk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản có độ dài 4-16 ký tự, với các ký tự a-z, 0-9", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!CheckAccount(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu có độ dài 4-16 ký tự, với các ký tự a-z, 0-9", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (xacNhan != matKhau)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!CheckEmail(Email))
            {
                MessageBox.Show("Vui lòng nhập email với định dạng username@gmail.com", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (modify.TaiKhoans("Select * From TaiKhoan where Email = '" + Email + "'").Count() != 0)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng dùng email khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    // Thực hiện câu lệnh SQL để thêm tài khoản vào cơ sở dữ liệu
                    string query = "Insert into TaiKhoan values ('" + tenTk + "', '" + matKhau + "', '" + Email + "')";
                    modify.Command(query);
                    MessageBox.Show("Đăng ký tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                    // Hiển thị form đăng nhập sau khi đăng ký thành công
                    DangNhap dangNhapForm = new DangNhap();
                    dangNhapForm.Show();
                }
                catch
                {
                    MessageBox.Show("Tên tài khoản này đã được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Xử lý sự kiện khi textbox "txtTaiKhoan" nhận focus
        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == " Tài khoản")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }

        // Xử lý sự kiện khi textbox "txtTaiKhoan" mất focus
        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                txtTaiKhoan.Text = " Tài khoản";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }

        // Xử lý sự kiện khi textbox "txtMatKhau" nhận focus
        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == " Mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.PasswordChar = '*'; // Đặt PasswordChar khi nhập
            }
        }

        // Xử lý sự kiện khi textbox "txtMatKhau" mất focus
        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = " Mật khẩu";
                txtMatKhau.ForeColor = Color.Black;
                txtMatKhau.PasswordChar = '\0'; // Đặt lại PasswordChar khi rời khỏi
            }
        }

        // Xử lý sự kiện khi textbox "txtXacNhan" nhận focus
        private void txtXacNhan_Enter(object sender, EventArgs e)
        {
            if (txtXacNhan.Text == " Nhập lại mật khẩu")
            {
                txtXacNhan.Text = "";
                txtXacNhan.ForeColor = Color.Black;
                txtXacNhan.PasswordChar = '*';
            }
        }

        // Xử lý sự kiện khi textbox "txtXacNhan" mất focus
        private void txtXacNhan_Leave(object sender, EventArgs e)
        {
            if (txtXacNhan.Text == "")
            {
                txtXacNhan.Text = " Nhập lại mật khẩu";
                txtXacNhan.ForeColor = Color.Black;
                txtXacNhan.PasswordChar = '\0';
            }
        }

        // Xử lý sự kiện khi textbox "txtEmail" nhận focus
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == " Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        // Xử lý sự kiện khi textbox "txtEmail" mất focus
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = " Email";
                txtEmail.ForeColor = Color.Black;
            }
        }
    }
}
