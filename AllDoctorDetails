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
    public partial class AllDonorDetails : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        public AllDonorDetails()
        {
            InitializeComponent();
        }

        private void Closeallpatient_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void AllDonorDetails_Load(object sender, EventArgs e)
        {
            string query = "select * from AddNewDonor";

            DataSet ds = fn.getData(query);
            dataGridView6.DataSource = ds.Tables[0];
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView6.Width, this.dataGridView6.Height);
            dataGridView6.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView6.Width, this.dataGridView6.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void Print_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
