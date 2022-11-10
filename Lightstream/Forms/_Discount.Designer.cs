namespace Lightstream.Forms
{
    partial class _Discount
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
            this._set = new System.Windows.Forms.Button();
            this._cancel = new System.Windows.Forms.Button();
            this._txtDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _set
            // 
            this._set.BackColor = System.Drawing.Color.ForestGreen;
            this._set.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._set.ForeColor = System.Drawing.Color.White;
            this._set.Location = new System.Drawing.Point(43, 133);
            this._set.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._set.Name = "_set";
            this._set.Size = new System.Drawing.Size(139, 57);
            this._set.TabIndex = 21;
            this._set.Text = "Set";
            this._set.UseVisualStyleBackColor = false;
            this._set.Click += new System.EventHandler(this._set_Click);
            // 
            // _cancel
            // 
            this._cancel.BackColor = System.Drawing.Color.ForestGreen;
            this._cancel.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cancel.ForeColor = System.Drawing.Color.White;
            this._cancel.Location = new System.Drawing.Point(210, 133);
            this._cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(139, 57);
            this._cancel.TabIndex = 20;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = false;
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // _txtDiscount
            // 
            this._txtDiscount.Location = new System.Drawing.Point(12, 84);
            this._txtDiscount.Name = "_txtDiscount";
            this._txtDiscount.Size = new System.Drawing.Size(350, 39);
            this._txtDiscount.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 62);
            this.label1.TabIndex = 18;
            this.label1.Text = "Discount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(374, 196);
            this.Controls.Add(this._set);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._txtDiscount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "_Discount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_Discount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button _set;
        private Button _cancel;
        private TextBox _txtDiscount;
        private Label label1;
    }
}