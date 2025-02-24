using Supabase.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
                string firstName = firstNameTxt.Text;
                string lastName = lastNameTxt.Text;
                string fullName = $"{firstName} {lastName}"; // Combine first and last name
                string userName = txtuName.Text;
                string password = txtpWord.Text;
                string contactNo = contactNoTxt.Text;
                string email = emailAddTxt.Text;
                string schoolId = schoolIDTxt.Text;

                string hashedPassword = BCrypt.HashPassword(password);
                // Hash the password for security
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                var user = new
                {
                    full_name = fullName, // Use the combined full name
                    user_name = userName,
                    password = hashedPassword,
                    contact_no = contactNo,
                    email = email,
                    school_id = schoolId,
                    department = "User" // Default department for regular users
                };

                var response = await SupaBaseClient.Client
                    .From("users")
                    .Insert(user);

                if (response.ResponseMessage.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sign up successful!");
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sign up failed. Please try again.");
                }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
