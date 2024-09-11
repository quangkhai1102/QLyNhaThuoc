using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Sử dụng namespace System.Data.SqlClient cho tương tác với cơ sở dữ liệu SQL Server từ ứng dụng C#

namespace QLyNhaThuoc
{
    internal class Modify // Lớp Modify chỉ có thể truy cập từ trong cùng một assembly
    {
        public Modify()
        {
            // Constructor mặc định không có tham số
        }

        SqlCommand sqlCommand; // Biến để thực hiện các câu lệnh insert, update, delete,...
        SqlDataReader dataReader; // Biến để đọc dữ liệu từ bảng

        // Phương thức truy vấn dữ liệu từ cơ sở dữ liệu và trả về danh sách các đối tượng TaiKhoan
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>(); // Danh sách để lưu trữ các tài khoản

            using (SqlConnection sqlConnection = Connection.GetSqlConnection()) // Sử dụng SqlConnection từ lớp Connection
            {
                sqlConnection.Open(); // Mở kết nối đến cơ sở dữ liệu
                sqlCommand = new SqlCommand(query, sqlConnection); // Tạo đối tượng SqlCommand với câu truy vấn và kết nối đã cho

                dataReader = sqlCommand.ExecuteReader(); // Thực thi câu truy vấn và lưu kết quả vào SqlDataReader

                while (dataReader.Read()) // Đọc từng dòng kết quả
                {
                    taiKhoans.Add(new TaiKhoan(dataReader.GetString(0), dataReader.GetString(1))); // Thêm một đối tượng TaiKhoan mới vào danh sách
                }

                sqlConnection.Close(); // Đóng kết nối đến cơ sở dữ liệu sau khi sử dụng
            }

            return taiKhoans; // Trả về danh sách các tài khoản
        }

        // Phương thức thực hiện câu lệnh truy vấn không trả về kết quả (insert, update, delete)
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection()) // Sử dụng SqlConnection từ lớp Connection
            {
                sqlConnection.Open(); // Mở kết nối đến cơ sở dữ liệu
                sqlCommand = new SqlCommand(query, sqlConnection); // Tạo đối tượng SqlCommand với câu truy vấn và kết nối đã cho

                sqlCommand.ExecuteNonQuery(); // Thực thi câu lệnh không trả về kết quả

                sqlConnection.Close(); // Đóng kết nối đến cơ sở dữ liệu sau khi sử dụng
            }
        }
    }
}
