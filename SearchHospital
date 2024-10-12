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
    public partial class HHotline : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        String query;
        public HHotline()
        {
            InitializeComponent();
        }

        private void CloseHotline_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void HHotline_Load(object sender, EventArgs e)
        {
            query = "select *from Hotline";
            DataSet ds = fn.getData(query);
            dataGridView5.DataSource = ds.Tables[0];
        }

        private void txtHID_TextChanged(object sender, EventArgs e)
        {
            string ht = txtHID.Text.Trim();
            if (txtHID.Text != "@ht ")
            {
                query = "select * from Hotline where HId like '" + txtHID.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView5.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from Hotline";
                DataSet ds = fn.getData(query);
                dataGridView5.DataSource = ds.Tables[0];

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView5.Width, this.dataGridView5.Height);
            dataGridView5.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView5.Width, this.dataGridView5.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void Hotlineprint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
