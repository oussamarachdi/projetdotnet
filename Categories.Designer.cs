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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label14 = new Label();
            CategoriesList = new Guna.UI2.WinForms.Guna2DataGridView();
            label12 = new Label();
            AddBtn = new Button();
            EditBtn = new Button();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label7 = new Label();
            DeleteBtn = new Button();
            panel7 = new Panel();
            label13 = new Label();
            pictureBox7 = new PictureBox();
            label6 = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            NameTb = new TextBox();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            panel6 = new Panel();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CategoriesList).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(79, 19);
            label4.Name = "label4";
            label4.Size = new Size(69, 13);
            label4.TabIndex = 6;
            label4.Text = "Customers";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.DarkCyan;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(79, 19);
            label2.Name = "label2";
            label2.Size = new Size(40, 13);
            label2.TabIndex = 6;
            label2.Text = "Items";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(243, 59);
            label14.Name = "label14";
            label14.Size = new Size(146, 13);
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
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CategoriesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CategoriesList.ColumnHeadersHeight = 4;
            CategoriesList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CategoriesList.DefaultCellStyle = dataGridViewCellStyle3;
            CategoriesList.GridColor = Color.FromArgb(231, 229, 255);
            CategoriesList.Location = new Point(212, 326);
            CategoriesList.Name = "CategoriesList";
            CategoriesList.RowHeadersVisible = false;
            CategoriesList.Size = new Size(1142, 257);
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
            label12.Location = new Point(761, 310);
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
            AddBtn.Location = new Point(749, 260);
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
            EditBtn.Location = new Point(551, 260);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(126, 29);
            EditBtn.TabIndex = 47;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkCyan;
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 56);
            panel3.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkCyan;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 19);
            label1.Name = "label1";
            label1.Size = new Size(69, 13);
            label1.TabIndex = 6;
            label1.Text = "Categories";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(661, 162);
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
            DeleteBtn.Location = new Point(927, 260);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(126, 29);
            DeleteBtn.TabIndex = 49;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkCyan;
            panel7.Controls.Add(label13);
            panel7.Controls.Add(pictureBox7);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(199, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1213, 56);
            panel7.TabIndex = 40;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(1175, 9);
            label13.Name = "label13";
            label13.Size = new Size(26, 25);
            label13.TabIndex = 10;
            label13.Text = "X";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.DarkCyan;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(13, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(43, 54);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(79, 19);
            label6.Name = "label6";
            label6.Size = new Size(182, 13);
            label6.TabIndex = 6;
            label6.Text = "Stock Management Application";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 104);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 56);
            panel4.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 532);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 56);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkCyan;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(79, 19);
            label3.Name = "label3";
            label3.Size = new Size(45, 13);
            label3.TabIndex = 6;
            label3.Text = "Logout";
            // 
            // NameTb
            // 
            NameTb.Location = new Point(661, 189);
            NameTb.Name = "NameTb";
            NameTb.Size = new Size(259, 21);
            NameTb.TabIndex = 41;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 600);
            panel1.TabIndex = 39;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.DarkCyan;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(79, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 54);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 8;
            pictureBox6.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkCyan;
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(3, 336);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 56);
            panel6.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.DarkCyan;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(3, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(79, 19);
            label5.Name = "label5";
            label5.Size = new Size(69, 13);
            label5.TabIndex = 6;
            label5.Text = "Dashboard";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkCyan;
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(0, 260);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 56);
            panel5.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.DarkCyan;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1412, 600);
            Controls.Add(label14);
            Controls.Add(CategoriesList);
            Controls.Add(label12);
            Controls.Add(AddBtn);
            Controls.Add(EditBtn);
            Controls.Add(label7);
            Controls.Add(DeleteBtn);
            Controls.Add(panel7);
            Controls.Add(NameTb);
            Controls.Add(panel1);
            Font = new Font("Verdana", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categories";
            Text = "Categories";
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)CategoriesList).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label14;
        private Guna.UI2.WinForms.Guna2DataGridView CategoriesList;
        private Label label12;
        private Button AddBtn;
        private Button EditBtn;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label7;
        private Button DeleteBtn;
        private Panel panel7;
        private Label label13;
        private PictureBox pictureBox7;
        private Label label6;
        private Panel panel4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox NameTb;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Panel panel1;
        private PictureBox pictureBox6;
        private Panel panel6;
        private PictureBox pictureBox5;
        private Label label5;
        private Panel panel5;
        private PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}