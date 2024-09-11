using medicine_store.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicine_store.dao
{
    internal class InvoiceDetailDAO
    {
        private readonly string connectionString;
        private static Random random = new Random();

        public InvoiceDetailDAO (string connectionString)
        {
            this.connectionString = connectionString;
        }

        private static string genID()
        {
            int randomNum = random.Next(1, 1000);
            return "INVD" + randomNum.ToString("000");
        }

        public bool addInvoiceDetail(InvoiceDetail invoiceDetail)
        {
            using (SqlConnection conn =  new SqlConnection(connectionString))
            {
                string queryAddInvoiceDetail = "INSERT INTO invoice_detail VALUES (@id, @invoice_id, @medicine_id, @quantity, @unit_price, @subtotal)";
                SqlCommand cmd = new SqlCommand(queryAddInvoiceDetail, conn);
                cmd.Parameters.AddWithValue("@id", genID());
                cmd.Parameters.AddWithValue("@invoice_id", invoiceDetail.invoiceID);
                cmd.Parameters.AddWithValue("@medicine_id", invoiceDetail.medicineID);
                cmd.Parameters.AddWithValue("@quantity", invoiceDetail.quantity);
                cmd.Parameters.AddWithValue("@unit_price", invoiceDetail.unitPrice);
                cmd.Parameters.AddWithValue("@subtotal", invoiceDetail.subtotal);
                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteNonQuery();
                    return count > 0;
                }
                catch
                {
                    return false;
                }

               
            }
        }
    }
}
