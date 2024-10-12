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
    public partial class RecordPatient : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        public RecordPatient()
        {
            InitializeComponent();
        }

        private void CloseH_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void RecordPatient_Load(object sender, EventArgs e)
        {
            string query = "select *from Historypatient";
            DataSet ds = fn.getData(query);
            dataGridView17.DataSource = ds.Tables[0];
        }
    }
}
