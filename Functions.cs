using System.Data;
using Microsoft.Data.SqlClient;

namespace StockManagement
{
    internal class Functions
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable dt;
        private string conStr;
        private SqlDataAdapter sDa;

        public Functions()
        {
            conStr = "Data Source=YourServer;Initial Catalog=YourDatabase;Integrated Security=True";
            Con = new SqlConnection(conStr);
            cmd = Con.CreateCommand();
            dt = new DataTable();
            sDa = new SqlDataAdapter();
        }

        public int SetData(string Query)
        {
            int Cnt;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            cmd.CommandText = Query;
            Cnt = cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;
        }
    }
}
