using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace ODPProject
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void City_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string date_of_birth = dateTimePicker1.Text.Trim();
            string medical_insurance = txtMediInsurance.Text.Trim();
            string medical_history = txtMediHistory.Text.Trim();
            string street = txtStreet.Text.Trim();
            string city = txtCity.Text.Trim();
            string state = txtState.Text.Trim();
            string blood_group = txtBloodGroup.Text.Trim();
            string phone_number = txtPhoneNumber.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm_password = txtConfirmPassword.Text.Trim();

            if (name == " " || date_of_birth == " " || medical_insurance == " " || medical_history == " " || street == " " || city == " " || state == " " || blood_group == " " || phone_number == " " || password == " " || confirm_password == " ")
            {
                MessageBox.Show("All fields required");
                return;
            }
            else if (password != confirm_password)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }
            else
            {
                //perform registration logic
                try
                {
                    //MySqlConnection conn = new MySqlConnection(connString);
                    using (SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS01;Initial Catalog=ODP;Integrated Security=True;Encrypt=True; TrustServerCertificate=True"))
                    {
                        con.Open();
                        // string query = "INSERT INTO registration(Name, Date_of_Birth, Medical_Insurance, Medical_History, Street, City, State, Blood_Group, Phone_Number, Password, Confirm_Password) values (@name, @date_of_Birth, @medical_insurance, @medical_history, @street, @city, @state, @blood_group, @phone_number, @password, @confirm_password)";

                        // MySqlCommand cmd = new MySqlCommand(query, conn);
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO registration(Name, Date_of_Birth, Medical_Insurance, Medical_History, Street, City, State, Blood_Group, Phone_Number, Password, Confirm_Password) values (@name, @date_of_Birth, @medical_insurance, @medical_history, @street, @city, @state, @blood_group, @phone_number, @password, @confirm_password)", con))
                        {
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@date_of_Birth", date_of_birth);
                            cmd.Parameters.AddWithValue("@medical_insurance", medical_insurance);
                            cmd.Parameters.AddWithValue("@medical_history", medical_history);
                            cmd.Parameters.AddWithValue("@street", street);
                            cmd.Parameters.AddWithValue("@city", city);
                            cmd.Parameters.AddWithValue("@state", state);
                            cmd.Parameters.AddWithValue("@blood_group", blood_group);
                            cmd.Parameters.AddWithValue("@phone_number", phone_number);
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@confirm_password", confirm_password);

                            int status = cmd.ExecuteNonQuery();
                            if (status > 0 )
                            {
                                MessageBox.Show("Account created Succesfully!");
                                con.Close();
                                new LogIn().Show();
                                this.Close();
                                return;
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

    }
}
