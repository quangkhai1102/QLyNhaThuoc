using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicine_store.dao
{
    internal class MedicineDAO
    {
        private readonly string connectionString;
        private static Random random = new Random();

        public MedicineDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Lấy tất cả thuốc từ cơ sở dữ liệu và hiển thị lên dataGridView
        public DataTable getAllData()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM medicine";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }       
    }
}
