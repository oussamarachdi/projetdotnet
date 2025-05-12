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
    public partial class Billings : Form
    {
        public Billings()
        {
            InitializeComponent();
            HookEvents();
        }
        private void HookEvents()
        {
            NavItem.Click += (s, e) =>
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
