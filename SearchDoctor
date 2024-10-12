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
    public partial class SearchDoctor : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        String query;
        public SearchDoctor()
        {
            InitializeComponent();
        }

        private void CloseSearchDoctor_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void SearchDoctor_Load(object sender, EventArgs e)
        {
            query = "select *from AddNewDoctor";
            DataSet ds = fn.getData(query);
            dataGridView13.DataSource = ds.Tables[0];
        }

        private void txtDocLoc_TextChanged(object sender, EventArgs e)
        {
            if (txtDocHos.Text != " ")
            {
                query = "select * from AddNewDoctor where DocHospitalname like '" + txtDocHos.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView13.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from AddNewDoctor";
                DataSet ds = fn.getData(query);
                dataGridView13.DataSource = ds.Tables[0];

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView13.Width, this.dataGridView13.Height);
            dataGridView13.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView13.Width, this.dataGridView13.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void SearchDoctorPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
