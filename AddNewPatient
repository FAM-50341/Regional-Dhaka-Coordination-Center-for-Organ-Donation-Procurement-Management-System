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
    public partial class AddNewPatient : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        public AddNewPatient()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Closeaddpatient_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void AddNewPatient_Load(object sender, EventArgs e)
        {
            try
            {
                String query = "select max (PId) from AddNewPatient";
                DataSet ds = fn.getData(query);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    string patientIDStr = ds.Tables[0].Rows[0][0].ToString();
                    int count;

                    if (int.TryParse(patientIDStr, out count))
                    {
                        IDno.Text = (count + 1).ToString();
                    }
                    else
                    {
                        Console.WriteLine("Error parsing patient ID: Invalid format");
                        // Handle the case where the retrieved data is not a valid integer
                    }
                }
                else
                {
                    // Handle the case where there are no patients yet (set ID to 1)
                    IDno.Text = "1";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting max patient ID: " + ex.Message);
                // Log the exception details for further investigation
            }
        }

        private void save_Click(object sender, EventArgs e)
        {

            // Check for empty fields using string.IsNullOrEmpty()
            if (!string.IsNullOrEmpty(txtPatientname.Text) &&
                !string.IsNullOrEmpty(txtPatientfathersname.Text) &&
                !string.IsNullOrEmpty(txtPatientmothersname.Text) &&
                !string.IsNullOrEmpty(dateTimePickerPatient.Text) &&
                !string.IsNullOrEmpty(txtPatientmobile.Text) &&
                !string.IsNullOrEmpty(comboBoxPGender.Text) &&
                !string.IsNullOrEmpty(txtEmailPatient.Text) &&
                !string.IsNullOrEmpty(comboBoxBlood.Text) &&
                !string.IsNullOrEmpty(richTxtAdresspatient.Text))
            {
                string pname = txtPatientname.Text;
                string pfather = txtPatientfathersname.Text;
                string pmother = txtPatientmothersname.Text;
                string pDOB = dateTimePickerPatient.Text;
                string pmobile = txtPatientmobile.Text;
                string pgender = comboBoxPGender.Text;
                string pemail = txtEmailPatient.Text;
                string pblood = comboBoxBlood.Text;
                string padress = richTxtAdresspatient.Text;

                // Use parameterized queries to prevent SQL injection
                string query = "INSERT INTO AddNewPatient (PName, PFathername, PMothername, PDOB, PMobile, PGender, PEmail, PBloodgroup, PAdress) " +
                               "VALUES (@PName, @PFathername, @PMothername, @PDOB, @PMobile, @PGender, @PEmail, @PBloodgroup, @PAdress)";

                // Create and open a connection (assuming 'fn' is your data access layer)
                using (var connection = fn.GetConnection())
                {
                    connection.Open();

                    // Create a command object
                    using (var command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@PName", pname);
                        command.Parameters.AddWithValue("@PFathername", pfather);
                        command.Parameters.AddWithValue("@PMothername", pmother);
                        command.Parameters.AddWithValue("@PDOB", pDOB);
                        command.Parameters.AddWithValue("@PMobile", pmobile);
                        command.Parameters.AddWithValue("@PGender", pgender);
                        command.Parameters.AddWithValue("@PEmail", pemail);
                        command.Parameters.AddWithValue("@PBloodgroup", pblood);
                        command.Parameters.AddWithValue("@PAdress", padress);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Patient data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtPatientname.Text = "";  // Clear text box
            txtPatientfathersname.Text = "";  // Clear text box
            txtPatientmothersname.Text = "";  // Clear text box
            dateTimePickerPatient.Value = DateTime.Now;  // Set date picker to current date/time
            txtPatientmobile.Text = "";  // Clear text box
            comboBoxPGender.SelectedIndex = -1;  // Reset combo box selection (if applicable)
            txtEmailPatient.Text = "";  // Clear text box
            comboBoxBlood.SelectedIndex = -1;  // Reset combo box selection (if applicable)
            richTxtAdresspatient.Text = "";  // Clear rich text box
        }
    }
}
