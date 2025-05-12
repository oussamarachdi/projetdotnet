namespace StockManagement
{
    partial class Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSales;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtStockAvailable;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtSaleDate;


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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.cmbItem = new ComboBox();
            label14 = new Label();
            this.dgvSales = new Guna.UI2.WinForms.Guna2DataGridView();
            label12 = new Label();
            this.btnExport = new Button();
            this.btnSell = new Button();
            label11 = new Label();
            this.txtQuantity = new TextBox();
            label10 = new Label();
            this.txtStockAvailable = new TextBox();
            label9 = new Label();
            this.txtUnitPrice = new TextBox();
            label8 = new Label();
            label7 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            this.cmbCustomer = new ComboBox();
            this.dtSaleDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            txtTotal = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)this.dgvSales).BeginInit();
            SuspendLayout();
            // 
            // cmbItem
            // 
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new Point(359, 68);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new Size(258, 26);
            this.cmbItem.TabIndex = 37;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(41, 6);
            label14.Name = "label14";
            label14.Size = new Size(169, 18);
            label14.TabIndex = 36;
            label14.Text = " Sales Management";
            label14.Click += label14_Click;
            // 
            // dgvSales
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            this.dgvSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            this.dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSales.ColumnHeadersHeight = 4;
            this.dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            this.dgvSales.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSales.GridColor = Color.FromArgb(231, 229, 255);
            this.dgvSales.Location = new Point(2, 286);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.Size = new Size(1271, 260);
            this.dgvSales.TabIndex = 35;
            this.dgvSales.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            this.dgvSales.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSales.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            this.dgvSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            this.dgvSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            this.dgvSales.ThemeStyle.BackColor = Color.White;
            this.dgvSales.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            this.dgvSales.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            this.dgvSales.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvSales.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dgvSales.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            this.dgvSales.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSales.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvSales.ThemeStyle.ReadOnly = false;
            this.dgvSales.ThemeStyle.RowsStyle.BackColor = Color.White;
            this.dgvSales.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSales.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dgvSales.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            this.dgvSales.ThemeStyle.RowsStyle.Height = 25;
            this.dgvSales.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            this.dgvSales.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(565, 257);
            label12.Name = "label12";
            label12.Size = new Size(88, 18);
            label12.TabIndex = 34;
            label12.Text = "Sales List";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = Color.Teal;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = FlatStyle.Flat;
            this.btnExport.ForeColor = Color.White;
            this.btnExport.Location = new Point(653, 212);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new Size(126, 29);
            this.btnExport.TabIndex = 32;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnSell
            // 
            this.btnSell.BackColor = Color.Teal;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = FlatStyle.Flat;
            this.btnSell.ForeColor = Color.White;
            this.btnSell.Location = new Point(456, 212);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new Size(126, 29);
            this.btnSell.TabIndex = 31;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(359, 122);
            label11.Name = "label11";
            label11.Size = new Size(117, 18);
            label11.TabIndex = 30;
            label11.Text = "Total Amount";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new Point(41, 152);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new Size(258, 27);
            this.txtQuantity.TabIndex = 29;
            this.txtQuantity.TextChanged += this.txtManufacturer_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(938, 39);
            label10.Name = "label10";
            label10.Size = new Size(133, 18);
            label10.TabIndex = 28;
            label10.Text = "Stock Available";
            // 
            // txtStockAvailable
            // 
            this.txtStockAvailable.Location = new Point(938, 67);
            this.txtStockAvailable.Name = "txtStockAvailable";
            this.txtStockAvailable.ReadOnly = true;
            this.txtStockAvailable.Size = new Size(258, 27);
            this.txtStockAvailable.TabIndex = 27;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(653, 39);
            label9.Name = "label9";
            label9.Size = new Size(87, 18);
            label9.TabIndex = 26;
            label9.Text = "Unit Price";
            label9.Click += label9_Click;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new Point(653, 67);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new Size(258, 27);
            this.txtUnitPrice.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(359, 39);
            label8.Name = "label8";
            label8.Size = new Size(47, 18);
            label8.TabIndex = 24;
            label8.Text = "Item";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 39);
            label7.Name = "label7";
            label7.Size = new Size(86, 18);
            label7.TabIndex = 23;
            label7.Text = "Customer";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new Point(40, 68);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new Size(258, 26);
            this.cmbCustomer.TabIndex = 38;
            // 
            // dtSaleDate
            // 
            this.dtSaleDate.Checked = true;
            this.dtSaleDate.CustomizableEdges = customizableEdges3;
            this.dtSaleDate.Font = new Font("Segoe UI", 9F);
            this.dtSaleDate.Format = DateTimePickerFormat.Long;
            this.dtSaleDate.Location = new Point(653, 152);
            this.dtSaleDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtSaleDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtSaleDate.Name = "dtSaleDate";
            this.dtSaleDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.dtSaleDate.Size = new Size(200, 36);
            this.dtSaleDate.TabIndex = 39;
            this.dtSaleDate.Value = new DateTime(2025, 5, 12, 21, 34, 56, 692);
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(359, 152);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(258, 27);
            txtTotal.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 122);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 42;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(653, 122);
            label3.Name = "label3";
            label3.Size = new Size(88, 18);
            label3.TabIndex = 43;
            label3.Text = "Sale Date";
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 548);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTotal);
            Controls.Add(this.dtSaleDate);
            Controls.Add(this.cmbCustomer);
            Controls.Add(this.cmbItem);
            Controls.Add(label14);
            Controls.Add(this.dgvSales);
            Controls.Add(label12);
            Controls.Add(this.btnExport);
            Controls.Add(this.btnSell);
            Controls.Add(label11);
            Controls.Add(this.txtQuantity);
            Controls.Add(label10);
            Controls.Add(this.txtStockAvailable);
            Controls.Add(label9);
            Controls.Add(this.txtUnitPrice);
            Controls.Add(label8);
            Controls.Add(label7);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Sales";
            Text = "Sales";
            Load += Sales_Load;
            ((System.ComponentModel.ISupportInitialize)this.dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategory;
        private Label label14;
        private Guna.UI2.WinForms.Guna2DataGridView dgvItems;
        private Label label12;
        private Button btnDelete;
        private Button btnAddItem;
        private Button btnEdit;
        private Label label11;
        private TextBox txtManufacturer;
        private Label label10;
        private TextBox txtStock;
        private Label label9;
        private TextBox txtPrice;
        private Label label8;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private TextBox txtTotal;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}