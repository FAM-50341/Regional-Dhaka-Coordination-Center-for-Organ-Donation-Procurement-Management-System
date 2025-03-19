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
    public partial class DonorHistory : Form
    {
        public DonorHistory()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string donid = textBoxDonid.Text.Trim();
            string organdon = comboBox4.Text.Trim();
            string hospitalid = textBoxHid.Text.Trim();
            string doctorid = textBoxDid.Text.Trim();
            string patid = textBoxPaId.Text.Trim();
            string orgid = textBoxOrgid.Text.Trim();
            string issue = dateTimePickerDH.Text.Trim();
            string stat = comboBoxDH.Text.Trim();
            if (donid == " " || organdon == " " || hospitalid == " " || doctorid == " " || patid == " " || orgid == " " || issue == " " || stat == " ")
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
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Historydonor (DonorID, OrganDonated, HospitalID, DoctorID, PatientID, OrganID, IssueDate, Status) values (@donid, @organdon, @hospitalid, @doctorid, @patid, @orgid, @issue, @stat)", con))
                        {
                            cmd.Parameters.AddWithValue("@donid", donid);
                            cmd.Parameters.AddWithValue("@organdon", organdon);
                            cmd.Parameters.AddWithValue("@hospitalid", hospitalid);
                            cmd.Parameters.AddWithValue("@doctorid", doctorid);
                            cmd.Parameters.AddWithValue("@patid", patid);
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
    }
    
    
}
