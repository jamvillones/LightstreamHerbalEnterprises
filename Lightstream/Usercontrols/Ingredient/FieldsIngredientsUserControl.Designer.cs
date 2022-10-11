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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.unitOption = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Unit of Measurement:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name:";
            // 
            // cost
            // 
            this.cost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cost.DecimalPlaces = 2;
            this.cost.Location = new System.Drawing.Point(131, 61);
            this.cost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(333, 23);
            this.cost.TabIndex = 8;
            this.cost.ThousandsSeparator = true;
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxt.Location = new System.Drawing.Point(131, 3);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(333, 23);
            this.nameTxt.TabIndex = 6;
            // 
            // unitOption
            // 
            this.unitOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitOption.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.unitOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.unitOption.DisplayMember = "Name";
            this.unitOption.FormattingEnabled = true;
            this.unitOption.Location = new System.Drawing.Point(131, 32);
            this.unitOption.Name = "unitOption";
            this.unitOption.Size = new System.Drawing.Size(333, 23);
            this.unitOption.TabIndex = 12;
            // 
            // FieldsIngredientsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.unitOption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.nameTxt);
            this.Name = "FieldsIngredientsUserControl";
            this.Size = new System.Drawing.Size(467, 87);
            this.Load += new System.EventHandler(this.FieldsIngredientsUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown cost;
        private TextBox nameTxt;
        private ComboBox unitOption;
    }
}
