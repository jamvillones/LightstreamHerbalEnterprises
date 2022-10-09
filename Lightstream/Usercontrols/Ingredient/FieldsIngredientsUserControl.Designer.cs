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
            this.unitofMeasuremenTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
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
            // unitofMeasuremenTxt
            // 
            this.unitofMeasuremenTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitofMeasuremenTxt.Location = new System.Drawing.Point(131, 32);
            this.unitofMeasuremenTxt.Name = "unitofMeasuremenTxt";
            this.unitofMeasuremenTxt.Size = new System.Drawing.Size(333, 23);
            this.unitofMeasuremenTxt.TabIndex = 7;
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
            // FieldsIngredientsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.unitofMeasuremenTxt);
            this.Controls.Add(this.nameTxt);
            this.Name = "FieldsIngredientsUserControl";
            this.Size = new System.Drawing.Size(467, 87);
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown cost;
        private TextBox unitofMeasuremenTxt;
        private TextBox nameTxt;
    }
}
