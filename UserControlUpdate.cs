using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;

namespace VanMau101
{
    public partial class UserControlUpdate : UserControl
    {
        IFirebaseClient client;

        public UserControlUpdate()
        {
            InitializeComponent();
        }

        private void UserControlUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(frmHome.Config);

                GetAllDocumentFromFireBaseToTreeView();
            }
            catch (Exception)
            {
                throw;
            }

        }

        async void GetAllDocumentFromFireBaseToTreeView()
        {
            try
            {
                tvResult.Nodes.Clear();

                //Console.WriteLine("Fetching Data");
                lbEditPreview.Text = "Fetching Data";
                FirebaseResponse response = await client.GetTaskAsync(@"Documents");
                //Console.WriteLine("Data Loaded");
                lbEditPreview.Text = "Data Loaded";
                Dictionary<string, Document> doc = JsonConvert.DeserializeObject<Dictionary<string, Document>>(response.Body.ToString());

                //TreeNode root = new TreeNode() { Text = "Documents" };
                
                PopulateResultToTreeView(doc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateResultToTreeView(Dictionary<string, Document> record/*, TreeNode root*/)
        {
            try
            {
                if(record == null)
                {
                    //Console.WriteLine("Failed to fetch data");
                    MessageBox.Show("Failed to fetch data\nPlease check the database is empty or not", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                foreach (var item in record)
                {
                    TreeNode node = new TreeNode() { Name = item.Value.Id.ToString(), 
                                                        Text = item.Value.Name.ToString() };

                    tvResult.Nodes.Add(node);
                    //root.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ResultClicked(object sender, EventArgs e)
        {
            var obj = sender;

            MessageBox.Show(obj.ToString());
        }

        string tempName = string.Empty;
        string tempID = string.Empty;
        private void tvResult_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.Name +"\n" +  e.Node.Text + "\n" + tvResult.SelectedNode.Name + "\n" + tvResult.SelectedNode.Index);
            tempID = e.Node.Name;
            tempName = e.Node.Text;

            GetDocumentFromSelectNode(tempID);
        }

        async void GetDocumentFromSelectNode(string key)
        {
            try
            {
                //Console.WriteLine("Loading document");
                lbEditPreview.Text = "Loading document";
                FirebaseResponse response = await client.GetTaskAsync("Documents/" + key);
                //Console.WriteLine("Loaded document");
                lbEditPreview.Text = "Loaded document";
                Document doc = response.ResultAs<Document>();

                lbEditPreview.Text = string.Format("Editing: {0}", doc.Name);

                rTxtPreDoc.Text = doc.Content;

                rTxtEdit.Text = doc.Content;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        #region Change font

        private void fontSizeSmallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtEdit.Font = new Font(rTxtEdit.Font.FontFamily, 9.75f);
        }

        private void fontSizeMediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtEdit.Font = new Font(rTxtEdit.Font.FontFamily, 12f);
        }

        private void fontSizeBigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtEdit.Font = new Font(rTxtEdit.Font.FontFamily, 15.75f);
        }

        private void fontSizeMASSIVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtEdit.Font = new Font(rTxtEdit.Font.FontFamily, 20.25f);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rTxtPreDoc.Font = new Font(rTxtEdit.Font.FontFamily, 9.75f);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rTxtPreDoc.Font = new Font(rTxtEdit.Font.FontFamily, 12f);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            rTxtPreDoc.Font = new Font(rTxtEdit.Font.FontFamily, 15.75f);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            rTxtPreDoc.Font = new Font(rTxtEdit.Font.FontFamily, 20.25f);
        }
        #endregion


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(tempName == string.Empty || tempID == string.Empty)
            {
                return;
            }

            DialogResult dr = MessageBox.Show(string.Format("Are you want to update \"{0}\" " , tempName), "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        
            if(dr != DialogResult.OK)
            {
                return;
            }
            else if(dr == DialogResult.OK)
            {
                // MessageBox.Show(string.Format("ok update {0} ", tempID), "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                UpdateSelectedDocument();
            }
        }

        async void UpdateSelectedDocument()
        {
            try
            {
                Document doc = new Document()
                {
                    Id = tempID,
                    Name = tempName,
                    Content = rTxtEdit.Text,
                };

                //Console.WriteLine("ready to update.." + tempID);
                btnUpdate.Text = string.Format("Preparing to update {0} ...", tempName);
                btnUpdate.Enabled = false;
                FirebaseResponse response = await client.UpdateTaskAsync("Documents/" + tempID, doc);
                //Console.WriteLine("update.." + tempID + " successfull");

                DialogResult dr = MessageBox.Show(string.Format("Update \"{0}\" successfull",tempName),"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                if(dr == DialogResult.OK)
                {
                    btnUpdate.Text = string.Format("Update");

                    btnUpdate.Enabled = true;

                    tempID = tempName = string.Empty;

                    GetAllDocumentFromFireBaseToTreeView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAllDocumentFromFireBaseToTreeView();
        }

        private void rTxtEdit_Enter(object sender, EventArgs e)
        {
            lbEditPreview.Text = string.Format("Editing: {0}", tempName);
        }

        private void UserControlUpdate_Enter(object sender, EventArgs e)
        {
            GetAllDocumentFromFireBaseToTreeView();
        }
    }
}
