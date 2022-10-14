namespace Lightstream.Usercontrols.IngredientForm
{
    partial class FieldsIngredientsUserControl
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
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.unitOption = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cost
            // 
            this.cost.DecimalPlaces = 2;
            this.cost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cost.Location = new System.Drawing.Point(3, 19);
            this.cost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(506, 23);
            this.cost.TabIndex = 2;
            this.cost.ThousandsSeparator = true;
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTxt.Location = new System.Drawing.Point(3, 19);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(506, 16);
            this.nameTxt.TabIndex = 0;
            // 
            // unitOption
            // 
            this.unitOption.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.unitOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.unitOption.DisplayMember = "Name";
            this.unitOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitOption.FormattingEnabled = true;
            this.unitOption.Location = new System.Drawing.Point(3, 19);
            this.unitOption.Name = "unitOption";
            this.unitOption.Size = new System.Drawing.Size(506, 23);
            this.unitOption.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 40);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredient Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.unitOption);
            this.groupBox2.Location = new System.Drawing.Point(3, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 45);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unit of Measurement";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cost);
            this.groupBox3.Location = new System.Drawing.Point(3, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 45);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cost";
            // 
            // FieldsIngredientsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FieldsIngredientsUserControl";
            this.Size = new System.Drawing.Size(518, 152);
            this.Load += new System.EventHandler(this.FieldsIngredientsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private NumericUpDown cost;
        private TextBox nameTxt;
        private ComboBox unitOption;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
