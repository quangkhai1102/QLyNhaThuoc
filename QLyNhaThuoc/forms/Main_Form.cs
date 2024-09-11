using medicine_store.dao;
using medicine_store.model;
using medicine_store.util;
using QLyNhaThuoc;
using QLyNhaThuoc.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medicine_store.forms
{
    public partial class Main_Form : Form
    {
        private static readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Visual Studio\Code\QLyNhaThuoc\Database1.mdf"";Integrated Security=True";
        MedicineDAO medicineDAO = new MedicineDAO(connectionString);
        CustomerDAO customerDAO = new CustomerDAO(connectionString);
        InvoiceDAO invoiceDAO = new InvoiceDAO(connectionString);
        InvoiceDetailDAO invoiceDetailDAO = new InvoiceDetailDAO(connectionString);
        private ContextMenuStrip userContextMenu;
        private DataTable selectedItemsTable;
        public Main_Form()
        {
            InitializeComponent();
            InitializeUserContextMenu();
            DisplayLoggedInUser(SessionManager.LoggedInUser);
            LoadDataToDataGridView();
            InitializeSelectedItemsTable();
        }

        private void InitializeSelectedItemsTable()
        {
            selectedItemsTable = new DataTable();
            selectedItemsTable.Columns.Add("Mã thuốc");
            selectedItemsTable.Columns.Add("Tên thuốc");
            selectedItemsTable.Columns.Add("Số lượng", typeof(int));
            selectedItemsTable.Columns.Add("Đơn giá", typeof(decimal));
            selectedItemsTable.Columns.Add("Tổng giá trị", typeof(double)); // Chỉnh sửa thành typeof(double)
        }


        private void InitializeUserContextMenu()
        {
            // Tạo mới context menu
            userContextMenu = new ContextMenuStrip();

            // Tạo và thêm các item vào context menu
            ToolStripMenuItem changePasswordItem = new ToolStripMenuItem("Đổi mật khẩu");
            ToolStripMenuItem signOutItem = new ToolStripMenuItem("Đăng xuất");
            ToolStripMenuItem exitItem = new ToolStripMenuItem("Thoát");

            // Thêm sự kiện click cho các item
            changePasswordItem.Click += ChangePasswordItem_Click;
            signOutItem.Click += SignOutItem_Click;
            exitItem.Click += ExitItem_Click;

            // Thêm các item vào context menu
            userContextMenu.Items.AddRange(new ToolStripItem[] { changePasswordItem, signOutItem, exitItem });
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayLoggedInUser(string userName)
        {
            // Tạo và cấu hình toolStripStatusLabel
            ToolStripStatusLabel userStatusLabel = new ToolStripStatusLabel();
            userStatusLabel.Text = userName;
            userStatusLabel.IsLink = true; // Đặt là link để có thể nhấn vào
            userStatusLabel.Click += UserStatusLabel_Click;

            // Thêm vào toolStrip
            statusStrip.Items.Add(userStatusLabel);
        }

        private void UserStatusLabel_Click(object sender, EventArgs e)
        {
            // Hiển thị context menu khi nhấn vào label
            userContextMenu.Show(Cursor.Position);
        }

        private void ChangePasswordItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMatKhau_Form doiMatKhau_Form = new DoiMatKhau_Form();
            doiMatKhau_Form.ShowDialog();
        }

        private void SignOutItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }

        private void LoadDataToDataGridView()
        {
            try
            {
                // Lấy dữ liệu từ database
                DataTable dataTable = medicineDAO.getAllData();

                // Gán dữ liệu vào dataGridView
                allData.DataSource = dataTable;

                // Đổi tên các cột để hiển thị
                allData.Columns["medicine_id"].HeaderText = "Mã thuốc";
                allData.Columns["medicine_name"].HeaderText = "Tên thuốc";
                allData.Columns["description"].HeaderText = "Công dụng";
                allData.Columns["manufacturer"].HeaderText = "Hãng sản xuất";
                allData.Columns["price"].HeaderText = "Giá";
                allData.Columns["packaging"].HeaderText = "Đóng gói";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void allData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Sự kiện này sẽ được gọi mỗi khi có sự thay đổi trong việc chọn hàng trên dataGridView1
        private void allData_SelectionChanged(object sender, EventArgs e)
        {
            // Tạo một DataTable mới để chứa dữ liệu của các hàng được chọn
            DataTable selectedItemsTable = new DataTable();

            // Thêm các cột vào selectedItemsTable tương ứng với cấu trúc của dataGridView1
            foreach (DataGridViewColumn column in allData.Columns)
            {
                selectedItemsTable.Columns.Add(column.Name, column.ValueType);
                selectedItemsTable.Columns[column.Name].Caption = column.HeaderText;
            }

            // Lặp qua mỗi hàng được chọn trong dataGridView1
            foreach (DataGridViewRow row in allData.SelectedRows)
            {
                DataRow newRow = selectedItemsTable.NewRow();

                // Lặp qua mỗi cột trong hàng để lấy giá trị
                foreach (DataGridViewColumn col in allData.Columns)
                {
                    newRow[col.Name] = row.Cells[col.Name].Value;
                }

                // Thêm hàng mới vào DataTable
                selectedItemsTable.Rows.Add(newRow);
            }

            // Gán DataTable làm DataSource cho dataGridView mới
            selectedItems.DataSource = selectedItemsTable;
        }

        // Trong sự kiện CellClick của dataGridView allData
        private void allData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có chọn ô hợp lệ (không phải là header)
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin của item được chọn
                string selectedMedicineId = allData.Rows[e.RowIndex].Cells["medicine_id"].Value.ToString();
                string selectedMedicineName = allData.Rows[e.RowIndex].Cells["medicine_name"].Value.ToString();
                decimal price = Convert.ToDecimal(allData.Rows[e.RowIndex].Cells["price"].Value);

                // Tìm xem item đã có trong selectedItems chưa
                DataRow[] existingItems = selectedItemsTable.Select($"[Mã thuốc] = '{selectedMedicineId}'");
                if (existingItems.Length > 0)
                {
                    // Nếu item đã tồn tại, tăng quantity và tính lại sub_total
                    DataRow row = existingItems[0];
                    int quantity = Convert.ToInt32(row["Số lượng"]) + 1;
                    row["Số lượng"] = quantity;
                    row["Tổng giá trị"] = quantity * price;
                }
                else
                {
                    // Nếu item chưa tồn tại, thêm mới vào selectedItems
                    DataRow newRow = selectedItemsTable.NewRow();
                    newRow["Mã thuốc"] = selectedMedicineId;
                    newRow["Tên thuốc"] = selectedMedicineName;
                    newRow["Số lượng"] = 1; // Bắt đầu từ 1
                    newRow["Đơn giá"] = price;
                    newRow["Tổng giá trị"] = price; // Đơn giá * số lượng (ở đây là 1)
                    selectedItemsTable.Rows.Add(newRow);
                }

                // Cập nhật DataSource để phản ánh thay đổi trên UI
                selectedItems.DataSource = typeof(DataTable);
                selectedItems.DataSource = selectedItemsTable;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            selectedItemsTable.Clear();
        }

        // xử lý sự kiện nhấn nút tạo hoá đơn
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string customerName = customerName_tb.Text;
            string customerPhone = customerPhone_tb.Text;
            string customerAge = customerAge_tb.Text;
            if (string.IsNullOrEmpty(customerAge) || string.IsNullOrEmpty(customerPhone) || string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int age;
            try
            {
                age = int.Parse(customerAge);
                if (age < 0 || age > 100)
                {
                    MessageBox.Show("Tuổi khách hàng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Tuổi khách hàng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm khách hàng mới vào cơ sở dữ liệu và lấy ID của khách hàng vừa thêm
            string customerID = customerDAO.AddCustomer(new Customer(customerName, age, customerPhone));
            if (string.IsNullOrEmpty(customerID))
            {
                MessageBox.Show("Không thể thêm khách hàng mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedItemsTable.Rows.Count <= 0)
            {
                MessageBox.Show("Không có loại thuốc nào được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tính toán tổng giá trị của các mặt hàng được chọn
            double total = CalcTotalAmount(selectedItemsTable);

            // Thêm hoá đơn mới vào cơ sở dữ liệu và lấy ID của hoá đơn vừa thêm
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string invoiceID = invoiceDAO.AddInvoice(new Invoice(customerID, SessionManager.loggedInAdminID, date, total));

            // Thêm chi tiết hoá đơn với từng loại thuốc được chọn
            foreach (DataRow row in selectedItemsTable.Rows)
            {
                string medicineID = row["Mã thuốc"].ToString();
                int quantity = int.Parse(row["Số lượng"].ToString());
                decimal unitPrice = decimal.Parse(row["Đơn giá"].ToString());
                double subtotal = double.Parse(row["Tổng giá trị"].ToString());
                bool result = invoiceDetailDAO.addInvoiceDetail(new InvoiceDetail(invoiceID, medicineID, quantity, unitPrice, subtotal));
                if (!result)
                {
                    MessageBox.Show("Không thể thêm chi tiết hoá đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Sau khi đã thêm thành công thì làm mới dữ liệu của các ô input
            selectedItemsTable.Clear();
            customerName_tb.Clear();
            customerPhone_tb.Clear();
            customerAge_tb.Clear();


        }

        private static double CalcTotalAmount(DataTable selectedItemsTable)
        {
            // Sử dụng phương thức Compute của DataTable để tính tổng giá trị của cột "Tổng giá trị"
            object sumObject = selectedItemsTable.Compute("SUM([Tổng giá trị])", "");

            // Kiểm tra xem giá trị tính toán có phải là số thực không
            if (sumObject != DBNull.Value && sumObject is double)
                return (double)sumObject;
            else
                return 0; // Trả về 0 nếu không tính được tổng giá trị hoặc giá trị không hợp lệ
        }
    }
}
