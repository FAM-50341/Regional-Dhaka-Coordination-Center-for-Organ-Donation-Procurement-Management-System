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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Areyou_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            LogIn ln = new LogIn();
            ln.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Patient")
            {
                DialogResult dialogResult = MessageBox.Show("Dear User, Go to \"Patient\"", "Patient Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DonorInfo.Enabled = false;
                Doctorinfo.Enabled = false;
                recordpatient.Enabled = false;
                recorddonor.Enabled = false;
                recorddoctor.Enabled = false;
            }
            else if (comboBox1.Text == "Donor")
            {
                DialogResult dialogResult = MessageBox.Show(" Dear User, Go to \"Donor\"", "Donor Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PatientInfo.Enabled = false;
                Doctorinfo.Enabled = false;
                recordpatient.Enabled = false;
                recorddonor.Enabled = false;
                recorddoctor.Enabled = false;
            }
            else if (comboBox1.Text == "Doctor")
            {
                DialogResult dialogResult = MessageBox.Show(" Dear User, Go to \"Doctor\"", "Doctor Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PatientInfo.Enabled = false;
                DonorInfo.Enabled = false;
                recordpatient.Enabled = false;
                recorddonor.Enabled = false;
                recorddoctor.Enabled = false;

                
            }
            else if (comboBox1.Text == "Admin")
            {
                DialogResult dialogResult = MessageBox.Show("Dear Admin, Greetings","Admin Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PatientInfo.Enabled = false;
                DonorInfo.Enabled = false;
                Doctorinfo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please select your type!");
                return;
            }
        }

        private void SearchDonor_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click_1(object sender, EventArgs e)
        {
            LogIn ln = new LogIn();
            ln.Show();
            this.Close();
        }

        private void Addnewpatient_Click(object sender, EventArgs e)
        {
            AddNewPatient anp = new AddNewPatient();
            anp.Show();
        }

        private void Updatedetails_Click(object sender, EventArgs e)
        {
            UpdatePatientDetails upd = new UpdatePatientDetails();
            upd.Show();
        }

        private void AllPatientDetails_Click(object sender, EventArgs e)
        {
            AllPatientDetails apd = new AllPatientDetails();
            apd.Show();
        }

        private void PLocation_Click(object sender, EventArgs e)
        {
            SearchPatient sp = new SearchPatient();
            sp.Show();
        }

        private void PBloodgroup_Click(object sender, EventArgs e)
        {
            SearchPatientbyBloodGroup spbg = new SearchPatientbyBloodGroup();
            spbg.Show();
        }

        private void Seeupdateinfo_Click(object sender, EventArgs e)
        {
            Hospital hpt = new Hospital();
            hpt.Show();
        }

        private void Helpline_Click(object sender, EventArgs e)
        {
            HHotline hh = new HHotline();
            hh.Show();
        }

        private void AddnewDonor_Click(object sender, EventArgs e)
        {
            AddNewDonor and = new AddNewDonor();
            and.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDonorDetails udd = new UpdateDonorDetails();
            udd.Show();
        }

        private void allDonorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllDonorDetails add = new AllDonorDetails();
            add.Show();
        }
       
        private void donorIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonor_byID_ si = new SearchDonor_byID_();
            si.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDonor_ByBlood_ sdb = new SearchDonor_ByBlood_();
            sdb.Show();

        }

        private void Addnewdoctor_Click(object sender, EventArgs e)
        {
            AddNewDoctor ando = new AddNewDoctor();
            ando.Show();
        }

        private void updatedoctordetails_Click(object sender, EventArgs e)
        {
            UpdateDoctorDetails uddo = new UpdateDoctorDetails();
            uddo.Show();
        }

        private void allDoctorDetails_Click(object sender, EventArgs e)
        {
            AllDoctorDetails addt = new AllDoctorDetails();
            addt.Show();
        }

        private void hospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchDoctor sd = new SearchDoctor();
            sd.Show();
        }

        private void InfoOfOrgan_Click(object sender, EventArgs e)
        {
            Organ og = new Organ();
            og.Show();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            patienthistory ph = new patienthistory();
            ph.Show();
        }

        private void donorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DonorHistory dh = new DonorHistory();
            dh.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryDoctor htd = new HistoryDoctor();
            htd.Show();
        }

        private void patientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RecordPatient rp = new RecordPatient();
            rp.Show();
        }

        private void donorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RecordDonor rd = new RecordDonor();
            rd.Show();
        }

        private void doctorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RecordDoctor rdoc = new RecordDoctor();
            rdoc.Show();
        }
    }
}
