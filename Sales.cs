using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace StockManagement
{
    public partial class Sales : UserControl
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\SKYMIL\\Documents\\GestionStock.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public Sales()
        {
            InitializeComponent();
            HookEvents();
            Load += Sales_Load;
        }

        private void HookEvents()
        {
            cmbItem.SelectedIndexChanged += CmbItem_SelectedIndexChanged;
            txtQuantity.TextChanged += TxtQuantity_TextChanged;
            btnSell.Click += BtnAddSale_Click;
            btnExport.Click += BtnExport_Click;
        }

        private void Sales_Load(object? sender, EventArgs e)
        {
            LoadItems();
            LoadCustomers();
            LoadSales();
        }

        private void LoadItems()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT ItemID, ItemName, Price, Stock FROM Items", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbItem.DataSource = dt;
                cmbItem.DisplayMember = "ItemName";
                cmbItem.ValueMember = "ItemID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message);
            }
        }

        private void LoadCustomers()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT CustomerID, Name FROM Customers", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmbCustomer.DataSource = dt;
                cmbCustomer.DisplayMember = "Name";
                cmbCustomer.ValueMember = "CustomerID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void LoadSales()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT SaleID, Name AS Customer, ItemName, Quantity, UnitPrice, TotalAmount, SaleDate FROM Sales JOIN Customers ON Sales.CustomerID = Customers.CustomerID JOIN Items ON Sales.ItemID = Items.ItemID", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvSales.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales: " + ex.Message);
            }
        }

        private void CmbItem_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbItem.SelectedItem is DataRowView row)
            {
                txtUnitPrice.Text = row["Price"].ToString();
                txtStockAvailable.Text = row["Stock"].ToString();
            }
        }

        private void TxtQuantity_TextChanged(object? sender, EventArgs e)
        {
            if (decimal.TryParse(txtUnitPrice.Text, out decimal price) && int.TryParse(txtQuantity.Text, out int qty))
            {
                txtTotal.Text = (price * qty).ToString("F2");
            }
            else
            {
                txtTotal.Text = "0.00";
            }
        }

        private void BtnAddSale_Click(object? sender, EventArgs e)
        {
            if (cmbItem.SelectedValue != null && cmbCustomer.SelectedValue != null && int.TryParse(txtQuantity.Text, out int qty) && decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
            {
                int stock = int.Parse(txtStockAvailable.Text);
                if (qty > stock)
                {
                    MessageBox.Show("Not enough stock available.");
                    return;
                }

                int itemId = Convert.ToInt32(cmbItem.SelectedValue);
                int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                decimal total = qty * unitPrice;

                using SqlConnection conn = new SqlConnection(connectionString);
                try
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Sales (CustomerID, ItemID, Quantity, UnitPrice, TotalAmount, SaleDate) VALUES (@CustomerID, @ItemID, @Quantity, @UnitPrice, @TotalAmount, @SaleDate)", conn, transaction);
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@ItemID", itemId);
                    cmd.Parameters.AddWithValue("@Quantity", qty);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@TotalAmount", total);
                    cmd.Parameters.AddWithValue("@SaleDate", dtSaleDate.Value);
                    cmd.ExecuteNonQuery();

                    SqlCommand updateStock = new SqlCommand("UPDATE Items SET Stock = Stock - @Qty WHERE ItemID = @ItemID", conn, transaction);
                    updateStock.Parameters.AddWithValue("@Qty", qty);
                    updateStock.Parameters.AddWithValue("@ItemID", itemId);
                    updateStock.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Sale recorded successfully.");
                    LoadSales();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error recording sale: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all sale information correctly.");
            }
        }

        private void BtnExport_Click(object? sender, EventArgs e)
        {
            if (dgvSales.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog { Filter = "CSV (*.csv)|*.csv", FileName = "SalesExport.csv" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var sb = new System.Text.StringBuilder();
                        var headers = dgvSales.Columns.Cast<DataGridViewColumn>();
                        sb.AppendLine(string.Join(",", headers.Select(column => column.HeaderText)));
                        foreach (DataGridViewRow row in dgvSales.Rows)
                        {
                            var cells = row.Cells.Cast<DataGridViewCell>();
                            sb.AppendLine(string.Join(",", cells.Select(cell => cell.Value?.ToString()?.Replace(",", ";"))));
                        }
                        System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
                        MessageBox.Show("Exported successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Export failed: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No data to export.");
            }
        }

        private void label14_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void txtManufacturer_TextChanged(object sender, EventArgs e) { }
    }
}