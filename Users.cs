using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanMau101
{
    class Users
    {
        string username;
        string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        static string error = "";

        public static bool IsEqual(Users user1, Users user2)
        {
            if (user1 == null || user2 == null)
            {
                error = "Users does not exist";
                return false;
            }

            if(user1.username != user2.username)
            {
                error = "Incorrect username or password";
                return false;
            }

            if(user1.password != user2.password)
            {
                error = "Incorrect username or password";
                return false;
            }

            return true;
        }

        public static void ShowError()
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
