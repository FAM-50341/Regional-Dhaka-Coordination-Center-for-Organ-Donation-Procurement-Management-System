using System;
using System.Collections;
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
    public partial class SearchPatient : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        public SearchPatient()
        {
            InitializeComponent();
        }

        private void CloseSearchPatient_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void SearchPatient_Load(object sender, EventArgs e)
        {
            string query = "select *from AddNewPatient";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            string lct = txtPatientID.Text.Trim();

            if (txtPatientID.Text != "@lct ")
            {
                string query = "SELECT * FROM AddNewPatient WHERE PId LIKE '%" + txtPatientID.Text + "%'";
                try
                {
                    DataSet ds = fn.getData(query);
                    if (ds != null && ds.Tables.Count > 0) // Check if dataset and table exist
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        // Handle no data scenario (e.g., show a message)
                        MessageBox.Show("No matching patients found for this Id.");
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
                string query = "SELECT * FROM AddNewPatient";
                try
                {
                    DataSet ds = fn.getData(query);
                    if (ds != null && ds.Tables.Count > 0) // Check if dataset and table exist
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        // Handle no data scenario (e.g., show a message)
                        MessageBox.Show("No patients found in the database.");
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
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void SearchPatientPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
