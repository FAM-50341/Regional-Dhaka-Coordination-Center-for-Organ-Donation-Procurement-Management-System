using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODPProject
{
    public partial class Organ : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        String query;
        public Organ()
        {
            InitializeComponent();
        }

        //private void Organ_Load(object sender, EventArgs e)
        // {
        //   query = "select *from Organ";
        //   DataSet ds = fn.getData(query);
        //   dataGridView15.DataSource = ds.Tables[0];
        // }
        private void Organ_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM OrganData";
                DataSet ds = fn.getData(query);
                dataGridView15.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                // Log the exception details for debugging
                Console.WriteLine("An error occurred while loading organ data:");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                // Display a user-friendly error message
                MessageBox.Show("Error loading organ data. Please contact your system administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseH_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView15.Width, this.dataGridView15.Height);
            dataGridView15.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView15.Width, this.dataGridView15.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void Hprint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void dataGridView15_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
