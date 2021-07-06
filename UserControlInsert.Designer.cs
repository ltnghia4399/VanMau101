
namespace VanMau101
{
    partial class UserControlInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlInsert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbInsertPreview = new System.Windows.Forms.GroupBox();
            this.lbInsertPreviewContent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsertName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbInsertPreview.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbInsertPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 113);
            this.panel1.TabIndex = 0;
            // 
            // gbInsertPreview
            // 
            this.gbInsertPreview.Controls.Add(this.lbInsertPreviewContent);
            this.gbInsertPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInsertPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInsertPreview.Location = new System.Drawing.Point(0, 0);
            this.gbInsertPreview.Name = "gbInsertPreview";
            this.gbInsertPreview.Size = new System.Drawing.Size(816, 113);
            this.gbInsertPreview.TabIndex = 0;
            this.gbInsertPreview.TabStop = false;
            this.gbInsertPreview.Text = " Content Name";
            // 
            // lbInsertPreviewContent
            // 
            this.lbInsertPreviewContent.AutoEllipsis = true;
            this.lbInsertPreviewContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbInsertPreviewContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInsertPreviewContent.Location = new System.Drawing.Point(3, 18);
            this.lbInsertPreviewContent.Name = "lbInsertPreviewContent";
            this.lbInsertPreviewContent.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.lbInsertPreviewContent.Size = new System.Drawing.Size(810, 92);
            this.lbInsertPreviewContent.TabIndex = 0;
            this.lbInsertPreviewContent.Text = resources.GetString("lbInsertPreviewContent.Text");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 376);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.rtxtContent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtInsertName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Content Insert Information";
            // 
            // btnUpload
            // 
            this.btnUpload.AutoSize = true;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpload.Location = new System.Drawing.Point(3, 343);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(810, 30);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // rtxtContent
            // 
            this.rtxtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtContent.Location = new System.Drawing.Point(20, 102);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxtContent.Size = new System.Drawing.Size(777, 232);
            this.rtxtContent.TabIndex = 3;
            this.rtxtContent.Text = "";
            this.rtxtContent.TextChanged += new System.EventHandler(this.rtxtContent_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Content";
            // 
            // txtInsertName
            // 
            this.txtInsertName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsertName.Location = new System.Drawing.Point(20, 45);
            this.txtInsertName.Name = "txtInsertName";
            this.txtInsertName.Size = new System.Drawing.Size(777, 25);
            this.txtInsertName.TabIndex = 1;
            this.txtInsertName.TextChanged += new System.EventHandler(this.txtInsertName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // UserControlInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlInsert";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.UserControlInsert_Load);
            this.panel1.ResumeLayout(false);
            this.gbInsertPreview.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbInsertPreview;
        private System.Windows.Forms.Label lbInsertPreviewContent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsertName;
        private System.Windows.Forms.Label label1;
    }
}
