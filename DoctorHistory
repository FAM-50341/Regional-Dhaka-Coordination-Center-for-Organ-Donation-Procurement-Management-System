using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ODPProject
{
    public partial class HistoryDoctor : Form
    {
        public HistoryDoctor()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string docid = textBoxDocid.Text.Trim();
            string dept = comboBox5.Text.Trim();
            string hospitalid = textBoxHid.Text.Trim();
            string donid = textBoxDid.Text.Trim();
            string paid = textBoxPaId.Text.Trim();
            string orgid = textBoxOrgid.Text.Trim();
            string issue = dateTimePickerDoc.Text.Trim();
            string stat = comboBoxDoc.Text.Trim();
            if (docid == " " || dept == " " || hospitalid == " " || donid == " " || paid == " " || orgid == " " || issue == " " || stat == " ")
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
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Historydoctor (DocID, Department, HospitalID, DonorID, PatientID, OrganID, IssueDate, Status) values (@docid, @dept, @hospitalid, @donid, @paid, @orgid, @issue, @stat)", con))
                        {
                            cmd.Parameters.AddWithValue("@docid", docid);
                            cmd.Parameters.AddWithValue("@dept", dept);
                            cmd.Parameters.AddWithValue("@hospitalid", hospitalid);
                            cmd.Parameters.AddWithValue("@donid", donid);
                            cmd.Parameters.AddWithValue("@paid", paid);
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
