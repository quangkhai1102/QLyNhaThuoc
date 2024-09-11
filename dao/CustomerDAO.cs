using medicine_store.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicine_store.dao
{
    internal class CustomerDAO
    {
        private readonly string connectionString;
        private static readonly Random random = new Random();

        public CustomerDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public string AddCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string queryCheckUserExist = "SELECT COUNT(*) FROM customer WHERE phone = @phone";
                SqlCommand cmdCheckUserExist = new SqlCommand(queryCheckUserExist, conn);
                cmdCheckUserExist.Parameters.AddWithValue("@phone", customer.phone);

                try
                {
                    conn.Open();
                    int count = (int)cmdCheckUserExist.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Số điện thoại đã được đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return null;
                    }

                    // Kiểm tra độ dài của số điện thoại, ví dụ: 10 chữ số
                    if (customer.phone.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                    string queryAddCustomer = "INSERT INTO customer (customer_id, full_name, age, phone) OUTPUT INSERTED.customer_id VALUES (@id, @name, @age, @phone);";
                    SqlCommand cmdAddCustomer = new SqlCommand(queryAddCustomer, conn);
                    cmdAddCustomer.Parameters.AddWithValue("@id", GenerateID());
                    cmdAddCustomer.Parameters.AddWithValue("@name", customer.fullName);
                    cmdAddCustomer.Parameters.AddWithValue("@age", customer.age);
                    cmdAddCustomer.Parameters.AddWithValue("@phone", customer.phone);

                    object result = cmdAddCustomer.ExecuteScalar();
                    if (result != null)
                    {
                        string newCustomerId = result.ToString();
                        return newCustomerId;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        private static string GenerateID()
        {
            int randomNum = random.Next(0, 10000);
            return "CUS" + randomNum.ToString("D4");
        }
    }
}