namespace StockManagement
{
    partial class Categories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public new FormStartPosition StartPosition { get; private set; }
        public new FormBorderStyle FormBorderStyle { get; private set; }


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
            label14 = new Label();
            CategoriesList = new Guna.UI2.WinForms.Guna2DataGridView();
            label12 = new Label();
            AddBtn = new Button();
            EditBtn = new Button();
            label7 = new Label();
            DeleteBtn = new Button();
            CategoryName = new TextBox();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)CategoriesList).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(79, 36);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(207, 18);
            label14.TabIndex = 52;
            label14.Text = "Categories Management";
            label14.Click += label14_Click;
            // 
            // CategoriesList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            CategoriesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CategoriesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CategoriesList.ColumnHeadersHeight = 4;
            CategoriesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CategoriesList.DefaultCellStyle = dataGridViewCellStyle3;
            CategoriesList.GridColor = Color.FromArgb(231, 229, 255);
            CategoriesList.Location = new Point(0, 280);
            CategoriesList.Margin = new Padding(4, 4, 4, 4);
            CategoriesList.Name = "CategoriesList";
            CategoriesList.RowHeadersVisible = false;
            CategoriesList.Size = new Size(1271, 263);
            CategoriesList.TabIndex = 51;
            CategoriesList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CategoriesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            CategoriesList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CategoriesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CategoriesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CategoriesList.ThemeStyle.BackColor = Color.White;
            CategoriesList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            CategoriesList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            CategoriesList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CategoriesList.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoriesList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CategoriesList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CategoriesList.ThemeStyle.HeaderStyle.Height = 4;
            CategoriesList.ThemeStyle.ReadOnly = false;
            CategoriesList.ThemeStyle.RowsStyle.BackColor = Color.White;
            CategoriesList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CategoriesList.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CategoriesList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            CategoriesList.ThemeStyle.RowsStyle.Height = 25;
            CategoriesList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            CategoriesList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            CategoriesList.CellContentClick += CategoriesList_CellContentClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(516, 328);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(132, 18);
            label12.TabIndex = 50;
            label12.Text = "Categories List";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Teal;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(516, 158);
            AddBtn.Margin = new Padding(4, 4, 4, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(180, 40);
            AddBtn.TabIndex = 48;
            AddBtn.Text = "Add Categorie";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Teal;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(221, 158);
            EditBtn.Margin = new Padding(4, 4, 4, 4);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(180, 40);
            EditBtn.TabIndex = 47;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(383, 72);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(134, 18);
            label7.TabIndex = 42;
            label7.Text = "Category Name";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Teal;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(767, 158);
            DeleteBtn.Margin = new Padding(4, 4, 4, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(180, 40);
            DeleteBtn.TabIndex = 49;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // CategoryName
            // 
            CategoryName.Location = new Point(383, 109);
            CategoryName.Margin = new Padding(4, 4, 4, 4);
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new Size(368, 27);
            CategoryName.TabIndex = 41;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(564, 241);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(132, 18);
            label8.TabIndex = 55;
            label8.Text = "Categories List";
            label8.Click += label8_Click;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label8);
            Controls.Add(label14);
            Controls.Add(CategoriesList);
            Controls.Add(label12);
            Controls.Add(AddBtn);
            Controls.Add(EditBtn);
            Controls.Add(label7);
            Controls.Add(DeleteBtn);
            Controls.Add(CategoryName);
            Font = new Font("Verdana", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Categories";
            Size = new Size(1273, 548);
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)CategoriesList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label14;
        private Guna.UI2.WinForms.Guna2DataGridView CategoriesList;
        private Label label12;
        private Button AddBtn;
        private Button EditBtn;
        private Label label7;
        private Button DeleteBtn;
        private TextBox CategoryName;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label8;
    }
}