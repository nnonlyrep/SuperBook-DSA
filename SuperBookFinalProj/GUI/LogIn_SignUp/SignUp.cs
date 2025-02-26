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
            // ✅ Input Validation
            if (!ValidateInputs())
            {
                return; // Stops execution if validation fails
            }

            try
            {
                ConsumerRepository repo = new ConsumerRepository();

                Consumer consumer = new Consumer
                {
                    user_name = txtuName.Text.Trim(),
                    full_name = txtFullName.Text.Trim(),
                    contact_num = contactNoTxt.Text.Trim(),
                    email_add = emailAddTxt.Text.Trim(),
                    school_id = int.Parse(schoolIDTxt.Text.Trim()),
                    password = BCrypt.Net.BCrypt.HashPassword(txtpWord.Text.Trim())
                };

                int id = await repo.CreateAsync(consumer); // Call the modified CreateAsync method
                MessageBox.Show($"✅ Sign Up Successful! Your ID is {id}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Clears input fields after successful sign-up
                ClearInputs();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"❌ Request Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ✅ Method to Validate Inputs
        private bool ValidateInputs()
        {
            // Username validation
            if (string.IsNullOrWhiteSpace(txtuName.Text) || txtuName.Text.Length < 3)
            {
                MessageBox.Show("❌ Username is required and must be at least 3 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Full Name validation (allows spaces between words)
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || txtFullName.Text.Length < 3 || !txtFullName.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("❌ Full Name is required and must contain only letters with at least 3 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Contact Number validation (must be exactly 10 digits)
            if (!long.TryParse(contactNoTxt.Text, out _) || contactNoTxt.Text.Length < 10)
            {
                MessageBox.Show("❌ Contact Number is required and must be at least 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Email validation
            if (string.IsNullOrWhiteSpace(emailAddTxt.Text) || !IsValidEmail(emailAddTxt.Text))
            {
                MessageBox.Show("❌ A valid Email Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // School ID validation (must be numeric)
            if (!int.TryParse(schoolIDTxt.Text, out _))
            {
                MessageBox.Show("❌ School ID is required and must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Password validation (must contain at least 1 uppercase letter, 1 digit, and be at least 6 characters)
            if (string.IsNullOrWhiteSpace(txtpWord.Text) || txtpWord.Text.Length < 6 ||
                !txtpWord.Text.Any(char.IsUpper) || !txtpWord.Text.Any(char.IsDigit))
            {
                MessageBox.Show("❌ Password must be at least 6 characters long and include at least one uppercase letter and one number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // ✅ All validations passed
        }
        // ✅ Validate email using regex
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
