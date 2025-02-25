using Supabase.Interfaces;
using Supabase.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using Supabase;
using SuperBookFinalProj.Models;
using SuperBookFinalProj.Repositories;

namespace SuperBookFinalProj.GUI.LogIn_SignUp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void contactNoLbl_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }


        private async void SignUpBtn_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(txtuName.Text) || txtuName.Text.Length < 3)
            {
                MessageBox.Show("Username is required and must be at least 3 characters.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text) || !txtFullName.Text.All(char.IsLetter) || txtFullName.Text.Length < 3)
            {
                MessageBox.Show("Full Name is required and must be alphabets only with at least 3 characters.");
                return;
            }

            if (string.IsNullOrWhiteSpace(contactNoTxt.Text) || !contactNoTxt.Text.All(char.IsDigit) || contactNoTxt.Text.Length != 10)
            {
                MessageBox.Show("Contact Number is required and must be exactly 10 digits.");
                return;
            }

            if (string.IsNullOrWhiteSpace(emailAddTxt.Text) || !IsValidEmail(emailAddTxt.Text))
            {
                MessageBox.Show("A valid Email Address is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(schoolIDTxt.Text) || !schoolIDTxt.Text.All(char.IsDigit))
            {
                MessageBox.Show("School ID is required and must be numeric.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtpWord.Text) || txtpWord.Text.Length < 6 || !txtpWord.Text.Any(char.IsDigit) || !txtpWord.Text.Any(char.IsUpper))
            {
                MessageBox.Show("Password is required, must be at least 6 characters, with at least one number and one uppercase letter.");
                return;
            }

            try
            {
                ConsumerRepository repo = new ConsumerRepository();

                Consumer consumer = new Consumer
                {
                    user_name = txtuName.Text,
                    full_name = txtFullName.Text,
                    contact_num = contactNoTxt.Text,
                    email_add = emailAddTxt.Text,
                    school_id = int.Parse(schoolIDTxt.Text),
                    password = BCrypt.Net.BCrypt.HashPassword(txtpWord.Text)
                };

                int id = await repo.CreateAsync(consumer); // Call the modified CreateAsync method
                MessageBox.Show($"Sign Up Successful! Your ID is {id}");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Validate email using regex
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Clear input fields after successful sign up
        private void ClearInputs()
        {
            txtuName.Clear();
            txtFullName.Clear();
            contactNoTxt.Clear();
            emailAddTxt.Clear();
            schoolIDTxt.Clear();
            txtpWord.Clear();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
