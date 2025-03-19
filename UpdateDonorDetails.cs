using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODPProject
{
    public partial class UpdateDonorDetails : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void Closeaddpatient_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the text from textbox and handle potential format exceptions
                int did = int.Parse(textBoxDId.Text);
                string query = $"select * from AddNewDonor where DId = {did}";
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
                    UtxtDonorname.Text = ds.Tables[0].Rows[0][1].ToString();
                    UtxtDonorfathersname.Text = ds.Tables[0].Rows[0][2].ToString();
                    UtxtDonormothersname.Text = ds.Tables[0].Rows[0][3].ToString();
                    UdateTimePickerDonor.Text = ds.Tables[0].Rows[0][4].ToString();
                    UtxtDonormobile.Text = ds.Tables[0].Rows[0][5].ToString();
                    UcomboBoxPGender.Text = ds.Tables[0].Rows[0][6].ToString();
                    UtxtEmaildonor.Text = ds.Tables[0].Rows[0][7].ToString();
                    UcomboBoxBlood.Text = ds.Tables[0].Rows[0][8].ToString();
                    UrichTxtAdressdonor.Text = ds.Tables[0].Rows[0][9].ToString();
                    txthospitalid.Text = ds.Tables[0].Rows[0][9].ToString();
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

        private void textBoxDId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDId.Text == "")
            {
                UtxtDonorname.Clear();
                UtxtDonorfathersname.Clear();
                UtxtDonormothersname.Clear();
                UdateTimePickerDonor.ResetText();
                UtxtDonormobile.Clear();
                UcomboBoxPGender.ResetText();
                UtxtEmaildonor.Clear();
                UcomboBoxBlood.ResetText();
                UrichTxtAdressdonor.Clear();
                txthospitalid.Clear();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textBoxDId.Clear();
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            textBoxDId.Clear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string query = "update AddNewDonor set Dname='" + UtxtDonorname.Text + "', Dfathername='" + UtxtDonorfathersname.Text + "', Dmothername='" + UtxtDonormothersname.Text + "', DDOB='" + UdateTimePickerDonor.Text + "', DMobile='" + UtxtDonormobile.Text + "', DGender ='" + UcomboBoxPGender.Text + "',  DEmail='" + UtxtEmaildonor.Text + "', DBloodgroup ='" + UcomboBoxBlood.Text + "', DAdress='" + UrichTxtAdressdonor.Text + "', HId='" + txthospitalid.Text + "' where DId = " + textBoxDId.Text + "";
            fn.setData(query);
            UpdateDonorDetails_Load(this, null);
        }
    }
}
