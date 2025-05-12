using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            HookEvents();
        }
        private void HookEvents()
        {
            label2.Click += (s, e) =>
            {
                var itemsForm = new Items();
                itemsForm.Show();
                this.Hide();
            };

            NavCategorie.Click += (s, e) =>
            {
                var categoriesForm = new Categories();
                categoriesForm.Show();
                this.Hide();
            };

            NavCustomers.Click += (s, e) =>
            {
                var customersForm = new Customers();
                customersForm.Show();
                this.Hide();
            };

            NavDashboard.Click += (s, e) =>
            {
                var dashboardForm = new Billings();
                dashboardForm.Show();
                this.Hide();
            };

            label3.Click += (s, e) =>
            {
                Application.Exit(); // Logout
            };

        }

        private void ShowCustomers()
        {

        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            // TODO: Add button click logic here
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }

        private void NavItems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
