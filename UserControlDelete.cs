using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace VanMau101
{
    public partial class UserControlDelete : UserControl
    {
        IFirebaseClient client;
        string nameTemp = string.Empty;

        public UserControlDelete()
        {
            InitializeComponent();
        }

        private void UserControlDelete_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(frmHome.Config);

                //lbConnectResult.Text = string.Format("Connection Result : OK");

                GetAllDocumentsFromFireBase();
            }
            catch (Exception ex)
            {
                //lbConnectResult.Text = string.Format("Connection Result : Error");
                MessageBox.Show(string.Format("Error {0}", ex), "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private async void GetAllDocumentsFromFireBase()
        {
            try
            {
                gbDocuments.Text = string.Format("Status: {0}", "Fetching Data");
                FirebaseResponse response = await client.GetTaskAsync(@"Documents");
                gbDocuments.Text = string.Format("Status: {0}", "Data Loaded");
                Dictionary<string, Document> doc = JsonConvert.DeserializeObject<Dictionary<string, Document>>(response.Body.ToString());

                PopulateResult(doc);
            }
            catch (Exception)
            {

                throw;
            }
        }

        void PopulateResult(Dictionary<string, Document> record)
        {
            flpnResult.Controls.Clear();

            try
            {
                if (record == null)
                {
                    gbDocuments.Text = string.Format("Status: {0}", "Couldn't fetching data. Please check data on the database");
                    return;
                }

                foreach (var item in record)
                {
                    Button newBtn = new Button();
                    newBtn.Name = string.Format("{0}", item.Value.Id.ToString());
                    newBtn.Text = string.Format("{0}", item.Value.Name.ToString());
                    newBtn.Size = new Size(185, 28);
                    newBtn.TextAlign = ContentAlignment.MiddleLeft;
                    newBtn.AutoEllipsis = true;

                    newBtn.Click += new System.EventHandler(this.ResultClicked);
                    newBtn.MouseHover += new System.EventHandler(this.ResultHover);

                    flpnResult.Controls.Add(newBtn);
                }
            }
            catch (Exception)
            {
                //lbConnectResult.Text = string.Format("Status: {0}", "Coulsdn't fetching data. Please check data on the database");
                throw;
            }
        }

        void ResultHover(object sender, EventArgs e)
        {
            Button resultBtn = (Button)sender;
            resultBtn.Cursor = Cursors.Hand;
        }

        void ResultClicked(object sender, EventArgs e)
        {
            Button resultBtn = (Button)sender;

            nameTemp = resultBtn.Name;
            
            GetDocumentAtTheButton(resultBtn.Name);
        }

        async void GetDocumentAtTheButton(string key)
        {
            //FirebaseResponse response = client.Get("Documents/" + key);
            gbDocuments.Text = string.Format("Status: {0}", "Preparing document");
            FirebaseResponse response = await client.GetTaskAsync("Documents/" + key);
            gbDocuments.Text = string.Format("Status: {0}", "Loaded document");
            Document doc = response.ResultAs<Document>();
            gbPreview.Text = string.Format("Preview {0}", doc.Name);
            lbPreview.Text = doc.Content;
            //rtxtFullView.Text = doc.Content;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (Control c in flpnResult.Controls)
            {
                if (!c.Text.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    flpnResult.Controls.Remove(c);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetAllDocumentsFromFireBase();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(nameTemp == string.Empty)
            {
                MessageBox.Show("Select document you want to delete","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            
            DialogResult dialogResult = MessageBox.Show(string.Format("Are you really want to delete {0} ?", nameTemp), "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
            else if (dialogResult == DialogResult.OK)
            {
                DeleteDocumentFromFireBase();
            }
        }

        async void DeleteDocumentFromFireBase()
        {
            btnDelete.Enabled = false;
            btnDelete.Text = string.Format("Preparing to delete {0}", nameTemp);
            FirebaseResponse response = await client.DeleteTaskAsync("Documents/" + nameTemp);
            DialogResult dialogResult = MessageBox.Show(string.Format("Delete successful {0} ", nameTemp), "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            btnDelete.Text = string.Format("Delete successful {0}", nameTemp);

            if (dialogResult == DialogResult.OK)
            {
                GetAllDocumentsFromFireBase();
                gbPreview.Text = "Preview";
                lbPreview.Text = "";
                nameTemp = string.Empty;
                btnDelete.Enabled = true;
                btnDelete.Text = "Delete";
            }
        }
    }
}
