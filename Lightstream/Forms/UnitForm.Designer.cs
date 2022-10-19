namespace Lightstream.Forms
{
    partial class UnitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitForm));
            this.singularLabel = new System.Windows.Forms.Label();
            this._singular = new System.Windows.Forms.TextBox();
            this._plural = new System.Windows.Forms.TextBox();
            this._abbreviation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singularLabel
            // 
            this.singularLabel.AutoSize = true;
            this.singularLabel.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.singularLabel.Location = new System.Drawing.Point(33, 26);
            this.singularLabel.Name = "singularLabel";
            this.singularLabel.Size = new System.Drawing.Size(66, 15);
            this.singularLabel.TabIndex = 20;
            this.singularLabel.Text = "Singular Name:";
            // 
            // _singular
            // 
            this._singular.BackColor = System.Drawing.Color.White;
            this._singular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._singular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._singular.Location = new System.Drawing.Point(105, 23);
            this._singular.MaxLength = 50;
            this._singular.Name = "_singular";
            this._singular.Size = new System.Drawing.Size(299, 23);
            this._singular.TabIndex = 19;
            // 
            // _plural
            // 
            this._plural.BackColor = System.Drawing.Color.White;
            this._plural.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._plural.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._plural.Location = new System.Drawing.Point(105, 67);
            this._plural.MaxLength = 50;
            this._plural.Name = "_plural";
            this._plural.Size = new System.Drawing.Size(299, 23);
            this._plural.TabIndex = 21;
            // 
            // _abbreviation
            // 
            this._abbreviation.BackColor = System.Drawing.Color.White;
            this._abbreviation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._abbreviation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._abbreviation.Location = new System.Drawing.Point(105, 111);
            this._abbreviation.MaxLength = 50;
            this._abbreviation.Name = "_abbreviation";
            this._abbreviation.Size = new System.Drawing.Size(299, 23);
            this._abbreviation.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Plural Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Abbreviation:";
            // 
            // _save
            // 
            this._save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._save.FlatAppearance.BorderSize = 0;
            this._save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._save.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._save.Location = new System.Drawing.Point(167, 155);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(237, 29);
            this._save.TabIndex = 25;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = false;
            this._save.Click += new System.EventHandler(this._save_Click);
            // 
            // UnitForm
            // 
            this.AcceptButton = this._save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 207);
            this.Controls.Add(this._save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._abbreviation);
            this.Controls.Add(this._plural);
            this.Controls.Add(this.singularLabel);
            this.Controls.Add(this._singular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitForm";
            this.Text = "Create Unit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label singularLabel;
        private TextBox _singular;
        private TextBox _plural;
        private TextBox _abbreviation;
        private Label label1;
        private Label label2;
        private Button _save;
    }
}