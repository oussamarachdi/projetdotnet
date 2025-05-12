using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace StockManagement
{
    public partial class Items : UserControl
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mjarb\\OneDrive\\Documents\\stock_management_db.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public Items()
        {
            InitializeComponent();
            HookEvents();
            Load += Items_Load;
        }

        private void HookEvents()
        {
            btnAddItem.Click += BtnAddItem_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            dgvItems.CellClick += guna2DataGridView1_CellContentClick;
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

        private void guna2DataGridView1_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtItem.Text = dgvItems.Rows[e.RowIndex].Cells["ItemName"].Value?.ToString();
                txtCategory.Text = dgvItems.Rows[e.RowIndex].Cells["CategoryID"].Value?.ToString();
                txtPrice.Text = dgvItems.Rows[e.RowIndex].Cells["Price"].Value?.ToString();
                txtStock.Text = dgvItems.Rows[e.RowIndex].Cells["Stock"].Value?.ToString();
                txtManufacturer.Text = dgvItems.Rows[e.RowIndex].Cells["Manufacturer"].Value?.ToString();
            }
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
                        string query = "UPDATE Items SET ItemName=@Item, CategoryID=@Category, Price=@Price, Stock=@Stock, Manufacturer=@Manufacturer WHERE ItemID=@Id";
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
        private void label7_Click(object sender, EventArgs e)
        {
            // Handle label7 click event
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Handle label8 click event
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // Handle label9 click event
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Handle delete logic here
        }
        private void label11_Click(object sender, EventArgs e)
        {
            // Handle delete logic here
        }
        private void label12_Click(object sender, EventArgs e)
        {
            // Handle delete logic here
        }
        private void label14_Click(object sender, EventArgs e)
        {
            // Handle delete logic here
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Handle delete logic here
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Handle delete logic here
        }
    }
}
