using System.Drawing;
using System.Windows.Forms;

namespace medicine_store.forms
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            chỉnhSửaToolStripMenuItem = new ToolStripMenuItem();
            xemToolStripMenuItem = new ToolStripMenuItem();
            thốngKêToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new ToolStrip();
            allData = new DataGridView();
            selectedItems = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            customerName_tb = new TextBox();
            customerAge_tb = new TextBox();
            customerPhone_tb = new TextBox();
            confirm_btn = new Button();
            clear_btn = new Button();
            find_tb = new TextBox();
            find_btn = new Button();
            thêmThuốcToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)allData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectedItems).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chỉnhSửaToolStripMenuItem, xemToolStripMenuItem, thốngKêToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1292, 31);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            chỉnhSửaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmThuốcToolStripMenuItem });
            chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            chỉnhSửaToolStripMenuItem.Size = new Size(102, 27);
            chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // xemToolStripMenuItem
            // 
            xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            xemToolStripMenuItem.Size = new Size(60, 27);
            xemToolStripMenuItem.Text = "Xem";
            // 
            // thốngKêToolStripMenuItem
            // 
            thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            thốngKêToolStripMenuItem.Size = new Size(99, 27);
            thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // statusStrip
            // 
            statusStrip.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            statusStrip.Dock = DockStyle.None;
            statusStrip.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Location = new Point(1171, 31);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(112, 25);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "toolStrip1";
            // 
            // allData
            // 
            allData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            allData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            allData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allData.Location = new Point(46, 94);
            allData.Name = "allData";
            allData.ReadOnly = true;
            allData.RowHeadersWidth = 51;
            allData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allData.Size = new Size(1194, 239);
            allData.TabIndex = 2;
            allData.CellClick += allData_CellClick;
            allData.CellContentClick += allData_CellContentClick;
            // 
            // selectedItems
            // 
            selectedItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            selectedItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedItems.Location = new Point(46, 387);
            selectedItems.Name = "selectedItems";
            selectedItems.RowHeadersWidth = 51;
            selectedItems.Size = new Size(1194, 188);
            selectedItems.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(46, 361);
            label1.Name = "label1";
            label1.Size = new Size(209, 23);
            label1.TabIndex = 4;
            label1.Text = "Danh sách thuốc đã chọn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(46, 591);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 5;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label3.Location = new Point(46, 627);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 6;
            label3.Text = "Tuổi";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label4.Location = new Point(46, 662);
            label4.Name = "label4";
            label4.Size = new Size(213, 23);
            label4.TabIndex = 7;
            label4.Text = "Số điện thoại khách hàng";
            // 
            // customerName_tb
            // 
            customerName_tb.Location = new Point(288, 590);
            customerName_tb.Name = "customerName_tb";
            customerName_tb.Size = new Size(252, 27);
            customerName_tb.TabIndex = 8;
            // 
            // customerAge_tb
            // 
            customerAge_tb.Location = new Point(288, 626);
            customerAge_tb.Name = "customerAge_tb";
            customerAge_tb.Size = new Size(252, 27);
            customerAge_tb.TabIndex = 9;
            // 
            // customerPhone_tb
            // 
            customerPhone_tb.Location = new Point(288, 661);
            customerPhone_tb.Name = "customerPhone_tb";
            customerPhone_tb.Size = new Size(252, 27);
            customerPhone_tb.TabIndex = 10;
            // 
            // confirm_btn
            // 
            confirm_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            confirm_btn.Location = new Point(1113, 585);
            confirm_btn.Name = "confirm_btn";
            confirm_btn.Size = new Size(127, 42);
            confirm_btn.TabIndex = 11;
            confirm_btn.Text = "Tạo hoá đơn";
            confirm_btn.UseVisualStyleBackColor = true;
            confirm_btn.Click += confirm_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            clear_btn.Location = new Point(962, 585);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(127, 42);
            clear_btn.TabIndex = 13;
            clear_btn.Text = "Xoá tất cả";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // find_tb
            // 
            find_tb.Location = new Point(734, 58);
            find_tb.Name = "find_tb";
            find_tb.Size = new Size(252, 27);
            find_tb.TabIndex = 15;
            // 
            // find_btn
            // 
            find_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            find_btn.Location = new Point(1008, 49);
            find_btn.Name = "find_btn";
            find_btn.Size = new Size(127, 42);
            find_btn.TabIndex = 16;
            find_btn.Text = "Tìm thuốc";
            find_btn.UseVisualStyleBackColor = true;
            // 
            // thêmThuốcToolStripMenuItem
            // 
            thêmThuốcToolStripMenuItem.Name = "thêmThuốcToolStripMenuItem";
            thêmThuốcToolStripMenuItem.Size = new Size(224, 28);
            thêmThuốcToolStripMenuItem.Text = "Thêm thuốc";
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 694);
            Controls.Add(find_btn);
            Controls.Add(find_tb);
            Controls.Add(clear_btn);
            Controls.Add(confirm_btn);
            Controls.Add(customerPhone_tb);
            Controls.Add(customerAge_tb);
            Controls.Add(customerName_tb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(selectedItems);
            Controls.Add(allData);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)allData).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectedItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private ToolStripMenuItem xemToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStrip statusStrip;
        private DataGridView allData;
        private DataGridView selectedItems;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox customerName_tb;
        private TextBox customerAge_tb;
        private TextBox customerPhone_tb;
        private Button confirm_btn;
        private Button clear_btn;
        private TextBox find_tb;
        private Button find_btn;
        private ToolStripMenuItem thêmThuốcToolStripMenuItem;
    }
}