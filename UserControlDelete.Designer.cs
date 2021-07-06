
namespace VanMau101
{
    partial class UserControlDelete
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDelete));
            this.pnTop = new System.Windows.Forms.Panel();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.lbPreview = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbContent = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.gbDocuments = new System.Windows.Forms.GroupBox();
            this.flpnResult = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnTop.SuspendLayout();
            this.gbPreview.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbContent.SuspendLayout();
            this.gbDocuments.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.gbPreview);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(816, 113);
            this.pnTop.TabIndex = 0;
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.lbPreview);
            this.gbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.gbPreview.Location = new System.Drawing.Point(0, 0);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(816, 113);
            this.gbPreview.TabIndex = 0;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = " Preview {name}";
            // 
            // lbPreview
            // 
            this.lbPreview.AutoEllipsis = true;
            this.lbPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPreview.Location = new System.Drawing.Point(3, 18);
            this.lbPreview.Name = "lbPreview";
            this.lbPreview.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.lbPreview.Size = new System.Drawing.Size(810, 92);
            this.lbPreview.TabIndex = 0;
            this.lbPreview.Text = resources.GetString("lbPreview.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbContent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 376);
            this.panel1.TabIndex = 1;
            // 
            // gbContent
            // 
            this.gbContent.Controls.Add(this.btnRefresh);
            this.gbContent.Controls.Add(this.gbDocuments);
            this.gbContent.Controls.Add(this.btnDelete);
            this.gbContent.Controls.Add(this.txtSearch);
            this.gbContent.Controls.Add(this.lbSearch);
            this.gbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbContent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContent.Location = new System.Drawing.Point(0, 0);
            this.gbContent.Name = "gbContent";
            this.gbContent.Size = new System.Drawing.Size(816, 376);
            this.gbContent.TabIndex = 1;
            this.gbContent.TabStop = false;
            this.gbContent.Text = " All documents";
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.Location = new System.Drawing.Point(3, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(810, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(20, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(677, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(17, 25);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(101, 17);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "Search by name";
            // 
            // gbDocuments
            // 
            this.gbDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDocuments.Controls.Add(this.flpnResult);
            this.gbDocuments.Location = new System.Drawing.Point(20, 76);
            this.gbDocuments.Name = "gbDocuments";
            this.gbDocuments.Size = new System.Drawing.Size(777, 261);
            this.gbDocuments.TabIndex = 5;
            this.gbDocuments.TabStop = false;
            this.gbDocuments.Text = "Result";
            // 
            // flpnResult
            // 
            this.flpnResult.AutoScroll = true;
            this.flpnResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnResult.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnResult.Location = new System.Drawing.Point(3, 21);
            this.flpnResult.Name = "flpnResult";
            this.flpnResult.Size = new System.Drawing.Size(771, 237);
            this.flpnResult.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoSize = true;
            this.btnRefresh.Location = new System.Drawing.Point(703, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(91, 27);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UserControlDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTop);
            this.Name = "UserControlDelete";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.UserControlDelete_Load);
            this.pnTop.ResumeLayout(false);
            this.gbPreview.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbContent.ResumeLayout(false);
            this.gbContent.PerformLayout();
            this.gbDocuments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.Label lbPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbContent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.GroupBox gbDocuments;
        private System.Windows.Forms.FlowLayoutPanel flpnResult;
        private System.Windows.Forms.Button btnRefresh;
    }
}
