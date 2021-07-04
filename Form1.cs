using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanMau101
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            
            userControlHome1.Show();
            userControlHome1.BringToFront();

            userControlInsert1.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlInsert1.Hide();

            userControlHome1.Show();
            userControlHome1.BringToFront();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userControlHome1.Hide();

            userControlInsert1.Show();
            userControlInsert1.BringToFront();
        }

    }
}
