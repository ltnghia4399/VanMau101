
namespace VanMau101
{
    partial class UserControlUpdate
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvResult = new System.Windows.Forms.TreeView();
            this.contextMenuStripRefresh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rTxtEdit = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontSizeSmallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeMediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeBigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeMASSIVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPreDoc = new System.Windows.Forms.GroupBox();
            this.rTxtPreDoc = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripPreDoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEditPreview = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStripRefresh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbEdit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStripEdit.SuspendLayout();
            this.gbPreDoc.SuspendLayout();
            this.contextMenuStripPreDoc.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(816, 489);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvResult
            // 
            this.tvResult.ContextMenuStrip = this.contextMenuStripRefresh;
            this.tvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvResult.Location = new System.Drawing.Point(0, 0);
            this.tvResult.Name = "tvResult";
            this.tvResult.Size = new System.Drawing.Size(199, 489);
            this.tvResult.TabIndex = 0;
            this.tvResult.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvResult_AfterSelect);
            // 
            // contextMenuStripRefresh
            // 
            this.contextMenuStripRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripRefresh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuStripRefresh.Name = "contextMenuStripRefresh";
            this.contextMenuStripRefresh.Size = new System.Drawing.Size(121, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::VanMau101.Properties.Resources.rotate_right_32px;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 26);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbEdit);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbPreDoc);
            this.splitContainer2.Size = new System.Drawing.Size(613, 463);
            this.splitContainer2.SplitterDistance = 311;
            this.splitContainer2.TabIndex = 1;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.panel2);
            this.gbEdit.Controls.Add(this.rTxtEdit);
            this.gbEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEdit.Location = new System.Drawing.Point(0, 0);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(311, 463);
            this.gbEdit.TabIndex = 0;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "Editing";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btnLoadFile);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 43);
            this.panel2.TabIndex = 1;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(3, 4);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(76, 37);
            this.btnLoadFile.TabIndex = 1;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(169, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 37);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // rTxtEdit
            // 
            this.rTxtEdit.ContextMenuStrip = this.contextMenuStripEdit;
            this.rTxtEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtEdit.Location = new System.Drawing.Point(3, 17);
            this.rTxtEdit.Name = "rTxtEdit";
            this.rTxtEdit.Size = new System.Drawing.Size(305, 443);
            this.rTxtEdit.TabIndex = 0;
            this.rTxtEdit.Text = "";
            this.rTxtEdit.Enter += new System.EventHandler(this.rTxtEdit_Enter);
            // 
            // contextMenuStripEdit
            // 
            this.contextMenuStripEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontSizeSmallToolStripMenuItem,
            this.fontSizeMediumToolStripMenuItem,
            this.fontSizeBigToolStripMenuItem,
            this.fontSizeMASSIVEToolStripMenuItem});
            this.contextMenuStripEdit.Name = "contextMenuStripEdit";
            this.contextMenuStripEdit.Size = new System.Drawing.Size(303, 172);
            // 
            // fontSizeSmallToolStripMenuItem
            // 
            this.fontSizeSmallToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSizeSmallToolStripMenuItem.Name = "fontSizeSmallToolStripMenuItem";
            this.fontSizeSmallToolStripMenuItem.Size = new System.Drawing.Size(302, 42);
            this.fontSizeSmallToolStripMenuItem.Text = "Font size small";
            this.fontSizeSmallToolStripMenuItem.Click += new System.EventHandler(this.fontSizeSmallToolStripMenuItem_Click);
            // 
            // fontSizeMediumToolStripMenuItem
            // 
            this.fontSizeMediumToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSizeMediumToolStripMenuItem.Name = "fontSizeMediumToolStripMenuItem";
            this.fontSizeMediumToolStripMenuItem.Size = new System.Drawing.Size(302, 42);
            this.fontSizeMediumToolStripMenuItem.Text = "Font size medium";
            this.fontSizeMediumToolStripMenuItem.Click += new System.EventHandler(this.fontSizeMediumToolStripMenuItem_Click);
            // 
            // fontSizeBigToolStripMenuItem
            // 
            this.fontSizeBigToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSizeBigToolStripMenuItem.Name = "fontSizeBigToolStripMenuItem";
            this.fontSizeBigToolStripMenuItem.Size = new System.Drawing.Size(302, 42);
            this.fontSizeBigToolStripMenuItem.Text = "Font size big";
            this.fontSizeBigToolStripMenuItem.Click += new System.EventHandler(this.fontSizeBigToolStripMenuItem_Click);
            // 
            // fontSizeMASSIVEToolStripMenuItem
            // 
            this.fontSizeMASSIVEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSizeMASSIVEToolStripMenuItem.Name = "fontSizeMASSIVEToolStripMenuItem";
            this.fontSizeMASSIVEToolStripMenuItem.Size = new System.Drawing.Size(302, 42);
            this.fontSizeMASSIVEToolStripMenuItem.Text = "Font size MASSIVE";
            this.fontSizeMASSIVEToolStripMenuItem.Click += new System.EventHandler(this.fontSizeMASSIVEToolStripMenuItem_Click);
            // 
            // gbPreDoc
            // 
            this.gbPreDoc.Controls.Add(this.rTxtPreDoc);
            this.gbPreDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPreDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPreDoc.Location = new System.Drawing.Point(0, 0);
            this.gbPreDoc.Name = "gbPreDoc";
            this.gbPreDoc.Size = new System.Drawing.Size(298, 463);
            this.gbPreDoc.TabIndex = 0;
            this.gbPreDoc.TabStop = false;
            this.gbPreDoc.Text = "Previous Document (Tip)";
            this.toolTip1.SetToolTip(this.gbPreDoc, "Right click in the text box to change font size");
            // 
            // rTxtPreDoc
            // 
            this.rTxtPreDoc.ContextMenuStrip = this.contextMenuStripPreDoc;
            this.rTxtPreDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtPreDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtPreDoc.Location = new System.Drawing.Point(3, 17);
            this.rTxtPreDoc.Name = "rTxtPreDoc";
            this.rTxtPreDoc.ReadOnly = true;
            this.rTxtPreDoc.Size = new System.Drawing.Size(292, 443);
            this.rTxtPreDoc.TabIndex = 0;
            this.rTxtPreDoc.Text = "";
            // 
            // contextMenuStripPreDoc
            // 
            this.contextMenuStripPreDoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.contextMenuStripPreDoc.Name = "contextMenuStripEdit";
            this.contextMenuStripPreDoc.Size = new System.Drawing.Size(303, 172);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(302, 42);
            this.toolStripMenuItem1.Text = "Font size small";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(302, 42);
            this.toolStripMenuItem2.Text = "Font size medium";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(302, 42);
            this.toolStripMenuItem3.Text = "Font size big";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(302, 42);
            this.toolStripMenuItem4.Text = "Font size MASSIVE";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbEditPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 26);
            this.panel1.TabIndex = 0;
            // 
            // lbEditPreview
            // 
            this.lbEditPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbEditPreview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditPreview.Location = new System.Drawing.Point(0, 0);
            this.lbEditPreview.Name = "lbEditPreview";
            this.lbEditPreview.Size = new System.Drawing.Size(613, 26);
            this.lbEditPreview.TabIndex = 0;
            this.lbEditPreview.Text = "Editing: {document name}";
            this.lbEditPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // UserControlUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserControlUpdate";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.UserControlUpdate_Load);
            this.Enter += new System.EventHandler(this.UserControlUpdate_Enter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStripRefresh.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbEdit.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contextMenuStripEdit.ResumeLayout(false);
            this.gbPreDoc.ResumeLayout(false);
            this.contextMenuStripPreDoc.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.GroupBox gbPreDoc;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TreeView tvResult;
        private System.Windows.Forms.RichTextBox rTxtEdit;
        private System.Windows.Forms.Label lbEditPreview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.RichTextBox rTxtPreDoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEdit;
        private System.Windows.Forms.ToolStripMenuItem fontSizeSmallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeMediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeBigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeMASSIVEToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPreDoc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRefresh;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}
