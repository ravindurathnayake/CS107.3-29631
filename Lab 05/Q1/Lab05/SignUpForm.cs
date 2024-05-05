using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Q5
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                DateTime dob = dtpDOB.Value;
                string email = txtEmail.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
                {
                    throw new Exception("All fields are required.");
                }

                if (!password.Equals(confirmPassword))
                {
                    throw new Exception("Password and confirm password do not match.");
                }

                if (!IsString(firstName) || !IsString(lastName))
                {
                    throw new Exception("First name and last name should only contain alphabets.");
                }

                MessageBox.Show("Signup successful!");

                User user = new User(firstName, lastName, dob, email, username);
                DisplayForm displayForm = new DisplayForm(user);
                displayForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool IsString(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDOB.Value = DateTime.Today;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }
    }
}