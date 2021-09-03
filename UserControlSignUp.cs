using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace VanMau101
{
    public partial class UserControlSignUp : UserControl
    {
        IFirebaseClient client;
        public UserControlSignUp()
        {
            InitializeComponent();
        }

        private void UserControlSignUp_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(frmHome.Config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error {0}", ex), "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput())
                {
                    return;
                }

                btnSignUp.Enabled = false;
                btnSignUp.Text = "Please wait for a sec";

                FirebaseResponse getResponse = await client.GetTaskAsync("Users");
                if (string.Equals(getResponse.Body.ToString(), "null"))
                {
                    RegisterNewUser();
                    return;
                }

                Dictionary<string, Users> getSameID = getResponse.ResultAs<Dictionary<string, Users>>();

                string getSame = "";

                foreach (var sameID in getSameID)
                {
                    getSame = sameID.Value.Username;
                    if (string.Equals(txtUsername.Text,getSame))
                    {
                        MessageBox.Show("Account has been taken\nTry again", "Check input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnSignUp.Text = "Sign Up";
                        btnSignUp.Enabled = true;
                        return;
                    }
                }

                RegisterNewUser();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public async void RegisterNewUser()
        {
            var newUser = new Users
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            SetResponse response = await client.SetTaskAsync("Users/" + newUser.Username, newUser);
            string message = string.Format("Sign up successfull\nNow you can login with username {0}", newUser.Username);
            MessageBox.Show(message, "Sign up successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtUsername.Text = txtPassword.Text = txtConfirmPassword.Text = "";
            chkTerms.Checked = false;
            btnSignUp.Text = "Sign Up";
            btnSignUp.Enabled = true;
        }

        private bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) 
                || string.IsNullOrWhiteSpace(txtPassword.Text) 
                || string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill out all information", "Check input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!string.Equals(txtPassword.Text, txtConfirmPassword.Text))
            {
                MessageBox.Show("Password and password confirm does not match", "Check input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!chkTerms.Checked)
            {
                MessageBox.Show("Please check \"I Agree with Terms\"", "Check input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
