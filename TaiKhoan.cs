using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLyNhaThuoc
{
    internal class TaiKhoan // Lớp TaiKhoan chỉ có thể truy cập từ trong cùng một assembly
    {
        private string tenTaiKhoan; // Biến để lưu trữ tên tài khoản
        private string MatKhau; // Biến để lưu trữ mật khẩu

        public TaiKhoan()
        {
            // Constructor mặc định không có tham số
        }

        // Constructor có tham số để khởi tạo đối tượng TaiKhoan với tên tài khoản và mật khẩu được cung cấp
        public TaiKhoan(string tenTaiKhoan, string matKhau)
        {
            this.tenTaiKhoan = tenTaiKhoan; // Gán giá trị của tham số tenTaiKhoan cho biến tenTaiKhoan của đối tượng
            MatKhau = matKhau; // Gán giá trị của tham số matKhau cho biến MatKhau của đối tượng
        }

        // Thuộc tính TenTaiKhoan cho phép đọc và gán giá trị cho biến tenTaiKhoan
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }

        // Thuộc tính MatKhau1 cho phép đọc và gán giá trị cho biến MatKhau
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }

    }
}
