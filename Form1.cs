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
using FireSharp.Config;
using System.IO;
using System.Reflection;

namespace VanMau101
{
    public partial class frmHome : Form
    {
        static IFirebaseConfig config = new FirebaseConfig
        {
            BasePath = "https://vanmau101-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        public static IFirebaseConfig Config { get => config; private set => config = value; }

        string GetAPIToken()
        {
            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);

            string path = Path.Combine(exeDir, "APIToken.txt");

            //string fullPath = Path.Combine(exeDir, "..\\..\\Images\\Texture.dds");
            //string path = @"E:\Users\boyng\source\repos\APIToken.txt";

            StreamReader streamReader = new StreamReader(path);

            string token = streamReader.ReadToEnd();

            streamReader.Close();

            return token;
        }

        async Task<string> TaskGetAPI()
        {
            Task<string> task = new Task<string>(() => GetAPIToken());

            task.Start();

            var token = await task;

            //Console.WriteLine("task hoan thanh");

            return token;
        }

        public frmHome()
        {
            InitializeComponent();
        }

        private async void frmHome_Load(object sender, EventArgs e)
        {
            Task<string> taskGetAPI = TaskGetAPI();

            var token = await taskGetAPI;

            config.AuthSecret = token;

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
            //MessageBox.Show("Working In Progress\nComeback later for this function", "Not working function", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (accessGranted)
            {
                userControlUpdate1.BringToFront();
            }
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Working In Progress\nComeback later for this function", "Not working function", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (accessGranted)
            {
                userControlDelete1.BringToFront();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();

            frmAbout.ShowDialog();

        }
    }
}
