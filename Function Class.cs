using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ODPProject
{
    internal class PatientIDfunction
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=ODP;Integrated Security=True;TrustServerCertificate=True";
            return conn;
        }

        public DataSet getData(string query) //get data form database
        {
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting data: " + ex.Message);
                // Log the exception details for further debugging
            }

            return ds;
        }
        public void setData(String query)
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
