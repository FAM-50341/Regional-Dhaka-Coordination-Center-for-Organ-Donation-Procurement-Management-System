using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODPProject
{
    public partial class SearchDonor_byID_ : Form
    {

        PatientIDfunction fn = new PatientIDfunction();
        public SearchDonor_byID_()
        {
            InitializeComponent();
        }

        private void SearchDonor_byID__Load(object sender, EventArgs e)
        {
            string query = "select *from AddNewDonor";
            DataSet ds = fn.getData(query);
            dataGridView7.DataSource = ds.Tables[0];
        }

        private void CloseSearchPatient_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void txtDonorID_TextChanged(object sender, EventArgs e)
        {
            string sdi = txtDonorID.Text.Trim();

            if (txtDonorID.Text != "@sdi")
            {
                string query = "SELECT * FROM AddNewDonor WHERE DId LIKE '%" + txtDonorID.Text + "%'";
                try
                {
                    DataSet ds = fn.getData(query);
                    if (ds != null && ds.Tables.Count > 0) // Check if dataset and table exist
                    {
                        dataGridView7.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        // Handle no data scenario (e.g., show a message)
                        MessageBox.Show("No matching donors found for this Id.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle other potential exceptions during data retrieval
                    MessageBox.Show("Error retrieving data: " + ex.Message);
                }
            }
            else
            {
                // If the location text is empty, show all data
                string query = "SELECT * FROM AddNewDonor";
                try
                {
                    DataSet ds = fn.getData(query);
                    if (ds != null && ds.Tables.Count > 0) // Check if dataset and table exist
                    {
                        dataGridView7.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        // Handle no data scenario (e.g., show a message)
                        MessageBox.Show("No donors found in the database.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle other potential exceptions during data retrieval
                    MessageBox.Show("Error retrieving data: " + ex.Message);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView7.Width, this.dataGridView7.Height);
            dataGridView7.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView7.Width, this.dataGridView7.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void SearchPatientPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
