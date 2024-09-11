using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Dùng để sử dụng các lớp để tương tác với cơ sở dữ liệu SQL Server từ ứng dụng C#

namespace QLyNhaThuoc
{
    internal class Connection // Định nghĩa lớp Connection, chỉ có thể truy cập từ trong cùng một assembly
    {
        // Chuỗi kết nối đến cơ sở dữ liệu SQL Server
        private static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\CNTT NĂM 2\Lập Trình Trên DESKTOP\QLyNhaThuoc (1)\Database1.mdf"";Integrated Security=True";
        // Phương thức trả về một đối tượng SqlConnection đã được cấu hình sẵn để kết nối đến cơ sở dữ liệu
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection); // Trả về một đối tượng SqlConnection được khởi tạo với chuỗi kết nối
        }
    }
}
