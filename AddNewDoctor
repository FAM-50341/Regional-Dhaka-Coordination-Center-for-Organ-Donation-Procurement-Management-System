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
    public partial class AddNewDoctor : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        public AddNewDoctor()
        {
            InitializeComponent();
        }

        private void AddNewDoctor_Load(object sender, EventArgs e)
        {
            try
            {
                String query = "select max (DocId) from AddNewDoctor";
                DataSet ds = fn.getData(query);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    string doctorIDStr = ds.Tables[0].Rows[0][0].ToString();
                    int count;

                    if (int.TryParse(doctorIDStr, out count))
                    {
                        DoctorIDno.Text = (count + 1).ToString();
                    }
                    else
                    {
                        Console.WriteLine("Error parsing Doctor ID: Invalid format");
                        // Handle the case where the retrieved data is not a valid integer
                    }
                }
                else
                {
                    // Handle the case where there are no patients yet (set ID to 1)
                    DoctorIDno.Text = "1001";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting max Doctor ID: " + ex.Message);
                // Log the exception details for further investigation
            }

        }

        private void Closeaddpatient_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDoctorname.Text) &&
                !string.IsNullOrEmpty(comboBoxHospitalname.Text) &&
                !string.IsNullOrEmpty(comboBox2.Text) &&
                !string.IsNullOrEmpty(textBoxContact.Text))
            {
                string docname = txtDoctorname.Text;
                string docHospital = comboBoxHospitalname.Text;
                string ddepartment = comboBox2.Text;
                string dcontact = textBoxContact.Text;

                string query = "INSERT INTO AddNewDoctor (Docname, DocHospitalname, DocDepartment ,Contact) " +
                               "VALUES (@Docname, @DocHospitalname, @DocDepartment, @Contact)";

                using (var connection = fn.GetConnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection (corrected spelling)
                        command.Parameters.AddWithValue("@Docname", docname);
                        command.Parameters.AddWithValue("@DocHospitalname", docHospital); // Corrected variable name
                        command.Parameters.AddWithValue("@DocDepartment", ddepartment);
                        command.Parameters.AddWithValue("@Contact", dcontact);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Doctor data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Reset_Click(object sender, EventArgs e)
        {
            txtDoctorname.Text = "";  // Clear text box
            comboBoxHospitalname.SelectedIndex = -1;  // Reset combo box selection (if applicable
            comboBox2.SelectedIndex = -1;  // Reset combo box selection (if applicable)
            textBoxContact.Text = "";
        }

        private void txtDoctorname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
