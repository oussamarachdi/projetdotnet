using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace StockManagement
{
    public partial class Customers : UserControl
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\SKYMIL\\Documents\\GestionStock.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public Customers()
        {
            InitializeComponent();
            HookEvents();
            Load += Customers_Load;
        }

        private void HookEvents()
        {
            BtnAdd.Click += BtnAdd_Click;
            BtnEdit.Click += BtnEdit_Click;
            BtnDelete.Click += BtnDelete_Click;
            dgvCustomers.CellClick += DgvCustomers_CellClick;
        }

        private void Customers_Load(object? sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customers", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCustomers.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customers: " + ex.Message);
                }
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "INSERT INTO Customers (Name, Gender, Phone) VALUES (@Name, @Gender, @Phone)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Customer added successfully.");
                        LoadCustomers();
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding customer: " + ex.Message);
                    }
                }
            }
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0 && ValidateInputs())
            {
                int id = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE Customers SET Name=@Name, Gender=@Gender, Phone=@Phone WHERE CustomerID=@Id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Customer updated successfully.");
                        LoadCustomers();
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating customer: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Customers WHERE CustomerID=@Id", conn);
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Customer deleted successfully.");
                        LoadCustomers();
                        ClearInputs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting customer: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void DgvCustomers_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = dgvCustomers.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
                cmbGender.SelectedItem = dgvCustomers.Rows[e.RowIndex].Cells["Gender"].Value?.ToString();
                txtPhone.Text = dgvCustomers.Rows[e.RowIndex].Cells["Phone"].Value?.ToString();
            }
        }

        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(txtName.Text) &&
                   cmbGender.SelectedItem != null &&
                   !string.IsNullOrWhiteSpace(txtPhone.Text);
        }

        private void ClearInputs()
        {
            txtName.Text = "";
            cmbGender.SelectedIndex = -1;
            txtPhone.Text = "";
        }

        private void ShowCustomers()
        {
            // Left for potential custom logic or alternate usage
        }

        private void AddButtonClick(object sender, EventArgs e)
        {
            // Left for legacy or unused event reference
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Optional label click logic
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional legacy event binding
        }

        private void NavItems_Paint(object sender, PaintEventArgs e)
        {
            // Optional custom paint logic for navigation
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Optional label logic
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            // Optional duplicate label logic
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            // Optional duplicate label logic
        }
    }
}
