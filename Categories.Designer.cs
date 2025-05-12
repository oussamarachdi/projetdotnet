namespace StockManagement
{
    partial class Categories
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
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
            panel1 = new Panel();
            NavItem = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            NavDashboard = new Panel();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            NavCustomers = new Panel();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            NavCategorie = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel7 = new Panel();
            label13 = new Label();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)CategoriesList).BeginInit();
            panel1.SuspendLayout();
            NavItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            NavDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            NavCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            NavCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(195, 67);
            label14.Name = "label14";
            label14.Size = new Size(146, 13);
            label14.TabIndex = 52;
            label14.Text = "Categories Management";
            label14.Click += label14_Click;
            // 
            // CategoriesList
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            CategoriesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Verdana", 8F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            CategoriesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            CategoriesList.ColumnHeadersHeight = 4;
            CategoriesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Verdana", 8F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            CategoriesList.DefaultCellStyle = dataGridViewCellStyle6;
            CategoriesList.GridColor = Color.FromArgb(231, 229, 255);
            CategoriesList.Location = new Point(140, 243);
            CategoriesList.Name = "CategoriesList";
            CategoriesList.RowHeadersVisible = false;
            CategoriesList.Size = new Size(890, 190);
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
            label12.Location = new Point(501, 278);
            label12.Name = "label12";
            label12.Size = new Size(92, 13);
            label12.TabIndex = 50;
            label12.Text = "Categories List";
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Teal;
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(501, 155);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(126, 29);
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
            EditBtn.Location = new Point(295, 155);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(126, 29);
            EditBtn.TabIndex = 47;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(408, 93);
            label7.Name = "label7";
            label7.Size = new Size(97, 13);
            label7.TabIndex = 42;
            label7.Text = "Category Name";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Teal;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(677, 155);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(126, 29);
            DeleteBtn.TabIndex = 49;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // CategoryName
            // 
            CategoryName.Location = new Point(408, 120);
            CategoryName.Name = "CategoryName";
            CategoryName.Size = new Size(259, 20);
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
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(NavItem);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(NavDashboard);
            panel1.Controls.Add(NavCustomers);
            panel1.Controls.Add(NavCategorie);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 433);
            panel1.TabIndex = 53;
            // 
            // NavItem
            // 
            NavItem.BackColor = Color.DarkCyan;
            NavItem.Controls.Add(pictureBox3);
            NavItem.Controls.Add(label2);
            NavItem.Location = new Point(0, 79);
            NavItem.Margin = new Padding(2);
            NavItem.Name = "NavItem";
            NavItem.Size = new Size(140, 40);
            NavItem.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DarkCyan;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(2, 1);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(55, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 13);
            label2.TabIndex = 6;
            label2.Text = "Items";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.DarkCyan;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Margin = new Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(140, 80);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // NavDashboard
            // 
            NavDashboard.BackColor = Color.DarkCyan;
            NavDashboard.Controls.Add(pictureBox5);
            NavDashboard.Controls.Add(label5);
            NavDashboard.Location = new Point(2, 243);
            NavDashboard.Margin = new Padding(2);
            NavDashboard.Name = "NavDashboard";
            NavDashboard.Size = new Size(138, 40);
            NavDashboard.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.DarkCyan;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(2, 0);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(28, 39);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(55, 14);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 13);
            label5.TabIndex = 6;
            label5.Text = "Dashboard";
            // 
            // NavCustomers
            // 
            NavCustomers.BackColor = Color.DarkCyan;
            NavCustomers.Controls.Add(pictureBox4);
            NavCustomers.Controls.Add(label4);
            NavCustomers.Font = new Font("Verdana", 8F, FontStyle.Bold);
            NavCustomers.Location = new Point(0, 188);
            NavCustomers.Margin = new Padding(2);
            NavCustomers.Name = "NavCustomers";
            NavCustomers.Size = new Size(140, 40);
            NavCustomers.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.DarkCyan;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(2, 0);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 8F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(48, 14);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 13);
            label4.TabIndex = 6;
            label4.Text = "Customers";
            // 
            // NavCategorie
            // 
            NavCategorie.BackColor = Color.Cyan;
            NavCategorie.Controls.Add(pictureBox2);
            NavCategorie.Controls.Add(label1);
            NavCategorie.Font = new Font("Verdana", 8F, FontStyle.Bold);
            NavCategorie.Location = new Point(0, 132);
            NavCategorie.Margin = new Padding(2);
            NavCategorie.Name = "NavCategorie";
            NavCategorie.Size = new Size(140, 40);
            NavCategorie.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Cyan;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, 0);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(49, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 13);
            label1.TabIndex = 6;
            label1.Text = "Categories";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-1, 391);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(140, 40);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkCyan;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(55, 14);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 13);
            label3.TabIndex = 6;
            label3.Text = "Logout";
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkCyan;
            panel7.Controls.Add(label13);
            panel7.Controls.Add(pictureBox7);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(140, 0);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(890, 40);
            panel7.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(853, 9);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(26, 25);
            label13.TabIndex = 10;
            label13.Text = "X";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.DarkCyan;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Margin = new Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(51, 39);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(55, 14);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(182, 13);
            label6.TabIndex = 6;
            label6.Text = "Stock Management Application";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(535, 215);
            label8.Name = "label8";
            label8.Size = new Size(92, 13);
            label8.TabIndex = 55;
            label8.Text = "Categories List";
            label8.Click += label8_Click;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 433);
            Controls.Add(label8);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Controls.Add(label14);
            Controls.Add(CategoriesList);
            Controls.Add(label12);
            Controls.Add(AddBtn);
            Controls.Add(EditBtn);
            Controls.Add(label7);
            Controls.Add(DeleteBtn);
            Controls.Add(CategoryName);
            Font = new Font("Verdana", 8F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories";
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)CategoriesList).EndInit();
            panel1.ResumeLayout(false);
            NavItem.ResumeLayout(false);
            NavItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            NavDashboard.ResumeLayout(false);
            NavDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            NavCustomers.ResumeLayout(false);
            NavCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            NavCategorie.ResumeLayout(false);
            NavCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
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
        private Panel panel1;
        private Panel NavItem;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox6;
        private Panel NavDashboard;
        private PictureBox pictureBox5;
        private Label label5;
        private Panel NavCustomers;
        private PictureBox pictureBox4;
        private Label label4;
        private Panel NavCategorie;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label8;
        private Panel panel7;
        private Label label13;
        private PictureBox pictureBox7;
        private Label label6;
    }
}