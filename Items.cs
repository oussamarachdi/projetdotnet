using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class Items : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\SKYMIL\\Documents\\GestionStock.mdf;Integrated Security=True;Connect Timeout=30";

        public Items()
        {
            InitializeComponent();
            HookEvents();
        }

        private void HookEvents()
        {
            btnAddItem.Click += BtnAddItem_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
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

        private void Items_Load(object? sender, EventArgs e)
        {
            LoadItems();
        }

        private void LoadItems()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Items", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvItems.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void label13_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Stock Management Application");
        }

        private void label7_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Label 7 clicked (Item)");
        }

        private void label8_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Label 8 clicked (Category)");
        }

        private void label9_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Label 9 clicked (Price)");
        }

        private void textBox4_TextChanged(object? sender, EventArgs e)
        {
            // Stock field changed
        }

        private void label11_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Label 11 clicked (Manufacturer)");
        }

        private void button3_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Delete button clicked");
        }

        private void label12_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Items List Label Clicked");
        }

        private void guna2DataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtItem.Text = dgvItems.Rows[e.RowIndex].Cells["ItemName"].Value.ToString();
                txtCategory.Text = dgvItems.Rows[e.RowIndex].Cells["CategoryID"].Value.ToString();
                txtPrice.Text = dgvItems.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                txtStock.Text = dgvItems.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
                txtManufacturer.Text = dgvItems.Rows[e.RowIndex].Cells["Manufacturer"].Value.ToString();
            }
        }

        private void label14_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Items Management header clicked");
        }

        private void panel2_Paint(object? sender, PaintEventArgs e)
        {
            // Optional: custom drawing for logout panel
        }

        private void BtnAddItem_Click(object? sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Items (ItemName, CategoryId, Price, Stock, Manufacturer) VALUES (@Item, @Category, @Price, @Stock, @Manufacturer)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Item", txtItem.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim());
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));
                        cmd.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text.Trim());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Item added successfully.");
                        LoadItems();
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding item: " + ex.Message);
                    }
                }
            }
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0 && ValidateInputs())
            {
                int id = Convert.ToInt32(dgvItems.SelectedRows[0].Cells["ItemID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Items SET ItemName=@Item, CategoryID=@Category, Price=@Price, Stock=@Stock, Manufacturer=@Manufacturer WHERE Id=@Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Item", txtItem.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category", txtCategory.Text.Trim());
                        cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtStock.Text));
                        cmd.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text.Trim());
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Item updated successfully.");
                        LoadItems();
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating item: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvItems.SelectedRows[0].Cells["ItemId"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Items WHERE ItemID=@Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Item deleted successfully.");
                        LoadItems();
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting item: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(txtItem.Text) &&
                   !string.IsNullOrWhiteSpace(txtCategory.Text) &&
                   decimal.TryParse(txtPrice.Text, out _) &&
                   int.TryParse(txtStock.Text, out _) &&
                   !string.IsNullOrWhiteSpace(txtManufacturer.Text);
        }

        private void ClearInputs()
        {
            txtItem.Text = "";
            txtCategory.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            txtManufacturer.Text = "";
        }
    }
}
