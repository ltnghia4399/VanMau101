using System;
using System.Collections.Generic;
using Newtonsoft.Json;
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
using System.IO;

namespace VanMau101
{
    public partial class UserControlHome : UserControl
    {
        
        IFirebaseClient client;

        public UserControlHome()
        {
            InitializeComponent();
        }

        private void UserControlHome_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(frmHome.Config);

                lbConnectResult.Text = string.Format("Connection Result : OK");

                GetAllDocumentsFromFireBase();
            }
            catch (Exception ex)
            {
                lbConnectResult.Text = string.Format("Connection Result : Error");
                MessageBox.Show(string.Format("Error {0}", ex), "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            
        }

        async void GetAllDocumentsFromFireBase()
        {
            try
            {
                txtSearch.Text = string.Empty;
                lbConnectResult.Text = string.Format("Status: {0}", "Fetching Data");
                FirebaseResponse response = await client.GetTaskAsync(@"Documents");
                lbConnectResult.Text = string.Format("Status: {0}", "Data Loaded");
                Dictionary<string, Document> doc = JsonConvert.DeserializeObject<Dictionary<string, Document>>(response.Body.ToString());

                PopulateResult(doc);
            }
            catch (Exception)
            {
                lbConnectResult.Text = string.Format("Status: {0}", "Couldn't fetching data. Please check data on the database");
                throw;
            }
            
        }

        void PopulateResult(Dictionary<string, Document> record)
        {
            flpnResult.Controls.Clear();

            try
            {
                if(record == null)
                {
                    lbConnectResult.Text = string.Format("Status: {0}", "Couldn't fetching data. Please check data on the database");
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
            
            GetDocumentAtTheButton(resultBtn.Name);
        }

        async void GetDocumentAtTheButton(string key)
        {
            //FirebaseResponse response = client.Get("Documents/" + key);
            gbResult.Text = string.Format("Status: {0}", "Preparing document");
            FirebaseResponse response = await client.GetTaskAsync("Documents/" + key);
            gbResult.Text = string.Format("Status: {0}", "Loaded document");
            Document doc = response.ResultAs<Document>();
            gbPreview.Text = string.Format("Preview {0}", doc.Name);
            lbPreview.Text = doc.Content;
            rtxtFullView.Text = doc.Content;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(rtxtFullView.Text);
                MessageBox.Show(string.Format("Đã copy văn mẫu!\nPaste ra rồi chiến thôi bruh!~"),"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format("Chưa chọn văn mẫu mà bruh"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            
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

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAllDocumentsFromFireBase();
        }

        private void UserControlHome_Enter(object sender, EventArgs e)
        {
            GetAllDocumentsFromFireBase();
        }
    }
}

