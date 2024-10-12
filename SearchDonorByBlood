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
    public partial class SearchDonor_ByBlood_ : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        String query;
        public SearchDonor_ByBlood_()
        {
            InitializeComponent();
        }

        private void CloseSearchDonor_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void SearchDonor_ByBlood__Load(object sender, EventArgs e)
        {
            query = "select *from AddNewDonor";
            DataSet ds = fn.getData(query);
            dataGridView9.DataSource = ds.Tables[0];
        }

        private void txtDBlood_TextChanged(object sender, EventArgs e)
        {
            if (txtDBlood.Text != " ")
            {
                query = "select * from AddNewDonor where DBloodgroup like '" + txtDBlood.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView9.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from AddNewDonor";
                DataSet ds = fn.getData(query);
                dataGridView9.DataSource = ds.Tables[0];

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView9.Width, this.dataGridView9.Height);
            dataGridView9.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView9.Width, this.dataGridView9.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void SearchDonortPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
