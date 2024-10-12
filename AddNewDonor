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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ODPProject
{
    public partial class AddNewDonor : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void Closeaddpatient_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {

            try
            {
                String query = "select max (DId) from AddNewDonor";
                DataSet ds = fn.getData(query);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    string donorIDStr = ds.Tables[0].Rows[0][0].ToString();
                    int count;

                    if (int.TryParse(donorIDStr, out count))
                    {
                        DonorIDno.Text = (count + 1).ToString();
                    }
                    else
                    {
                        Console.WriteLine("Error parsing donor ID: Invalid format");
                        // Handle the case where the retrieved data is not a valid integer
                    }
                }
                else
                {
                    // Handle the case where there are no patients yet (set ID to 1)
                    DonorIDno.Text = "1";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting max Donor ID: " + ex.Message);
                // Log the exception details for further investigation
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDonorname.Text) &&
               !string.IsNullOrEmpty(txtDonorfathersname.Text) &&
               !string.IsNullOrEmpty(txtDonormothersname.Text) &&
               !string.IsNullOrEmpty(dateTimePickerDonor.Text) &&
               !string.IsNullOrEmpty(txtDonormobile.Text) &&
               !string.IsNullOrEmpty(comboBoxPGender.Text) &&
               !string.IsNullOrEmpty(txtEmailDonor.Text) &&
               !string.IsNullOrEmpty(comboBoxBlood.Text) &&
               !string.IsNullOrEmpty(richTxtAdressdonor.Text) &&
               !string.IsNullOrEmpty(txthospitalid.Text)
                    )
            {
                    string dname = txtDonorname.Text;
                    string dfather = txtDonorfathersname.Text;
                    string dmother = txtDonormothersname.Text;
                    string dDOB = dateTimePickerDonor.Text;
                    string dmobile = txtDonormobile.Text;
                    string dgender = comboBoxPGender.Text;
                    string demail = txtEmailDonor.Text;
                    string dblood = comboBoxBlood.Text;
                    string dadress = richTxtAdressdonor.Text;
                    string dhid = txthospitalid.Text;
                string query = "INSERT INTO AddNewDonor (DName, DFathername, DMothername, DDOB, DMobile, DGender, DEmail, DBloodgroup, DAdress, HId) " +
                              "VALUES (@DName, @DFathername, @DMothername, @DDOB, @DMobile, @DGender, @DEmail, @DBloodgroup, @DAdress, @HId)";
                using (var connection = fn.GetConnection())
                {
                    connection.Open();

                    // Create a command object
                    using (var command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@DName", dname);
                        command.Parameters.AddWithValue("@DFathername", dfather);
                        command.Parameters.AddWithValue("@DMothername", dmother);
                        command.Parameters.AddWithValue("@DDOB", dDOB);
                        command.Parameters.AddWithValue("@DMobile", dmobile);
                        command.Parameters.AddWithValue("@DGender", dgender);
                        command.Parameters.AddWithValue("@DEmail", demail);
                        command.Parameters.AddWithValue("@DBloodgroup", dblood);
                        command.Parameters.AddWithValue("@DAdress", dadress);
                        command.Parameters.AddWithValue("@HId",dhid);
                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Donor data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        { 
            txtDonorname.Text = "";  // Clear text box
            txtDonorfathersname.Text = "";  // Clear text box
            txtDonormothersname.Text = "";  // Clear text box
            dateTimePickerDonor.Value = DateTime.Now;  // Set date picker to current date/time
            txtDonormobile.Text = "";  // Clear text box
            comboBoxPGender.SelectedIndex = -1;  // Reset combo box selection (if applicable)
            txtEmailDonor.Text = "";  // Clear text box
            comboBoxBlood.SelectedIndex = -1;  // Reset combo box selection (if applicable)
            richTxtAdressdonor.Text = "";  //
            txthospitalid.Text = "";
        }
    }
}

