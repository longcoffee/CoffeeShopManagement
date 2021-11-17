
namespace CoffeeShopManagement
{
    partial class formTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panInfotableTablemanager = new System.Windows.Forms.Panel();
            this.lvwdgvInfortableTablemanager = new System.Windows.Forms.ListView();
            this.columnIdFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCountFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPriceFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotalPriceFood = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panOptionTablemanager = new System.Windows.Forms.Panel();
            this.cbbSwitchtableTablemanager = new System.Windows.Forms.ComboBox();
            this.bttSwitchtableTablemanager = new System.Windows.Forms.Button();
            this.nmrDiscountTablemanager = new System.Windows.Forms.NumericUpDown();
            this.bttDiscountTablemanager = new System.Windows.Forms.Button();
            this.bttPayTablemanager = new System.Windows.Forms.Button();
            this.panelAddfoodTablemanager = new System.Windows.Forms.Panel();
            this.nmrFoodcountTablemanager = new System.Windows.Forms.NumericUpDown();
            this.bttAddFoodTablemanager = new System.Windows.Forms.Button();
            this.cbbFoodTablemanager = new System.Windows.Forms.ComboBox();
            this.cbbCategoryTablemanager = new System.Windows.Forms.ComboBox();
            this.panViewtableTablemanager = new System.Windows.Forms.FlowLayoutPanel();
            this.flpViewtableTablemanager = new System.Windows.Forms.FlowLayoutPanel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panInfotableTablemanager.SuspendLayout();
            this.panOptionTablemanager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscountTablemanager)).BeginInit();
            this.panelAddfoodTablemanager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFoodcountTablemanager)).BeginInit();
            this.panViewtableTablemanager.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panInfotableTablemanager
            // 
            this.panInfotableTablemanager.Controls.Add(this.lvwdgvInfortableTablemanager);
            this.panInfotableTablemanager.Location = new System.Drawing.Point(394, 99);
            this.panInfotableTablemanager.Name = "panInfotableTablemanager";
            this.panInfotableTablemanager.Size = new System.Drawing.Size(383, 294);
            this.panInfotableTablemanager.TabIndex = 2;
            // 
            // lvwdgvInfortableTablemanager
            // 
            this.lvwdgvInfortableTablemanager.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdFood,
            this.columnCountFood,
            this.columnPriceFood,
            this.columnTotalPriceFood});
            this.lvwdgvInfortableTablemanager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwdgvInfortableTablemanager.GridLines = true;
            this.lvwdgvInfortableTablemanager.HideSelection = false;
            this.lvwdgvInfortableTablemanager.Location = new System.Drawing.Point(4, 4);
            this.lvwdgvInfortableTablemanager.Name = "lvwdgvInfortableTablemanager";
            this.lvwdgvInfortableTablemanager.Size = new System.Drawing.Size(376, 284);
            this.lvwdgvInfortableTablemanager.TabIndex = 0;
            this.lvwdgvInfortableTablemanager.UseCompatibleStateImageBehavior = false;
            this.lvwdgvInfortableTablemanager.View = System.Windows.Forms.View.Details;
            // 
            // columnIdFood
            // 
            this.columnIdFood.Text = "Tên món";
            this.columnIdFood.Width = 127;
            // 
            // columnCountFood
            // 
            this.columnCountFood.Text = "Số lượng";
            this.columnCountFood.Width = 81;
            // 
            // columnPriceFood
            // 
            this.columnPriceFood.Text = "Giá";
            this.columnPriceFood.Width = 69;
            // 
            // columnTotalPriceFood
            // 
            this.columnTotalPriceFood.Text = "Thành tiền";
            this.columnTotalPriceFood.Width = 93;
            // 
            // panOptionTablemanager
            // 
            this.panOptionTablemanager.Controls.Add(this.labTotalPrice);
            this.panOptionTablemanager.Controls.Add(this.txbTotalPrice);
            this.panOptionTablemanager.Controls.Add(this.cbbSwitchtableTablemanager);
            this.panOptionTablemanager.Controls.Add(this.bttSwitchtableTablemanager);
            this.panOptionTablemanager.Controls.Add(this.nmrDiscountTablemanager);
            this.panOptionTablemanager.Controls.Add(this.bttDiscountTablemanager);
            this.panOptionTablemanager.Controls.Add(this.bttPayTablemanager);
            this.panOptionTablemanager.Location = new System.Drawing.Point(395, 399);
            this.panOptionTablemanager.Name = "panOptionTablemanager";
            this.panOptionTablemanager.Size = new System.Drawing.Size(382, 106);
            this.panOptionTablemanager.TabIndex = 3;
            // 
            // cbbSwitchtableTablemanager
            // 
            this.cbbSwitchtableTablemanager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSwitchtableTablemanager.FormattingEnabled = true;
            this.cbbSwitchtableTablemanager.Location = new System.Drawing.Point(3, 35);
            this.cbbSwitchtableTablemanager.Name = "cbbSwitchtableTablemanager";
            this.cbbSwitchtableTablemanager.Size = new System.Drawing.Size(120, 26);
            this.cbbSwitchtableTablemanager.TabIndex = 5;
            // 
            // bttSwitchtableTablemanager
            // 
            this.bttSwitchtableTablemanager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSwitchtableTablemanager.Location = new System.Drawing.Point(3, 67);
            this.bttSwitchtableTablemanager.Name = "bttSwitchtableTablemanager";
            this.bttSwitchtableTablemanager.Size = new System.Drawing.Size(120, 34);
            this.bttSwitchtableTablemanager.TabIndex = 8;
            this.bttSwitchtableTablemanager.Text = "Chuyển bàn";
            this.bttSwitchtableTablemanager.UseVisualStyleBackColor = true;
            this.bttSwitchtableTablemanager.Click += new System.EventHandler(this.bttSwitchTable_Click);
            // 
            // nmrDiscountTablemanager
            // 
            this.nmrDiscountTablemanager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrDiscountTablemanager.Location = new System.Drawing.Point(129, 35);
            this.nmrDiscountTablemanager.Name = "nmrDiscountTablemanager";
            this.nmrDiscountTablemanager.Size = new System.Drawing.Size(115, 26);
            this.nmrDiscountTablemanager.TabIndex = 5;
            this.nmrDiscountTablemanager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrDiscountTablemanager.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bttDiscountTablemanager
            // 
            this.bttDiscountTablemanager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDiscountTablemanager.Location = new System.Drawing.Point(129, 67);
            this.bttDiscountTablemanager.Name = "bttDiscountTablemanager";
            this.bttDiscountTablemanager.Size = new System.Drawing.Size(115, 34);
            this.bttDiscountTablemanager.TabIndex = 7;
            this.bttDiscountTablemanager.Text = "Giảm giá";
            this.bttDiscountTablemanager.UseVisualStyleBackColor = true;
            this.bttDiscountTablemanager.Click += new System.EventHandler(this.bttDiscount_Click);
            // 
            // bttPayTablemanager
            // 
            this.bttPayTablemanager.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPayTablemanager.Location = new System.Drawing.Point(250, 35);
            this.bttPayTablemanager.Name = "bttPayTablemanager";
            this.bttPayTablemanager.Size = new System.Drawing.Size(129, 66);
            this.bttPayTablemanager.TabIndex = 5;
            this.bttPayTablemanager.Text = "Thanh toán";
            this.bttPayTablemanager.UseVisualStyleBackColor = true;
            this.bttPayTablemanager.Click += new System.EventHandler(this.bttPay_Click);
            // 
            // panelAddfoodTablemanager
            // 
            this.panelAddfoodTablemanager.Controls.Add(this.nmrFoodcountTablemanager);
            this.panelAddfoodTablemanager.Controls.Add(this.bttAddFoodTablemanager);
            this.panelAddfoodTablemanager.Controls.Add(this.cbbFoodTablemanager);
            this.panelAddfoodTablemanager.Controls.Add(this.cbbCategoryTablemanager);
            this.panelAddfoodTablemanager.Location = new System.Drawing.Point(394, 27);
            this.panelAddfoodTablemanager.Name = "panelAddfoodTablemanager";
            this.panelAddfoodTablemanager.Size = new System.Drawing.Size(383, 66);
            this.panelAddfoodTablemanager.TabIndex = 4;
            // 
            // nmrFoodcountTablemanager
            // 
            this.nmrFoodcountTablemanager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrFoodcountTablemanager.Location = new System.Drawing.Point(251, 4);
            this.nmrFoodcountTablemanager.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmrFoodcountTablemanager.Name = "nmrFoodcountTablemanager";
            this.nmrFoodcountTablemanager.Size = new System.Drawing.Size(129, 26);
            this.nmrFoodcountTablemanager.TabIndex = 4;
            this.nmrFoodcountTablemanager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrFoodcountTablemanager.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bttAddFoodTablemanager
            // 
            this.bttAddFoodTablemanager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAddFoodTablemanager.Location = new System.Drawing.Point(251, 36);
            this.bttAddFoodTablemanager.Name = "bttAddFoodTablemanager";
            this.bttAddFoodTablemanager.Size = new System.Drawing.Size(129, 26);
            this.bttAddFoodTablemanager.TabIndex = 2;
            this.bttAddFoodTablemanager.Text = "Thêm món";
            this.bttAddFoodTablemanager.UseVisualStyleBackColor = true;
            this.bttAddFoodTablemanager.Click += new System.EventHandler(this.bttAddCategory_Click);
            // 
            // cbbFoodTablemanager
            // 
            this.cbbFoodTablemanager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFoodTablemanager.FormattingEnabled = true;
            this.cbbFoodTablemanager.Location = new System.Drawing.Point(3, 36);
            this.cbbFoodTablemanager.Name = "cbbFoodTablemanager";
            this.cbbFoodTablemanager.Size = new System.Drawing.Size(242, 26);
            this.cbbFoodTablemanager.TabIndex = 1;
            // 
            // cbbCategoryTablemanager
            // 
            this.cbbCategoryTablemanager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategoryTablemanager.FormattingEnabled = true;
            this.cbbCategoryTablemanager.Location = new System.Drawing.Point(4, 4);
            this.cbbCategoryTablemanager.Name = "cbbCategoryTablemanager";
            this.cbbCategoryTablemanager.Size = new System.Drawing.Size(241, 26);
            this.cbbCategoryTablemanager.TabIndex = 0;
            // 
            // panViewtableTablemanager
            // 
            this.panViewtableTablemanager.AutoScroll = true;
            this.panViewtableTablemanager.Controls.Add(this.flpViewtableTablemanager);
            this.panViewtableTablemanager.Location = new System.Drawing.Point(12, 27);
            this.panViewtableTablemanager.Name = "panViewtableTablemanager";
            this.panViewtableTablemanager.Size = new System.Drawing.Size(376, 478);
            this.panViewtableTablemanager.TabIndex = 5;
            // 
            // flpViewtableTablemanager
            // 
            this.flpViewtableTablemanager.Location = new System.Drawing.Point(3, 3);
            this.flpViewtableTablemanager.Name = "flpViewtableTablemanager";
            this.flpViewtableTablemanager.Size = new System.Drawing.Size(362, 471);
            this.flpViewtableTablemanager.TabIndex = 0;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.ForeColor = System.Drawing.Color.Gold;
            this.txbTotalPrice.Location = new System.Drawing.Point(250, 4);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(129, 26);
            this.txbTotalPrice.TabIndex = 9;
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.labTotalPrice.Location = new System.Drawing.Point(157, 7);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(87, 19);
            this.labTotalPrice.TabIndex = 10;
            this.labTotalPrice.Text = "Tổng tiền:";
            // 
            // formTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 517);
            this.Controls.Add(this.panViewtableTablemanager);
            this.Controls.Add(this.panelAddfoodTablemanager);
            this.Controls.Add(this.panOptionTablemanager);
            this.Controls.Add(this.panInfotableTablemanager);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý tiệm Cà phê";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panInfotableTablemanager.ResumeLayout(false);
            this.panOptionTablemanager.ResumeLayout(false);
            this.panOptionTablemanager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscountTablemanager)).EndInit();
            this.panelAddfoodTablemanager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrFoodcountTablemanager)).EndInit();
            this.panViewtableTablemanager.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panInfotableTablemanager;
        private System.Windows.Forms.Panel panOptionTablemanager;
        private System.Windows.Forms.Button bttSwitchtableTablemanager;
        private System.Windows.Forms.NumericUpDown nmrDiscountTablemanager;
        private System.Windows.Forms.Button bttDiscountTablemanager;
        private System.Windows.Forms.Button bttPayTablemanager;
        private System.Windows.Forms.Panel panelAddfoodTablemanager;
        private System.Windows.Forms.NumericUpDown nmrFoodcountTablemanager;
        private System.Windows.Forms.Button bttAddFoodTablemanager;
        private System.Windows.Forms.ComboBox cbbFoodTablemanager;
        private System.Windows.Forms.ComboBox cbbCategoryTablemanager;
        private System.Windows.Forms.FlowLayoutPanel panViewtableTablemanager;
        private System.Windows.Forms.ComboBox cbbSwitchtableTablemanager;
        private System.Windows.Forms.ListView lvwdgvInfortableTablemanager;
        private System.Windows.Forms.FlowLayoutPanel flpViewtableTablemanager;
        private System.Windows.Forms.ColumnHeader columnIdFood;
        private System.Windows.Forms.ColumnHeader columnCountFood;
        private System.Windows.Forms.ColumnHeader columnPriceFood;
        private System.Windows.Forms.ColumnHeader columnTotalPriceFood;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label labTotalPrice;
    }
}