using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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

        bool accessGranted = false;

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (accessGranted)
            {
                return;
            }

            string insertKey = Interaction.InputBox("Enter the insert key: ", "Insert key require",string.Empty,500,300);

            if(insertKey == "cu29")
            {
                accessGranted = true;

                MessageBox.Show("Access granted\nNow you can edit data to the database", "Access granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid insert key\nContact to the admin for the insert key","Invalid insert key",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (accessGranted)
            {
                userControlHome1.Hide();

                userControlInsert1.Show();
                userControlInsert1.BringToFront();

                return;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Working In Progress\nComeback later for this function", "Not working function", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Working In Progress\nComeback later for this function", "Not working function", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
