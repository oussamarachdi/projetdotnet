using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Microsoft.Data.SqlClient;

namespace StockManagement
{
    public partial class Dashboard : UserControl
    {
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\SKYMIL\\Documents\\GestionStock.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public Dashboard()
        {
            InitializeComponent();
            Load += Dashboard_Load;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadTopSellingProducts();
            LoadSalesByCategory();
        }

        private void LoadTopSellingProducts()
        {
            List<string> labels = new List<string>();
            List<double> values = new List<double>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT TOP 5 I.ItemName, SUM(S.Quantity) AS TotalSold
                        FROM Sales S
                        JOIN Items I ON S.ItemID = I.ItemID
                        GROUP BY I.ItemName
                        ORDER BY TotalSold DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        labels.Add(reader["ItemName"].ToString());
                        values.Add(Convert.ToDouble(reader["TotalSold"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des ventes : " + ex.Message);
                }
            }

            cartesianChartTopProducts.Series = new ISeries[]
            {
                new ColumnSeries<double>
                {
                    Values = values,
                    Name = "Quantité vendue"
                }
            };

            cartesianChartTopProducts.XAxes = new Axis[]
            {
                new Axis
                {
                    Labels = labels
                }
            };

            cartesianChartTopProducts.YAxes = new Axis[]
            {
                new Axis
                {
                    Labeler = value => value.ToString("N0")
                }
            };
        }

        private void LoadSalesByCategory()
        {
            List<PieSeries<double>> series = new List<PieSeries<double>>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT C.CategoryName, SUM(S.Quantity) AS Total
                        FROM Sales S
                        JOIN Items I ON S.ItemID = I.ItemID
                        JOIN Categories C ON I.CategoryID = C.CategoryID
                        GROUP BY C.CategoryName";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string category = reader["CategoryName"].ToString(); // ✅ fixed this line
                        double total = Convert.ToDouble(reader["Total"]);

                        series.Add(new PieSeries<double>
                        {
                            Values = new[] { total },
                            Name = category,
                            DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                            DataLabelsFormatter = point => $"{category}: {point.PrimaryValue:N0}"
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des catégories : " + ex.Message);
                }
            }

            pieChartByCategory.Series = series;
        }
    }
}
