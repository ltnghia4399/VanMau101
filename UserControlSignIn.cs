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
using FireSharp.Interfaces;
using FireSharp.Response;

namespace VanMau101
{
    public partial class UserControlSignIn : UserControl
    {
        IFirebaseClient client;

        public UserControlSignIn()
        {
            InitializeComponent();
        }

        private void UserControlSignIn_Load(object sender, EventArgs e)
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

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPass.Checked;
        }

        private void chkShowPass_Leave(object sender, EventArgs e)
        {
            chkShowPass.Checked = false;
        }

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput())
                {
                    return;
                }

                btnSignIn.Enabled = false;
                FirebaseResponse getUsers = await client.GetTaskAsync("Users/" + txtUsername.Text.Trim());

                if (string.Equals(getUsers.Body.ToString(), "null")){
                    MessageBox.Show("User does not exist", "Check input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSignIn.Enabled = true;
                    return;
                }

                Users user = getUsers.ResultAs<Users>();

                Users curUser = new Users
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim()
                };

                if (Users.IsEqual(user, curUser))
                {
                    MessageBox.Show("Login successfull\nNow you can edit data", "Check input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSignIn.Enabled = true;
                    frmHome.accessGranted = true;
                    this.ParentForm.Close();
                }
                else
                {
                    Users.ShowError();
                    btnSignIn.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Sign up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text.Trim()) ||
                string.IsNullOrWhiteSpace(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Please fill out all information", "Check input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
