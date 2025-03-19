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
using System.Xml.Linq;

namespace ODPProject
{
    public partial class patienthistory : Form
    {
        public patienthistory()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string patientid = textBoxPid.Text.Trim();
            string dieases = comboBox3.Text.Trim();
            string hospitalid = textBoxHid.Text.Trim();
            string doctorid = textBoxDid.Text.Trim();
            string donorid = textBoxDoid.Text.Trim();
            string orgid = textBoxOrgid.Text.Trim();
            string issue = dateTimePickerHP.Text.Trim();
            string stat = comboBoxHP.Text.Trim();


            if (patientid == " " || dieases == " " || hospitalid == " " || doctorid == " " || donorid == " " || orgid == " " || issue == " " || stat == " ")
            {
                MessageBox.Show("All fields required");
                return;
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=ODP;Integrated Security=True;Encrypt=True; TrustServerCertificate=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Historypatient (PatientID, Dieases, HospitalID, DoctorID, DonorID, OrganID, IssueDate, Status) values (@patientid, @dieases, @hospitalid, @doctorid, @donorid, @orgid, @issue, @stat)", con))
                        {
                            cmd.Parameters.AddWithValue("@patientid", patientid);
                            cmd.Parameters.AddWithValue("@dieases", dieases);
                            cmd.Parameters.AddWithValue("@hospitalid", hospitalid);
                            cmd.Parameters.AddWithValue("@doctorid", doctorid);
                            cmd.Parameters.AddWithValue("@donorid", donorid);
                            cmd.Parameters.AddWithValue("@orgid", orgid);
                            cmd.Parameters.AddWithValue("@issue", issue);
                            cmd.Parameters.AddWithValue("@stat", stat);

                            int status = cmd.ExecuteNonQuery();
                            if (status > 0)
                            {
                                MessageBox.Show("Recorded Data Succesfully!");
                                con.Close();
                                //new LogIn().Show();
                                //this.Close();
                                return;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOrgid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDoid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPid_TextChanged(object sender, EventArgs e)
        {

        }

        private void organid_Click(object sender, EventArgs e)
        {

        }

        private void donorid_Click(object sender, EventArgs e)
        {

        }

        private void DoctorId_Click(object sender, EventArgs e)
        {

        }

        private void Hospitalid_Click(object sender, EventArgs e)
        {

        }

        private void Dieases_Click(object sender, EventArgs e)
        {

        }

        private void patientid_Click(object sender, EventArgs e)
        {

        }

        private void Historypatient_Click(object sender, EventArgs e)
        {

        }
    }
}
