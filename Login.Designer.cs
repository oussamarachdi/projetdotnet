namespace StockManagement
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            label8 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            txtUsername = new TextBox();
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            btnReset = new Label();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            pictureBox6 = new PictureBox();
            lblClose = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Teal;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(321, 284);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(126, 29);
            btnLogin.TabIndex = 34;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(260, 206);
            label8.Name = "label8";
            label8.Size = new Size(61, 13);
            label8.TabIndex = 26;
            label8.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(260, 233);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(259, 21);
            txtPassword.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(260, 127);
            label7.Name = "label7";
            label7.Size = new Size(66, 13);
            label7.TabIndex = 24;
            label7.Text = "UserName";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(260, 154);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(259, 21);
            txtUsername.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 486);
            panel1.TabIndex = 21;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(720, 41);
            label1.Name = "label1";
            label1.Size = new Size(69, 13);
            label1.TabIndex = 35;
            label1.Text = "Login Page";
            // 
            // btnReset
            // 
            btnReset.AutoSize = true;
            btnReset.Font = new Font("Verdana", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Crimson;
            btnReset.Location = new Point(358, 327);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(50, 18);
            btnReset.TabIndex = 36;
            btnReset.Text = "Reset";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.Control;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(800, 127);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(457, 203);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 37;
            pictureBox6.TabStop = false;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Font = new Font("Verdana", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClose.ForeColor = Color.Crimson;
            lblClose.Location = new Point(1344, 29);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(26, 25);
            lblClose.TabIndex = 38;
            lblClose.Text = "X";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 486);
            Controls.Add(lblClose);
            Controls.Add(pictureBox6);
            Controls.Add(btnReset);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(label8);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(txtUsername);
            Controls.Add(panel1);
            Font = new Font("Verdana", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            Load += Login_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label8;
        private TextBox txtPassword;
        private Label label7;
        private TextBox txtUsername;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private Label btnReset;
        private PictureBox pictureBox6;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Label lblClose;
    }
}
