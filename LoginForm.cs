using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SkillsInternationalSchool

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=LAPTOP-7VP5U14R;Database=Student;Integrated Security=True";
            string query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", txtUsername.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count == 1)
                {
                    this.Hide();
                    RegistrationForm registrationForm = new RegistrationForm();
                    registrationForm.Show();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
