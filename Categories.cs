using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace StockManagement
{
    public partial class Categories : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\SKYMIL\\Documents\\GestionStock.mdf;Integrated Security=True;Connect Timeout=30";


        public Categories()
        {
            InitializeComponent();
            HookEvents();
        }
        private void HookEvents()
        {
            NavItem.Click += (s, e) => { new Items().Show(); this.Hide(); };
            NavCategorie.Click += (s, e) => { new Categories().Show(); this.Hide(); };
            NavCustomers.Click += (s, e) => { new Customers().Show(); this.Hide(); };
            NavDashboard.Click += (s, e) => { new Billings().Show(); this.Hide(); };
            label3.Click += (s, e) => Application.Exit();

            AddBtn.Click += AddBtn_Click;
            EditBtn.Click += EditBtn_Click;
            DeleteBtn.Click += DeleteBtn_Click;
            CategoriesList.CellContentClick += CategoriesList_CellContentClick;
            this.Load += Categories_Load;
        }

        private void Categories_Load(object? sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Categories", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                CategoriesList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }


        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object? sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CategoryName.Text))
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Categories (CategoryName) VALUES (@Name)", conn);
                    cmd.Parameters.AddWithValue("@Name", CategoryName.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Category added successfully.");
                    LoadCategories();
                    CategoryName.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding category: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a category name.");
            }
        }
        private void EditBtn_Click(object? sender, EventArgs e)
        {
            if (CategoriesList.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(CategoryName.Text))
            {
                int id = Convert.ToInt32(CategoriesList.SelectedRows[0].Cells["CategoryId"].Value);
                using SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Categories SET CategoryName = @Name WHERE CategoryId = @Id", conn);
                    cmd.Parameters.AddWithValue("@Name", CategoryName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Category updated successfully.");
                    LoadCategories();
                    CategoryName.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating category: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a category and enter a new name.");
            }
        }
        private void DeleteBtn_Click(object? sender, EventArgs e)
        {
            if (CategoriesList.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(CategoriesList.SelectedRows[0].Cells["CategoryId"].Value);
                using SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Categories WHERE CategoryId = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Category deleted successfully.");
                    LoadCategories();
                    CategoryName.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting category: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete.");
            }
        }


        private void CategoriesList_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                CategoryName.Text = CategoriesList.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
