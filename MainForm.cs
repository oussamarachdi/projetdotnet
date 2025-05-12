using System;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent(); 
            btnItems.Click += btnItems_Click;
            btnCategories.Click += btnCategories_Click;
            btnCustomers.Click += btnCustomers_Click;
            btnExit.Click += btnExit_Click;
            lblExit.Click += btnExit_Click;
            btnSales.Click += btnSales_Click;
            btnDashboard.Click += BtnDashboard_Click;


            LoadPage(new Items()); // Load default page
        }

        private void BtnDashboard_Click(object? sender, EventArgs e)
        {
            LoadPage(new Dashboard());
        }

        private void LoadPage(UserControl page)
        {
            panelContent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContent.Controls.Add(page);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnItems_Click(object sender, EventArgs e)
        {
            LoadPage(new Items());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            LoadPage(new Categories());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            LoadPage(new Customers());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            LoadPage(new Sales());
        }
    }
}





