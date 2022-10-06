namespace Lightstream
{
    partial class FrmLgn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lgn = new System.Windows.Forms.Label();
            this.lblpsswrd = new System.Windows.Forms.Label();
            this.lblusrnm = new System.Windows.Forms.Label();
            this.btnCnfrm = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.txtUser);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Controls.Add(this.lgn);
            this.pnlLogin.Controls.Add(this.lblpsswrd);
            this.pnlLogin.Controls.Add(this.lblusrnm);
            this.pnlLogin.Controls.Add(this.btnCnfrm);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(800, 450);
            this.pnlLogin.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(279, 158);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(300, 31);
            this.txtUser.TabIndex = 11;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(279, 213);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(300, 31);
            this.txtPass.TabIndex = 10;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lgn
            // 
            this.lgn.AutoSize = true;
            this.lgn.BackColor = System.Drawing.Color.White;
            this.lgn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lgn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lgn.Location = new System.Drawing.Point(371, 89);
            this.lgn.Name = "lgn";
            this.lgn.Size = new System.Drawing.Size(104, 34);
            this.lgn.TabIndex = 8;
            this.lgn.Text = "LOGIN";
            // 
            // lblpsswrd
            // 
            this.lblpsswrd.AutoSize = true;
            this.lblpsswrd.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblpsswrd.Location = new System.Drawing.Point(132, 215);
            this.lblpsswrd.Name = "lblpsswrd";
            this.lblpsswrd.Size = new System.Drawing.Size(100, 23);
            this.lblpsswrd.TabIndex = 9;
            this.lblpsswrd.Text = "Password";
            // 
            // lblusrnm
            // 
            this.lblusrnm.AutoSize = true;
            this.lblusrnm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblusrnm.Location = new System.Drawing.Point(131, 162);
            this.lblusrnm.Name = "lblusrnm";
            this.lblusrnm.Size = new System.Drawing.Size(108, 23);
            this.lblusrnm.TabIndex = 7;
            this.lblusrnm.Text = "Username";
            // 
            // btnCnfrm
            // 
            this.btnCnfrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCnfrm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCnfrm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCnfrm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCnfrm.Location = new System.Drawing.Point(483, 334);
            this.btnCnfrm.Margin = new System.Windows.Forms.Padding(10);
            this.btnCnfrm.Name = "btnCnfrm";
            this.btnCnfrm.Size = new System.Drawing.Size(212, 45);
            this.btnCnfrm.TabIndex = 6;
            this.btnCnfrm.Text = "CONFIRM";
            this.btnCnfrm.UseVisualStyleBackColor = false;
            this.btnCnfrm.Click += new System.EventHandler(this.btnCnfrm_Click);
            // 
            // FrmLgn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlLogin);
            this.Name = "FrmLgn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.FrmLgn_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlLogin;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label lgn;
        private Label lblpsswrd;
        private Label lblusrnm;
        private Button btnCnfrm;
    }
}