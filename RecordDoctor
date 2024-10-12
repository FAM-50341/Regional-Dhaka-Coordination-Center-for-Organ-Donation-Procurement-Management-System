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
    public partial class RecordDoctor : Form
    {
        PatientIDfunction fn = new PatientIDfunction();
        public RecordDoctor()
        {
            InitializeComponent();
        }

        private void CloseH_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void RecordDoctor_Load(object sender, EventArgs e)
        {
            string query = "select *from Historydoctor";
            DataSet ds = fn.getData(query);
            dataGridView19.DataSource = ds.Tables[0];
        }
    }
}
