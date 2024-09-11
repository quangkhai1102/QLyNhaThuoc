using medicine_store.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace medicine_store.dao
{
    internal class InvoiceDAO
    {
        private readonly string connectionString;
        private static readonly Random random = new Random();

        public InvoiceDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        private static string GenerateID()
        {
            int randomNum = random.Next(1, 1000);
            return "INV" + randomNum.ToString("000");
        }

        // Trả về invoice_id để sử dụng sau này
        public string AddInvoice(Invoice invoice)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryAddInvoice = "INSERT INTO invoice (invoice_id, customer_id, admin_id, invoice_date, total_amount) OUTPUT INSERTED.invoice_id VALUES (@id, @customer_id, @admin_id, @date, @total)";
                SqlCommand cmdAddInvoice = new SqlCommand(queryAddInvoice, connection);

                cmdAddInvoice.Parameters.AddWithValue("@id", GenerateID());
                cmdAddInvoice.Parameters.AddWithValue("@customer_id", invoice.customerID);
                cmdAddInvoice.Parameters.AddWithValue("@admin_id", invoice.adminID);
                cmdAddInvoice.Parameters.AddWithValue("@date", invoice.date);
                cmdAddInvoice.Parameters.AddWithValue("@total", invoice.totalAmount);

                try
                {
                    connection.Open();
                    // Thực hiện truy vấn và lấy ID của hóa đơn vừa tạo
                    object result = cmdAddInvoice.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}