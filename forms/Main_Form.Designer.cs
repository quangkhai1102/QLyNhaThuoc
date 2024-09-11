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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.ToolStrip();
            this.allData = new System.Windows.Forms.DataGridView();
            this.selectedItems = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerName_tb = new System.Windows.Forms.TextBox();
            this.customerAge_tb = new System.Windows.Forms.TextBox();
            this.customerPhone_tb = new System.Windows.Forms.TextBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.find_tb = new System.Windows.Forms.TextBox();
            this.find_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaToolStripMenuItem,
            this.xemToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1292, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmThuốcToolStripMenuItem});
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // thêmThuốcToolStripMenuItem
            // 
            this.thêmThuốcToolStripMenuItem.Name = "thêmThuốcToolStripMenuItem";
            this.thêmThuốcToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.thêmThuốcToolStripMenuItem.Text = "Thêm thuốc";
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.xemToolStripMenuItem.Text = "Xem";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // statusStrip
            // 
            this.statusStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(1172, 31);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(111, 25);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "toolStrip1";
            // 
            // allData
            // 
            this.allData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allData.Location = new System.Drawing.Point(46, 94);
            this.allData.Name = "allData";
            this.allData.ReadOnly = true;
            this.allData.RowHeadersWidth = 51;
            this.allData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allData.Size = new System.Drawing.Size(1194, 239);
            this.allData.TabIndex = 2;
            // 
            // selectedItems
            // 
            this.selectedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedItems.Location = new System.Drawing.Point(46, 387);
            this.selectedItems.Name = "selectedItems";
            this.selectedItems.RowHeadersWidth = 51;
            this.selectedItems.Size = new System.Drawing.Size(1194, 188);
            this.selectedItems.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(46, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách thuốc đã chọn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(46, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(46, 627);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tuổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(46, 662);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số điện thoại khách hàng";
            // 
            // customerName_tb
            // 
            this.customerName_tb.Location = new System.Drawing.Point(288, 590);
            this.customerName_tb.Name = "customerName_tb";
            this.customerName_tb.Size = new System.Drawing.Size(252, 23);
            this.customerName_tb.TabIndex = 8;
            // 
            // customerAge_tb
            // 
            this.customerAge_tb.Location = new System.Drawing.Point(288, 626);
            this.customerAge_tb.Name = "customerAge_tb";
            this.customerAge_tb.Size = new System.Drawing.Size(252, 23);
            this.customerAge_tb.TabIndex = 9;
            // 
            // customerPhone_tb
            // 
            this.customerPhone_tb.Location = new System.Drawing.Point(288, 661);
            this.customerPhone_tb.Name = "customerPhone_tb";
            this.customerPhone_tb.Size = new System.Drawing.Size(252, 23);
            this.customerPhone_tb.TabIndex = 10;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.confirm_btn.Location = new System.Drawing.Point(1113, 585);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(127, 42);
            this.confirm_btn.TabIndex = 11;
            this.confirm_btn.Text = "Tạo hoá đơn";
            this.confirm_btn.UseVisualStyleBackColor = true;
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.clear_btn.Location = new System.Drawing.Point(962, 585);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(127, 42);
            this.clear_btn.TabIndex = 13;
            this.clear_btn.Text = "Xoá tất cả";
            this.clear_btn.UseVisualStyleBackColor = true;
            // 
            // find_tb
            // 
            this.find_tb.Location = new System.Drawing.Point(734, 58);
            this.find_tb.Name = "find_tb";
            this.find_tb.Size = new System.Drawing.Size(252, 23);
            this.find_tb.TabIndex = 15;
            // 
            // find_btn
            // 
            this.find_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.find_btn.Location = new System.Drawing.Point(1008, 49);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(127, 42);
            this.find_btn.TabIndex = 16;
            this.find_btn.Text = "Tìm thuốc";
            this.find_btn.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 694);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.find_tb);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.customerPhone_tb);
            this.Controls.Add(this.customerAge_tb);
            this.Controls.Add(this.customerName_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedItems);
            this.Controls.Add(this.allData);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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