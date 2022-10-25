namespace Lightstream.Forms
{
    partial class _frmHelpandAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_frmHelpandAbout));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this._details = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 124);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this._details.Location = new System.Drawing.Point(505, 253);
            this._details.Multiline = true;
            this._details.Name = "textBox1";
            this._details.ReadOnly = true;
            this._details.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._details.Size = new System.Drawing.Size(100, 185);
            this._details.TabIndex = 1;
            this._details.Text = resources.GetString("textBox1.Text");
            // 
            // _frmHelpandAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._details);
            this.Controls.Add(this.listBox1);
            this.Name = "_frmHelpandAbout";
            this.Text = "Help & About";
            this.Load += new System.EventHandler(this.HelpandAboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private TextBox _details;
    }
}