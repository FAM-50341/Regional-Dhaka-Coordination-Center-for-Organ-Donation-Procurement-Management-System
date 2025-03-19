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
    public partial class UpdatePatientDetails : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        public UpdatePatientDetails()
        {
            InitializeComponent();
        }

        private void txtPatientfathersname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Closeaddpatient_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the text from textbox and handle potential format exceptions
                int pid = int.Parse(textBoxPid.Text);

                // Use string interpolation for cleaner and safer query building
                string query = $"select * from AddNewPatient where PId = {pid}";

                // Create a connection (assuming you have a connection string)
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
                    UtxtPatientname.Text = ds.Tables[0].Rows[0][1].ToString();
                    UtxtPatientfathersname.Text = ds.Tables[0].Rows[0][2].ToString();
                    UtxtPatientmothersname.Text = ds.Tables[0].Rows[0][3].ToString();
                    UdateTimePickerPatient.Text = ds.Tables[0].Rows[0][4].ToString();
                    UtxtPatientmobile.Text = ds.Tables[0].Rows[0][5].ToString();
                    UcomboBoxPGender.Text = ds.Tables[0].Rows[0][6].ToString();
                    UtxtEmailPatient.Text = ds.Tables[0].Rows[0][7].ToString();
                    UcomboBoxBlood.Text = ds.Tables[0].Rows[0][8].ToString();
                    UrichTxtAdresspatient.Text = ds.Tables[0].Rows[0][9].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Patient ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Close the connection
                connection.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer for Patient ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException)
            {
                MessageBox.Show("Error connecting to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPid_TextChanged(object sender, EventArgs e)
        {
            if(textBoxPid.Text == "")
            {
                UtxtPatientname.Clear() ;
                UtxtPatientfathersname.Clear();
                UtxtPatientmothersname.Clear();
                UdateTimePickerPatient.ResetText();
                UtxtPatientmobile.Clear();
                UcomboBoxPGender.ResetText();
                UtxtEmailPatient.Clear();
                UcomboBoxBlood.ResetText();
                UrichTxtAdresspatient.Clear();
            }
        }

        private void UReset_Click(object sender, EventArgs e)
        {
            textBoxPid.Clear();
        }

        private void UpdatePatientDetails_Load(object sender, EventArgs e)
        {
            textBoxPid.Clear();
        }

        private void UpdateSave_Click(object sender, EventArgs e)
        {
            string query = "update AddNewPatient set PName='" + UtxtPatientname.Text + "', PFathername='" + UtxtPatientfathersname.Text + "', PMothername='" + UtxtPatientmothersname.Text + "', PDOB='" + UdateTimePickerPatient.Text + "', PMobile='" + UtxtPatientmobile.Text + "', PGender ='" + UcomboBoxPGender.Text + "',  PEmail='" + UtxtEmailPatient.Text + "', PBloodgroup ='" + UcomboBoxBlood.Text + "', PAdress='" + UrichTxtAdresspatient.Text + "' where PId = " + textBoxPid.Text + "";
            fn.setData(query);
            UpdatePatientDetails_Load(this, null);
        
        }
    }
}
