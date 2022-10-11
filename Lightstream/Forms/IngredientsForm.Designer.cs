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
            this.addBtn = new System.Windows.Forms.Button();
            this.ingredientField = new Lightstream.Usercontrols.IngredientForm.FieldsIngredientsUserControl();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(201, 114);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(170, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // ingredientField
            // 
            this.ingredientField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingredientField.Cost = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ingredientField.IngredientName = "";
            this.ingredientField.Location = new System.Drawing.Point(12, 12);
            this.ingredientField.Name = "ingredientField";
            this.ingredientField.Size = new System.Drawing.Size(359, 87);
            this.ingredientField.TabIndex = 7;
            //this.ingredientField.UnitOfMeasurement = "";
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 149);
            this.Controls.Add(this.ingredientField);
            this.Controls.Add(this.addBtn);
            this.Name = "IngredientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredient";
            this.ResumeLayout(false);

        }

        #endregion
        private Button addBtn;
        private Usercontrols.IngredientForm.FieldsIngredientsUserControl ingredientField;
    }
}