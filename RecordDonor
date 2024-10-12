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
    public partial class RecordDonor : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        public RecordDonor()
        {
            InitializeComponent();
        }

        private void CloseH_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void RecordDonor_Load(object sender, EventArgs e)
        {
            string query = "select *from Historydonor";
            DataSet ds = fn.getData(query);
            dataGridView18.DataSource = ds.Tables[0];
        }
    }
}
