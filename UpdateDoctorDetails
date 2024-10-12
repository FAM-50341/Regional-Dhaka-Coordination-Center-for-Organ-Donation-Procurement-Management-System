using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODPProject
{
    public partial class UpdateDoctorDetails : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        public UpdateDoctorDetails()
        {
            InitializeComponent();
        }

        private void Closeupdatedonor_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the text from textbox and handle potential format exceptions
                int docid = int.Parse(textBoxDocId.Text);
                string query = $"select * from AddNewDoctor where DocId = {docid}";
                string connectionString = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=ODP;Integrated Security=True;TrustServerCertificate=True"; // Replace with your actual connection string
                SqlConnection connection = new SqlConnection(connectionString);

                // Create a command object with parameterized query (prevents SQL injection)
                SqlCommand command = new SqlCommand(query, connection);

                // Open the connection
                connection.Open();

                // Execute the query and handle potential exceptions (e.g., data not found)
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    txtDoctorname.Text = ds.Tables[0].Rows[0][1].ToString();
                    comboBoxHospitalname.Text = ds.Tables[0].Rows[0][2].ToString();
                     comboBox2.Text = ds.Tables[0].Rows[0][6].ToString();
                     textBoxContact.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                { 
                    MessageBox.Show("Invalid Donor ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Close the connection
                connection.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer for Donor ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Error connecting to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxDocId_TextChanged(object sender, EventArgs e)
        {
            txtDoctorname.Clear();
            comboBoxHospitalname.ResetText();
            comboBox2.ResetText();
            textBoxContact.Clear();

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBoxDocId.Clear();
        }

        private void UpdateDoctorDetails_Load(object sender, EventArgs e)
        {
            textBoxDocId.Clear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string query = "update AddNewDoctor set Docname='" + txtDoctorname.Text + "', DocHospitalname='" + comboBoxHospitalname.Text + "', DocDepartment='" + comboBox2.Text + "', Contact='" + textBoxContact.Text + "";
            fn.setData(query);
            UpdateDoctorDetails_Load(this, null);
        }
    }
}
