namespace Lightstream.Forms
{
    partial class IngredientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientsForm));
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitOption = new System.Windows.Forms.ComboBox();
            this.cost = new System.Windows.Forms.NumericUpDown();
            this.nameTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cost)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(222, 159);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(150, 30);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "SAVE";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Unit of Measurement:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(78, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ingredient name:";
            // 
            // unitOption
            // 
            this.unitOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitOption.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.unitOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.unitOption.DisplayMember = "Name";
            this.unitOption.FormattingEnabled = true;
            this.unitOption.Location = new System.Drawing.Point(111, 112);
            this.unitOption.Name = "unitOption";
            this.unitOption.Size = new System.Drawing.Size(261, 23);
            this.unitOption.TabIndex = 22;
            // 
            // cost
            // 
            this.cost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cost.DecimalPlaces = 2;
            this.cost.Location = new System.Drawing.Point(111, 67);
            this.cost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(261, 23);
            this.cost.TabIndex = 23;
            this.cost.ThousandsSeparator = true;
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTxt.BackColor = System.Drawing.Color.White;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxt.Location = new System.Drawing.Point(111, 22);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(261, 23);
            this.nameTxt.TabIndex = 21;
            // 
            // IngredientsForm
            // 
            this.AcceptButton = this.addBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unitOption);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.addBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IngredientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredient";
            this.Load += new System.EventHandler(this.IngredientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button addBtn;
        private Label label3;
        private Label label1;
        private Label label2;
        private ComboBox unitOption;
        private NumericUpDown cost;
        private TextBox nameTxt;
    }
}