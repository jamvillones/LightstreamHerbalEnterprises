﻿using Lightstream.CustomControls;

namespace Lightstream.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeForm));
            this.qty = new NumericUpDownNoArrows();
            this.ingredientOption = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._save = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qty)).BeginInit();
            this.SuspendLayout();
            // 
            // qty
            // 
            this.qty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qty.DecimalPlaces = 4;
            this.qty.Location = new System.Drawing.Point(76, 57);
            this.qty.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(302, 23);
            this.qty.TabIndex = 1;
            this.qty.ThousandsSeparator = true;
            this.qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ingredientOption
            // 
            this.ingredientOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingredientOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ingredientOption.DisplayMember = "Key";
            this.ingredientOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ingredientOption.FormattingEnabled = true;
            this.ingredientOption.Location = new System.Drawing.Point(76, 12);
            this.ingredientOption.Name = "ingredientOption";
            this.ingredientOption.Size = new System.Drawing.Size(302, 23);
            this.ingredientOption.TabIndex = 0;
            this.ingredientOption.ValueMember = "Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Required Qty:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingredient:";
            // 
            // _save
            // 
            this._save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._save.Font = new System.Drawing.Font("Bebas Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._save.ForeColor = System.Drawing.Color.Black;
            this._save.Location = new System.Drawing.Point(258, 105);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(120, 30);
            this._save.TabIndex = 3;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = false;
            this._save.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // RecipeForm
            // 
            this.AcceptButton = this._save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 147);
            this.Controls.Add(this._save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingredientOption);
            this.Controls.Add(this.qty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecipeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Required Ingredient";
            this.Load += new System.EventHandler(this.RecipeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDownNoArrows qty;
        private ComboBox ingredientOption;
        private Label label1;
        private Label label3;
        private Button _save;
        private ToolTip toolTip1;
    }
}