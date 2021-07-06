using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace VanMau101
{
    public partial class UserControlAbout : UserControl
    {
        public UserControlAbout()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/ltnghia4399");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/ltnghia4399/");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:ltnghia439@gmail.com");
        }
    }
}
