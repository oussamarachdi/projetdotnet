namespace StockManagement
{
    partial class Items
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label7 = new Label();
            txtItem = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtPrice = new TextBox();
            label10 = new Label();
            txtStock = new TextBox();
            label11 = new Label();
            txtManufacturer = new TextBox();
            btnEdit = new Button();
            btnAddItem = new Button();
            btnDelete = new Button();
            label12 = new Label();
            dgvItems = new Guna.UI2.WinForms.Guna2DataGridView();
            label14 = new Label();
            cmbCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 40);
            label7.Name = "label7";
            label7.Size = new Size(47, 18);
            label7.TabIndex = 6;
            label7.Text = "Item";
            label7.Click += label7_Click;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(27, 68);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(258, 27);
            txtItem.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(357, 40);
            label8.Name = "label8";
            label8.Size = new Size(81, 18);
            label8.TabIndex = 8;
            label8.Text = "Category";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(651, 40);
            label9.Name = "label9";
            label9.Size = new Size(47, 18);
            label9.TabIndex = 10;
            label9.Text = "Price";
            label9.Click += label9_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(651, 68);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(258, 27);
            txtPrice.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(936, 40);
            label10.Name = "label10";
            label10.Size = new Size(52, 18);
            label10.TabIndex = 12;
            label10.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(936, 68);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(258, 27);
            txtStock.TabIndex = 11;
            txtStock.TextChanged += textBox4_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(489, 136);
            label11.Name = "label11";
            label11.Size = new Size(114, 18);
            label11.TabIndex = 14;
            label11.Text = "Manufacturer";
            label11.Click += label11_Click;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(480, 158);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(258, 27);
            txtManufacturer.TabIndex = 13;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Teal;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(353, 208);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 29);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.Teal;
            btnAddItem.FlatAppearance.BorderSize = 0;
            btnAddItem.FlatStyle = FlatStyle.Flat;
            btnAddItem.ForeColor = Color.White;
            btnAddItem.Location = new Point(550, 208);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(126, 29);
            btnAddItem.TabIndex = 16;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Teal;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(729, 208);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(126, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(563, 258);
            label12.Name = "label12";
            label12.Size = new Size(92, 18);
            label12.TabIndex = 18;
            label12.Text = "Items List";
            label12.Click += label12_Click;
            // 
            // dgvItems
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvItems.ColumnHeadersHeight = 4;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvItems.GridColor = Color.FromArgb(231, 229, 255);
            dgvItems.Location = new Point(0, 287);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersVisible = false;
            dgvItems.Size = new Size(1271, 260);
            dgvItems.TabIndex = 19;
            dgvItems.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvItems.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvItems.ThemeStyle.BackColor = Color.White;
            dgvItems.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvItems.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvItems.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvItems.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvItems.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvItems.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvItems.ThemeStyle.HeaderStyle.Height = 4;
            dgvItems.ThemeStyle.ReadOnly = false;
            dgvItems.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvItems.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvItems.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvItems.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvItems.ThemeStyle.RowsStyle.Height = 25;
            dgvItems.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvItems.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvItems.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(39, 7);
            label14.Name = "label14";
            label14.Size = new Size(167, 18);
            label14.TabIndex = 20;
            label14.Text = "Items Management";
            label14.Click += label14_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(357, 69);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(258, 26);
            cmbCategory.TabIndex = 21;
            // 
            // Items
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(cmbCategory);
            Controls.Add(label14);
            Controls.Add(dgvItems);
            Controls.Add(label12);
            Controls.Add(btnDelete);
            Controls.Add(btnAddItem);
            Controls.Add(btnEdit);
            Controls.Add(label11);
            Controls.Add(txtManufacturer);
            Controls.Add(label10);
            Controls.Add(txtStock);
            Controls.Add(label9);
            Controls.Add(txtPrice);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtItem);
            Font = new Font("Verdana", 12F);
            Margin = new Padding(4);
            Name = "Items";
            Size = new Size(1273, 548);
            Load += Items_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label11;
        private TextBox txtManufacturer;
        private Label label10;
        private TextBox txtStock;
        private Label label9;
        private TextBox txtPrice;
        private Label label8;
        private Label label7;
        private TextBox txtItem;
        private Button btnDelete;
        private Button btnAddItem;
        private Button btnEdit;
        private Label label12;
        private Label label14;
        private Guna.UI2.WinForms.Guna2DataGridView dgvItems;
        private ComboBox cmbCategory;

        public FormStartPosition StartPosition { get; private set; }
        public FormBorderStyle FormBorderStyle { get; private set; }
    }
}