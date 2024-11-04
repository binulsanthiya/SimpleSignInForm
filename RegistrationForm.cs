using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkillsInternationalSchool
{
    public partial class RegistrationForm : Form
    {
        string connectionString = "Server=LAPTOP-7VP5U14R;Database=Student;Integrated Security=True";
        public RegistrationForm()
        {
            InitializeComponent();
            LoadRegistrationNumbers();
        }
        private void LoadRegistrationNumbers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT regNo FROM Registration";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cbRegNo.Items.Add(reader["regNo"].ToString());
                }
            }
        }
        private void lblDateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Registration (regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) VALUES (@regNo, @firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@regNo", cbRegNo.Text);
                command.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@lastName", txtLastName.Text);
                command.Parameters.AddWithValue("@dateOfBirth", dtpDateOfBirth.Value);
                command.Parameters.AddWithValue("@gender", rbMale.Checked ? "Male" : "Female");
                command.Parameters.AddWithValue("@address", txtAddress.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@mobilePhone", txtMobilePhone.Text);
                command.Parameters.AddWithValue("@homePhone", txtHomePhone.Text);
                command.Parameters.AddWithValue("@parentName", txtParentName.Text);
                command.Parameters.AddWithValue("@nic", txtNic.Text);
                command.Parameters.AddWithValue("@contactNo", txtContactNo.Text);

                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Registration SET firstName=@firstName, lastName=@lastName, dateOfBirth=@dateOfBirth, gender=@gender, address=@address, email=@email, mobilePhone=@mobilePhone, homePhone=@homePhone, parentName=@parentName, nic=@nic, contactNo=@contactNo WHERE regNo=@regNo";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@regNo", cbRegNo.Text);
                command.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                command.Parameters.AddWithValue("@lastName", txtLastName.Text);
                command.Parameters.AddWithValue("@dateOfBirth", dtpDateOfBirth.Value);
                command.Parameters.AddWithValue("@gender", rbMale.Checked ? "Male" : "Female");
                command.Parameters.AddWithValue("@address", txtAddress.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@mobilePhone", txtMobilePhone.Text);
                command.Parameters.AddWithValue("@homePhone", txtHomePhone.Text);
                command.Parameters.AddWithValue("@parentName", txtParentName.Text);
                command.Parameters.AddWithValue("@nic", txtNic.Text);
                command.Parameters.AddWithValue("@contactNo", txtContactNo.Text);

                connection.Open();
                command.ExecuteNonQuery();

                MessageBox.Show("Update successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            cbRegNo.Text = "";
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobilePhone.Clear();
            txtHomePhone.Clear();
            txtParentName.Clear();
            txtNic.Clear();
            txtContactNo.Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Registration WHERE regNo=@regNo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@regNo", cbRegNo.Text);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Delete successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadRegistrationNumbers();
                }
            }
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void cbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Registration WHERE regNo=@regNo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@regNo", cbRegNo.Text);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtFirstName.Text = reader["firstName"].ToString();
                    txtLastName.Text = reader["lastName"].ToString();
                    dtpDateOfBirth.Value = Convert.ToDateTime(reader["dateOfBirth"]);
                    if (reader["gender"].ToString() == "Male")
                    {
                        rbMale.Checked = true;
                    }
                    else
                    {
                        rbFemale.Checked = true;
                    }
                    txtAddress.Text = reader["address"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtMobilePhone.Text = reader["mobilePhone"].ToString();
                    txtHomePhone.Text = reader["homePhone"].ToString();
                    txtParentName.Text = reader["parentName"].ToString();
                    txtNic.Text = reader["nic"].ToString();
                    txtContactNo.Text = reader["contactNo"].ToString();
                }
            }
        }
    }
}
