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
    public partial class Hospital : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        String query;
        public Hospital()
        {
            InitializeComponent();
        }

        private void CloseH_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void Hospital_Load(object sendeusingr, EventArgs e)
        {
            query = "select *from Hospital";
            DataSet ds = fn.getData(query);
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void txtHLocation_TextChanged(object sender, EventArgs e)
        {
            
            string shl = txtHLocation.Text.Trim();
            if (txtHLocation.Text != "@shl ")
            {
                query = "select * from Hospital where HAdress like '" + txtHLocation.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView3.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from Hospital";
                DataSet ds = fn.getData(query);
                dataGridView3.DataSource = ds.Tables[0];

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView3.Width, this.dataGridView3.Height);
            dataGridView3.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView3.Width, this.dataGridView3.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void Hprint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
