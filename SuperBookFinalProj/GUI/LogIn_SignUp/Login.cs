using SuperBookFinalProj.Models;
using SuperBookFinalProj.Repositories;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            string uName = unameTxt.Text.Trim();
            string pWord = pwordTxt.Text.Trim();

            // 🔹 Input Validation: Ensure fields are not empty
            if (string.IsNullOrWhiteSpace(uName) || string.IsNullOrWhiteSpace(pWord))
            {
                MessageBox.Show("❌ Username and Password cannot be empty!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 🔹 Check if the user is Admin
                Admin admin = new Admin("Superbook", "admin", uName, pWord);
                if (admin.validateLogin(uName, pWord))
                {
                    MessageBox.Show("✅ Welcome, Admin!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    HomeFrmAdmin homeFrmAdmin = new HomeFrmAdmin();
                    homeFrmAdmin.ShowDialog();
                    this.Close();
                    return;
                }

                // 🔹 Authenticate normal users from Supabase
                ConsumerRepository repo = new ConsumerRepository();
                Consumer user = await repo.AuthenticateUserAsync(uName, pWord);

                if (user != null)
                {
                    MessageBox.Show($"✅ Welcome, {user.full_name}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    HomeFrm home_form = new HomeFrm();
                    home_form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("❌ Incorrect Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lblsignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signup = new SignUp();
            signup.ShowDialog();
            this.Close();
        }

        private void unameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
