
namespace VanMau101
{
    partial class frmAccount
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSignIn = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControlSignIn1 = new VanMau101.UserControlSignIn();
            this.userControlSignUp1 = new VanMau101.UserControlSignUp();
            this.userControlSignUp2 = new VanMau101.UserControlSignUp();
            this.pnlSignIn.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSignIn
            // 
            this.pnlSignIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSignIn.Controls.Add(this.userControlSignIn1);
            this.pnlSignIn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSignIn.Location = new System.Drawing.Point(0, 0);
            this.pnlSignIn.Name = "pnlSignIn";
            this.pnlSignIn.Size = new System.Drawing.Size(351, 351);
            this.pnlSignIn.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControlSignUp2);
            this.panel1.Controls.Add(this.userControlSignUp1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(351, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 351);
            this.panel1.TabIndex = 2;
            // 
            // userControlSignIn1
            // 
            this.userControlSignIn1.AutoSize = true;
            this.userControlSignIn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSignIn1.Location = new System.Drawing.Point(0, 0);
            this.userControlSignIn1.Name = "userControlSignIn1";
            this.userControlSignIn1.Size = new System.Drawing.Size(349, 349);
            this.userControlSignIn1.TabIndex = 0;
            // 
            // userControlSignUp1
            // 
            this.userControlSignUp1.Location = new System.Drawing.Point(178, 142);
            this.userControlSignUp1.Name = "userControlSignUp1";
            this.userControlSignUp1.Size = new System.Drawing.Size(8, 8);
            this.userControlSignUp1.TabIndex = 0;
            // 
            // userControlSignUp2
            // 
            this.userControlSignUp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSignUp2.Location = new System.Drawing.Point(0, 0);
            this.userControlSignUp2.Name = "userControlSignUp2";
            this.userControlSignUp2.Size = new System.Drawing.Size(530, 351);
            this.userControlSignUp2.TabIndex = 1;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSignIn";
            this.pnlSignIn.ResumeLayout(false);
            this.pnlSignIn.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSignIn;
        private System.Windows.Forms.Panel panel1;
        private UserControlSignIn userControlSignIn1;
        private UserControlSignUp userControlSignUp2;
        private UserControlSignUp userControlSignUp1;
    }
}