using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ODPProject
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void HideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (HideShow.Text == "Show Password")
            {
                HideShow.Text = "Hide Password";
                textboxPassword.PasswordChar = '\0';
            }
            else
            {
                HideShow.Text = "Show Password";
                textboxPassword.PasswordChar = '*';
            }
        }

        private void TermsCondition_CheckedChanged(object sender, EventArgs e)
        {
            btnLogIn.Enabled = TermsCondition.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogIn.Enabled = false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textboxPassword.Text.Trim();
            if (username == "" || password == "")
            {
                MessageBox.Show("Username and Password required!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS01; Initial Catalog=ODP; Integrated Security=True; TrustServerCertificate=True"))
                {
                    conn.Open();
                    using (SqlCommand selectCmd = new SqlCommand("SELECT Username, Password FROM login WHERE Username = @uname AND Password = @password", conn))
                    {
                        selectCmd.Parameters.AddWithValue("@uname", username);
                        selectCmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                MessageBox.Show("Logged in Successfully!");
                                new Dashboard().Show();
                                this.Hide();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void btnReg_Click(object sender, EventArgs e)
        {
            new Registration().Show();
            this.Hide();
        }
    }
}
