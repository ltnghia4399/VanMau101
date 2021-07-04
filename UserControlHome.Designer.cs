
namespace VanMau101
{
    partial class UserControlHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnResult = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpnResult = new System.Windows.Forms.FlowLayoutPanel();
            this.pnRefresh = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnFullView = new System.Windows.Forms.Panel();
            this.pnCopyBtn = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.rtxtFullView = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.lbPreview = new System.Windows.Forms.Label();
            this.lbConnectResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnResult.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnRefresh.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.pnFullView.SuspendLayout();
            this.pnCopyBtn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnResult);
            this.panel1.Controls.Add(this.pnRefresh);
            this.panel1.Controls.Add(this.gbSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 489);
            this.panel1.TabIndex = 3;
            // 
            // pnResult
            // 
            this.pnResult.Controls.Add(this.groupBox1);
            this.pnResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnResult.Location = new System.Drawing.Point(0, 80);
            this.pnResult.Name = "pnResult";
            this.pnResult.Size = new System.Drawing.Size(221, 409);
            this.pnResult.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpnResult);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 409);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Result";
            // 
            // flpnResult
            // 
            this.flpnResult.AutoScroll = true;
            this.flpnResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnResult.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnResult.Location = new System.Drawing.Point(3, 21);
            this.flpnResult.Name = "flpnResult";
            this.flpnResult.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flpnResult.Size = new System.Drawing.Size(215, 385);
            this.flpnResult.TabIndex = 0;
            this.flpnResult.WrapContents = false;
            // 
            // pnRefresh
            // 
            this.pnRefresh.Controls.Add(this.btnRefresh);
            this.pnRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnRefresh.Location = new System.Drawing.Point(0, 50);
            this.pnRefresh.Name = "pnRefresh";
            this.pnRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.pnRefresh.Size = new System.Drawing.Size(221, 30);
            this.pnRefresh.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(10, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(206, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(0, 0);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(221, 50);
            this.gbSearch.TabIndex = 0;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = " Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(203, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnFullView);
            this.pnBody.Controls.Add(this.panel2);
            this.pnBody.Controls.Add(this.lbConnectResult);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(221, 0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(595, 489);
            this.pnBody.TabIndex = 9;
            // 
            // pnFullView
            // 
            this.pnFullView.Controls.Add(this.pnCopyBtn);
            this.pnFullView.Controls.Add(this.rtxtFullView);
            this.pnFullView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFullView.Location = new System.Drawing.Point(0, 64);
            this.pnFullView.Name = "pnFullView";
            this.pnFullView.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pnFullView.Size = new System.Drawing.Size(595, 412);
            this.pnFullView.TabIndex = 8;
            // 
            // pnCopyBtn
            // 
            this.pnCopyBtn.Controls.Add(this.btnCopy);
            this.pnCopyBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnCopyBtn.Location = new System.Drawing.Point(5, 361);
            this.pnCopyBtn.Name = "pnCopyBtn";
            this.pnCopyBtn.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnCopyBtn.Size = new System.Drawing.Size(585, 51);
            this.pnCopyBtn.TabIndex = 7;
            // 
            // btnCopy
            // 
            this.btnCopy.AutoSize = true;
            this.btnCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(0, 10);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(585, 41);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy to clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // rtxtFullView
            // 
            this.rtxtFullView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtFullView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtFullView.Location = new System.Drawing.Point(5, 0);
            this.rtxtFullView.Name = "rtxtFullView";
            this.rtxtFullView.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtFullView.Size = new System.Drawing.Size(585, 412);
            this.rtxtFullView.TabIndex = 6;
            this.rtxtFullView.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbPreview);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 64);
            this.panel2.TabIndex = 5;
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.lbPreview);
            this.gbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPreview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPreview.Location = new System.Drawing.Point(0, 0);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(595, 64);
            this.gbPreview.TabIndex = 0;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "Preview";
            // 
            // lbPreview
            // 
            this.lbPreview.AutoEllipsis = true;
            this.lbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPreview.Location = new System.Drawing.Point(3, 21);
            this.lbPreview.Name = "lbPreview";
            this.lbPreview.Size = new System.Drawing.Size(589, 40);
            this.lbPreview.TabIndex = 0;
            this.lbPreview.Text = resources.GetString("lbPreview.Text");
            // 
            // lbConnectResult
            // 
            this.lbConnectResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbConnectResult.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectResult.Location = new System.Drawing.Point(0, 476);
            this.lbConnectResult.Name = "lbConnectResult";
            this.lbConnectResult.Size = new System.Drawing.Size(595, 13);
            this.lbConnectResult.TabIndex = 10;
            this.lbConnectResult.Text = "Connection Result : {0}";
            this.lbConnectResult.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // UserControlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlHome";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.UserControlHome_Load);
            this.panel1.ResumeLayout(false);
            this.pnResult.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnRefresh.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.pnBody.ResumeLayout(false);
            this.pnFullView.ResumeLayout(false);
            this.pnCopyBtn.ResumeLayout(false);
            this.pnCopyBtn.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbPreview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpnResult;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.Label lbPreview;
        private System.Windows.Forms.Panel pnFullView;
        private System.Windows.Forms.RichTextBox rtxtFullView;
        private System.Windows.Forms.Label lbConnectResult;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Panel pnCopyBtn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnRefresh;
        private System.Windows.Forms.Panel pnResult;
    }
}
