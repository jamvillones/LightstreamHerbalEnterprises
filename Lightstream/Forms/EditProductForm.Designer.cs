namespace Lightstream.Forms
{
    partial class EditProductForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._recipe = new System.Windows.Forms.ListBox();
            this._addIngredients = new System.Windows.Forms.Button();
            this._description = new System.Windows.Forms.TextBox();
            this._cancel = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this._save = new System.Windows.Forms.Button();
            this._productName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._recipe);
            this.groupBox1.Controls.Add(this._addIngredients);
            this.groupBox1.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(20, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(440, 187);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Required Ingredients";
            // 
            // _recipe
            // 
            this._recipe.BackColor = System.Drawing.SystemColors.Control;
            this._recipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._recipe.DisplayMember = "DisplayMember";
            this._recipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this._recipe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._recipe.FormattingEnabled = true;
            this._recipe.ItemHeight = 15;
            this._recipe.Location = new System.Drawing.Point(5, 21);
            this._recipe.Name = "_recipe";
            this._recipe.Size = new System.Drawing.Size(430, 131);
            this._recipe.TabIndex = 1;
            // 
            // _addIngredients
            // 
            this._addIngredients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._addIngredients.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._addIngredients.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._addIngredients.Location = new System.Drawing.Point(5, 152);
            this._addIngredients.Name = "_addIngredients";
            this._addIngredients.Size = new System.Drawing.Size(430, 30);
            this._addIngredients.TabIndex = 2;
            this._addIngredients.Text = "Add Ingredients";
            this._addIngredients.UseVisualStyleBackColor = true;
            // 
            // _description
            // 
            this._description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._description.Location = new System.Drawing.Point(118, 34);
            this._description.Name = "_description";
            this._description.Size = new System.Drawing.Size(342, 23);
            this._description.TabIndex = 12;
            // 
            // _cancel
            // 
            this._cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancel.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cancel.Location = new System.Drawing.Point(340, 285);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(120, 29);
            this._cancel.TabIndex = 15;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(118, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(342, 23);
            this.textBox2.TabIndex = 13;
            // 
            // _save
            // 
            this._save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._save.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._save.Location = new System.Drawing.Point(214, 285);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(120, 29);
            this._save.TabIndex = 14;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = false;
            // 
            // _productName
            // 
            this._productName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._productName.Location = new System.Drawing.Point(118, 5);
            this._productName.Name = "_productName";
            this._productName.Size = new System.Drawing.Size(342, 23);
            this._productName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "UNIT OF MEASUREMENT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(55, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "DESCRIPTION:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "PRODUCT NAME:";
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._description);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this._save);
            this.Controls.Add(this._productName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Product";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private ListBox _recipe;
        private Button _addIngredients;
        private TextBox _description;
        private Button _cancel;
        private TextBox textBox2;
        private Button _save;
        private TextBox _productName;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}