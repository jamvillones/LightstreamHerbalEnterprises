﻿namespace Lightstream.Forms
{
    partial class RecipeForm
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
            this.components = new System.ComponentModel.Container();
            this.qty = new System.Windows.Forms.NumericUpDown();
            this.unitOption = new System.Windows.Forms.ComboBox();
            this.ingredientOption = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addConversionBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            this.SuspendLayout();
            // 
            // qty
            // 
            this.qty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qty.DecimalPlaces = 2;
            this.qty.Location = new System.Drawing.Point(97, 40);
            this.qty.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(235, 23);
            this.qty.TabIndex = 0;
            this.qty.ThousandsSeparator = true;
            this.qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // unitOption
            // 
            this.unitOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.unitOption.DisplayMember = "Name";
            this.unitOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitOption.FormattingEnabled = true;
            this.unitOption.Location = new System.Drawing.Point(97, 69);
            this.unitOption.Name = "unitOption";
            this.unitOption.Size = new System.Drawing.Size(235, 23);
            this.unitOption.TabIndex = 1;
            this.unitOption.SelectedIndexChanged += new System.EventHandler(this.ingredientOption_SelectedIndexChanged);
            // 
            // ingredientOption
            // 
            this.ingredientOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingredientOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ingredientOption.DisplayMember = "Key";
            this.ingredientOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ingredientOption.FormattingEnabled = true;
            this.ingredientOption.Location = new System.Drawing.Point(97, 11);
            this.ingredientOption.Name = "ingredientOption";
            this.ingredientOption.Size = new System.Drawing.Size(235, 23);
            this.ingredientOption.TabIndex = 2;
            this.ingredientOption.ValueMember = "Value";
            this.ingredientOption.SelectedIndexChanged += new System.EventHandler(this.ingredientOption_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Required Qty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingredient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unit:";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Location = new System.Drawing.Point(257, 106);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addConversionBtn
            // 
            this.addConversionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addConversionBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addConversionBtn.Enabled = false;
            this.addConversionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addConversionBtn.Location = new System.Drawing.Point(97, 106);
            this.addConversionBtn.Name = "addConversionBtn";
            this.addConversionBtn.Size = new System.Drawing.Size(154, 23);
            this.addConversionBtn.TabIndex = 9;
            this.addConversionBtn.Text = "Add Conversion";
            this.toolTip1.SetToolTip(this.addConversionBtn, "Conversion for  the units is not yet defined");
            this.addConversionBtn.UseVisualStyleBackColor = false;
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 141);
            this.Controls.Add(this.addConversionBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingredientOption);
            this.Controls.Add(this.unitOption);
            this.Controls.Add(this.qty);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecipeForm";
            this.Text = "Add Required Ingredient";
            this.Load += new System.EventHandler(this.RecipeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown qty;
        private ComboBox unitOption;
        private ComboBox ingredientOption;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button saveBtn;
        private Button addConversionBtn;
        private ToolTip toolTip1;
    }
}