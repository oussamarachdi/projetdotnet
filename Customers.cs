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
            Con = new Functions();
            ShowCustomers();
        }
        Functions Con;

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
    }
}
