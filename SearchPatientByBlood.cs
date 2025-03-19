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
    public partial class SearchPatientbyBloodGroup : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        String query;
        public SearchPatientbyBloodGroup()
        {
            InitializeComponent();
        }

        private void CloseSearchPatient_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void SearchPatientbyBloodGroup_Load(object sender, EventArgs e)
        {
            query = "select *from AddNewPatient";
            DataSet ds = fn.getData(query);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void txtPBlood_TextChanged(object sender, EventArgs e)
        {
            if (txtPBlood.Text!= " ")
            {
                query = "select * from AddNewPatient where PBloodgroup like '"+txtPBlood.Text+"%'";
                DataSet ds = fn.getData(query);
                dataGridView2.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from AddNewPatient";
                DataSet ds = fn.getData(query);
                dataGridView2.DataSource = ds.Tables[0];

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView2.Width, this.dataGridView2.Height);
            dataGridView2.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView2.Width, this.dataGridView2.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void SearchPatientPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
