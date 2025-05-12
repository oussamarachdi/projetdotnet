namespace StockManagement
{
    partial class Dashboard
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            lblDashboardTitle = new Label();
            lblSalesByCategory = new Label();
            lblTopProducts = new Label();
            cartesianChartTopProducts = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            pieChartByCategory = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            SuspendLayout();
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.AutoSize = true;
            lblDashboardTitle.BackColor = Color.White;
            lblDashboardTitle.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardTitle.ForeColor = Color.Red;
            lblDashboardTitle.Location = new Point(649, 48);
            lblDashboardTitle.Margin = new Padding(4, 0, 4, 0);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(104, 18);
            lblDashboardTitle.TabIndex = 53;
            lblDashboardTitle.Text = "Dashboard";
            // 
            // lblSalesByCategory
            // 
            lblSalesByCategory.AutoSize = true;
            lblSalesByCategory.Location = new Point(797, 109);
            lblSalesByCategory.Margin = new Padding(4, 0, 4, 0);
            lblSalesByCategory.Name = "lblSalesByCategory";
            lblSalesByCategory.Size = new Size(309, 18);
            lblSalesByCategory.TabIndex = 55;
            lblSalesByCategory.Text = "Répartition des ventes par catégorie";
            // 
            // lblTopProducts
            // 
            lblTopProducts.AutoSize = true;
            lblTopProducts.Location = new Point(97, 109);
            lblTopProducts.Margin = new Padding(4, 0, 4, 0);
            lblTopProducts.Name = "lblTopProducts";
            lblTopProducts.Size = new Size(173, 18);
            lblTopProducts.TabIndex = 56;
            lblTopProducts.Text = "Top produits vendus";
            // 
            // cartesianChartTopProducts
            // 
            cartesianChartTopProducts.BackColor = SystemColors.ActiveCaption;
            cartesianChartTopProducts.BorderStyle = BorderStyle.FixedSingle;
            cartesianChartTopProducts.Location = new Point(97, 147);
            cartesianChartTopProducts.Name = "cartesianChartTopProducts";
            cartesianChartTopProducts.Size = new Size(600, 300);
            cartesianChartTopProducts.TabIndex = 57;
            // 
            // pieChartByCategory
            // 
            pieChartByCategory.BackColor = SystemColors.GradientActiveCaption;
            pieChartByCategory.BorderStyle = BorderStyle.FixedSingle;
            pieChartByCategory.InitialRotation = 0D;
            pieChartByCategory.IsClockwise = true;
            pieChartByCategory.Location = new Point(797, 147);
            pieChartByCategory.MaxAngle = 360D;
            pieChartByCategory.Name = "pieChartByCategory";
            pieChartByCategory.Size = new Size(400, 300);
            pieChartByCategory.TabIndex = 58;
            pieChartByCategory.Total = null;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pieChartByCategory);
            Controls.Add(cartesianChartTopProducts);
            Controls.Add(lblTopProducts);
            Controls.Add(lblSalesByCategory);
            Controls.Add(lblDashboardTitle);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Dashboard";
            Size = new Size(1273, 548);
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashboardTitle;
        private Label lblSalesByCategory;
        private Label lblTopProducts;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChartTopProducts;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChartByCategory;
    }
}
