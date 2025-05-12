namespace StockManagement
{
    partial class Customers
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label14 = new Label();
            dgvCustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            label12 = new Label();
            BtnAdd = new Button();
            BtnEdit = new Button();
            label9 = new Label();
            txtPhone = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            BtnDelete = new Button();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            cmbGender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.ForeColor = Color.Red;
            label14.Location = new Point(34, 53);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(196, 18);
            label14.TabIndex = 38;
            label14.Text = "Customers Managment";
            // 
            // dgvCustomers
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Verdana", 8F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCustomers.ColumnHeadersHeight = 4;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Verdana", 8F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvCustomers.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCustomers.GridColor = Color.FromArgb(231, 229, 255);
            dgvCustomers.Location = new Point(0, 331);
            dgvCustomers.Margin = new Padding(4);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersVisible = false;
            dgvCustomers.Size = new Size(1271, 213);
            dgvCustomers.TabIndex = 37;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCustomers.ThemeStyle.BackColor = Color.White;
            dgvCustomers.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCustomers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCustomers.ThemeStyle.HeaderStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvCustomers.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCustomers.ThemeStyle.HeaderStyle.Height = 4;
            dgvCustomers.ThemeStyle.ReadOnly = false;
            dgvCustomers.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCustomers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomers.ThemeStyle.RowsStyle.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvCustomers.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCustomers.ThemeStyle.RowsStyle.Height = 25;
            dgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvCustomers.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(567, 287);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(131, 18);
            label12.TabIndex = 36;
            label12.Text = "Customers List";
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.Teal;
            BtnAdd.FlatAppearance.BorderSize = 0;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.ForeColor = Color.White;
            BtnAdd.Location = new Point(550, 217);
            BtnAdd.Margin = new Padding(4);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(180, 40);
            BtnAdd.TabIndex = 34;
            BtnAdd.Text = "Add Customer";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += button2_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.Teal;
            BtnEdit.FlatAppearance.BorderSize = 0;
            BtnEdit.FlatStyle = FlatStyle.Flat;
            BtnEdit.ForeColor = Color.White;
            BtnEdit.Location = new Point(267, 217);
            BtnEdit.Margin = new Padding(4);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(180, 40);
            BtnEdit.TabIndex = 33;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(924, 109);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(58, 18);
            label9.TabIndex = 28;
            label9.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(924, 147);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(241, 27);
            txtPhone.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(504, 109);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 18);
            label8.TabIndex = 26;
            label8.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 109);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(55, 18);
            label7.TabIndex = 24;
            label7.Text = "Name";
            label7.Click += label7_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(33, 147);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(241, 27);
            txtName.TabIndex = 23;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.Teal;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.ForeColor = Color.White;
            BtnDelete.Location = new Point(804, 217);
            BtnDelete.Margin = new Padding(4);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(180, 40);
            BtnDelete.TabIndex = 35;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(474, 147);
            cmbGender.Margin = new Padding(4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(241, 26);
            cmbGender.TabIndex = 39;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(cmbGender);
            Controls.Add(label14);
            Controls.Add(dgvCustomers);
            Controls.Add(label12);
            Controls.Add(BtnAdd);
            Controls.Add(BtnEdit);
            Controls.Add(label9);
            Controls.Add(txtPhone);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtName);
            Controls.Add(BtnDelete);
            Font = new Font("Verdana", 12F);
            Margin = new Padding(4);
            Name = "Customers";
            Size = new Size(1273, 548);
            Load += Customers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label14;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomers;
        private Label label12;
        private Button BtnAdd;
        private Button BtnEdit;
        private Label label9;
        private TextBox txtPhone;
        private Label label8;
        private Label label7;
        private TextBox txtName;
        private Button BtnDelete;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private ComboBox cmbGender;
    }
}