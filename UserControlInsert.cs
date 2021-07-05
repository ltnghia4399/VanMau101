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
using System.Text.RegularExpressions;

namespace VanMau101
{
    public partial class UserControlInsert : UserControl
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Wqsj5PvQK4xFZMnofSDiPm5QxQF4iSHhSVjZk3QN",
            BasePath = "https://vanmau101-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;


        public UserControlInsert()
        {
            InitializeComponent();
        }

        private void UserControlInsert_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error {0}", ex), "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void txtInsertName_TextChanged(object sender, EventArgs e)
        {
            gbInsertPreview.Text = string.Format(" {0}", txtInsertName.Text);
        }

        private void rtxtContent_TextChanged(object sender, EventArgs e)
        {
            lbInsertPreviewContent.Text = rtxtContent.Text;
        }

        private async void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                uniqueID = GenerateID();

                var newDoc = new Document()
                {
                    Id = uniqueID,
                    Name = txtInsertName.Text.Trim(),
                    Content = rtxtContent.Text
                };
                btnUpload.Enabled = false;
                btnUpload.Text = string.Format("Status: {0}", "Uploading Content");
                SetResponse response = await client.SetTaskAsync("Documents/" + uniqueID, newDoc);
                btnUpload.Text = string.Format("Status: {0}", "Content Uploaded");
                Document result = response.ResultAs<Document>();
                DialogResult dr = MessageBox.Show(string.Format("Document is uploaded\nID: {0}\nName: {1}", uniqueID, txtInsertName.Text),"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                if(dr == DialogResult.OK)
                {
                    btnUpload.Text = string.Format("Upload");
                    btnUpload.Enabled = true;
                    txtInsertName.Text = string.Empty;
                    gbInsertPreview.Text = "Content Name";

                    rtxtContent.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error {0}", ex), "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            
        }

        string uniqueID;

        private string GenerateID()
        {
            try
            {
                //string d = DateTime.Now.ToString("ddMMyyyy");
                //string t = DateTime.Now.ToString("h:mm-tt");

                //key = string.Format("{0}-{1}-{2}", key, d, t);

                //string subname = name.Substring(0, name.IndexOf(" "));
                //string trimName = Regex.Replace(name, @"s", "");

                string name = txtInsertName.Text.Trim();

                Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
                string temp = name.Normalize(NormalizationForm.FormD);

                string removeAccented = regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');

                return Regex.Replace(removeAccented, @"\s", "");

            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        
    }
}
